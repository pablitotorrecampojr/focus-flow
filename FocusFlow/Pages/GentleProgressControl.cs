using System.Text;

namespace FocusFlow
{
    public partial class GentleProgressControl : UserControl
    {
        private readonly ProfileRecord? profile;
        private string range = "week";
        private bool loadingNote;

        public GentleProgressControl() : this(null)
        {
        }

        public GentleProgressControl(ProfileRecord? profile)
        {
            this.profile = profile;
            InitializeComponent();
            UiShapes.KeepPill(dayButton);
            UiShapes.KeepPill(weekButton);
            UiShapes.KeepPill(monthButton);
            UiShapes.KeepPill(exportButton);
            UiShapes.KeepRounded(starsCard, UiShapes.CornerRadius);
            UiShapes.KeepRounded(focusCard, UiShapes.CornerRadius);
            UiShapes.KeepRounded(peakCard, UiShapes.CornerRadius);
            UiShapes.KeepRounded(noteCard, UiShapes.CornerRadius);
            UiShapes.KeepRounded(dayMon, UiShapes.CornerRadius);
            UiShapes.KeepRounded(dayTue, UiShapes.CornerRadius);
            UiShapes.KeepRounded(dayWed, UiShapes.CornerRadius);
            UiShapes.KeepRounded(dayThu, UiShapes.CornerRadius);
            UiShapes.KeepRounded(dayFri, UiShapes.CornerRadius);
            UiShapes.KeepRounded(daySat, UiShapes.CornerRadius);
            UiShapes.KeepRounded(daySun, UiShapes.CornerRadius);
            UiShapes.KeepRounded(noteBox, UiShapes.CornerRadius);
        }

        public void Reload()
        {
            ApplyRangeStyle();
            if (profile is null)
            {
                focusValue.Text = "0";
                peakValue.Text = "Not enough sessions yet";
                noteBox.Text = "";
                PaintStars(new HashSet<string>());
                return;
            }

            (DateTime from, DateTime to) = Range();
            focusValue.Text = AppDatabase.GetFocusMinutes(profile.Id, from, to).ToString();
            focusCaption.Text = range switch
            {
                "day" => "Calm minutes today",
                "month" => "Calm minutes this month",
                _ => "Calm minutes this week",
            };
            peakValue.Text = AppDatabase.GetPeakHour(profile.Id, from, to) ?? "Not enough sessions yet";
            DateTime weekStart = StartOfWeek(DateTime.Today);
            PaintStars(AppDatabase.GetActiveDates(profile.Id, weekStart, weekStart.AddDays(7)));
            loadingNote = true;
            noteBox.Text = AppDatabase.GetJournalNote(profile.Id, DateTime.Today);
            loadingNote = false;
        }

        private void dayButton_Click(object? sender, EventArgs e)
        {
            range = "day";
            Reload();
        }

        private void weekButton_Click(object? sender, EventArgs e)
        {
            range = "week";
            Reload();
        }

        private void monthButton_Click(object? sender, EventArgs e)
        {
            range = "month";
            Reload();
        }

        private void exportButton_Click(object? sender, EventArgs e)
        {
            if (profile is null)
            {
                MessageBox.Show(FindForm(), "Open a profile before exporting.", "Journal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using var dialog = new SaveFileDialog
            {
                Filter = "PDF (*.pdf)|*.pdf",
                FileName = $"FocusFlow-{DateTime.Today:yyyy-MM-dd}.pdf",
            };
            if (dialog.ShowDialog(FindForm()) != DialogResult.OK)
            {
                return;
            }

            (DateTime from, DateTime to) = Range();
            var lines = new List<string>
            {
                "FocusFlow journal",
                profile.Name,
                $"{from:MMM d} - {to.AddDays(-1):MMM d}",
                $"Focus minutes: {focusValue.Text}",
                $"Peak time: {peakValue.Text}",
                $"Note: {noteBox.Text}",
            };
            File.WriteAllBytes(dialog.FileName, SimplePdf(lines));
        }

        private void noteBox_Leave(object? sender, EventArgs e)
        {
            if (loadingNote || profile is null)
            {
                return;
            }

            AppDatabase.SaveJournalNote(profile.Id, DateTime.Today, noteBox.Text.Trim());
        }

        private (DateTime From, DateTime To) Range()
        {
            DateTime today = DateTime.Today;
            return range switch
            {
                "day" => (today, today.AddDays(1)),
                "month" => (new DateTime(today.Year, today.Month, 1), new DateTime(today.Year, today.Month, 1).AddMonths(1)),
                _ => (StartOfWeek(today), StartOfWeek(today).AddDays(7)),
            };
        }

        private void PaintStars(IReadOnlySet<string> active)
        {
            DateTime start = StartOfWeek(DateTime.Today);
            Label[] marks = [monMark, tueMark, wedMark, thuMark, friMark, satMark, sunMark];
            for (int i = 0; i < marks.Length; i++)
            {
                bool on = range != "day" || start.AddDays(i) == DateTime.Today;
                bool earned = on && active.Contains(start.AddDays(i).ToString("yyyy-MM-dd"));
                marks[i].Text = earned ? "★" : "—";
            }
        }

        private void ApplyRangeStyle()
        {
            StyleRange(dayButton, range == "day");
            StyleRange(weekButton, range == "week");
            StyleRange(monthButton, range == "month");
        }

        private static void StyleRange(Button button, bool selected)
        {
            button.BackColor = selected ? Color.FromArgb(102, 145, 124) : Color.FromArgb(244, 241, 236);
            button.ForeColor = selected ? Color.White : Color.FromArgb(74, 84, 92);
            button.FlatAppearance.MouseOverBackColor = button.BackColor;
            button.FlatAppearance.MouseDownBackColor = button.BackColor;
        }

        private static DateTime StartOfWeek(DateTime day)
        {
            int diff = ((int)day.DayOfWeek + 6) % 7;
            return day.AddDays(-diff);
        }

        private static byte[] SimplePdf(IReadOnlyList<string> lines)
        {
            var content = new StringBuilder("BT\n/F1 12 Tf\n50 760 Td\n16 TL\n");
            foreach (string line in lines)
            {
                content.Append('(').Append(Escape(line)).Append(") '\n");
            }

            content.Append("ET\n");
            string stream = content.ToString();
            string[] objects =
            [
                "<< /Type /Catalog /Pages 2 0 R >>",
                "<< /Type /Pages /Kids [3 0 R] /Count 1 >>",
                "<< /Type /Page /Parent 2 0 R /MediaBox [0 0 612 792] /Contents 4 0 R /Resources << /Font << /F1 5 0 R >> >> >>",
                $"<< /Length {Encoding.ASCII.GetByteCount(stream)} >>\nstream\n{stream}endstream",
                "<< /Type /Font /Subtype /Type1 /BaseFont /Helvetica >>",
            ];

            var output = new StringBuilder("%PDF-1.4\n");
            var offsets = new List<int>();
            for (int i = 0; i < objects.Length; i++)
            {
                offsets.Add(Encoding.ASCII.GetByteCount(output.ToString()));
                output.Append(i + 1).Append(" 0 obj\n").Append(objects[i]).Append("\nendobj\n");
            }

            int xref = Encoding.ASCII.GetByteCount(output.ToString());
            output.Append("xref\n0 ").Append(objects.Length + 1).Append('\n');
            output.Append("0000000000 65535 f \n");
            foreach (int offset in offsets)
            {
                output.Append(offset.ToString("D10")).Append(" 00000 n \n");
            }

            output.Append("trailer << /Size ").Append(objects.Length + 1).Append(" /Root 1 0 R >>\nstartxref\n");
            output.Append(xref).Append("\n%%EOF");
            return Encoding.ASCII.GetBytes(output.ToString());
        }

        private static string Escape(string value)
        {
            var clean = new string(value.Select(character => character is >= ' ' and <= '~' ? character : ' ').ToArray());
            return clean.Replace("\\", "\\\\").Replace("(", "\\(").Replace(")", "\\)");
        }
    }
}
