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
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)icon).BeginInit();
            SuspendLayout();
            // 
            // name
            // 
            name.Anchor = AnchorStyles.Top;
            name.AutoSize = true;
            name.Font = new Font("OCR A Extended", 42F, FontStyle.Regular, GraphicsUnit.Point, 0);
            name.Location = new Point(12, 9);
            name.Margin = new Padding(2, 0, 2, 0);
            name.Name = "name";
            name.Size = new Size(433, 58);
            name.TabIndex = 0;
            name.Text = "TerraCreator";
            name.MouseEnter += name_MouseEnter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 89);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(164, 51);
            label2.TabIndex = 1;
            label2.Text = "v2025.8\r\n(c)CEllOMiKA\r\n邮箱:cmcello@outlook.com";
            // 
            // notice
            // 
            notice.AutoSize = true;
            notice.Location = new Point(22, 154);
            notice.Margin = new Padding(2, 0, 2, 0);
            notice.Name = "notice";
            notice.Size = new Size(278, 119);
            notice.TabIndex = 8;
            notice.Text = "注意:\r\nTerraCreator处于开发阶段\r\n不能保证完全没有BUG\r\n同时,TerraCreator可能无法满足你的所有代码要求\r\n只能起到辅助编程的作用 \r\n感谢理解\r\n\r\n";
            // 
            // ok
            // 
            ok.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ok.Location = new Point(435, 382);
            ok.Margin = new Padding(2);
            ok.Name = "ok";
            ok.Size = new Size(71, 24);
            ok.TabIndex = 9;
            ok.Text = "OK";
            ok.UseVisualStyleBackColor = true;
            ok.Click += ok_Click;
            // 
            // icon
            // 
            icon.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            icon.Image = Properties.Resources.icon;
            icon.Location = new Point(444, 94);
            icon.Margin = new Padding(2);
            icon.Name = "icon";
            icon.Size = new Size(45, 46);
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
            Milestone.Location = new Point(200, 66);
            Milestone.Margin = new Padding(2, 0, 2, 0);
            Milestone.Name = "Milestone";
            Milestone.Size = new Size(109, 23);
            Milestone.TabIndex = 11;
            Milestone.Text = "Milestone #2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 273);
            label1.Name = "label1";
            label1.Size = new Size(301, 68);
            label1.TabIndex = 12;
            label1.Text = "GitHub项目地址:\r\nhttps://github.com/CEllOMiKA/TerraCreator-Public\r\n后续作者会开放TerraCreator-Community仓库\r\n期待社区的提交!";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 357);
            label3.Name = "label3";
            label3.Size = new Size(143, 17);
            label3.TabIndex = 13;
            label3.Text = "感谢你使用TerraCreator";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("OCR A Extended", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(414, 38);
            label4.Name = "label4";
            label4.Size = new Size(75, 23);
            label4.TabIndex = 14;
            label4.Text = "inDev";
            // 
            // about
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 255, 255);
            ClientSize = new Size(513, 414);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(Milestone);
            Controls.Add(icon);
            Controls.Add(ok);
            Controls.Add(notice);
            Controls.Add(label2);
            Controls.Add(name);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
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
        private Label label1;
        private Label label3;
        private Label label4;
    }
}