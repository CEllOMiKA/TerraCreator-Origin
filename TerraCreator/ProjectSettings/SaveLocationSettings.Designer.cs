namespace TerraCreator.projectsettings
{
    partial class SaveLocationSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaveLocationSettings));
            SaveLocationSettingsTitleLabel = new Label();
            ItemSaveLocationLabel = new Label();
            ProjectileSaveLocationLabel = new Label();
            ItemSaveLocationTextBox = new TextBox();
            ItemSaveLocationButton = new Button();
            ProjectileSaveLocationButton = new Button();
            ProjectileSaveLocationTextBox = new TextBox();
            SaveButton = new Button();
            SaveLocationPanel = new Panel();
            SaveLocationPanel.SuspendLayout();
            SuspendLayout();
            // 
            // SaveLocationSettingsTitleLabel
            // 
            SaveLocationSettingsTitleLabel.AutoSize = true;
            SaveLocationSettingsTitleLabel.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            SaveLocationSettingsTitleLabel.Location = new Point(12, 9);
            SaveLocationSettingsTitleLabel.Name = "SaveLocationSettingsTitleLabel";
            SaveLocationSettingsTitleLabel.Size = new Size(138, 21);
            SaveLocationSettingsTitleLabel.TabIndex = 3;
            SaveLocationSettingsTitleLabel.Text = "默认保存位置设置";
            // 
            // ItemSaveLocationLabel
            // 
            ItemSaveLocationLabel.AutoSize = true;
            ItemSaveLocationLabel.Location = new Point(6, 6);
            ItemSaveLocationLabel.Name = "ItemSaveLocationLabel";
            ItemSaveLocationLabel.Size = new Size(83, 17);
            ItemSaveLocationLabel.TabIndex = 4;
            ItemSaveLocationLabel.Text = "物品默认位置:";
            // 
            // ProjectileSaveLocationLabel
            // 
            ProjectileSaveLocationLabel.AutoSize = true;
            ProjectileSaveLocationLabel.Location = new Point(6, 35);
            ProjectileSaveLocationLabel.Name = "ProjectileSaveLocationLabel";
            ProjectileSaveLocationLabel.Size = new Size(83, 17);
            ProjectileSaveLocationLabel.TabIndex = 5;
            ProjectileSaveLocationLabel.Text = "射弹默认位置:";
            // 
            // ItemSaveLocationTextBox
            // 
            ItemSaveLocationTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ItemSaveLocationTextBox.Location = new Point(95, 3);
            ItemSaveLocationTextBox.Name = "ItemSaveLocationTextBox";
            ItemSaveLocationTextBox.Size = new Size(411, 23);
            ItemSaveLocationTextBox.TabIndex = 7;
            // 
            // ItemSaveLocationButton
            // 
            ItemSaveLocationButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ItemSaveLocationButton.Location = new Point(512, 3);
            ItemSaveLocationButton.Name = "ItemSaveLocationButton";
            ItemSaveLocationButton.Size = new Size(75, 23);
            ItemSaveLocationButton.TabIndex = 8;
            ItemSaveLocationButton.Text = "选择";
            ItemSaveLocationButton.UseVisualStyleBackColor = true;
            ItemSaveLocationButton.Click += ItemSaveLocationButton_Click;
            // 
            // ProjectileSaveLocationButton
            // 
            ProjectileSaveLocationButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ProjectileSaveLocationButton.Location = new Point(512, 32);
            ProjectileSaveLocationButton.Name = "ProjectileSaveLocationButton";
            ProjectileSaveLocationButton.Size = new Size(75, 23);
            ProjectileSaveLocationButton.TabIndex = 10;
            ProjectileSaveLocationButton.Text = "选择";
            ProjectileSaveLocationButton.UseVisualStyleBackColor = true;
            ProjectileSaveLocationButton.Click += ProjectileSaveLocationButton_Click;
            // 
            // ProjectileSaveLocationTextBox
            // 
            ProjectileSaveLocationTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ProjectileSaveLocationTextBox.Location = new Point(95, 32);
            ProjectileSaveLocationTextBox.Name = "ProjectileSaveLocationTextBox";
            ProjectileSaveLocationTextBox.Size = new Size(411, 23);
            ProjectileSaveLocationTextBox.TabIndex = 9;
            // 
            // SaveButton
            // 
            SaveButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            SaveButton.Location = new Point(512, 247);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(75, 23);
            SaveButton.TabIndex = 11;
            SaveButton.Text = "保存";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // SaveLocationPanel
            // 
            SaveLocationPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SaveLocationPanel.BackColor = Color.FromArgb(192, 255, 255);
            SaveLocationPanel.Controls.Add(SaveButton);
            SaveLocationPanel.Controls.Add(ProjectileSaveLocationButton);
            SaveLocationPanel.Controls.Add(ProjectileSaveLocationTextBox);
            SaveLocationPanel.Controls.Add(ItemSaveLocationButton);
            SaveLocationPanel.Controls.Add(ItemSaveLocationTextBox);
            SaveLocationPanel.Controls.Add(ProjectileSaveLocationLabel);
            SaveLocationPanel.Controls.Add(ItemSaveLocationLabel);
            SaveLocationPanel.Location = new Point(12, 33);
            SaveLocationPanel.Name = "SaveLocationPanel";
            SaveLocationPanel.Size = new Size(596, 273);
            SaveLocationPanel.TabIndex = 13;
            // 
            // SaveLocationSettings
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 255, 255);
            ClientSize = new Size(620, 318);
            Controls.Add(SaveLocationPanel);
            Controls.Add(SaveLocationSettingsTitleLabel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "SaveLocationSettings";
            Text = "保存位置设置";
            Load += SaveLocationSettings_Load;
            SaveLocationPanel.ResumeLayout(false);
            SaveLocationPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label SaveLocationSettingsTitleLabel;
        private Label ItemSaveLocationLabel;
        private Label ProjectileSaveLocationLabel;
        private TextBox ItemSaveLocationTextBox;
        private Button ItemSaveLocationButton;
        private Button ProjectileSaveLocationButton;
        private TextBox ProjectileSaveLocationTextBox;
        private Button SaveButton;
        private Panel SaveLocationPanel;
    }
}