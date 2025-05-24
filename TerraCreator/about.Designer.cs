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
            label3 = new Label();
            notice = new Label();
            ok = new Button();
            icon = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)icon).BeginInit();
            SuspendLayout();
            // 
            // name
            // 
            name.AutoSize = true;
            name.Font = new Font("Microsoft YaHei UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 134);
            name.Location = new Point(12, 9);
            name.Name = "name";
            name.Size = new Size(502, 96);
            name.TabIndex = 0;
            name.Text = "TerraCreator";
            name.Click += name_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 125);
            label2.Name = "label2";
            label2.Size = new Size(242, 72);
            label2.TabIndex = 1;
            label2.Text = "v2025.5.1 build 22\r\n(c)CEllOMiKA\r\n邮箱:cmcello@outlook.com";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label3.Location = new Point(413, 86);
            label3.Name = "label3";
            label3.Size = new Size(85, 31);
            label3.TabIndex = 2;
            label3.Text = "Alpha";
            // 
            // notice
            // 
            notice.AutoSize = true;
            notice.Location = new Point(35, 212);
            notice.Name = "notice";
            notice.Size = new Size(410, 168);
            notice.TabIndex = 8;
            notice.Text = "注意:\r\nTerraCreator处于开发阶段\r\n不能保证完全没有BUG\r\n同时,TerraCreator可能无法满足你的所有代码要求\r\n只能起到辅助编程的作用 \r\n感谢理解\r\n\r\n";
            // 
            // ok
            // 
            ok.Location = new Point(402, 344);
            ok.Name = "ok";
            ok.Size = new Size(112, 34);
            ok.TabIndex = 9;
            ok.Text = "OK";
            ok.UseVisualStyleBackColor = true;
            ok.Click += ok_Click;
            // 
            // icon
            // 
            icon.Image = Properties.Resources.icon;
            icon.Location = new Point(423, 133);
            icon.Name = "icon";
            icon.Size = new Size(64, 64);
            icon.SizeMode = PictureBoxSizeMode.StretchImage;
            icon.TabIndex = 10;
            icon.TabStop = false;
            icon.Click += icon_Click;
            // 
            // about
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 255, 255);
            ClientSize = new Size(525, 390);
            Controls.Add(icon);
            Controls.Add(ok);
            Controls.Add(notice);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(name);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "about";
            Text = "关于";
            ((System.ComponentModel.ISupportInitialize)icon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label name;
        private Label label2;
        private Label label3;
        private Label notice;
        private Button ok;
        private PictureBox icon;
    }
}