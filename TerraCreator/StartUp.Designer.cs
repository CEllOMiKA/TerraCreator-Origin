namespace TerraCreator
{
    partial class StartUp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            loadbar = new ProgressBar();
            SuspendLayout();
            // 
            // loadbar
            // 
            loadbar.BackColor = Color.FromArgb(255, 255, 128);
            loadbar.ForeColor = Color.Brown;
            loadbar.Location = new Point(12, 12);
            loadbar.Name = "loadbar";
            loadbar.Size = new Size(786, 25);
            loadbar.Step = 1;
            loadbar.Style = ProgressBarStyle.Marquee;
            loadbar.TabIndex = 2;
            // 
            // StartUp
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(810, 46);
            ControlBox = false;
            Controls.Add(loadbar);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "StartUp";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "Loading TerraCreator";
            TransparencyKey = Color.Transparent;
            Load += StartUp_Load;
            ResumeLayout(false);
        }

        #endregion

        public static ProgressBar loadbar;
    }
}