using System.Drawing.Drawing2D;
using System.Reflection;

namespace FocusFlow
{
    public partial class FocusModeControl : UserControl
    {
        private readonly ProfileRecord? profile;
        private readonly System.Windows.Forms.Timer clock = new() { Interval = 1000 };
        private int remaining = 25 * 60;
        private int elapsed;
        private bool running;
        private string mode = "Focus";
        private int modeSeconds = 25 * 60;
        private string sound = "None";
        private string sessionTitle = "";

        public event EventHandler? ExitRequested;

        public FocusModeControl() : this(null)
        {
        }

        public FocusModeControl(ProfileRecord? profile)
        {
            this.profile = profile;
            InitializeComponent();
            UiShapes.KeepPill(soundButton);
            UiShapes.KeepPill(exitButton);
            UiShapes.KeepPill(modeBar);
            UiShapes.KeepPill(focusModeButton);
            UiShapes.KeepPill(shortBreakButton);
            UiShapes.KeepPill(longBreakButton);
            UiShapes.KeepCircle(timerRing);
            UiShapes.KeepCircle(timerFace);
            typeof(Control).InvokeMember(
                "DoubleBuffered",
                BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.SetProperty,
                null,
                timerRing,
                [true]);
            UiShapes.KeepPill(pauseButton);
            UiShapes.KeepPill(skipButton);
            clock.Tick += (_, _) => Tick();
            ShowClock();
        }

        public void RefreshIdle()
        {
            if (running)
            {
                return;
            }

            if (string.IsNullOrWhiteSpace(sessionTitle))
            {
                sessionLabel.Text = NextTaskTitle();
            }
        }

        public void BeginSession(string? title)
        {
            sessionTitle = string.IsNullOrWhiteSpace(title) ? NextTaskTitle() : title;
            sessionLabel.Text = sessionTitle;
            ApplyMode("Focus", 25 * 60, "Focus Session");
        }

        private void focusModeButton_Click(object? sender, EventArgs e)
        {
            ApplyMode("Focus", 25 * 60, "Focus Session");
        }

        private void shortBreakButton_Click(object? sender, EventArgs e)
        {
            ApplyMode("Short Break", 5 * 60, "Short Break");
        }

        private void longBreakButton_Click(object? sender, EventArgs e)
        {
            ApplyMode("Long Break", 15 * 60, "Long Break");
        }

        private void pauseButton_Click(object? sender, EventArgs e)
        {
            if (running)
            {
                running = false;
                clock.Stop();
                pauseButton.Text = "Resume";
                return;
            }

            Start();
        }

        private void skipButton_Click(object? sender, EventArgs e)
        {
            FinishSession();
            remaining = modeSeconds;
            elapsed = 0;
            running = false;
            clock.Stop();
            pauseButton.Text = "Start Timer";
            ShowClock();
        }

        private void soundButton_Click(object? sender, EventArgs e)
        {
            sound = sound switch
            {
                "None" => "Soft",
                "Soft" => "Chime",
                _ => "None",
            };
            soundButton.Text = $"Sound: {sound}";
        }

        private void exitButton_Click(object? sender, EventArgs e)
        {
            running = false;
            clock.Stop();
            pauseButton.Text = "Start Timer";
            ExitRequested?.Invoke(this, EventArgs.Empty);
        }

        private void ApplyMode(string nextMode, int seconds, string caption)
        {
            mode = nextMode;
            modeSeconds = seconds;
            remaining = seconds;
            elapsed = 0;
            running = false;
            clock.Stop();
            timerCaption.Text = caption;
            pauseButton.Text = "Start Timer";
            ShowClock();
            HighlightMode();
        }

        private void Start()
        {
            if (remaining <= 0)
            {
                remaining = modeSeconds;
                elapsed = 0;
            }

            if (string.IsNullOrWhiteSpace(sessionTitle))
            {
                sessionTitle = NextTaskTitle();
                sessionLabel.Text = sessionTitle;
            }

            running = true;
            pauseButton.Text = "Pause Timer";
            ShowClock();
            clock.Start();
        }

        private void Tick()
        {
            if (!running)
            {
                return;
            }

            if (remaining > 0)
            {
                remaining--;
                elapsed++;
            }

            ShowClock();
            if (remaining > 0)
            {
                return;
            }

            running = false;
            clock.Stop();
            pauseButton.Text = "Start Timer";
            FinishSession();
            if (sound != "None")
            {
                System.Media.SystemSounds.Asterisk.Play();
            }
        }

        private void FinishSession()
        {
            if (profile is null || mode != "Focus")
            {
                return;
            }

            int minutes = elapsed / 60;
            AppDatabase.AddFocusSession(profile.Id, mode, sessionLabel.Text, minutes);
            elapsed = 0;
        }

        private void ShowClock()
        {
            int minutes = remaining / 60;
            int seconds = remaining % 60;
            timerValue.Text = $"{minutes:00}:{seconds:00}";
            timerRing.Invalidate();
        }

        private void timerRing_Paint(object? sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            const float thickness = 14f;
            float inset = thickness / 2f;
            var bounds = new RectangleF(inset, inset, timerRing.Width - thickness, timerRing.Height - thickness);
            using var track = new Pen(Color.FromArgb(196, 216, 206), thickness);
            using var progress = new Pen(Color.FromArgb(102, 145, 124), thickness)
            {
                StartCap = LineCap.Round,
                EndCap = LineCap.Round,
            };
            e.Graphics.DrawEllipse(track, bounds);
            if (modeSeconds <= 0 || elapsed <= 0)
            {
                return;
            }

            float sweep = Math.Min(359.9f, 360f * elapsed / modeSeconds);
            e.Graphics.DrawArc(progress, bounds, -90, sweep);
        }

        private void HighlightMode()
        {
            StyleMode(focusModeButton, mode == "Focus");
            StyleMode(shortBreakButton, mode == "Short Break");
            StyleMode(longBreakButton, mode == "Long Break");
        }

        private static void StyleMode(Button button, bool selected)
        {
            button.BackColor = selected ? Color.FromArgb(102, 145, 124) : Color.FromArgb(226, 236, 230);
            button.ForeColor = selected ? Color.White : Color.FromArgb(74, 96, 88);
        }

        private string NextTaskTitle()
        {
            if (profile is null)
            {
                return "No active task";
            }

            foreach (TaskRecord task in AppDatabase.GetTasks(profile.Id))
            {
                bool open = AppDatabase.GetSubTasks(task.Id).Any(item => item.Status != SubTaskStatus.Done);
                if (open || AppDatabase.GetSubTasks(task.Id).Count == 0)
                {
                    return task.Title;
                }
            }

            return "No active task";
        }

    }
}
