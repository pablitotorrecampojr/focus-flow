namespace FocusFlow
{
    public partial class ProfilePickerForm : Form
    {
        public ProfilePickerForm()
        {
            InitializeComponent();
            LoadIcons();
            UiShapes.ApplyPill(audio_prompt_btn);
            audio_prompt_btn.Resize += (_, _) => UiShapes.ApplyPill(audio_prompt_btn);
            UiShapes.ApplyPill(guestModeBtn);
            guestModeBtn.Resize += (_, _) => UiShapes.ApplyPill(guestModeBtn);
            LoadProfiles();
            Resize += (_, _) => FitProfilesPanel();
            CenterGuestButton();
        }

        private void LoadIcons()
        {
            brandIcon.Image = LoadIcon("icons8-cloud-100.png", brandIcon.Width);
            audio_prompt_btn.Image = LoadIcon("icons8-speaker-100.png", audio_prompt_btn.Height / 2);
        }

        private static Bitmap LoadIcon(string fileName, int size)
        {
            var iconPath = Path.Combine(AppContext.BaseDirectory, "icons", fileName);
            using var source = Image.FromFile(iconPath);
            return new Bitmap(source, new Size(size, size));
        }

        private void LoadProfiles()
        {
            while (profilesPanel.Controls.Count > 0)
            {
                profilesPanel.Controls[0].Dispose();
            }

            foreach (ProfileRecord profile in AppDatabase.GetProfiles())
            {
                var card = new ProfileCard();
                card.Bind(profile);
                card.ProfileChosen += (_, _) => ChooseProfile(card);
                profilesPanel.Controls.Add(card);
            }

            var addCard = new AddProfileCard();
            addCard.AddRequested += (_, _) => AddProfile();
            profilesPanel.Controls.Add(addCard);
            foreach (Control card in profilesPanel.Controls)
            {
                card.MouseWheel += ScrollProfilesHorizontally;
                foreach (Control child in card.Controls)
                {
                    child.MouseWheel += ScrollProfilesHorizontally;
                }
            }

            FitProfilesPanel();
        }

        private void ScrollProfilesHorizontally(object? sender, MouseEventArgs e)
        {
            int next = -profilesPanel.AutoScrollPosition.X - Math.Sign(e.Delta) * 48;
            profilesPanel.AutoScrollPosition = new Point(Math.Max(0, next), 0);
            if (e is HandledMouseEventArgs handled)
            {
                handled.Handled = true;
            }
        }

        private void ChooseProfile(ProfileCard card)
        {
            if (card.Profile is not ProfileRecord profile)
            {
                return;
            }

            if (profile.HasPin)
            {
                using var prompt = new PinPrompt(profile.Name);
                if (prompt.ShowDialog(this) != DialogResult.OK)
                {
                    return;
                }

                if (!AppDatabase.VerifyPin(profile.Id, prompt.Pin))
                {
                    MessageBox.Show(this, "That PIN doesn't match.", "Enter PIN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            welcomeLabel.Text = $"Welcome back, {profile.Name.Split(' ')[0]}";
        }

        private void AddProfile()
        {
            using var dialog = new AddProfileForm();
            if (dialog.ShowDialog(this) != DialogResult.OK)
            {
                return;
            }

            AppDatabase.AddProfile(dialog.ProfileName, dialog.ProfileType, dialog.Pin);
            LoadProfiles();
        }

        private void FitProfilesPanel()
        {
            profilesPanel.Height = 216 + 16 + SystemInformation.HorizontalScrollBarHeight;
            guestModeBtn.Top = profilesPanel.Bottom + 18;
            CenterGuestButton();
        }

        private void CenterGuestButton()
        {
            guestModeBtn.Left = Math.Max(16, (ClientSize.Width - guestModeBtn.Width) / 2);
        }
    }
}