namespace FocusFlow
{
    partial class ProfilePickerForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            audio_prompt_btn = new Button();
            SuspendLayout();
            // 
            // audio_prompt_btn
            // 
            audio_prompt_btn.Location = new Point(642, 12);
            audio_prompt_btn.Name = "audio_prompt_btn";
            audio_prompt_btn.Size = new Size(134, 23);
            audio_prompt_btn.TabIndex = 0;
            audio_prompt_btn.Text = "Audio Prompt";
            audio_prompt_btn.UseVisualStyleBackColor = true;
            // 
            // ProfilePickerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(audio_prompt_btn);
            Name = "ProfilePickerForm";
            Text = "Profile Picker";
            ResumeLayout(false);
        }

        #endregion

        private Button audio_prompt_btn;
    }
}
