namespace TerraCreator
{
    partial class NewProject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewProject));
            newprojlabel = new Label();
            tmlyouneed = new Label();
            clickto = new LinkLabel();
            openfoldertext = new Label();
            choosefolder = new Button();
            folderpositiontext = new Label();
            create = new Button();
            typenamespace = new Label();
            ProjectNameSpaceTextBox = new TextBox();
            SuspendLayout();
            // 
            // newprojlabel
            // 
            newprojlabel.AutoSize = true;
            newprojlabel.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            newprojlabel.Location = new Point(12, 9);
            newprojlabel.Name = "newprojlabel";
            newprojlabel.Size = new Size(110, 31);
            newprojlabel.TabIndex = 0;
            newprojlabel.Text = "导入项目";
            // 
            // tmlyouneed
            // 
            tmlyouneed.AutoSize = true;
            tmlyouneed.Location = new Point(12, 54);
            tmlyouneed.Name = "tmlyouneed";
            tmlyouneed.Size = new Size(279, 48);
            tmlyouneed.TabIndex = 1;
            tmlyouneed.Text = "你需要在tModLoader中创建项目\r\n什么?你不会?\r\n";
            // 
            // clickto
            // 
            clickto.AutoSize = true;
            clickto.Location = new Point(12, 102);
            clickto.Name = "clickto";
            clickto.Size = new Size(118, 24);
            clickto.TabIndex = 2;
            clickto.TabStop = true;
            clickto.Text = "点我查看教程";
            clickto.LinkClicked += clickto_LinkClicked;
            // 
            // openfoldertext
            // 
            openfoldertext.AutoSize = true;
            openfoldertext.Location = new Point(12, 126);
            openfoldertext.Name = "openfoldertext";
            openfoldertext.Size = new Size(172, 48);
            openfoldertext.TabIndex = 3;
            openfoldertext.Text = "你已经创建好了?\r\n选择代码所在文件夹";
            // 
            // choosefolder
            // 
            choosefolder.Location = new Point(12, 177);
            choosefolder.Name = "choosefolder";
            choosefolder.Size = new Size(110, 32);
            choosefolder.TabIndex = 4;
            choosefolder.Text = "选择";
            choosefolder.UseVisualStyleBackColor = true;
            choosefolder.Click += choosefolder_Click;
            // 
            // folderpositiontext
            // 
            folderpositiontext.AutoSize = true;
            folderpositiontext.Location = new Point(12, 212);
            folderpositiontext.Name = "folderpositiontext";
            folderpositiontext.Size = new Size(176, 24);
            folderpositiontext.TabIndex = 5;
            folderpositiontext.Text = "你选择的文件夹地址:";
            // 
            // create
            // 
            create.Location = new Point(12, 266);
            create.Name = "create";
            create.Size = new Size(110, 34);
            create.TabIndex = 8;
            create.Text = "导入并开始";
            create.UseVisualStyleBackColor = true;
            create.Click += create_Click;
            // 
            // typenamespace
            // 
            typenamespace.AutoSize = true;
            typenamespace.Location = new Point(12, 239);
            typenamespace.Name = "typenamespace";
            typenamespace.Size = new Size(158, 24);
            typenamespace.TabIndex = 9;
            typenamespace.Text = "输入模组内部名称:";
            // 
            // ProjectNameSpaceTextBox
            // 
            ProjectNameSpaceTextBox.Location = new Point(176, 236);
            ProjectNameSpaceTextBox.Name = "ProjectNameSpaceTextBox";
            ProjectNameSpaceTextBox.Size = new Size(346, 30);
            ProjectNameSpaceTextBox.TabIndex = 10;
            // 
            // NewProject
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 255, 255);
            ClientSize = new Size(553, 314);
            Controls.Add(ProjectNameSpaceTextBox);
            Controls.Add(typenamespace);
            Controls.Add(create);
            Controls.Add(folderpositiontext);
            Controls.Add(choosefolder);
            Controls.Add(openfoldertext);
            Controls.Add(clickto);
            Controls.Add(tmlyouneed);
            Controls.Add(newprojlabel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "NewProject";
            Text = "导入项目";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label newprojlabel;
        private Label tmlyouneed;
        private LinkLabel clickto;
        private Label openfoldertext;
        private Button choosefolder;
        private Label folderpositiontext;
        private Button create;
        private Label typenamespace;
        private TextBox ProjectNameSpaceTextBox;
    }
}