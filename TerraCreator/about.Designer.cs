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
            name.Anchor = AnchorStyles.Top;
            name.AutoSize = true;
            name.Font = new Font("Noto Sans JP", 42F, FontStyle.Regular, GraphicsUnit.Point, 0);
            name.Location = new Point(38, 5);
            name.Name = "name";
            name.Size = new Size(543, 121);
            name.TabIndex = 0;
            name.Text = "TerraCreator";
            name.MouseEnter += name_MouseEnter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 178);
            label2.Name = "label2";
            label2.Size = new Size(237, 96);
            label2.TabIndex = 1;
            label2.Text = "TerraCreator Origin 社区版\r\nv2025.8.1\r\n(c)CEllOMiKA\r\n(c)所有为此项目付出的你";
            // 
            // notice
            // 
            notice.AutoSize = true;
            notice.Location = new Point(35, 291);
            notice.Name = "notice";
            notice.Size = new Size(410, 168);
            notice.TabIndex = 8;
            notice.Text = "注意:\r\nTerraCreator处于开发阶段\r\n不能保证完全没有BUG\r\n同时,TerraCreator可能无法满足你的所有代码要求\r\n只能起到辅助编程的作用 \r\n感谢理解\r\n\r\n";
            // 
            // ok
            // 
            ok.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ok.Location = new Point(580, 539);
            ok.Name = "ok";
            ok.Size = new Size(112, 34);
            ok.TabIndex = 9;
            ok.Text = "OK";
            ok.UseVisualStyleBackColor = true;
            ok.Click += ok_Click;
            // 
            // icon
            // 
            icon.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            icon.Image = Properties.Resources.icon;
            icon.Location = new Point(561, 133);
            icon.Name = "icon";
            icon.Size = new Size(104, 102);
            icon.SizeMode = PictureBoxSizeMode.StretchImage;
            icon.TabIndex = 10;
            icon.TabStop = false;
            icon.Click += icon_Click;
            // 
            // Milestone
            // 
            Milestone.Anchor = AnchorStyles.Top;
            Milestone.AutoSize = true;
            Milestone.BackColor = Color.Transparent;
            Milestone.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Milestone.Location = new Point(514, 76);
            Milestone.Name = "Milestone";
            Milestone.Size = new Size(166, 33);
            Milestone.TabIndex = 11;
            Milestone.Text = "Milestone #2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 459);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(208, 24);
            label3.TabIndex = 13;
            label3.Text = "感谢你使用TerraCreator";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Myriad Pro Cond", 14.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(268, 109);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(177, 36);
            label4.TabIndex = 14;
            label4.Text = "Origin 社区版";
            // 
            // about
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 255, 255);
            ClientSize = new Size(702, 584);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(Milestone);
            Controls.Add(icon);
            Controls.Add(ok);
            Controls.Add(notice);
            Controls.Add(label2);
            Controls.Add(name);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "about";
            Text = "关于";
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