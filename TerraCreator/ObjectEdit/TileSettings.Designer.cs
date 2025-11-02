namespace TerraCreator.ObjectEdit
{
    partial class TileSettings
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
            TileImagePictureBox = new PictureBox();
            TileImagePathLabel = new Label();
            TileImageChooseButton = new Button();
            TileImageLabel = new Label();
            TileNamespaceTextBox = new TextBox();
            TileNamespaceLabel = new Label();
            TileNameTextBox = new TextBox();
            TileNameLabel = new Label();
            NewTileTitle = new Label();
            ((System.ComponentModel.ISupportInitialize)TileImagePictureBox).BeginInit();
            SuspendLayout();
            // 
            // TileImagePictureBox
            // 
            TileImagePictureBox.ImeMode = ImeMode.NoControl;
            TileImagePictureBox.Location = new Point(1101, 35);
            TileImagePictureBox.Margin = new Padding(5, 4, 5, 4);
            TileImagePictureBox.Name = "TileImagePictureBox";
            TileImagePictureBox.Size = new Size(126, 113);
            TileImagePictureBox.TabIndex = 18;
            TileImagePictureBox.TabStop = false;
            // 
            // TileImagePathLabel
            // 
            TileImagePathLabel.AutoSize = true;
            TileImagePathLabel.ImeMode = ImeMode.NoControl;
            TileImagePathLabel.Location = new Point(243, 124);
            TileImagePathLabel.Margin = new Padding(5, 0, 5, 0);
            TileImagePathLabel.Name = "TileImagePathLabel";
            TileImagePathLabel.Size = new Size(100, 24);
            TileImagePathLabel.TabIndex = 17;
            TileImagePathLabel.Text = "未选择图片";
            // 
            // TileImageChooseButton
            // 
            TileImageChooseButton.ImeMode = ImeMode.NoControl;
            TileImageChooseButton.Location = new Point(116, 120);
            TileImageChooseButton.Margin = new Padding(5, 4, 5, 4);
            TileImageChooseButton.Name = "TileImageChooseButton";
            TileImageChooseButton.Size = new Size(118, 32);
            TileImageChooseButton.TabIndex = 16;
            TileImageChooseButton.Text = "选择图片";
            TileImageChooseButton.UseVisualStyleBackColor = true;
            // 
            // TileImageLabel
            // 
            TileImageLabel.AutoSize = true;
            TileImageLabel.ImeMode = ImeMode.NoControl;
            TileImageLabel.Location = new Point(14, 124);
            TileImageLabel.Margin = new Padding(5, 0, 5, 0);
            TileImageLabel.Name = "TileImageLabel";
            TileImageLabel.Size = new Size(86, 24);
            TileImageLabel.TabIndex = 15;
            TileImageLabel.Text = "物块贴图:";
            // 
            // TileNamespaceTextBox
            // 
            TileNamespaceTextBox.Location = new Point(116, 84);
            TileNamespaceTextBox.Margin = new Padding(5, 4, 5, 4);
            TileNamespaceTextBox.Name = "TileNamespaceTextBox";
            TileNamespaceTextBox.Size = new Size(975, 30);
            TileNamespaceTextBox.TabIndex = 14;
            // 
            // TileNamespaceLabel
            // 
            TileNamespaceLabel.AutoSize = true;
            TileNamespaceLabel.ImeMode = ImeMode.NoControl;
            TileNamespaceLabel.Location = new Point(14, 88);
            TileNamespaceLabel.Margin = new Padding(5, 0, 5, 0);
            TileNamespaceLabel.Name = "TileNamespaceLabel";
            TileNamespaceLabel.Size = new Size(86, 24);
            TileNamespaceLabel.TabIndex = 13;
            TileNamespaceLabel.Text = "物块名称:";
            // 
            // TileNameTextBox
            // 
            TileNameTextBox.Location = new Point(116, 47);
            TileNameTextBox.Margin = new Padding(5, 4, 5, 4);
            TileNameTextBox.Name = "TileNameTextBox";
            TileNameTextBox.Size = new Size(975, 30);
            TileNameTextBox.TabIndex = 12;
            // 
            // TileNameLabel
            // 
            TileNameLabel.AutoSize = true;
            TileNameLabel.ImeMode = ImeMode.NoControl;
            TileNameLabel.Location = new Point(14, 51);
            TileNameLabel.Margin = new Padding(5, 0, 5, 0);
            TileNameLabel.Name = "TileNameLabel";
            TileNameLabel.Size = new Size(86, 24);
            TileNameLabel.TabIndex = 11;
            TileNameLabel.Text = "物块名称:";
            // 
            // NewTileTitle
            // 
            NewTileTitle.AutoSize = true;
            NewTileTitle.Font = new Font("Microsoft YaHei UI", 12F);
            NewTileTitle.ImeMode = ImeMode.NoControl;
            NewTileTitle.Location = new Point(14, 9);
            NewTileTitle.Margin = new Padding(5, 0, 5, 0);
            NewTileTitle.Name = "NewTileTitle";
            NewTileTitle.Size = new Size(62, 31);
            NewTileTitle.TabIndex = 10;
            NewTileTitle.Text = "物块";
            // 
            // TileSettings
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 255, 255);
            ClientSize = new Size(1302, 895);
            Controls.Add(TileImagePictureBox);
            Controls.Add(TileImagePathLabel);
            Controls.Add(TileImageChooseButton);
            Controls.Add(TileImageLabel);
            Controls.Add(TileNamespaceTextBox);
            Controls.Add(TileNamespaceLabel);
            Controls.Add(TileNameTextBox);
            Controls.Add(TileNameLabel);
            Controls.Add(NewTileTitle);
            Name = "TileSettings";
            Text = "物块设置";
            ((System.ComponentModel.ISupportInitialize)TileImagePictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox TileImagePictureBox;
        private Label TileImagePathLabel;
        private Button TileImageChooseButton;
        private Label TileImageLabel;
        private TextBox TileNamespaceTextBox;
        private Label TileNamespaceLabel;
        private TextBox TileNameTextBox;
        private Label TileNameLabel;
        private Label NewTileTitle;
    }
}