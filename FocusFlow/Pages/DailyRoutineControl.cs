namespace FocusFlow
{
    public partial class DailyRoutineControl : UserControl
    {
        private const string DragFormat = "FocusFlowRoutine";

        private readonly ProfileRecord? profile;
        private readonly Font cardTitleFont = new("Nunito Sans Normal SemiBold", 8.75F);
        private readonly Font cardTitleDoneFont = new("Nunito Sans Normal SemiBold", 8.75F, FontStyle.Strikeout);
        private readonly Font cardMetaFont = new("Nunito Sans Normal", 7.75F);
        private readonly Image deleteIcon = Icon("icons8-trash-100.png", 14);
        private readonly HashSet<long> completedToday = [];

        public event EventHandler<string>? LaunchFocus;
        private Point? dragOrigin;

        public DailyRoutineControl() : this(null)
        {
        }

        public DailyRoutineControl(ProfileRecord? profile)
        {
            this.profile = profile;
            InitializeComponent();
            morningIcon.Image = Icon("icons8-sunrise-100.png", 18);
            afternoonIcon.Image = Icon("icons8-afternoon-100.png", 18);
            eveningIcon.Image = Icon("icons8-sunset-100.png", 18);
            UiShapes.KeepPill(launchButton);
            UiShapes.KeepPill(morningAdd);
            UiShapes.KeepPill(afternoonAdd);
            UiShapes.KeepPill(eveningAdd);
            UiShapes.KeepPill(morningCount);
            UiShapes.KeepPill(afternoonCount);
            UiShapes.KeepPill(eveningCount);
            UiShapes.KeepRounded(morningColumn, UiShapes.CornerRadius);
            UiShapes.KeepRounded(afternoonColumn, UiShapes.CornerRadius);
            UiShapes.KeepRounded(eveningColumn, UiShapes.CornerRadius);
            morningAdd.Click += (_, _) => AddRoutine(RoutinePeriod.Morning);
            afternoonAdd.Click += (_, _) => AddRoutine(RoutinePeriod.Afternoon);
            eveningAdd.Click += (_, _) => AddRoutine(RoutinePeriod.Evening);
            BindDrop(morningColumn, morningList, morningEmpty, RoutinePeriod.Morning);
            BindDrop(afternoonColumn, afternoonList, afternoonEmpty, RoutinePeriod.Afternoon);
            BindDrop(eveningColumn, eveningList, eveningEmpty, RoutinePeriod.Evening);
            Reload();
        }

        private void launchButton_Click(object? sender, EventArgs e)
        {
            if (profile is null)
            {
                MessageBox.Show(FindForm(), "Open a profile before launching a routine.", "Daily Routine", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string period = RoutinePeriod.Current();
            IReadOnlySet<long> done = AppDatabase.GetCompletedRoutineIds(profile.Id, DateTime.Today);
            RoutineRecord? next = AppDatabase.GetRoutines(profile.Id)
                .Where(routine => routine.Period == period && RoutineDays.Includes(routine.DaysMask, DateTime.Today) && !done.Contains(routine.Id))
                .OrderBy(routine => routine.SortOrder)
                .ThenBy(routine => routine.Id)
                .FirstOrDefault();
            if (next is null)
            {
                MessageBox.Show(FindForm(), $"Nothing left to launch this {period.ToLowerInvariant()}.", "Daily Routine", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            LaunchFocus?.Invoke(this, next.Title);
        }

        private void AddRoutine(string period)
        {
            if (profile is null)
            {
                MessageBox.Show(FindForm(), "Open a profile before adding a routine.", "Daily Routine", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using var dialog = new AddRoutineForm(period);
            if (dialog.ShowDialog(FindForm()) != DialogResult.OK)
            {
                return;
            }

            AppDatabase.AddRoutine(profile.Id, period, dialog.RoutineTitle, dialog.Minutes, dialog.RoutineCategory, dialog.DaysMask);
            Reload();
        }

        private void EditRoutine(RoutineRecord routine)
        {
            if (profile is null)
            {
                return;
            }

            using var dialog = new AddRoutineForm(routine.Period, routine.Title, routine.Minutes, routine.Category, routine.DaysMask);
            if (dialog.ShowDialog(FindForm()) != DialogResult.OK)
            {
                return;
            }

            AppDatabase.UpdateRoutine(routine.Id, dialog.RoutineTitle, dialog.Minutes, dialog.RoutineCategory, dialog.DaysMask);
            Reload();
        }

        public void Reload()
        {
            completedToday.Clear();
            if (profile is not null)
            {
                foreach (long id in AppDatabase.GetCompletedRoutineIds(profile.Id, DateTime.Today))
                {
                    completedToday.Add(id);
                }
            }

            IReadOnlyList<RoutineRecord> routines = profile is null
                ? []
                : AppDatabase.GetRoutines(profile.Id);
            ShowColumn(morningList, morningEmpty, morningCount, routines.Where(routine => routine.Period == RoutinePeriod.Morning));
            ShowColumn(afternoonList, afternoonEmpty, afternoonCount, routines.Where(routine => routine.Period == RoutinePeriod.Afternoon));
            ShowColumn(eveningList, eveningEmpty, eveningCount, routines.Where(routine => routine.Period == RoutinePeriod.Evening));
        }

        private void ShowColumn(Panel list, Label empty, Label count, IEnumerable<RoutineRecord> routines)
        {
            var items = routines.OrderBy(routine => routine.SortOrder).ThenBy(routine => routine.Id).ToList();
            ClearCards(list, empty);
            empty.Visible = items.Count == 0;
            count.Text = items.Count == 1 ? "1 Item" : $"{items.Count} Items";
            const int inset = 8;
            int y = 6;
            int width = Math.Max(40, list.ClientSize.Width - inset * 2);
            foreach (RoutineRecord item in items)
            {
                Panel card = CreateCard(item);
                card.SetBounds(inset, y, width, 52);
                list.Controls.Add(card);
                card.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
                UiShapes.KeepRounded(card, UiShapes.CornerRadius);
                y += 58;
            }
        }

        private void ClearCards(Panel list, Label empty)
        {
            for (int i = list.Controls.Count - 1; i >= 0; i--)
            {
                if (list.Controls[i] != empty)
                {
                    list.Controls[i].Dispose();
                }
            }
        }

        private Panel CreateCard(RoutineRecord routine)
        {
            var card = new Panel
            {
                Size = new Size(200, 52),
                BackColor = Color.White,
                Tag = routine.Id,
                Cursor = Cursors.Hand,
            };
            bool scheduledToday = RoutineDays.Includes(routine.DaysMask, DateTime.Today);
            bool done = scheduledToday && completedToday.Contains(routine.Id);
            var title = new Label
            {
                Text = routine.Title,
                AutoSize = false,
                AutoEllipsis = true,
                UseMnemonic = false,
                Font = done ? cardTitleDoneFont : cardTitleFont,
                ForeColor = done ? Color.FromArgb(140, 136, 130) : Color.FromArgb(32, 44, 62),
                Location = new Point(scheduledToday ? 32 : 10, 4),
                Size = new Size(scheduledToday ? 128 : 150, 18),
                Cursor = Cursors.Hand,
            };
            var meta = new Label
            {
                Text = $"{routine.Minutes} mins   ·   {routine.Category}   ·   {RoutineDays.Describe(routine.DaysMask)}",
                AutoSize = false,
                AutoEllipsis = true,
                UseMnemonic = false,
                Font = cardMetaFont,
                ForeColor = Color.FromArgb(120, 116, 110),
                Location = new Point(10, 26),
                Size = new Size(178, 16),
                Cursor = Cursors.Hand,
            };
            var remove = new Button
            {
                Text = "",
                Image = deleteIcon,
                ImageAlign = ContentAlignment.MiddleCenter,
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.White,
                Location = new Point(172, 4),
                Size = new Size(22, 22),
                Cursor = Cursors.Hand,
                TabStop = false,
            };
            remove.FlatAppearance.BorderSize = 0;
            remove.FlatAppearance.MouseOverBackColor = Color.FromArgb(244, 241, 236);
            remove.FlatAppearance.MouseDownBackColor = Color.FromArgb(232, 224, 216);
            remove.Click += (_, _) =>
            {
                if (profile is null)
                {
                    return;
                }

                AppDatabase.DeleteRoutine(routine.Id);
                Reload();
            };

            if (scheduledToday)
            {
                var doneBox = new CheckBox
                {
                    Checked = done,
                    Location = new Point(8, 5),
                    Size = new Size(18, 18),
                    BackColor = Color.White,
                    Cursor = Cursors.Hand,
                    TabStop = false,
                };
                doneBox.CheckedChanged += (_, _) =>
                {
                    if (profile is null)
                    {
                        return;
                    }

                    AppDatabase.SetRoutineDone(routine.Id, DateTime.Today, doneBox.Checked);
                    BeginInvoke(Reload);
                };
                card.Controls.Add(doneBox);
            }

            card.Controls.Add(remove);
            card.Controls.Add(meta);
            card.Controls.Add(title);
            title.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            meta.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            remove.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            WireDrag(card, routine.Id);
            WireDrag(title, routine.Id);
            WireDrag(meta, routine.Id);
            card.DoubleClick += (_, _) => EditRoutine(routine);
            title.DoubleClick += (_, _) => EditRoutine(routine);
            meta.DoubleClick += (_, _) => EditRoutine(routine);
            return card;
        }

        private void WireDrag(Control control, long routineId)
        {
            control.MouseDown += (_, e) =>
            {
                if (e.Button == MouseButtons.Left)
                {
                    dragOrigin = Cursor.Position;
                }
            };
            control.MouseMove += (_, e) =>
            {
                if (dragOrigin is not Point origin || e.Button != MouseButtons.Left)
                {
                    return;
                }

                int travel = Math.Abs(Cursor.Position.X - origin.X) + Math.Abs(Cursor.Position.Y - origin.Y);
                if (travel < 6)
                {
                    return;
                }

                dragOrigin = null;
                control.DoDragDrop(new DataObject(DragFormat, routineId.ToString()), DragDropEffects.Move);
            };
            control.MouseUp += (_, _) => dragOrigin = null;
        }

        private void BindDrop(Panel column, Panel list, Label empty, string period)
        {
            void Allow(object? sender, DragEventArgs e)
            {
                bool ok = e.Data?.GetDataPresent(DragFormat) == true;
                e.Effect = ok ? DragDropEffects.Move : DragDropEffects.None;
                if (ok)
                {
                    column.BackColor = Color.FromArgb(236, 242, 238);
                }
            }

            void Leave(object? sender, EventArgs e)
            {
                Point cursor = column.PointToClient(Cursor.Position);
                if (!column.ClientRectangle.Contains(cursor))
                {
                    column.BackColor = Color.White;
                }
            }

            column.AllowDrop = true;
            list.AllowDrop = true;
            empty.AllowDrop = true;
            column.DragEnter += Allow;
            column.DragOver += Allow;
            list.DragEnter += Allow;
            list.DragOver += Allow;
            empty.DragEnter += Allow;
            empty.DragOver += Allow;
            column.DragLeave += Leave;
            list.DragLeave += Leave;
            column.DragDrop += (_, e) => FinishDrop(e, period, list, append: true);
            list.DragDrop += (_, e) => FinishDrop(e, period, list, append: false);
            empty.DragDrop += (_, e) => FinishDrop(e, period, list, append: true);
        }

        private void FinishDrop(DragEventArgs e, string period, Panel list, bool append)
        {
            morningColumn.BackColor = Color.White;
            afternoonColumn.BackColor = Color.White;
            eveningColumn.BackColor = Color.White;
            if (profile is null || e.Data?.GetData(DragFormat) is not string text || !long.TryParse(text, out long id))
            {
                return;
            }

            int index = append ? int.MaxValue : IndexFromDrop(list, e, id);
            AppDatabase.PlaceRoutine(profile.Id, id, period, index);
            Reload();
        }

        private static int IndexFromDrop(Panel list, DragEventArgs e, long movingId)
        {
            Point point = list.PointToClient(new Point(e.X, e.Y));
            int index = 0;
            foreach (Control control in list.Controls)
            {
                if (control.Tag is not long id)
                {
                    continue;
                }

                if (id == movingId)
                {
                    continue;
                }

                int midpoint = control.Top + list.AutoScrollPosition.Y + control.Height / 2;
                if (point.Y < midpoint)
                {
                    break;
                }

                index++;
            }

            return index;
        }

        private static Image Icon(string fileName, int size)
        {
            var path = Path.Combine(AppContext.BaseDirectory, "icons", fileName);
            using var source = Image.FromFile(path);
            return new Bitmap(source, new Size(size, size));
        }
    }
}
