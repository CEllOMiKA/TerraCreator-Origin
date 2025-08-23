namespace TerraCreator
{
    partial class ProjectSettings
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
            ListViewGroup listViewGroup1 = new ListViewGroup("基础设置", HorizontalAlignment.Left);
            ListViewItem listViewItem1 = new ListViewItem("项目展示配置");
            ListViewItem listViewItem2 = new ListViewItem("默认代码生成位置");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectSettings));
            SettingsPanel = new Panel();
            SettingsListView = new ListView();
            ProjectSettingRootPanel = new Panel();
            SettingsSplitter = new Splitter();
            colorDialog1 = new ColorDialog();
            ProjectSettingRootPanel.SuspendLayout();
            SuspendLayout();
            // 
            // SettingsPanel
            // 
            SettingsPanel.BackColor = Color.FromArgb(192, 255, 255);
            SettingsPanel.Dock = DockStyle.Fill;
            SettingsPanel.Location = new Point(276, 0);
            SettingsPanel.Margin = new Padding(5, 4, 5, 4);
            SettingsPanel.Name = "SettingsPanel";
            SettingsPanel.Size = new Size(1171, 986);
            SettingsPanel.TabIndex = 8;
            // 
            // SettingsListView
            // 
            SettingsListView.BackColor = Color.FromArgb(192, 255, 255);
            SettingsListView.Dock = DockStyle.Left;
            listViewGroup1.Header = "基础设置";
            listViewGroup1.Name = "BasicSettings";
            SettingsListView.Groups.AddRange(new ListViewGroup[] { listViewGroup1 });
            listViewItem1.Group = listViewGroup1;
            listViewItem1.ToolTipText = "项目展示配置";
            listViewItem2.Group = listViewGroup1;
            listViewItem2.ToolTipText = "默认代码生成位置";
            SettingsListView.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2 });
            SettingsListView.Location = new Point(0, 0);
            SettingsListView.Margin = new Padding(5, 4, 5, 4);
            SettingsListView.Name = "SettingsListView";
            SettingsListView.Size = new Size(276, 986);
            SettingsListView.TabIndex = 10;
            SettingsListView.UseCompatibleStateImageBehavior = false;
            SettingsListView.View = View.SmallIcon;
            SettingsListView.SelectedIndexChanged += SettingsListView_SelectedIndexChanged;
            // 
            // ProjectSettingRootPanel
            // 
            ProjectSettingRootPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ProjectSettingRootPanel.BackColor = Color.FromArgb(192, 255, 255);
            ProjectSettingRootPanel.Controls.Add(SettingsSplitter);
            ProjectSettingRootPanel.Controls.Add(SettingsPanel);
            ProjectSettingRootPanel.Controls.Add(SettingsListView);
            ProjectSettingRootPanel.Location = new Point(17, 13);
            ProjectSettingRootPanel.Margin = new Padding(5, 4, 5, 4);
            ProjectSettingRootPanel.Name = "ProjectSettingRootPanel";
            ProjectSettingRootPanel.Size = new Size(1447, 986);
            ProjectSettingRootPanel.TabIndex = 9;
            // 
            // SettingsSplitter
            // 
            SettingsSplitter.Location = new Point(276, 0);
            SettingsSplitter.Name = "SettingsSplitter";
            SettingsSplitter.Size = new Size(4, 986);
            SettingsSplitter.TabIndex = 11;
            SettingsSplitter.TabStop = false;
            // 
            // ProjectSettings
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 255, 255);
            ClientSize = new Size(1478, 1012);
            Controls.Add(ProjectSettingRootPanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 4, 5, 4);
            Name = "ProjectSettings";
            Text = "项目设置";
            Load += ProjectSettings_Load;
            ProjectSettingRootPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel SettingsPanel;
        private ListView SettingsListView;
        private Panel ProjectSettingRootPanel;
        private Splitter SettingsSplitter;
        private ColorDialog colorDialog1;
    }
}