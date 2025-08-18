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
            toolStripSeparator6 = new ToolStripSeparator();
            terraCreatorReToolStripMenuItem = new ToolStripMenuItem();
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
            TabProjectSettings = new TabPage();
            ObjectProject = new Panel();
            TabObject = new TabPage();
            ObjectPanel = new Panel();
            splitter2 = new Splitter();
            ObjectListView = new ListView();
            TabFile = new TabPage();
            Panel = new Panel();
            codes = new RichTextBox();
            ImageBox = new PictureBox();
            splitter1 = new Splitter();
            fileview = new TreeView();
            ListTab = new TabControl();
            MenuList.SuspendLayout();
            ToolList.SuspendLayout();
            status.SuspendLayout();
            TabProjectSettings.SuspendLayout();
            TabObject.SuspendLayout();
            TabFile.SuspendLayout();
            Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ImageBox).BeginInit();
            ListTab.SuspendLayout();
            SuspendLayout();
            // 
            // MenuList
            // 
            resources.ApplyResources(MenuList, "MenuList");
            MenuList.ImageScalingSize = new Size(24, 24);
            MenuList.Items.AddRange(new ToolStripItem[] { 文件ToolStripMenuItem, Run, About });
            MenuList.Name = "MenuList";
            // 
            // 文件ToolStripMenuItem
            // 
            resources.ApplyResources(文件ToolStripMenuItem, "文件ToolStripMenuItem");
            文件ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolst_newproj, toolst_newitem, toolst_additemintoproj, toolStripSeparator2, toolst_SaveAs, toolst_save, toolStripSeparator3, toolst_exitprog });
            文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            // 
            // toolst_newproj
            // 
            resources.ApplyResources(toolst_newproj, "toolst_newproj");
            toolst_newproj.Name = "toolst_newproj";
            toolst_newproj.Click += toolst_newproj_Click;
            // 
            // toolst_newitem
            // 
            resources.ApplyResources(toolst_newitem, "toolst_newitem");
            toolst_newitem.Name = "toolst_newitem";
            toolst_newitem.Click += toolst_newitem_Click;
            // 
            // toolst_additemintoproj
            // 
            resources.ApplyResources(toolst_additemintoproj, "toolst_additemintoproj");
            toolst_additemintoproj.Name = "toolst_additemintoproj";
            toolst_additemintoproj.Click += toolst_additemintoproj_Click;
            // 
            // toolStripSeparator2
            // 
            resources.ApplyResources(toolStripSeparator2, "toolStripSeparator2");
            toolStripSeparator2.Name = "toolStripSeparator2";
            // 
            // toolst_SaveAs
            // 
            resources.ApplyResources(toolst_SaveAs, "toolst_SaveAs");
            toolst_SaveAs.Name = "toolst_SaveAs";
            toolst_SaveAs.Click += toolst_SaveAs_Click;
            // 
            // toolst_save
            // 
            resources.ApplyResources(toolst_save, "toolst_save");
            toolst_save.Name = "toolst_save";
            toolst_save.Click += toolst_save_Click;
            // 
            // toolStripSeparator3
            // 
            resources.ApplyResources(toolStripSeparator3, "toolStripSeparator3");
            toolStripSeparator3.Name = "toolStripSeparator3";
            // 
            // toolst_exitprog
            // 
            resources.ApplyResources(toolst_exitprog, "toolst_exitprog");
            toolst_exitprog.Name = "toolst_exitprog";
            toolst_exitprog.Click += toolst_exitprog_Click;
            // 
            // Run
            // 
            resources.ApplyResources(Run, "Run");
            Run.DropDownItems.AddRange(new ToolStripItem[] { RuntML, OpenCsproj });
            Run.Name = "Run";
            // 
            // RuntML
            // 
            resources.ApplyResources(RuntML, "RuntML");
            RuntML.Name = "RuntML";
            RuntML.Click += RuntML_Click;
            // 
            // OpenCsproj
            // 
            resources.ApplyResources(OpenCsproj, "OpenCsproj");
            OpenCsproj.Name = "OpenCsproj";
            OpenCsproj.Click += OpenCsproj_Click;
            // 
            // About
            // 
            resources.ApplyResources(About, "About");
            About.DropDownItems.AddRange(new ToolStripItem[] { toolst_about, toolStripSeparator6, terraCreatorReToolStripMenuItem, toolStripSeparator1, addon, settings });
            About.Name = "About";
            // 
            // toolst_about
            // 
            resources.ApplyResources(toolst_about, "toolst_about");
            toolst_about.Name = "toolst_about";
            toolst_about.Click += toolst_about_Click;
            // 
            // toolStripSeparator6
            // 
            resources.ApplyResources(toolStripSeparator6, "toolStripSeparator6");
            toolStripSeparator6.Name = "toolStripSeparator6";
            // 
            // terraCreatorReToolStripMenuItem
            // 
            resources.ApplyResources(terraCreatorReToolStripMenuItem, "terraCreatorReToolStripMenuItem");
            terraCreatorReToolStripMenuItem.Name = "terraCreatorReToolStripMenuItem";
            terraCreatorReToolStripMenuItem.Click += terraCreatorReToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            resources.ApplyResources(toolStripSeparator1, "toolStripSeparator1");
            toolStripSeparator1.Name = "toolStripSeparator1";
            // 
            // addon
            // 
            resources.ApplyResources(addon, "addon");
            addon.Name = "addon";
            addon.Click += addon_Click;
            // 
            // settings
            // 
            resources.ApplyResources(settings, "settings");
            settings.Name = "settings";
            settings.Click += settings_Click;
            // 
            // ToolList
            // 
            resources.ApplyResources(ToolList, "ToolList");
            ToolList.ImageScalingSize = new Size(24, 24);
            ToolList.Items.AddRange(new ToolStripItem[] { ImportProject, fresh, save, additem, toolStripSeparator5, OpenTML, OpenCsprojFile, toolStripSeparator4, ProjectName });
            ToolList.Name = "ToolList";
            // 
            // ImportProject
            // 
            resources.ApplyResources(ImportProject, "ImportProject");
            ImportProject.DisplayStyle = ToolStripItemDisplayStyle.Image;
            ImportProject.Image = Properties.Resources.Open;
            ImportProject.Name = "ImportProject";
            ImportProject.Click += ImportProject_Click;
            // 
            // fresh
            // 
            resources.ApplyResources(fresh, "fresh");
            fresh.DisplayStyle = ToolStripItemDisplayStyle.Image;
            fresh.Image = Properties.Resources.Reflash;
            fresh.Name = "fresh";
            fresh.Click += fresh_Click;
            // 
            // save
            // 
            resources.ApplyResources(save, "save");
            save.DisplayStyle = ToolStripItemDisplayStyle.Image;
            save.Image = Properties.Resources.Save;
            save.Name = "save";
            save.Click += save_Click;
            // 
            // additem
            // 
            resources.ApplyResources(additem, "additem");
            additem.DisplayStyle = ToolStripItemDisplayStyle.Image;
            additem.Image = Properties.Resources.NewItem;
            additem.Name = "additem";
            additem.Click += additem_Click;
            // 
            // toolStripSeparator5
            // 
            resources.ApplyResources(toolStripSeparator5, "toolStripSeparator5");
            toolStripSeparator5.Name = "toolStripSeparator5";
            // 
            // OpenTML
            // 
            resources.ApplyResources(OpenTML, "OpenTML");
            OpenTML.DisplayStyle = ToolStripItemDisplayStyle.Image;
            OpenTML.Image = Properties.Resources.OpenTML;
            OpenTML.Name = "OpenTML";
            OpenTML.Click += OpenTML_Click;
            // 
            // OpenCsprojFile
            // 
            resources.ApplyResources(OpenCsprojFile, "OpenCsprojFile");
            OpenCsprojFile.DisplayStyle = ToolStripItemDisplayStyle.Image;
            OpenCsprojFile.Image = Properties.Resources.OpenCsproj;
            OpenCsprojFile.Name = "OpenCsprojFile";
            OpenCsprojFile.Click += OpenCsprojFile_Click;
            // 
            // toolStripSeparator4
            // 
            resources.ApplyResources(toolStripSeparator4, "toolStripSeparator4");
            toolStripSeparator4.Name = "toolStripSeparator4";
            // 
            // ProjectName
            // 
            resources.ApplyResources(ProjectName, "ProjectName");
            ProjectName.Name = "ProjectName";
            // 
            // status
            // 
            resources.ApplyResources(status, "status");
            status.ImageScalingSize = new Size(24, 24);
            status.Items.AddRange(new ToolStripItem[] { CodeCount, FilePropt, FileStatus });
            status.Name = "status";
            // 
            // CodeCount
            // 
            resources.ApplyResources(CodeCount, "CodeCount");
            CodeCount.BackColor = Color.White;
            CodeCount.Name = "CodeCount";
            // 
            // FilePropt
            // 
            resources.ApplyResources(FilePropt, "FilePropt");
            FilePropt.BackColor = Color.White;
            FilePropt.Name = "FilePropt";
            // 
            // FileStatus
            // 
            resources.ApplyResources(FileStatus, "FileStatus");
            FileStatus.BackColor = Color.White;
            FileStatus.Name = "FileStatus";
            // 
            // TabProjectSettings
            // 
            resources.ApplyResources(TabProjectSettings, "TabProjectSettings");
            TabProjectSettings.BackColor = Color.FromArgb(192, 255, 255);
            TabProjectSettings.Controls.Add(ObjectProject);
            TabProjectSettings.ForeColor = SystemColors.ControlText;
            TabProjectSettings.Name = "TabProjectSettings";
            // 
            // ObjectProject
            // 
            resources.ApplyResources(ObjectProject, "ObjectProject");
            ObjectProject.Name = "ObjectProject";
            // 
            // TabObject
            // 
            resources.ApplyResources(TabObject, "TabObject");
            TabObject.Controls.Add(ObjectPanel);
            TabObject.Controls.Add(splitter2);
            TabObject.Controls.Add(ObjectListView);
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
            resources.ApplyResources(ObjectListView, "ObjectListView");
            ObjectListView.BackColor = Color.FromArgb(192, 255, 255);
            ObjectListView.Groups.AddRange(new ListViewGroup[] { (ListViewGroup)resources.GetObject("ObjectListView.Groups"), (ListViewGroup)resources.GetObject("ObjectListView.Groups1"), (ListViewGroup)resources.GetObject("ObjectListView.Groups2"), (ListViewGroup)resources.GetObject("ObjectListView.Groups3") });
            ObjectListView.Name = "ObjectListView";
            ObjectListView.UseCompatibleStateImageBehavior = false;
            ObjectListView.View = View.SmallIcon;
            ObjectListView.ItemSelectionChanged += ObjectListView_ItemSelectionChanged;
            // 
            // TabFile
            // 
            resources.ApplyResources(TabFile, "TabFile");
            TabFile.Controls.Add(Panel);
            TabFile.Controls.Add(splitter1);
            TabFile.Controls.Add(fileview);
            TabFile.Name = "TabFile";
            TabFile.UseVisualStyleBackColor = true;
            // 
            // Panel
            // 
            resources.ApplyResources(Panel, "Panel");
            Panel.Controls.Add(codes);
            Panel.Controls.Add(ImageBox);
            Panel.Name = "Panel";
            // 
            // codes
            // 
            codes.AcceptsTab = true;
            resources.ApplyResources(codes, "codes");
            codes.BackColor = Color.FromArgb(192, 255, 255);
            codes.Name = "codes";
            codes.TextChanged += codes_TextChanged;
            // 
            // ImageBox
            // 
            resources.ApplyResources(ImageBox, "ImageBox");
            ImageBox.Name = "ImageBox";
            ImageBox.TabStop = false;
            // 
            // splitter1
            // 
            resources.ApplyResources(splitter1, "splitter1");
            splitter1.Name = "splitter1";
            splitter1.TabStop = false;
            // 
            // fileview
            // 
            resources.ApplyResources(fileview, "fileview");
            fileview.BackColor = Color.FromArgb(192, 255, 255);
            fileview.Name = "fileview";
            fileview.AfterSelect += fileview_AfterSelect;
            // 
            // ListTab
            // 
            resources.ApplyResources(ListTab, "ListTab");
            ListTab.Controls.Add(TabFile);
            ListTab.Controls.Add(TabObject);
            ListTab.Controls.Add(TabProjectSettings);
            ListTab.Name = "ListTab";
            ListTab.SelectedIndex = 0;
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
            TabProjectSettings.ResumeLayout(false);
            TabObject.ResumeLayout(false);
            TabFile.ResumeLayout(false);
            Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ImageBox).EndInit();
            ListTab.ResumeLayout(false);
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
        private ToolStripStatusLabel FileStatus;
        private ToolStripButton ImportProject;
        private ToolStripButton OpenTML;
        private ToolStripButton OpenCsprojFile;
        private ToolStripSeparator toolStripSeparator5;
        private TabControl ListTab;
        private TabPage TabFile;
        private Panel Panel;
        private Splitter splitter1;
        private TabPage TabObject;
        private Splitter splitter2;
        private TabPage TabProjectSettings;
        private ToolStripMenuItem terraCreatorReToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator6;
        public static Panel ObjectProject;
        public static ToolStripStatusLabel CodeCount;
        public static ToolStripStatusLabel FilePropt;
        public static ToolStripLabel ProjectName;
        public static RichTextBox codes;
        public static PictureBox ImageBox;
        public static TreeView fileview;
        public static Panel ObjectPanel;
        public static ListView ObjectListView;
    }             
}
