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
            milestone = new Label();
            ((System.ComponentModel.ISupportInitialize)icon).BeginInit();
            SuspendLayout();
            // 
            // name
            // 
            name.Anchor = AnchorStyles.Top;
            name.AutoSize = true;
            name.Font = new Font("Yu Gothic UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            name.Location = new Point(26, 6);
            name.Margin = new Padding(2, 0, 2, 0);
            name.Name = "name";
            name.Size = new Size(299, 65);
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
            label2.Text = "v2025.6.3\r\n(c)CEllOMiKA\r\n邮箱:cmcello@outlook.com";
            // 
            // notice
            // 
            notice.AutoSize = true;
            notice.Location = new Point(22, 149);
            notice.Margin = new Padding(2, 0, 2, 0);
            notice.Name = "notice";
            notice.Size = new Size(278, 119);
            notice.TabIndex = 8;
            notice.Text = "注意:\r\nTerraCreator处于开发阶段\r\n不能保证完全没有BUG\r\n同时,TerraCreator可能无法满足你的所有代码要求\r\n只能起到辅助编程的作用 \r\n感谢理解\r\n\r\n";
            // 
            // ok
            // 
            ok.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ok.Location = new Point(256, 244);
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
            icon.Location = new Point(269, 94);
            icon.Margin = new Padding(2);
            icon.Name = "icon";
            icon.Size = new Size(41, 45);
            icon.SizeMode = PictureBoxSizeMode.StretchImage;
            icon.TabIndex = 10;
            icon.TabStop = false;
            icon.Click += icon_Click;
            // 
            // milestone
            // 
            milestone.Anchor = AnchorStyles.Top;
            milestone.AutoSize = true;
            milestone.BackColor = Color.Transparent;
            milestone.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            milestone.Location = new Point(111, 66);
            milestone.Margin = new Padding(2, 0, 2, 0);
            milestone.Name = "milestone";
            milestone.Size = new Size(106, 23);
            milestone.TabIndex = 11;
            milestone.Text = "Milestone #1\r\n";
            // 
            // about
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 255, 255);
            ClientSize = new Size(334, 276);
            Controls.Add(milestone);
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
        private Label milestone;
    }
}