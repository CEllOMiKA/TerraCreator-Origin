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
            menuStrip1 = new MenuStrip();
            文件ToolStripMenuItem = new ToolStripMenuItem();
            toolst_newproj = new ToolStripMenuItem();
            toolst_newitem = new ToolStripMenuItem();
            toolst_additemintoproj = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            toolst_save = new ToolStripMenuItem();
            toolst_exitprog = new ToolStripMenuItem();
            关于ToolStripMenuItem = new ToolStripMenuItem();
            toolst_about = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            fresh = new ToolStripButton();
            save = new ToolStripButton();
            additem = new ToolStripButton();
            codes = new RichTextBox();
            fileview = new TreeView();
            split = new SplitContainer();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)split).BeginInit();
            split.Panel1.SuspendLayout();
            split.Panel2.SuspendLayout();
            split.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { 文件ToolStripMenuItem, 关于ToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1355, 32);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            文件ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolst_newproj, toolst_newitem, toolst_additemintoproj, toolStripSeparator2, toolst_save, toolst_exitprog });
            文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            文件ToolStripMenuItem.Size = new Size(62, 28);
            文件ToolStripMenuItem.Text = "文件";
            // 
            // toolst_newproj
            // 
            toolst_newproj.Name = "toolst_newproj";
            toolst_newproj.Size = new Size(182, 34);
            toolst_newproj.Text = "导入项目";
            toolst_newproj.Click += toolst_newproj_Click;
            // 
            // toolst_newitem
            // 
            toolst_newitem.Name = "toolst_newitem";
            toolst_newitem.Size = new Size(182, 34);
            toolst_newitem.Text = "新建项";
            toolst_newitem.Click += toolst_newitem_Click;
            // 
            // toolst_additemintoproj
            // 
            toolst_additemintoproj.Name = "toolst_additemintoproj";
            toolst_additemintoproj.Size = new Size(182, 34);
            toolst_additemintoproj.Text = "导入项";
            toolst_additemintoproj.Click += toolst_additemintoproj_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(179, 6);
            // 
            // toolst_save
            // 
            toolst_save.Name = "toolst_save";
            toolst_save.Size = new Size(182, 34);
            toolst_save.Text = "保存";
            toolst_save.Click += toolst_save_Click;
            // 
            // toolst_exitprog
            // 
            toolst_exitprog.Name = "toolst_exitprog";
            toolst_exitprog.Size = new Size(182, 34);
            toolst_exitprog.Text = "退出";
            toolst_exitprog.Click += toolst_exitprog_Click;
            // 
            // 关于ToolStripMenuItem
            // 
            关于ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolst_about });
            关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            关于ToolStripMenuItem.Size = new Size(62, 28);
            关于ToolStripMenuItem.Text = "关于";
            // 
            // toolst_about
            // 
            toolst_about.Name = "toolst_about";
            toolst_about.Size = new Size(146, 34);
            toolst_about.Text = "关于";
            toolst_about.Click += toolst_about_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(24, 24);
            toolStrip1.Items.AddRange(new ToolStripItem[] { fresh, save, additem });
            toolStrip1.Location = new Point(0, 32);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1355, 33);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // fresh
            // 
            fresh.DisplayStyle = ToolStripItemDisplayStyle.Image;
            fresh.Image = Properties.Resources.f__1_;
            fresh.ImageTransparentColor = Color.Magenta;
            fresh.Name = "fresh";
            fresh.Size = new Size(34, 28);
            fresh.Text = "toolStripButton1";
            fresh.Click += fresh_Click;
            // 
            // save
            // 
            save.DisplayStyle = ToolStripItemDisplayStyle.Image;
            save.Image = Properties.Resources.f__3_;
            save.ImageTransparentColor = Color.Magenta;
            save.Name = "save";
            save.Size = new Size(34, 28);
            save.Text = "toolStripButton1";
            save.Click += save_Click;
            // 
            // additem
            // 
            additem.DisplayStyle = ToolStripItemDisplayStyle.Image;
            additem.Image = Properties.Resources.f__2_;
            additem.ImageTransparentColor = Color.Magenta;
            additem.Name = "additem";
            additem.Size = new Size(34, 28);
            additem.Text = "toolStripButton1";
            additem.Click += additem_Click;
            // 
            // codes
            // 
            codes.BackColor = Color.FromArgb(192, 255, 255);
            codes.Dock = DockStyle.Fill;
            codes.Font = new Font("微软雅黑", 11F, FontStyle.Regular, GraphicsUnit.Point, 134);
            codes.Location = new Point(0, 0);
            codes.Name = "codes";
            codes.Size = new Size(1031, 849);
            codes.TabIndex = 2;
            codes.Text = "欢迎使用TerraCreator\n点击上方按钮开始吧\n右侧是文件夹文件\n这个是代码编辑器\n\n\n\nBUG反馈:cmcello@outlook.com";
            codes.TextChanged += codes_TextChanged;
            // 
            // fileview
            // 
            fileview.BackColor = Color.FromArgb(192, 255, 255);
            fileview.Dock = DockStyle.Fill;
            fileview.Location = new Point(0, 0);
            fileview.Name = "fileview";
            fileview.Size = new Size(320, 849);
            fileview.TabIndex = 3;
            fileview.AfterSelect += fileview_AfterSelect;
            // 
            // split
            // 
            split.Dock = DockStyle.Fill;
            split.FixedPanel = FixedPanel.Panel1;
            split.IsSplitterFixed = true;
            split.Location = new Point(0, 65);
            split.Name = "split";
            // 
            // split.Panel1
            // 
            split.Panel1.Controls.Add(fileview);
            // 
            // split.Panel2
            // 
            split.Panel2.Controls.Add(codes);
            split.Size = new Size(1355, 849);
            split.SplitterDistance = 320;
            split.TabIndex = 4;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 255, 255);
            ClientSize = new Size(1355, 914);
            Controls.Add(split);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Main";
            Text = "TerraCreator";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            split.Panel1.ResumeLayout(false);
            split.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)split).EndInit();
            split.ResumeLayout(false);
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
        public static TreeView fileview;
        public static RichTextBox codes;
    }
}
