namespace TerraCreator
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            fileview = new TreeView();
            MenuList = new MenuStrip();
            文件ToolStripMenuItem = new ToolStripMenuItem();
            toolst_newproj = new ToolStripMenuItem();
            toolst_newitem = new ToolStripMenuItem();
            toolst_additemintoproj = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            toolst_SaveAs = new ToolStripMenuItem();
            toolst_save = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            toolst_exitprog = new ToolStripMenuItem();
            Run = new ToolStripMenuItem();
            RuntML = new ToolStripMenuItem();
            OpenCsproj = new ToolStripMenuItem();
            About = new ToolStripMenuItem();
            toolst_about = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            addon = new ToolStripMenuItem();
            settings = new ToolStripMenuItem();
            ToolList = new ToolStrip();
            ImportProject = new ToolStripButton();
            fresh = new ToolStripButton();
            save = new ToolStripButton();
            additem = new ToolStripButton();
            toolStripSeparator5 = new ToolStripSeparator();
            OpenTML = new ToolStripButton();
            OpenCsprojFile = new ToolStripButton();
            toolStripSeparator4 = new ToolStripSeparator();
            ProjectName = new ToolStripLabel();
            status = new StatusStrip();
            CodeCount = new ToolStripStatusLabel();
            FilePropt = new ToolStripStatusLabel();
            FileStatus = new ToolStripStatusLabel();
            ImageBox = new PictureBox();
            codes = new RichTextBox();
            Panel = new Panel();
            ListTab = new TabControl();
            TabFile = new TabPage();
            splitter1 = new Splitter();
            TabObject = new TabPage();
            ObjectPanel = new Panel();
            splitter2 = new Splitter();
            ObjectListView = new ListView();
            FileSystem = new FileSystemWatcher();
            TabProjectSettings = new TabPage();
            splitter3 = new Splitter();
            panel1 = new Panel();
            listView1 = new ListView();
            MenuList.SuspendLayout();
            ToolList.SuspendLayout();
            status.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ImageBox).BeginInit();
            Panel.SuspendLayout();
            ListTab.SuspendLayout();
            TabFile.SuspendLayout();
            TabObject.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)FileSystem).BeginInit();
            TabProjectSettings.SuspendLayout();
            SuspendLayout();
            // 
            // fileview
            // 
            fileview.BackColor = Color.FromArgb(192, 255, 255);
            resources.ApplyResources(fileview, "fileview");
            fileview.Name = "fileview";
            fileview.AfterSelect += fileview_AfterSelect;
            // 
            // MenuList
            // 
            MenuList.ImageScalingSize = new Size(24, 24);
            MenuList.Items.AddRange(new ToolStripItem[] { 文件ToolStripMenuItem, Run, About });
            resources.ApplyResources(MenuList, "MenuList");
            MenuList.Name = "MenuList";
            // 
            // 文件ToolStripMenuItem
            // 
            文件ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolst_newproj, toolst_newitem, toolst_additemintoproj, toolStripSeparator2, toolst_SaveAs, toolst_save, toolStripSeparator3, toolst_exitprog });
            文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            resources.ApplyResources(文件ToolStripMenuItem, "文件ToolStripMenuItem");
            // 
            // toolst_newproj
            // 
            toolst_newproj.Name = "toolst_newproj";
            resources.ApplyResources(toolst_newproj, "toolst_newproj");
            toolst_newproj.Click += toolst_newproj_Click;
            // 
            // toolst_newitem
            // 
            toolst_newitem.Name = "toolst_newitem";
            resources.ApplyResources(toolst_newitem, "toolst_newitem");
            toolst_newitem.Click += toolst_newitem_Click;
            // 
            // toolst_additemintoproj
            // 
            toolst_additemintoproj.Name = "toolst_additemintoproj";
            resources.ApplyResources(toolst_additemintoproj, "toolst_additemintoproj");
            toolst_additemintoproj.Click += toolst_additemintoproj_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            resources.ApplyResources(toolStripSeparator2, "toolStripSeparator2");
            // 
            // toolst_SaveAs
            // 
            toolst_SaveAs.Name = "toolst_SaveAs";
            resources.ApplyResources(toolst_SaveAs, "toolst_SaveAs");
            toolst_SaveAs.Click += toolst_SaveAs_Click;
            // 
            // toolst_save
            // 
            toolst_save.Name = "toolst_save";
            resources.ApplyResources(toolst_save, "toolst_save");
            toolst_save.Click += toolst_save_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            resources.ApplyResources(toolStripSeparator3, "toolStripSeparator3");
            // 
            // toolst_exitprog
            // 
            toolst_exitprog.Name = "toolst_exitprog";
            resources.ApplyResources(toolst_exitprog, "toolst_exitprog");
            toolst_exitprog.Click += toolst_exitprog_Click;
            // 
            // Run
            // 
            Run.DropDownItems.AddRange(new ToolStripItem[] { RuntML, OpenCsproj });
            Run.Name = "Run";
            resources.ApplyResources(Run, "Run");
            // 
            // RuntML
            // 
            RuntML.Name = "RuntML";
            resources.ApplyResources(RuntML, "RuntML");
            RuntML.Click += RuntML_Click;
            // 
            // OpenCsproj
            // 
            OpenCsproj.Name = "OpenCsproj";
            resources.ApplyResources(OpenCsproj, "OpenCsproj");
            OpenCsproj.Click += OpenCsproj_Click;
            // 
            // About
            // 
            About.DropDownItems.AddRange(new ToolStripItem[] { toolst_about, toolStripSeparator1, addon, settings });
            About.Name = "About";
            resources.ApplyResources(About, "About");
            // 
            // toolst_about
            // 
            toolst_about.Name = "toolst_about";
            resources.ApplyResources(toolst_about, "toolst_about");
            toolst_about.Click += toolst_about_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(toolStripSeparator1, "toolStripSeparator1");
            // 
            // addon
            // 
            resources.ApplyResources(addon, "addon");
            addon.Name = "addon";
            addon.Click += addon_Click;
            // 
            // settings
            // 
            settings.Name = "settings";
            resources.ApplyResources(settings, "settings");
            settings.Click += settings_Click;
            // 
            // ToolList
            // 
            ToolList.Items.AddRange(new ToolStripItem[] { ImportProject, fresh, save, additem, toolStripSeparator5, OpenTML, OpenCsprojFile, toolStripSeparator4, ProjectName });
            resources.ApplyResources(ToolList, "ToolList");
            ToolList.Name = "ToolList";
            // 
            // ImportProject
            // 
            ImportProject.DisplayStyle = ToolStripItemDisplayStyle.Image;
            ImportProject.Image = Properties.Resources.Open;
            resources.ApplyResources(ImportProject, "ImportProject");
            ImportProject.Name = "ImportProject";
            ImportProject.Click += ImportProject_Click;
            // 
            // fresh
            // 
            fresh.DisplayStyle = ToolStripItemDisplayStyle.Image;
            fresh.Image = Properties.Resources.Reflash;
            resources.ApplyResources(fresh, "fresh");
            fresh.Name = "fresh";
            fresh.Click += fresh_Click;
            // 
            // save
            // 
            save.DisplayStyle = ToolStripItemDisplayStyle.Image;
            save.Image = Properties.Resources.Save;
            resources.ApplyResources(save, "save");
            save.Name = "save";
            save.Click += save_Click;
            // 
            // additem
            // 
            additem.DisplayStyle = ToolStripItemDisplayStyle.Image;
            additem.Image = Properties.Resources.NewItem;
            resources.ApplyResources(additem, "additem");
            additem.Name = "additem";
            additem.Click += additem_Click;
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            resources.ApplyResources(toolStripSeparator5, "toolStripSeparator5");
            // 
            // OpenTML
            // 
            OpenTML.DisplayStyle = ToolStripItemDisplayStyle.Image;
            OpenTML.Image = Properties.Resources.OpenTML;
            resources.ApplyResources(OpenTML, "OpenTML");
            OpenTML.Name = "OpenTML";
            OpenTML.Click += OpenTML_Click;
            // 
            // OpenCsprojFile
            // 
            OpenCsprojFile.DisplayStyle = ToolStripItemDisplayStyle.Image;
            OpenCsprojFile.Image = Properties.Resources.OpenCsproj;
            resources.ApplyResources(OpenCsprojFile, "OpenCsprojFile");
            OpenCsprojFile.Name = "OpenCsprojFile";
            OpenCsprojFile.Click += OpenCsprojFile_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            resources.ApplyResources(toolStripSeparator4, "toolStripSeparator4");
            // 
            // ProjectName
            // 
            ProjectName.Name = "ProjectName";
            resources.ApplyResources(ProjectName, "ProjectName");
            // 
            // status
            // 
            status.Items.AddRange(new ToolStripItem[] { CodeCount, FilePropt, FileStatus });
            resources.ApplyResources(status, "status");
            status.Name = "status";
            // 
            // CodeCount
            // 
            CodeCount.BackColor = Color.White;
            CodeCount.Name = "CodeCount";
            resources.ApplyResources(CodeCount, "CodeCount");
            // 
            // FilePropt
            // 
            FilePropt.BackColor = Color.White;
            FilePropt.Name = "FilePropt";
            resources.ApplyResources(FilePropt, "FilePropt");
            // 
            // FileStatus
            // 
            FileStatus.BackColor = Color.White;
            FileStatus.Name = "FileStatus";
            resources.ApplyResources(FileStatus, "FileStatus");
            // 
            // ImageBox
            // 
            resources.ApplyResources(ImageBox, "ImageBox");
            ImageBox.Name = "ImageBox";
            ImageBox.TabStop = false;
            // 
            // codes
            // 
            codes.AcceptsTab = true;
            codes.BackColor = Color.FromArgb(192, 255, 255);
            resources.ApplyResources(codes, "codes");
            codes.Name = "codes";
            codes.TextChanged += codes_TextChanged;
            // 
            // Panel
            // 
            Panel.Controls.Add(codes);
            Panel.Controls.Add(ImageBox);
            resources.ApplyResources(Panel, "Panel");
            Panel.Name = "Panel";
            // 
            // ListTab
            // 
            ListTab.Controls.Add(TabFile);
            ListTab.Controls.Add(TabObject);
            ListTab.Controls.Add(TabProjectSettings);
            resources.ApplyResources(ListTab, "ListTab");
            ListTab.Name = "ListTab";
            ListTab.SelectedIndex = 0;
            // 
            // TabFile
            // 
            TabFile.Controls.Add(Panel);
            TabFile.Controls.Add(splitter1);
            TabFile.Controls.Add(fileview);
            resources.ApplyResources(TabFile, "TabFile");
            TabFile.Name = "TabFile";
            TabFile.UseVisualStyleBackColor = true;
            // 
            // splitter1
            // 
            resources.ApplyResources(splitter1, "splitter1");
            splitter1.Name = "splitter1";
            splitter1.TabStop = false;
            // 
            // TabObject
            // 
            TabObject.Controls.Add(ObjectPanel);
            TabObject.Controls.Add(splitter2);
            TabObject.Controls.Add(ObjectListView);
            resources.ApplyResources(TabObject, "TabObject");
            TabObject.Name = "TabObject";
            TabObject.UseVisualStyleBackColor = true;
            // 
            // ObjectPanel
            // 
            resources.ApplyResources(ObjectPanel, "ObjectPanel");
            ObjectPanel.BackColor = Color.FromArgb(192, 255, 255);
            ObjectPanel.Name = "ObjectPanel";
            // 
            // splitter2
            // 
            resources.ApplyResources(splitter2, "splitter2");
            splitter2.Name = "splitter2";
            splitter2.TabStop = false;
            // 
            // ObjectListView
            // 
            ObjectListView.BackColor = Color.FromArgb(192, 255, 255);
            resources.ApplyResources(ObjectListView, "ObjectListView");
            ObjectListView.Groups.AddRange(new ListViewGroup[] { (ListViewGroup)resources.GetObject("ObjectListView.Groups"), (ListViewGroup)resources.GetObject("ObjectListView.Groups1") });
            ObjectListView.Name = "ObjectListView";
            ObjectListView.UseCompatibleStateImageBehavior = false;
            ObjectListView.View = View.SmallIcon;
            ObjectListView.ItemSelectionChanged += ObjectListView_ItemSelectionChanged;
            // 
            // FileSystem
            // 
            FileSystem.EnableRaisingEvents = true;
            FileSystem.SynchronizingObject = this;
            // 
            // TabProjectSettings
            // 
            TabProjectSettings.BackColor = Color.FromArgb(128, 255, 255);
            TabProjectSettings.Controls.Add(panel1);
            TabProjectSettings.Controls.Add(splitter3);
            TabProjectSettings.Controls.Add(listView1);
            resources.ApplyResources(TabProjectSettings, "TabProjectSettings");
            TabProjectSettings.Name = "TabProjectSettings";
            // 
            // splitter3
            // 
            resources.ApplyResources(splitter3, "splitter3");
            splitter3.Name = "splitter3";
            splitter3.TabStop = false;
            // 
            // panel1
            // 
            resources.ApplyResources(panel1, "panel1");
            panel1.BackColor = Color.FromArgb(192, 255, 255);
            panel1.Name = "panel1";
            // 
            // listView1
            // 
            listView1.BackColor = Color.FromArgb(192, 255, 255);
            resources.ApplyResources(listView1, "listView1");
            listView1.Groups.AddRange(new ListViewGroup[] { (ListViewGroup)resources.GetObject("listView1.Groups"), (ListViewGroup)resources.GetObject("listView1.Groups1") });
            listView1.Name = "listView1";
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.SmallIcon;
            // 
            // Main
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 255, 255);
            Controls.Add(ListTab);
            Controls.Add(status);
            Controls.Add(ToolList);
            Controls.Add(MenuList);
            Name = "Main";
            Load += Main_Load;
            MenuList.ResumeLayout(false);
            MenuList.PerformLayout();
            ToolList.ResumeLayout(false);
            ToolList.PerformLayout();
            status.ResumeLayout(false);
            status.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ImageBox).EndInit();
            Panel.ResumeLayout(false);
            ListTab.ResumeLayout(false);
            TabFile.ResumeLayout(false);
            TabObject.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)FileSystem).EndInit();
            TabProjectSettings.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip MenuList;
        private ToolStripMenuItem 文件ToolStripMenuItem;
        private ToolStripMenuItem About;
        private ToolStrip ToolList;
        private ToolStripButton fresh;
        private ToolStripMenuItem toolst_about;
        private ToolStripMenuItem toolst_newproj;
        private ToolStripMenuItem toolst_newitem;
        private ToolStripMenuItem toolst_additemintoproj;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem toolst_save;
        private ToolStripMenuItem toolst_exitprog;
        private ToolStripButton save;
        private ToolStripButton additem;
        private ToolStripMenuItem settings;
        private ToolStripMenuItem addon;
        private ToolStripMenuItem Run;
        private ToolStripMenuItem RuntML;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem toolst_SaveAs;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem OpenCsproj;
        private StatusStrip status;
        private ToolStripSeparator toolStripSeparator4;
        private Panel Panel;
        private ToolStripStatusLabel FileStatus;
        private TabControl ListTab;
        private TabPage TabFile;
        private TabPage TabObject;
        private Splitter splitter1;
        private Splitter splitter2;
        private ToolStripButton ImportProject;
        private ToolStripButton OpenTML;
        private ToolStripButton OpenCsprojFile;
        private ToolStripSeparator toolStripSeparator5;
        public static Panel ObjectPanel;
        public static ListView ObjectListView;
        public static PictureBox ImageBox;
        public static RichTextBox codes;
        public static TreeView fileview;
        public static ToolStripStatusLabel CodeCount;
        public static ToolStripStatusLabel FilePropt;
        public static ToolStripLabel ProjectName;
        public static FileSystemWatcher FileSystem;
        private TabPage TabProjectSettings;
        public Panel panel1;
        private Splitter splitter3;
        public ListView listView1;
    }             
}
