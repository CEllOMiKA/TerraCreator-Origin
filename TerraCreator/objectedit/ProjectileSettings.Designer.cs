namespace TerraCreator
{
    partial class ProjectileSettingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectileSettingForm));
            ProjectileAIStyleNumericUpDown = new NumericUpDown();
            ProjectileAIStyleLabel = new Label();
            ProjectileDamageNumericUpDown = new NumericUpDown();
            ProjectileDamageLabel = new Label();
            ProjectileSetDefaultsCodesRichTextBox = new RichTextBox();
            ProjectileSetDefaultsCodesLabel = new Label();
            ProjectileHostileComboBox = new ComboBox();
            ProjectileHostileLabel = new Label();
            ProjectileFriendlyComboBox = new ComboBox();
            ProjectileFriendlyLabel = new Label();
            ProjectilePenetrateNumericUpDown = new NumericUpDown();
            ProjectilePenetrateLabel = new Label();
            ProjectileTimeLeftNumericUpDown = new NumericUpDown();
            ProjectileTimeLeftLabel = new Label();
            ProjectileAlphaNumericUpDown = new NumericUpDown();
            ProjectileAlphaLabel = new Label();
            ProjectileScaleTextBox = new TextBox();
            ProjectileScaleLabel = new Label();
            ProjectileWidthNumericUpDown = new NumericUpDown();
            ProjectileWidthLabel = new Label();
            ProjectileHeightNumericUpDown = new NumericUpDown();
            ProjectileHeightLabel = new Label();
            NewProjectileTitle = new Label();
            ProjectileNameLabel = new Label();
            ProjectileNameTextBox = new TextBox();
            ProjectileNamespaceLabel = new Label();
            ProjectileNamespaceTextBox = new TextBox();
            ProjectileImageLabel = new Label();
            ProjectileImageChooseButton = new Button();
            ProjectileImagePathLabel = new Label();
            ProjectileImagePictureBox = new PictureBox();
            CodeViewRichTextBox = new RichTextBox();
            PreviewCode = new Button();
            OriginalCode = new Button();
            SaveButton = new Button();
            OriginCodeFilePathLabel = new Label();
            OriginCodeFilePath = new Label();
            ProjectileTabControl = new TabControl();
            SetDefaultsTabPage = new TabPage();
            AITabPage = new TabPage();
            OtherTabPage = new TabPage();
            HeadTabPage = new TabPage();
            ((System.ComponentModel.ISupportInitialize)ProjectileAIStyleNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ProjectileDamageNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ProjectilePenetrateNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ProjectileTimeLeftNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ProjectileAlphaNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ProjectileWidthNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ProjectileHeightNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ProjectileImagePictureBox).BeginInit();
            ProjectileTabControl.SuspendLayout();
            SetDefaultsTabPage.SuspendLayout();
            SuspendLayout();
            // 
            // ProjectileAIStyleNumericUpDown
            // 
            ProjectileAIStyleNumericUpDown.Location = new Point(695, 151);
            ProjectileAIStyleNumericUpDown.Margin = new Padding(5, 4, 5, 4);
            ProjectileAIStyleNumericUpDown.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            ProjectileAIStyleNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, int.MinValue });
            ProjectileAIStyleNumericUpDown.Name = "ProjectileAIStyleNumericUpDown";
            ProjectileAIStyleNumericUpDown.Size = new Size(471, 30);
            ProjectileAIStyleNumericUpDown.TabIndex = 21;
            ProjectileAIStyleNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, int.MinValue });
            // 
            // ProjectileAIStyleLabel
            // 
            ProjectileAIStyleLabel.AutoSize = true;
            ProjectileAIStyleLabel.Location = new Point(592, 154);
            ProjectileAIStyleLabel.Margin = new Padding(5, 0, 5, 0);
            ProjectileAIStyleLabel.Name = "ProjectileAIStyleLabel";
            ProjectileAIStyleLabel.Size = new Size(68, 24);
            ProjectileAIStyleLabel.TabIndex = 20;
            ProjectileAIStyleLabel.Text = "射弹AI:";
            // 
            // ProjectileDamageNumericUpDown
            // 
            ProjectileDamageNumericUpDown.Location = new Point(112, 151);
            ProjectileDamageNumericUpDown.Margin = new Padding(5, 4, 5, 4);
            ProjectileDamageNumericUpDown.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            ProjectileDamageNumericUpDown.Name = "ProjectileDamageNumericUpDown";
            ProjectileDamageNumericUpDown.Size = new Size(471, 30);
            ProjectileDamageNumericUpDown.TabIndex = 19;
            ProjectileDamageNumericUpDown.Value = new decimal(new int[] { 32, 0, 0, 0 });
            // 
            // ProjectileDamageLabel
            // 
            ProjectileDamageLabel.AutoSize = true;
            ProjectileDamageLabel.Location = new Point(9, 154);
            ProjectileDamageLabel.Margin = new Padding(5, 0, 5, 0);
            ProjectileDamageLabel.Name = "ProjectileDamageLabel";
            ProjectileDamageLabel.Size = new Size(86, 24);
            ProjectileDamageLabel.TabIndex = 18;
            ProjectileDamageLabel.Text = "射弹伤害:";
            // 
            // ProjectileSetDefaultsCodesRichTextBox
            // 
            ProjectileSetDefaultsCodesRichTextBox.AcceptsTab = true;
            ProjectileSetDefaultsCodesRichTextBox.Location = new Point(9, 265);
            ProjectileSetDefaultsCodesRichTextBox.Margin = new Padding(5, 4, 5, 4);
            ProjectileSetDefaultsCodesRichTextBox.Name = "ProjectileSetDefaultsCodesRichTextBox";
            ProjectileSetDefaultsCodesRichTextBox.Size = new Size(1154, 440);
            ProjectileSetDefaultsCodesRichTextBox.TabIndex = 17;
            ProjectileSetDefaultsCodesRichTextBox.Text = "//可能会出错请注意";
            ProjectileSetDefaultsCodesRichTextBox.TextChanged += ProjectileSetDefaultsCodesRichTextBox_TextChanged;
            // 
            // ProjectileSetDefaultsCodesLabel
            // 
            ProjectileSetDefaultsCodesLabel.AutoSize = true;
            ProjectileSetDefaultsCodesLabel.Location = new Point(9, 237);
            ProjectileSetDefaultsCodesLabel.Margin = new Padding(5, 0, 5, 0);
            ProjectileSetDefaultsCodesLabel.Name = "ProjectileSetDefaultsCodesLabel";
            ProjectileSetDefaultsCodesLabel.Size = new Size(104, 24);
            ProjectileSetDefaultsCodesLabel.TabIndex = 16;
            ProjectileSetDefaultsCodesLabel.Text = "自定义代码:";
            // 
            // ProjectileHostileComboBox
            // 
            ProjectileHostileComboBox.FormattingEnabled = true;
            ProjectileHostileComboBox.Items.AddRange(new object[] { "true", "false" });
            ProjectileHostileComboBox.Location = new Point(847, 112);
            ProjectileHostileComboBox.Margin = new Padding(5, 4, 5, 4);
            ProjectileHostileComboBox.Name = "ProjectileHostileComboBox";
            ProjectileHostileComboBox.Size = new Size(317, 32);
            ProjectileHostileComboBox.TabIndex = 15;
            ProjectileHostileComboBox.Text = "true";
            // 
            // ProjectileHostileLabel
            // 
            ProjectileHostileLabel.AutoSize = true;
            ProjectileHostileLabel.Location = new Point(592, 116);
            ProjectileHostileLabel.Margin = new Padding(5, 0, 5, 0);
            ProjectileHostileLabel.Name = "ProjectileHostileLabel";
            ProjectileHostileLabel.Size = new Size(232, 24);
            ProjectileHostileLabel.TabIndex = 14;
            ProjectileHostileLabel.Text = "射弹是否可攻击友方和NPC:";
            // 
            // ProjectileFriendlyComboBox
            // 
            ProjectileFriendlyComboBox.FormattingEnabled = true;
            ProjectileFriendlyComboBox.Items.AddRange(new object[] { "true", "false" });
            ProjectileFriendlyComboBox.Location = new Point(206, 112);
            ProjectileFriendlyComboBox.Margin = new Padding(5, 4, 5, 4);
            ProjectileFriendlyComboBox.Name = "ProjectileFriendlyComboBox";
            ProjectileFriendlyComboBox.Size = new Size(375, 32);
            ProjectileFriendlyComboBox.TabIndex = 13;
            ProjectileFriendlyComboBox.Text = "true";
            // 
            // ProjectileFriendlyLabel
            // 
            ProjectileFriendlyLabel.AutoSize = true;
            ProjectileFriendlyLabel.Location = new Point(9, 116);
            ProjectileFriendlyLabel.Margin = new Padding(5, 0, 5, 0);
            ProjectileFriendlyLabel.Name = "ProjectileFriendlyLabel";
            ProjectileFriendlyLabel.Size = new Size(176, 24);
            ProjectileFriendlyLabel.TabIndex = 12;
            ProjectileFriendlyLabel.Text = "射弹是否可攻击敌方:";
            // 
            // ProjectilePenetrateNumericUpDown
            // 
            ProjectilePenetrateNumericUpDown.Location = new Point(732, 75);
            ProjectilePenetrateNumericUpDown.Margin = new Padding(5, 4, 5, 4);
            ProjectilePenetrateNumericUpDown.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            ProjectilePenetrateNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, int.MinValue });
            ProjectilePenetrateNumericUpDown.Name = "ProjectilePenetrateNumericUpDown";
            ProjectilePenetrateNumericUpDown.Size = new Size(434, 30);
            ProjectilePenetrateNumericUpDown.TabIndex = 11;
            // 
            // ProjectilePenetrateLabel
            // 
            ProjectilePenetrateLabel.AutoSize = true;
            ProjectilePenetrateLabel.Location = new Point(592, 78);
            ProjectilePenetrateLabel.Margin = new Padding(5, 0, 5, 0);
            ProjectilePenetrateLabel.Name = "ProjectilePenetrateLabel";
            ProjectilePenetrateLabel.Size = new Size(122, 24);
            ProjectilePenetrateLabel.TabIndex = 10;
            ProjectilePenetrateLabel.Text = "射弹穿透次数:";
            // 
            // ProjectileTimeLeftNumericUpDown
            // 
            ProjectileTimeLeftNumericUpDown.Location = new Point(149, 75);
            ProjectileTimeLeftNumericUpDown.Margin = new Padding(5, 4, 5, 4);
            ProjectileTimeLeftNumericUpDown.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            ProjectileTimeLeftNumericUpDown.Name = "ProjectileTimeLeftNumericUpDown";
            ProjectileTimeLeftNumericUpDown.Size = new Size(434, 30);
            ProjectileTimeLeftNumericUpDown.TabIndex = 9;
            ProjectileTimeLeftNumericUpDown.Value = new decimal(new int[] { 180, 0, 0, 0 });
            // 
            // ProjectileTimeLeftLabel
            // 
            ProjectileTimeLeftLabel.AutoSize = true;
            ProjectileTimeLeftLabel.Location = new Point(9, 78);
            ProjectileTimeLeftLabel.Margin = new Padding(5, 0, 5, 0);
            ProjectileTimeLeftLabel.Name = "ProjectileTimeLeftLabel";
            ProjectileTimeLeftLabel.Size = new Size(122, 24);
            ProjectileTimeLeftLabel.TabIndex = 8;
            ProjectileTimeLeftLabel.Text = "射弹存在时间:";
            // 
            // ProjectileAlphaNumericUpDown
            // 
            ProjectileAlphaNumericUpDown.Location = new Point(713, 38);
            ProjectileAlphaNumericUpDown.Margin = new Padding(5, 4, 5, 4);
            ProjectileAlphaNumericUpDown.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            ProjectileAlphaNumericUpDown.Name = "ProjectileAlphaNumericUpDown";
            ProjectileAlphaNumericUpDown.Size = new Size(453, 30);
            ProjectileAlphaNumericUpDown.TabIndex = 7;
            // 
            // ProjectileAlphaLabel
            // 
            ProjectileAlphaLabel.AutoSize = true;
            ProjectileAlphaLabel.Location = new Point(592, 42);
            ProjectileAlphaLabel.Margin = new Padding(5, 0, 5, 0);
            ProjectileAlphaLabel.Name = "ProjectileAlphaLabel";
            ProjectileAlphaLabel.Size = new Size(104, 24);
            ProjectileAlphaLabel.TabIndex = 6;
            ProjectileAlphaLabel.Text = "射弹透明度:";
            // 
            // ProjectileScaleTextBox
            // 
            ProjectileScaleTextBox.Location = new Point(149, 38);
            ProjectileScaleTextBox.Margin = new Padding(5, 4, 5, 4);
            ProjectileScaleTextBox.Name = "ProjectileScaleTextBox";
            ProjectileScaleTextBox.Size = new Size(431, 30);
            ProjectileScaleTextBox.TabIndex = 5;
            ProjectileScaleTextBox.Text = "1f";
            // 
            // ProjectileScaleLabel
            // 
            ProjectileScaleLabel.AutoSize = true;
            ProjectileScaleLabel.Location = new Point(9, 42);
            ProjectileScaleLabel.Margin = new Padding(5, 0, 5, 0);
            ProjectileScaleLabel.Name = "ProjectileScaleLabel";
            ProjectileScaleLabel.Size = new Size(122, 24);
            ProjectileScaleLabel.TabIndex = 4;
            ProjectileScaleLabel.Text = "射弹缩放倍率:";
            // 
            // ProjectileWidthNumericUpDown
            // 
            ProjectileWidthNumericUpDown.Location = new Point(695, 1);
            ProjectileWidthNumericUpDown.Margin = new Padding(5, 4, 5, 4);
            ProjectileWidthNumericUpDown.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            ProjectileWidthNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            ProjectileWidthNumericUpDown.Name = "ProjectileWidthNumericUpDown";
            ProjectileWidthNumericUpDown.Size = new Size(471, 30);
            ProjectileWidthNumericUpDown.TabIndex = 3;
            ProjectileWidthNumericUpDown.Value = new decimal(new int[] { 32, 0, 0, 0 });
            // 
            // ProjectileWidthLabel
            // 
            ProjectileWidthLabel.AutoSize = true;
            ProjectileWidthLabel.Location = new Point(592, 4);
            ProjectileWidthLabel.Margin = new Padding(5, 0, 5, 0);
            ProjectileWidthLabel.Name = "ProjectileWidthLabel";
            ProjectileWidthLabel.Size = new Size(86, 24);
            ProjectileWidthLabel.TabIndex = 2;
            ProjectileWidthLabel.Text = "射弹宽度:";
            // 
            // ProjectileHeightNumericUpDown
            // 
            ProjectileHeightNumericUpDown.Location = new Point(112, 1);
            ProjectileHeightNumericUpDown.Margin = new Padding(5, 4, 5, 4);
            ProjectileHeightNumericUpDown.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            ProjectileHeightNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            ProjectileHeightNumericUpDown.Name = "ProjectileHeightNumericUpDown";
            ProjectileHeightNumericUpDown.Size = new Size(471, 30);
            ProjectileHeightNumericUpDown.TabIndex = 1;
            ProjectileHeightNumericUpDown.Value = new decimal(new int[] { 32, 0, 0, 0 });
            // 
            // ProjectileHeightLabel
            // 
            ProjectileHeightLabel.AutoSize = true;
            ProjectileHeightLabel.Location = new Point(9, 4);
            ProjectileHeightLabel.Margin = new Padding(5, 0, 5, 0);
            ProjectileHeightLabel.Name = "ProjectileHeightLabel";
            ProjectileHeightLabel.Size = new Size(86, 24);
            ProjectileHeightLabel.TabIndex = 0;
            ProjectileHeightLabel.Text = "射弹高度:";
            // 
            // NewProjectileTitle
            // 
            NewProjectileTitle.AutoSize = true;
            NewProjectileTitle.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            NewProjectileTitle.Location = new Point(19, 13);
            NewProjectileTitle.Margin = new Padding(5, 0, 5, 0);
            NewProjectileTitle.Name = "NewProjectileTitle";
            NewProjectileTitle.Size = new Size(62, 31);
            NewProjectileTitle.TabIndex = 1;
            NewProjectileTitle.Text = "射弹";
            // 
            // ProjectileNameLabel
            // 
            ProjectileNameLabel.AutoSize = true;
            ProjectileNameLabel.Location = new Point(19, 55);
            ProjectileNameLabel.Margin = new Padding(5, 0, 5, 0);
            ProjectileNameLabel.Name = "ProjectileNameLabel";
            ProjectileNameLabel.Size = new Size(86, 24);
            ProjectileNameLabel.TabIndex = 2;
            ProjectileNameLabel.Text = "射弹名称:";
            // 
            // ProjectileNameTextBox
            // 
            ProjectileNameTextBox.Location = new Point(121, 51);
            ProjectileNameTextBox.Margin = new Padding(5, 4, 5, 4);
            ProjectileNameTextBox.Name = "ProjectileNameTextBox";
            ProjectileNameTextBox.Size = new Size(975, 30);
            ProjectileNameTextBox.TabIndex = 3;
            // 
            // ProjectileNamespaceLabel
            // 
            ProjectileNamespaceLabel.AutoSize = true;
            ProjectileNamespaceLabel.Location = new Point(19, 92);
            ProjectileNamespaceLabel.Margin = new Padding(5, 0, 5, 0);
            ProjectileNamespaceLabel.Name = "ProjectileNamespaceLabel";
            ProjectileNamespaceLabel.Size = new Size(86, 24);
            ProjectileNamespaceLabel.TabIndex = 4;
            ProjectileNamespaceLabel.Text = "射弹名称:";
            // 
            // ProjectileNamespaceTextBox
            // 
            ProjectileNamespaceTextBox.Location = new Point(121, 88);
            ProjectileNamespaceTextBox.Margin = new Padding(5, 4, 5, 4);
            ProjectileNamespaceTextBox.Name = "ProjectileNamespaceTextBox";
            ProjectileNamespaceTextBox.Size = new Size(975, 30);
            ProjectileNamespaceTextBox.TabIndex = 5;
            // 
            // ProjectileImageLabel
            // 
            ProjectileImageLabel.AutoSize = true;
            ProjectileImageLabel.Location = new Point(19, 128);
            ProjectileImageLabel.Margin = new Padding(5, 0, 5, 0);
            ProjectileImageLabel.Name = "ProjectileImageLabel";
            ProjectileImageLabel.Size = new Size(86, 24);
            ProjectileImageLabel.TabIndex = 6;
            ProjectileImageLabel.Text = "射弹贴图:";
            // 
            // ProjectileImageChooseButton
            // 
            ProjectileImageChooseButton.Location = new Point(121, 124);
            ProjectileImageChooseButton.Margin = new Padding(5, 4, 5, 4);
            ProjectileImageChooseButton.Name = "ProjectileImageChooseButton";
            ProjectileImageChooseButton.Size = new Size(118, 32);
            ProjectileImageChooseButton.TabIndex = 7;
            ProjectileImageChooseButton.Text = "选择图片";
            ProjectileImageChooseButton.UseVisualStyleBackColor = true;
            // 
            // ProjectileImagePathLabel
            // 
            ProjectileImagePathLabel.AutoSize = true;
            ProjectileImagePathLabel.Location = new Point(248, 128);
            ProjectileImagePathLabel.Margin = new Padding(5, 0, 5, 0);
            ProjectileImagePathLabel.Name = "ProjectileImagePathLabel";
            ProjectileImagePathLabel.Size = new Size(100, 24);
            ProjectileImagePathLabel.TabIndex = 8;
            ProjectileImagePathLabel.Text = "未选择图片";
            // 
            // ProjectileImagePictureBox
            // 
            ProjectileImagePictureBox.Location = new Point(1108, 51);
            ProjectileImagePictureBox.Margin = new Padding(5, 4, 5, 4);
            ProjectileImagePictureBox.Name = "ProjectileImagePictureBox";
            ProjectileImagePictureBox.Size = new Size(126, 113);
            ProjectileImagePictureBox.TabIndex = 9;
            ProjectileImagePictureBox.TabStop = false;
            // 
            // CodeViewRichTextBox
            // 
            CodeViewRichTextBox.AcceptsTab = true;
            CodeViewRichTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CodeViewRichTextBox.Location = new Point(1243, 79);
            CodeViewRichTextBox.Margin = new Padding(5, 4, 5, 4);
            CodeViewRichTextBox.Name = "CodeViewRichTextBox";
            CodeViewRichTextBox.Size = new Size(686, 788);
            CodeViewRichTextBox.TabIndex = 12;
            CodeViewRichTextBox.TabStop = false;
            CodeViewRichTextBox.Text = "";
            // 
            // PreviewCode
            // 
            PreviewCode.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            PreviewCode.Location = new Point(1383, 881);
            PreviewCode.Margin = new Padding(5, 4, 5, 4);
            PreviewCode.Name = "PreviewCode";
            PreviewCode.Size = new Size(118, 32);
            PreviewCode.TabIndex = 13;
            PreviewCode.Text = "预览代码";
            PreviewCode.UseVisualStyleBackColor = true;
            PreviewCode.Click += PreviewCode_Click;
            // 
            // OriginalCode
            // 
            OriginalCode.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            OriginalCode.Location = new Point(1243, 881);
            OriginalCode.Margin = new Padding(5, 4, 5, 4);
            OriginalCode.Name = "OriginalCode";
            OriginalCode.Size = new Size(130, 32);
            OriginalCode.TabIndex = 14;
            OriginalCode.Text = "源文件代码";
            OriginalCode.UseVisualStyleBackColor = true;
            OriginalCode.Click += OriginalCode_Click;
            // 
            // SaveButton
            // 
            SaveButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            SaveButton.Location = new Point(1637, 881);
            SaveButton.Margin = new Padding(5, 4, 5, 4);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(294, 34);
            SaveButton.TabIndex = 15;
            SaveButton.Text = "保存当前显示的代码并保存图片";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // OriginCodeFilePathLabel
            // 
            OriginCodeFilePathLabel.AutoSize = true;
            OriginCodeFilePathLabel.Location = new Point(1243, 51);
            OriginCodeFilePathLabel.Margin = new Padding(5, 0, 5, 0);
            OriginCodeFilePathLabel.Name = "OriginCodeFilePathLabel";
            OriginCodeFilePathLabel.Size = new Size(122, 24);
            OriginCodeFilePathLabel.TabIndex = 16;
            OriginCodeFilePathLabel.Text = "射弹代码位置:";
            // 
            // OriginCodeFilePath
            // 
            OriginCodeFilePath.AutoSize = true;
            OriginCodeFilePath.Location = new Point(1383, 51);
            OriginCodeFilePath.Margin = new Padding(5, 0, 5, 0);
            OriginCodeFilePath.Name = "OriginCodeFilePath";
            OriginCodeFilePath.Size = new Size(64, 24);
            OriginCodeFilePath.TabIndex = 17;
            OriginCodeFilePath.Text = "无位置";
            // 
            // ProjectileTabControl
            // 
            ProjectileTabControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            ProjectileTabControl.Controls.Add(SetDefaultsTabPage);
            ProjectileTabControl.Controls.Add(AITabPage);
            ProjectileTabControl.Controls.Add(OtherTabPage);
            ProjectileTabControl.Controls.Add(HeadTabPage);
            ProjectileTabControl.Location = new Point(19, 165);
            ProjectileTabControl.Margin = new Padding(5, 4, 5, 4);
            ProjectileTabControl.Name = "ProjectileTabControl";
            ProjectileTabControl.SelectedIndex = 0;
            ProjectileTabControl.Size = new Size(1215, 750);
            ProjectileTabControl.TabIndex = 18;
            // 
            // SetDefaultsTabPage
            // 
            SetDefaultsTabPage.BackColor = Color.FromArgb(192, 255, 255);
            SetDefaultsTabPage.Controls.Add(ProjectileHeightLabel);
            SetDefaultsTabPage.Controls.Add(ProjectileAIStyleNumericUpDown);
            SetDefaultsTabPage.Controls.Add(ProjectileHeightNumericUpDown);
            SetDefaultsTabPage.Controls.Add(ProjectileAIStyleLabel);
            SetDefaultsTabPage.Controls.Add(ProjectileWidthLabel);
            SetDefaultsTabPage.Controls.Add(ProjectileDamageNumericUpDown);
            SetDefaultsTabPage.Controls.Add(ProjectileWidthNumericUpDown);
            SetDefaultsTabPage.Controls.Add(ProjectileDamageLabel);
            SetDefaultsTabPage.Controls.Add(ProjectileScaleLabel);
            SetDefaultsTabPage.Controls.Add(ProjectileSetDefaultsCodesRichTextBox);
            SetDefaultsTabPage.Controls.Add(ProjectileScaleTextBox);
            SetDefaultsTabPage.Controls.Add(ProjectileSetDefaultsCodesLabel);
            SetDefaultsTabPage.Controls.Add(ProjectileAlphaLabel);
            SetDefaultsTabPage.Controls.Add(ProjectileHostileComboBox);
            SetDefaultsTabPage.Controls.Add(ProjectileAlphaNumericUpDown);
            SetDefaultsTabPage.Controls.Add(ProjectileHostileLabel);
            SetDefaultsTabPage.Controls.Add(ProjectileTimeLeftLabel);
            SetDefaultsTabPage.Controls.Add(ProjectileFriendlyComboBox);
            SetDefaultsTabPage.Controls.Add(ProjectileTimeLeftNumericUpDown);
            SetDefaultsTabPage.Controls.Add(ProjectileFriendlyLabel);
            SetDefaultsTabPage.Controls.Add(ProjectilePenetrateLabel);
            SetDefaultsTabPage.Controls.Add(ProjectilePenetrateNumericUpDown);
            SetDefaultsTabPage.Location = new Point(4, 33);
            SetDefaultsTabPage.Margin = new Padding(5, 4, 5, 4);
            SetDefaultsTabPage.Name = "SetDefaultsTabPage";
            SetDefaultsTabPage.Padding = new Padding(5, 4, 5, 4);
            SetDefaultsTabPage.Size = new Size(1207, 713);
            SetDefaultsTabPage.TabIndex = 0;
            SetDefaultsTabPage.Text = "SetDefaults";
            // 
            // AITabPage
            // 
            AITabPage.BackColor = Color.FromArgb(192, 255, 255);
            AITabPage.Location = new Point(4, 33);
            AITabPage.Margin = new Padding(5, 4, 5, 4);
            AITabPage.Name = "AITabPage";
            AITabPage.Padding = new Padding(5, 4, 5, 4);
            AITabPage.Size = new Size(1207, 713);
            AITabPage.TabIndex = 1;
            AITabPage.Text = "AI";
            // 
            // OtherTabPage
            // 
            OtherTabPage.BackColor = Color.FromArgb(192, 255, 255);
            OtherTabPage.Location = new Point(4, 33);
            OtherTabPage.Name = "OtherTabPage";
            OtherTabPage.Size = new Size(1207, 713);
            OtherTabPage.TabIndex = 2;
            OtherTabPage.Text = "Other";
            // 
            // HeadTabPage
            // 
            HeadTabPage.BackColor = Color.FromArgb(192, 255, 255);
            HeadTabPage.Location = new Point(4, 33);
            HeadTabPage.Name = "HeadTabPage";
            HeadTabPage.Padding = new Padding(3);
            HeadTabPage.Size = new Size(1207, 713);
            HeadTabPage.TabIndex = 3;
            HeadTabPage.Text = "Head";
            // 
            // ProjectileSettingForm
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(128, 255, 255);
            ClientSize = new Size(1950, 929);
            Controls.Add(ProjectileTabControl);
            Controls.Add(OriginCodeFilePath);
            Controls.Add(OriginCodeFilePathLabel);
            Controls.Add(SaveButton);
            Controls.Add(OriginalCode);
            Controls.Add(PreviewCode);
            Controls.Add(CodeViewRichTextBox);
            Controls.Add(ProjectileImagePictureBox);
            Controls.Add(ProjectileImagePathLabel);
            Controls.Add(ProjectileImageChooseButton);
            Controls.Add(ProjectileImageLabel);
            Controls.Add(ProjectileNamespaceTextBox);
            Controls.Add(ProjectileNamespaceLabel);
            Controls.Add(ProjectileNameTextBox);
            Controls.Add(ProjectileNameLabel);
            Controls.Add(NewProjectileTitle);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 4, 5, 4);
            Name = "ProjectileSettingForm";
            Text = "射弹设置";
            Load += ProjectileSettingForm_Load;
            ((System.ComponentModel.ISupportInitialize)ProjectileAIStyleNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)ProjectileDamageNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)ProjectilePenetrateNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)ProjectileTimeLeftNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)ProjectileAlphaNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)ProjectileWidthNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)ProjectileHeightNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)ProjectileImagePictureBox).EndInit();
            ProjectileTabControl.ResumeLayout(false);
            SetDefaultsTabPage.ResumeLayout(false);
            SetDefaultsTabPage.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label NewProjectileTitle;
        private Label ProjectileNameLabel;
        private TextBox ProjectileNameTextBox;
        private Label ProjectileNamespaceLabel;
        private TextBox ProjectileNamespaceTextBox;
        private Label ProjectileImageLabel;
        private Button ProjectileImageChooseButton;
        private Label ProjectileImagePathLabel;
        private PictureBox ProjectileImagePictureBox;
        private NumericUpDown ProjectileWidthNumericUpDown;
        private Label ProjectileWidthLabel;
        private NumericUpDown ProjectileHeightNumericUpDown;
        private Label ProjectileHeightLabel;
        private NumericUpDown ProjectileAlphaNumericUpDown;
        private Label ProjectileAlphaLabel;
        private TextBox ProjectileScaleTextBox;
        private Label ProjectileScaleLabel;
        private Label ProjectileFriendlyLabel;
        private NumericUpDown ProjectilePenetrateNumericUpDown;
        private Label ProjectilePenetrateLabel;
        private NumericUpDown ProjectileTimeLeftNumericUpDown;
        private Label ProjectileTimeLeftLabel;
        private ComboBox ProjectileHostileComboBox;
        private Label ProjectileHostileLabel;
        private ComboBox ProjectileFriendlyComboBox;
        private RichTextBox ProjectileSetDefaultsCodesRichTextBox;
        private Label ProjectileSetDefaultsCodesLabel;
        private NumericUpDown ProjectileDamageNumericUpDown;
        private Label ProjectileDamageLabel;
        private NumericUpDown ProjectileAIStyleNumericUpDown;
        private Label ProjectileAIStyleLabel;
        private RichTextBox CodeViewRichTextBox;
        private Button PreviewCode;
        private Button OriginalCode;
        private Button SaveButton;
        private Label OriginCodeFilePathLabel;
        private Label OriginCodeFilePath;
        private TabControl ProjectileTabControl;
        private TabPage SetDefaultsTabPage;
        private TabPage AITabPage;
        private TabPage OtherTabPage;
        private TabPage HeadTabPage;
    }
}