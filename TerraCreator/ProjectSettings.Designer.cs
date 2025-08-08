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
            ListViewItem listViewItem1 = new ListViewItem("项目配置");
            ListViewItem listViewItem2 = new ListViewItem("默认代码生成位置");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectSettings));
            ProjectSettingsLabel = new Label();
            SettingsPanel = new Panel();
            SettingsListView = new ListView();
            SplitContainer = new SplitContainer();
            ((System.ComponentModel.ISupportInitialize)SplitContainer).BeginInit();
            SplitContainer.Panel1.SuspendLayout();
            SplitContainer.Panel2.SuspendLayout();
            SplitContainer.SuspendLayout();
            SuspendLayout();
            // 
            // ProjectSettingsLabel
            // 
            ProjectSettingsLabel.AutoSize = true;
            ProjectSettingsLabel.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            ProjectSettingsLabel.Location = new Point(11, 9);
            ProjectSettingsLabel.Margin = new Padding(2, 0, 2, 0);
            ProjectSettingsLabel.Name = "ProjectSettingsLabel";
            ProjectSettingsLabel.Size = new Size(74, 22);
            ProjectSettingsLabel.TabIndex = 6;
            ProjectSettingsLabel.Text = "项目设置";
            // 
            // SettingsPanel
            // 
            SettingsPanel.BackColor = Color.FromArgb(192, 255, 255);
            SettingsPanel.Dock = DockStyle.Fill;
            SettingsPanel.Location = new Point(0, 0);
            SettingsPanel.Name = "SettingsPanel";
            SettingsPanel.Size = new Size(595, 504);
            SettingsPanel.TabIndex = 8;
            // 
            // SettingsListView
            // 
            SettingsListView.BackColor = Color.FromArgb(192, 255, 255);
            SettingsListView.Dock = DockStyle.Fill;
            listViewGroup1.Header = "基础设置";
            listViewGroup1.Name = "BasicSettings";
            SettingsListView.Groups.AddRange(new ListViewGroup[] { listViewGroup1 });
            listViewItem1.Group = listViewGroup1;
            listViewItem1.ToolTipText = "项目配置";
            listViewItem2.Group = listViewGroup1;
            listViewItem2.ToolTipText = "默认代码生成位置";
            SettingsListView.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2 });
            SettingsListView.Location = new Point(0, 0);
            SettingsListView.Name = "SettingsListView";
            SettingsListView.Size = new Size(177, 504);
            SettingsListView.TabIndex = 10;
            SettingsListView.UseCompatibleStateImageBehavior = false;
            SettingsListView.View = View.SmallIcon;
            SettingsListView.SelectedIndexChanged += SettingsListView_SelectedIndexChanged;
            // 
            // SplitContainer
            // 
            SplitContainer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SplitContainer.Location = new Point(12, 34);
            SplitContainer.Name = "SplitContainer";
            // 
            // SplitContainer.Panel1
            // 
            SplitContainer.Panel1.Controls.Add(SettingsListView);
            // 
            // SplitContainer.Panel2
            // 
            SplitContainer.Panel2.Controls.Add(SettingsPanel);
            SplitContainer.Size = new Size(776, 504);
            SplitContainer.SplitterDistance = 177;
            SplitContainer.TabIndex = 11;
            // 
            // ProjectSettings
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 255, 255);
            ClientSize = new Size(800, 550);
            Controls.Add(SplitContainer);
            Controls.Add(ProjectSettingsLabel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ProjectSettings";
            Text = "项目设置";
            Load += ProjectSettings_Load;
            SplitContainer.Panel1.ResumeLayout(false);
            SplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)SplitContainer).EndInit();
            SplitContainer.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ProjectSettingsLabel;
        private Panel SettingsPanel;
        private ListView SettingsListView;
        private SplitContainer SplitContainer;
    }
}