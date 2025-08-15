namespace TerraCreator.objectedit
{
    partial class ItemSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemSettings));
            ItemTitle = new Label();
            ItemImagePictureBox = new PictureBox();
            ItemImagePathLabel = new Label();
            ItemImageChooseButton = new Button();
            ItemImageLabel = new Label();
            ItemNamespaceTextBox = new TextBox();
            ItemNamespaceLabel = new Label();
            ItemNameTextBox = new TextBox();
            ItemNameLabel = new Label();
            OriginCodeFilePath = new Label();
            OriginCodeFilePathLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)ItemImagePictureBox).BeginInit();
            SuspendLayout();
            // 
            // ItemTitle
            // 
            ItemTitle.AutoSize = true;
            ItemTitle.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            ItemTitle.Location = new Point(14, 9);
            ItemTitle.Margin = new Padding(5, 0, 5, 0);
            ItemTitle.Name = "ItemTitle";
            ItemTitle.Size = new Size(62, 31);
            ItemTitle.TabIndex = 2;
            ItemTitle.Text = "物品";
            // 
            // ItemImagePictureBox
            // 
            ItemImagePictureBox.Location = new Point(1106, 48);
            ItemImagePictureBox.Margin = new Padding(5, 4, 5, 4);
            ItemImagePictureBox.Name = "ItemImagePictureBox";
            ItemImagePictureBox.Size = new Size(126, 119);
            ItemImagePictureBox.TabIndex = 17;
            ItemImagePictureBox.TabStop = false;
            // 
            // ItemImagePathLabel
            // 
            ItemImagePathLabel.AutoSize = true;
            ItemImagePathLabel.Location = new Point(248, 125);
            ItemImagePathLabel.Margin = new Padding(5, 0, 5, 0);
            ItemImagePathLabel.Name = "ItemImagePathLabel";
            ItemImagePathLabel.Size = new Size(100, 24);
            ItemImagePathLabel.TabIndex = 16;
            ItemImagePathLabel.Text = "未选择图片";
            // 
            // ItemImageChooseButton
            // 
            ItemImageChooseButton.Location = new Point(121, 121);
            ItemImageChooseButton.Margin = new Padding(5, 4, 5, 4);
            ItemImageChooseButton.Name = "ItemImageChooseButton";
            ItemImageChooseButton.Size = new Size(118, 32);
            ItemImageChooseButton.TabIndex = 15;
            ItemImageChooseButton.Text = "选择图片";
            ItemImageChooseButton.UseVisualStyleBackColor = true;
            // 
            // ItemImageLabel
            // 
            ItemImageLabel.AutoSize = true;
            ItemImageLabel.Location = new Point(14, 125);
            ItemImageLabel.Margin = new Padding(5, 0, 5, 0);
            ItemImageLabel.Name = "ItemImageLabel";
            ItemImageLabel.Size = new Size(86, 24);
            ItemImageLabel.TabIndex = 14;
            ItemImageLabel.Text = "物品贴图:";
            // 
            // ItemNamespaceTextBox
            // 
            ItemNamespaceTextBox.Location = new Point(121, 85);
            ItemNamespaceTextBox.Margin = new Padding(5, 4, 5, 4);
            ItemNamespaceTextBox.Name = "ItemNamespaceTextBox";
            ItemNamespaceTextBox.Size = new Size(975, 30);
            ItemNamespaceTextBox.TabIndex = 13;
            // 
            // ItemNamespaceLabel
            // 
            ItemNamespaceLabel.AutoSize = true;
            ItemNamespaceLabel.Location = new Point(14, 88);
            ItemNamespaceLabel.Margin = new Padding(5, 0, 5, 0);
            ItemNamespaceLabel.Name = "ItemNamespaceLabel";
            ItemNamespaceLabel.Size = new Size(86, 24);
            ItemNamespaceLabel.TabIndex = 12;
            ItemNamespaceLabel.Text = "物品名称:";
            // 
            // ItemNameTextBox
            // 
            ItemNameTextBox.Location = new Point(121, 48);
            ItemNameTextBox.Margin = new Padding(5, 4, 5, 4);
            ItemNameTextBox.Name = "ItemNameTextBox";
            ItemNameTextBox.Size = new Size(975, 30);
            ItemNameTextBox.TabIndex = 11;
            // 
            // ItemNameLabel
            // 
            ItemNameLabel.AutoSize = true;
            ItemNameLabel.Location = new Point(14, 51);
            ItemNameLabel.Margin = new Padding(5, 0, 5, 0);
            ItemNameLabel.Name = "ItemNameLabel";
            ItemNameLabel.Size = new Size(86, 24);
            ItemNameLabel.TabIndex = 10;
            ItemNameLabel.Text = "物品名称:";
            // 
            // OriginCodeFilePath
            // 
            OriginCodeFilePath.AutoSize = true;
            OriginCodeFilePath.Location = new Point(1382, 48);
            OriginCodeFilePath.Margin = new Padding(5, 0, 5, 0);
            OriginCodeFilePath.Name = "OriginCodeFilePath";
            OriginCodeFilePath.Size = new Size(64, 24);
            OriginCodeFilePath.TabIndex = 19;
            OriginCodeFilePath.Text = "无位置";
            // 
            // OriginCodeFilePathLabel
            // 
            OriginCodeFilePathLabel.AutoSize = true;
            OriginCodeFilePathLabel.Location = new Point(1242, 48);
            OriginCodeFilePathLabel.Margin = new Padding(5, 0, 5, 0);
            OriginCodeFilePathLabel.Name = "OriginCodeFilePathLabel";
            OriginCodeFilePathLabel.Size = new Size(122, 24);
            OriginCodeFilePathLabel.TabIndex = 18;
            OriginCodeFilePathLabel.Text = "物品代码位置:";
            // 
            // ItemSettings
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 255, 255);
            ClientSize = new Size(1663, 923);
            Controls.Add(OriginCodeFilePath);
            Controls.Add(OriginCodeFilePathLabel);
            Controls.Add(ItemImagePictureBox);
            Controls.Add(ItemImagePathLabel);
            Controls.Add(ItemImageChooseButton);
            Controls.Add(ItemImageLabel);
            Controls.Add(ItemNamespaceTextBox);
            Controls.Add(ItemNamespaceLabel);
            Controls.Add(ItemNameTextBox);
            Controls.Add(ItemNameLabel);
            Controls.Add(ItemTitle);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ItemSettings";
            Text = "物品设置";
            ((System.ComponentModel.ISupportInitialize)ItemImagePictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ItemTitle;
        private PictureBox ItemImagePictureBox;
        private Label ItemImagePathLabel;
        private Button ItemImageChooseButton;
        private Label ItemImageLabel;
        private TextBox ItemNamespaceTextBox;
        private Label ItemNamespaceLabel;
        private TextBox ItemNameTextBox;
        private Label ItemNameLabel;
        private Label OriginCodeFilePath;
        private Label OriginCodeFilePathLabel;
    }
}