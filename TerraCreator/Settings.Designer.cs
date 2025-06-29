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
            ListViewGroup listViewGroup1 = new ListViewGroup("个性化", HorizontalAlignment.Left);
            ListViewGroup listViewGroup2 = new ListViewGroup("其他", HorizontalAlignment.Left);
            ListViewItem listViewItem1 = new ListViewItem("颜色");
            ListViewItem listViewItem2 = new ListViewItem("其他");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            settinglabel = new Label();
            SettingSplit = new SplitContainer();
            SettingList = new ListView();
            Panel = new Panel();
            SaveChanges = new Button();
            ((System.ComponentModel.ISupportInitialize)SettingSplit).BeginInit();
            SettingSplit.Panel1.SuspendLayout();
            SettingSplit.Panel2.SuspendLayout();
            SettingSplit.SuspendLayout();
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
            // SettingSplit
            // 
            SettingSplit.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SettingSplit.IsSplitterFixed = true;
            SettingSplit.Location = new Point(8, 30);
            SettingSplit.Margin = new Padding(2, 2, 2, 2);
            SettingSplit.Name = "SettingSplit";
            // 
            // SettingSplit.Panel1
            // 
            SettingSplit.Panel1.Controls.Add(SettingList);
            // 
            // SettingSplit.Panel2
            // 
            SettingSplit.Panel2.BackColor = Color.FromArgb(192, 255, 255);
            SettingSplit.Panel2.Controls.Add(Panel);
            SettingSplit.Size = new Size(773, 458);
            SettingSplit.SplitterDistance = 176;
            SettingSplit.SplitterWidth = 3;
            SettingSplit.TabIndex = 7;
            // 
            // SettingList
            // 
            SettingList.BackColor = Color.FromArgb(192, 255, 255);
            SettingList.Dock = DockStyle.Fill;
            listViewGroup1.Header = "个性化";
            listViewGroup1.Name = "Personality";
            listViewGroup2.Header = "其他";
            listViewGroup2.Name = "Else";
            SettingList.Groups.AddRange(new ListViewGroup[] { listViewGroup1, listViewGroup2 });
            listViewItem1.Group = listViewGroup1;
            listViewItem1.ToolTipText = "设置窗体和控件颜色";
            listViewItem2.Group = listViewGroup2;
            SettingList.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2 });
            SettingList.Location = new Point(0, 0);
            SettingList.Margin = new Padding(2, 2, 2, 2);
            SettingList.Name = "SettingList";
            SettingList.Size = new Size(176, 458);
            SettingList.TabIndex = 0;
            SettingList.UseCompatibleStateImageBehavior = false;
            SettingList.View = View.SmallIcon;
            SettingList.SelectedIndexChanged += SettingList_SelectedIndexChanged;
            // 
            // Panel
            // 
            Panel.Dock = DockStyle.Fill;
            Panel.Location = new Point(0, 0);
            Panel.Margin = new Padding(2, 2, 2, 2);
            Panel.Name = "Panel";
            Panel.Size = new Size(594, 458);
            Panel.TabIndex = 0;
            // 
            // SaveChanges
            // 
            SaveChanges.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            SaveChanges.Location = new Point(709, 493);
            SaveChanges.Margin = new Padding(2, 2, 2, 2);
            SaveChanges.Name = "SaveChanges";
            SaveChanges.Size = new Size(71, 24);
            SaveChanges.TabIndex = 8;
            SaveChanges.Text = "保存";
            SaveChanges.UseVisualStyleBackColor = true;
            SaveChanges.Click += SaveChanges_Click;
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 255, 255);
            ClientSize = new Size(788, 526);
            Controls.Add(SaveChanges);
            Controls.Add(SettingSplit);
            Controls.Add(settinglabel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2, 2, 2, 2);
            Name = "Settings";
            Text = "设置";
            Load += Settings_Load;
            SettingSplit.Panel1.ResumeLayout(false);
            SettingSplit.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)SettingSplit).EndInit();
            SettingSplit.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label settinglabel;
        private SplitContainer SettingSplit;
        private ListView SettingList;
        private Panel Panel;
        private Button SaveChanges;
    }
}