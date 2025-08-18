namespace TerraCreator
{
    partial class about
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(about));
            name = new Label();
            label2 = new Label();
            notice = new Label();
            ok = new Button();
            icon = new PictureBox();
            Milestone = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)icon).BeginInit();
            SuspendLayout();
            // 
            // name
            // 
            resources.ApplyResources(name, "name");
            name.Name = "name";
            name.MouseEnter += name_MouseEnter;
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // notice
            // 
            resources.ApplyResources(notice, "notice");
            notice.Name = "notice";
            // 
            // ok
            // 
            resources.ApplyResources(ok, "ok");
            ok.Name = "ok";
            ok.UseVisualStyleBackColor = true;
            ok.Click += ok_Click;
            // 
            // icon
            // 
            resources.ApplyResources(icon, "icon");
            icon.Image = Properties.Resources.icon;
            icon.Name = "icon";
            icon.TabStop = false;
            icon.Click += icon_Click;
            // 
            // Milestone
            // 
            resources.ApplyResources(Milestone, "Milestone");
            Milestone.BackColor = Color.Transparent;
            Milestone.Name = "Milestone";
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.Name = "label4";
            // 
            // about
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 255, 255);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(Milestone);
            Controls.Add(icon);
            Controls.Add(ok);
            Controls.Add(notice);
            Controls.Add(label2);
            Controls.Add(name);
            Name = "about";
            Load += about_Load;
            ((System.ComponentModel.ISupportInitialize)icon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label name;
        private Label label2;
        private Label notice;
        private Button ok;
        private PictureBox icon;
        private Label Milestone;
        private Label label3;
        private Label label4;
    }
}