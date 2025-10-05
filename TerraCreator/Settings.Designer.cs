namespace TerraCreator
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            settinglabel = new Label();
            SaveButton = new Button();
            label1 = new Label();
            SettingsTextBox = new RichTextBox();
            SuspendLayout();
            // 
            // settinglabel
            // 
            settinglabel.AutoSize = true;
            settinglabel.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            settinglabel.Location = new Point(8, 6);
            settinglabel.Margin = new Padding(2, 0, 2, 0);
            settinglabel.Name = "settinglabel";
            settinglabel.Size = new Size(42, 22);
            settinglabel.TabIndex = 5;
            settinglabel.Text = "设置";
            // 
            // SaveButton
            // 
            SaveButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            SaveButton.Location = new Point(780, 448);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(75, 23);
            SaveButton.TabIndex = 6;
            SaveButton.Text = "保存";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(11, 454);
            label1.Name = "label1";
            label1.Size = new Size(251, 17);
            label1.TabIndex = 7;
            label1.Text = "此部分正在整改,暂时放个配置文件编辑文本框";
            // 
            // SettingsTextBox
            // 
            SettingsTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SettingsTextBox.Location = new Point(12, 31);
            SettingsTextBox.Name = "SettingsTextBox";
            SettingsTextBox.Size = new Size(842, 411);
            SettingsTextBox.TabIndex = 8;
            SettingsTextBox.Text = "";
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 255, 255);
            ClientSize = new Size(866, 483);
            Controls.Add(SettingsTextBox);
            Controls.Add(label1);
            Controls.Add(SaveButton);
            Controls.Add(settinglabel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "Settings";
            Text = "设置";
            Load += Settings_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label settinglabel;
        private SplitContainer SettingSplit;
        private ListView SettingList;
        private Button SaveButton;
        private Label label1;
        private RichTextBox SettingsTextBox;
        private Button SaveChanges;
    }
}