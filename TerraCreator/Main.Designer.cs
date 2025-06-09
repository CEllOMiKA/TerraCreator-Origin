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
            split = new SplitContainer();
            fileview = new TreeView();
            codes = new RichTextBox();
            ImageBox = new PictureBox();
            menuStrip1 = new MenuStrip();
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
            关于ToolStripMenuItem = new ToolStripMenuItem();
            toolst_about = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            addon = new ToolStripMenuItem();
            settings = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            fresh = new ToolStripButton();
            save = new ToolStripButton();
            additem = new ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)split).BeginInit();
            split.Panel1.SuspendLayout();
            split.Panel2.SuspendLayout();
            split.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ImageBox).BeginInit();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // split
            // 
            resources.ApplyResources(split, "split");
            split.FixedPanel = FixedPanel.Panel1;
            split.Name = "split";
            // 
            // split.Panel1
            // 
            split.Panel1.Controls.Add(fileview);
            // 
            // split.Panel2
            // 
            split.Panel2.Controls.Add(codes);
            split.Panel2.Controls.Add(ImageBox);
            // 
            // fileview
            // 
            fileview.BackColor = Color.FromArgb(192, 255, 255);
            resources.ApplyResources(fileview, "fileview");
            fileview.Name = "fileview";
            fileview.AfterSelect += fileview_AfterSelect;
            // 
            // codes
            // 
            codes.BackColor = Color.FromArgb(192, 255, 255);
            resources.ApplyResources(codes, "codes");
            codes.Name = "codes";
            codes.TextChanged += codes_TextChanged;
            // 
            // ImageBox
            // 
            resources.ApplyResources(ImageBox, "ImageBox");
            ImageBox.Name = "ImageBox";
            ImageBox.TabStop = false;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { 文件ToolStripMenuItem, Run, 关于ToolStripMenuItem });
            resources.ApplyResources(menuStrip1, "menuStrip1");
            menuStrip1.Name = "menuStrip1";
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
            Run.DropDownItems.AddRange(new ToolStripItem[] { RuntML });
            Run.Name = "Run";
            resources.ApplyResources(Run, "Run");
            // 
            // RuntML
            // 
            RuntML.Name = "RuntML";
            resources.ApplyResources(RuntML, "RuntML");
            RuntML.Click += RuntML_Click;
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
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { fresh, save, additem });
            resources.ApplyResources(toolStrip1, "toolStrip1");
            toolStrip1.Name = "toolStrip1";
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
            // Main
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 255, 255);
            Controls.Add(split);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            Name = "Main";
            Load += Main_Load;
            split.Panel1.ResumeLayout(false);
            split.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)split).EndInit();
            split.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ImageBox).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem 文件ToolStripMenuItem;
        private ToolStripMenuItem 关于ToolStripMenuItem;
        private ToolStrip toolStrip1;
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
        private SplitContainer split;
        private ToolStripMenuItem settings;
        private ToolStripMenuItem addon;
        private ToolStripMenuItem Run;
        private ToolStripMenuItem RuntML;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem toolst_SaveAs;
        private ToolStripSeparator toolStripSeparator3;
        public static TreeView fileview;
        public static RichTextBox codes;
        public static PictureBox ImageBox;
    }
}
