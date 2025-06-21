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
            关于ToolStripMenuItem = new ToolStripMenuItem();
            toolst_about = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            addon = new ToolStripMenuItem();
            settings = new ToolStripMenuItem();
            ToolList = new ToolStrip();
            fresh = new ToolStripButton();
            save = new ToolStripButton();
            additem = new ToolStripButton();
            toolStripSeparator4 = new ToolStripSeparator();
            ProjectName = new ToolStripLabel();
            status = new StatusStrip();
            CodeCount = new ToolStripStatusLabel();
            FilePropt = new ToolStripStatusLabel();
            split = new Splitter();
            ImageBox = new PictureBox();
            codes = new RichTextBox();
            panel1 = new Panel();
            MenuList.SuspendLayout();
            ToolList.SuspendLayout();
            status.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ImageBox).BeginInit();
            panel1.SuspendLayout();
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
            MenuList.Items.AddRange(new ToolStripItem[] { 文件ToolStripMenuItem, Run, 关于ToolStripMenuItem });
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
            // 关于ToolStripMenuItem
            // 
            关于ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolst_about, toolStripSeparator1, addon, settings });
            关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            resources.ApplyResources(关于ToolStripMenuItem, "关于ToolStripMenuItem");
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
            addon.Name = "addon";
            resources.ApplyResources(addon, "addon");
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
            ToolList.Items.AddRange(new ToolStripItem[] { fresh, save, additem, toolStripSeparator4, ProjectName });
            resources.ApplyResources(ToolList, "ToolList");
            ToolList.Name = "ToolList";
            // 
            // fresh
            // 
            fresh.DisplayStyle = ToolStripItemDisplayStyle.Image;
            fresh.Image = Properties.Resources.f__1_;
            resources.ApplyResources(fresh, "fresh");
            fresh.Name = "fresh";
            fresh.Click += fresh_Click;
            // 
            // save
            // 
            save.DisplayStyle = ToolStripItemDisplayStyle.Image;
            save.Image = Properties.Resources.f__3_;
            resources.ApplyResources(save, "save");
            save.Name = "save";
            save.Click += save_Click;
            // 
            // additem
            // 
            additem.DisplayStyle = ToolStripItemDisplayStyle.Image;
            additem.Image = Properties.Resources.f__2_;
            resources.ApplyResources(additem, "additem");
            additem.Name = "additem";
            additem.Click += additem_Click;
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
            status.Items.AddRange(new ToolStripItem[] { CodeCount, FilePropt });
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
            // split
            // 
            resources.ApplyResources(split, "split");
            split.Name = "split";
            split.TabStop = false;
            // 
            // ImageBox
            // 
            resources.ApplyResources(ImageBox, "ImageBox");
            ImageBox.Name = "ImageBox";
            ImageBox.TabStop = false;
            // 
            // codes
            // 
            codes.BackColor = Color.FromArgb(192, 255, 255);
            resources.ApplyResources(codes, "codes");
            codes.Name = "codes";
            codes.TextChanged += codes_TextChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(codes);
            panel1.Controls.Add(ImageBox);
            resources.ApplyResources(panel1, "panel1");
            panel1.Name = "panel1";
            // 
            // Main
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 255, 255);
            Controls.Add(panel1);
            Controls.Add(split);
            Controls.Add(fileview);
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
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip MenuList;
        private ToolStripMenuItem 文件ToolStripMenuItem;
        private ToolStripMenuItem 关于ToolStripMenuItem;
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
        private Splitter split;
        public static PictureBox ImageBox;
        public static RichTextBox codes;
        private Panel panel1;
        public static TreeView fileview;
        public static ToolStripStatusLabel CodeCount;
        public static ToolStripStatusLabel FilePropt;
        public static ToolStripLabel ProjectName;
    }             
}
