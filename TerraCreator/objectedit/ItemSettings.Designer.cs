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
            ItemSettingsTabControl = new TabControl();
            ItemSetDefaultsTabPage = new TabPage();
            label2 = new Label();
            SetDefaultsOtherCodes = new RichTextBox();
            ItemShootGroup = new GroupBox();
            ItemShootSpeedLabel = new Label();
            ItemShootSpeedNumericUpDown = new NumericUpDown();
            ItemShootIUOPCheckBox = new CheckBox();
            ItemShootUOPComboBox = new ComboBox();
            ItemShootLabel = new Label();
            ItemShootNumericUpDown = new NumericUpDown();
            ItemShootCheckBox = new CheckBox();
            ItemItemGroup = new GroupBox();
            ItemNoMeleeComboBox = new ComboBox();
            ItemHammerLabel = new Label();
            ItemHammerNumericUpDown = new NumericUpDown();
            ItemNoMeleeLabel = new Label();
            ItemPickLabel = new Label();
            ItemPickNumericUpDown = new NumericUpDown();
            ItemAxeNumericUpDown = new NumericUpDown();
            ItemAxeLabel = new Label();
            ItemDamageTypeComboBox = new ComboBox();
            ItemDamageTypeLabel = new Label();
            ItemCritLabel = new Label();
            ItemCritNumericUpDown = new NumericUpDown();
            ItemDamageLabel = new Label();
            ItemDamageNumericUpDown = new NumericUpDown();
            ItemKnockbackNumericUpDown = new NumericUpDown();
            ItemKnockbackLabel = new Label();
            ItemItemCheckBox = new CheckBox();
            ItemMovementGroup = new GroupBox();
            ItemNoUseGraphicComboBox = new ComboBox();
            ItemUseTurnComboBox = new ComboBox();
            ItemUseStyleComboBox = new ComboBox();
            ItemUseStyleLabel = new Label();
            ItemAutoReuseComboBox = new ComboBox();
            ItemNoUseGraphicLabel = new Label();
            ItemAutoReuseLabel = new Label();
            ItemUseTurnLabel = new Label();
            ItemUseAnimationNumericUpDown = new NumericUpDown();
            ItemUseAnimationLabel = new Label();
            ItemUseTimeNumericUpDown = new NumericUpDown();
            ItemMovementCheckBox = new CheckBox();
            ItemUseTimeLabel = new Label();
            ItemRareComboBox = new ComboBox();
            ItemSoundLabel = new Label();
            ItemSoundNumericUpDown = new NumericUpDown();
            ItemRareLabel = new Label();
            ItemValueLabel = new Label();
            ItemValueNumericUpDown = new NumericUpDown();
            ItemMaxStackLabel = new Label();
            ItemMaxStackNumericUpDown = new NumericUpDown();
            ItemHeightLabel = new Label();
            ItemHeightNumericUpDown = new NumericUpDown();
            ItemWidthNumericUpDown = new NumericUpDown();
            ItemWidthLabel = new Label();
            ItemAddRecipesTabPage = new TabPage();
            SaveButton = new Button();
            OriginalCode = new Button();
            PreviewCode = new Button();
            CodeViewRichTextBox = new RichTextBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)ItemImagePictureBox).BeginInit();
            ItemSettingsTabControl.SuspendLayout();
            ItemSetDefaultsTabPage.SuspendLayout();
            ItemShootGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ItemShootSpeedNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ItemShootNumericUpDown).BeginInit();
            ItemItemGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ItemHammerNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ItemPickNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ItemAxeNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ItemCritNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ItemDamageNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ItemKnockbackNumericUpDown).BeginInit();
            ItemMovementGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ItemUseAnimationNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ItemUseTimeNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ItemSoundNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ItemValueNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ItemMaxStackNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ItemHeightNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ItemWidthNumericUpDown).BeginInit();
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
            ItemImagePictureBox.Location = new Point(1102, 48);
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
            // ItemSettingsTabControl
            // 
            ItemSettingsTabControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ItemSettingsTabControl.Controls.Add(ItemSetDefaultsTabPage);
            ItemSettingsTabControl.Controls.Add(ItemAddRecipesTabPage);
            ItemSettingsTabControl.Location = new Point(14, 174);
            ItemSettingsTabControl.Name = "ItemSettingsTabControl";
            ItemSettingsTabControl.SelectedIndex = 0;
            ItemSettingsTabControl.Size = new Size(1218, 776);
            ItemSettingsTabControl.TabIndex = 20;
            // 
            // ItemSetDefaultsTabPage
            // 
            ItemSetDefaultsTabPage.BackColor = Color.FromArgb(192, 255, 255);
            ItemSetDefaultsTabPage.Controls.Add(label2);
            ItemSetDefaultsTabPage.Controls.Add(SetDefaultsOtherCodes);
            ItemSetDefaultsTabPage.Controls.Add(ItemShootGroup);
            ItemSetDefaultsTabPage.Controls.Add(ItemItemGroup);
            ItemSetDefaultsTabPage.Controls.Add(ItemMovementGroup);
            ItemSetDefaultsTabPage.Controls.Add(ItemRareComboBox);
            ItemSetDefaultsTabPage.Controls.Add(ItemSoundLabel);
            ItemSetDefaultsTabPage.Controls.Add(ItemSoundNumericUpDown);
            ItemSetDefaultsTabPage.Controls.Add(ItemRareLabel);
            ItemSetDefaultsTabPage.Controls.Add(ItemValueLabel);
            ItemSetDefaultsTabPage.Controls.Add(ItemValueNumericUpDown);
            ItemSetDefaultsTabPage.Controls.Add(ItemMaxStackLabel);
            ItemSetDefaultsTabPage.Controls.Add(ItemMaxStackNumericUpDown);
            ItemSetDefaultsTabPage.Controls.Add(ItemHeightLabel);
            ItemSetDefaultsTabPage.Controls.Add(ItemHeightNumericUpDown);
            ItemSetDefaultsTabPage.Controls.Add(ItemWidthNumericUpDown);
            ItemSetDefaultsTabPage.Controls.Add(ItemWidthLabel);
            ItemSetDefaultsTabPage.Location = new Point(4, 33);
            ItemSetDefaultsTabPage.Name = "ItemSetDefaultsTabPage";
            ItemSetDefaultsTabPage.Padding = new Padding(3);
            ItemSetDefaultsTabPage.Size = new Size(1210, 739);
            ItemSetDefaultsTabPage.TabIndex = 0;
            ItemSetDefaultsTabPage.Text = "SetDefaults";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(595, 521);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(104, 24);
            label2.TabIndex = 41;
            label2.Text = "自定义代码:";
            // 
            // SetDefaultsOtherCodes
            // 
            SetDefaultsOtherCodes.Location = new Point(593, 548);
            SetDefaultsOtherCodes.Name = "SetDefaultsOtherCodes";
            SetDefaultsOtherCodes.Size = new Size(576, 181);
            SetDefaultsOtherCodes.TabIndex = 37;
            SetDefaultsOtherCodes.Text = "";
            // 
            // ItemShootGroup
            // 
            ItemShootGroup.Controls.Add(ItemShootSpeedLabel);
            ItemShootGroup.Controls.Add(ItemShootSpeedNumericUpDown);
            ItemShootGroup.Controls.Add(ItemShootIUOPCheckBox);
            ItemShootGroup.Controls.Add(ItemShootUOPComboBox);
            ItemShootGroup.Controls.Add(ItemShootLabel);
            ItemShootGroup.Controls.Add(ItemShootNumericUpDown);
            ItemShootGroup.Controls.Add(ItemShootCheckBox);
            ItemShootGroup.Location = new Point(3, 521);
            ItemShootGroup.Name = "ItemShootGroup";
            ItemShootGroup.Size = new Size(584, 208);
            ItemShootGroup.TabIndex = 36;
            ItemShootGroup.TabStop = false;
            ItemShootGroup.Text = "发射!";
            // 
            // ItemShootSpeedLabel
            // 
            ItemShootSpeedLabel.AutoSize = true;
            ItemShootSpeedLabel.Location = new Point(2, 170);
            ItemShootSpeedLabel.Margin = new Padding(5, 0, 5, 0);
            ItemShootSpeedLabel.Name = "ItemShootSpeedLabel";
            ItemShootSpeedLabel.Size = new Size(122, 24);
            ItemShootSpeedLabel.TabIndex = 60;
            ItemShootSpeedLabel.Text = "发射射弹速度:";
            // 
            // ItemShootSpeedNumericUpDown
            // 
            ItemShootSpeedNumericUpDown.Location = new Point(134, 167);
            ItemShootSpeedNumericUpDown.Margin = new Padding(5, 4, 5, 4);
            ItemShootSpeedNumericUpDown.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            ItemShootSpeedNumericUpDown.Name = "ItemShootSpeedNumericUpDown";
            ItemShootSpeedNumericUpDown.Size = new Size(442, 30);
            ItemShootSpeedNumericUpDown.TabIndex = 61;
            ItemShootSpeedNumericUpDown.Value = new decimal(new int[] { 25, 0, 0, 0 });
            // 
            // ItemShootIUOPCheckBox
            // 
            ItemShootIUOPCheckBox.AutoSize = true;
            ItemShootIUOPCheckBox.Location = new Point(134, 94);
            ItemShootIUOPCheckBox.Name = "ItemShootIUOPCheckBox";
            ItemShootIUOPCheckBox.Size = new Size(300, 28);
            ItemShootIUOPCheckBox.TabIndex = 59;
            ItemShootIUOPCheckBox.Text = "使用自定义射弹(启用则上框无效)";
            ItemShootIUOPCheckBox.UseVisualStyleBackColor = true;
            // 
            // ItemShootUOPComboBox
            // 
            ItemShootUOPComboBox.FormattingEnabled = true;
            ItemShootUOPComboBox.Location = new Point(134, 128);
            ItemShootUOPComboBox.Name = "ItemShootUOPComboBox";
            ItemShootUOPComboBox.Size = new Size(442, 32);
            ItemShootUOPComboBox.TabIndex = 58;
            // 
            // ItemShootLabel
            // 
            ItemShootLabel.AutoSize = true;
            ItemShootLabel.Location = new Point(2, 60);
            ItemShootLabel.Margin = new Padding(5, 0, 5, 0);
            ItemShootLabel.Name = "ItemShootLabel";
            ItemShootLabel.Size = new Size(122, 24);
            ItemShootLabel.TabIndex = 44;
            ItemShootLabel.Text = "物品发射射弹:";
            // 
            // ItemShootNumericUpDown
            // 
            ItemShootNumericUpDown.Location = new Point(134, 57);
            ItemShootNumericUpDown.Margin = new Padding(5, 4, 5, 4);
            ItemShootNumericUpDown.Maximum = new decimal(new int[] { 1021, 0, 0, 0 });
            ItemShootNumericUpDown.Name = "ItemShootNumericUpDown";
            ItemShootNumericUpDown.Size = new Size(442, 30);
            ItemShootNumericUpDown.TabIndex = 45;
            ItemShootNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // ItemShootCheckBox
            // 
            ItemShootCheckBox.AutoSize = true;
            ItemShootCheckBox.Location = new Point(2, 29);
            ItemShootCheckBox.Name = "ItemShootCheckBox";
            ItemShootCheckBox.Size = new Size(72, 28);
            ItemShootCheckBox.TabIndex = 38;
            ItemShootCheckBox.Text = "启用";
            ItemShootCheckBox.UseVisualStyleBackColor = true;
            // 
            // ItemItemGroup
            // 
            ItemItemGroup.Controls.Add(ItemNoMeleeComboBox);
            ItemItemGroup.Controls.Add(ItemHammerLabel);
            ItemItemGroup.Controls.Add(ItemHammerNumericUpDown);
            ItemItemGroup.Controls.Add(ItemNoMeleeLabel);
            ItemItemGroup.Controls.Add(ItemPickLabel);
            ItemItemGroup.Controls.Add(ItemPickNumericUpDown);
            ItemItemGroup.Controls.Add(ItemAxeNumericUpDown);
            ItemItemGroup.Controls.Add(ItemAxeLabel);
            ItemItemGroup.Controls.Add(ItemDamageTypeComboBox);
            ItemItemGroup.Controls.Add(ItemDamageTypeLabel);
            ItemItemGroup.Controls.Add(ItemCritLabel);
            ItemItemGroup.Controls.Add(ItemCritNumericUpDown);
            ItemItemGroup.Controls.Add(ItemDamageLabel);
            ItemItemGroup.Controls.Add(ItemDamageNumericUpDown);
            ItemItemGroup.Controls.Add(ItemKnockbackNumericUpDown);
            ItemItemGroup.Controls.Add(ItemKnockbackLabel);
            ItemItemGroup.Controls.Add(ItemItemCheckBox);
            ItemItemGroup.Location = new Point(3, 299);
            ItemItemGroup.Name = "ItemItemGroup";
            ItemItemGroup.Size = new Size(1166, 216);
            ItemItemGroup.TabIndex = 35;
            ItemItemGroup.TabStop = false;
            ItemItemGroup.Text = "武器工具属性";
            // 
            // ItemNoMeleeComboBox
            // 
            ItemNoMeleeComboBox.FormattingEnabled = true;
            ItemNoMeleeComboBox.Items.AddRange(new object[] { "true", "false" });
            ItemNoMeleeComboBox.Location = new Point(688, 173);
            ItemNoMeleeComboBox.Name = "ItemNoMeleeComboBox";
            ItemNoMeleeComboBox.Size = new Size(471, 32);
            ItemNoMeleeComboBox.TabIndex = 57;
            ItemNoMeleeComboBox.Text = "false";
            // 
            // ItemHammerLabel
            // 
            ItemHammerLabel.AutoSize = true;
            ItemHammerLabel.Location = new Point(2, 177);
            ItemHammerLabel.Margin = new Padding(5, 0, 5, 0);
            ItemHammerLabel.Name = "ItemHammerLabel";
            ItemHammerLabel.Size = new Size(86, 24);
            ItemHammerLabel.TabIndex = 54;
            ItemHammerLabel.Text = "物品锤力:";
            // 
            // ItemHammerNumericUpDown
            // 
            ItemHammerNumericUpDown.Location = new Point(105, 174);
            ItemHammerNumericUpDown.Margin = new Padding(5, 4, 5, 4);
            ItemHammerNumericUpDown.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            ItemHammerNumericUpDown.Name = "ItemHammerNumericUpDown";
            ItemHammerNumericUpDown.Size = new Size(471, 30);
            ItemHammerNumericUpDown.TabIndex = 55;
            ItemHammerNumericUpDown.Value = new decimal(new int[] { 50, 0, 0, 0 });
            // 
            // ItemNoMeleeLabel
            // 
            ItemNoMeleeLabel.AutoSize = true;
            ItemNoMeleeLabel.Location = new Point(585, 177);
            ItemNoMeleeLabel.Margin = new Padding(5, 0, 5, 0);
            ItemNoMeleeLabel.Name = "ItemNoMeleeLabel";
            ItemNoMeleeLabel.Size = new Size(104, 24);
            ItemNoMeleeLabel.TabIndex = 56;
            ItemNoMeleeLabel.Text = "不用碰撞箱:";
            // 
            // ItemPickLabel
            // 
            ItemPickLabel.AutoSize = true;
            ItemPickLabel.Location = new Point(2, 139);
            ItemPickLabel.Margin = new Padding(5, 0, 5, 0);
            ItemPickLabel.Name = "ItemPickLabel";
            ItemPickLabel.Size = new Size(86, 24);
            ItemPickLabel.TabIndex = 50;
            ItemPickLabel.Text = "物品镐力:";
            // 
            // ItemPickNumericUpDown
            // 
            ItemPickNumericUpDown.Location = new Point(105, 136);
            ItemPickNumericUpDown.Margin = new Padding(5, 4, 5, 4);
            ItemPickNumericUpDown.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            ItemPickNumericUpDown.Name = "ItemPickNumericUpDown";
            ItemPickNumericUpDown.Size = new Size(471, 30);
            ItemPickNumericUpDown.TabIndex = 51;
            ItemPickNumericUpDown.Value = new decimal(new int[] { 50, 0, 0, 0 });
            // 
            // ItemAxeNumericUpDown
            // 
            ItemAxeNumericUpDown.Location = new Point(688, 136);
            ItemAxeNumericUpDown.Margin = new Padding(5, 4, 5, 4);
            ItemAxeNumericUpDown.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            ItemAxeNumericUpDown.Name = "ItemAxeNumericUpDown";
            ItemAxeNumericUpDown.Size = new Size(471, 30);
            ItemAxeNumericUpDown.TabIndex = 53;
            ItemAxeNumericUpDown.Value = new decimal(new int[] { 45, 0, 0, 0 });
            // 
            // ItemAxeLabel
            // 
            ItemAxeLabel.AutoSize = true;
            ItemAxeLabel.Location = new Point(585, 139);
            ItemAxeLabel.Margin = new Padding(5, 0, 5, 0);
            ItemAxeLabel.Name = "ItemAxeLabel";
            ItemAxeLabel.Size = new Size(86, 24);
            ItemAxeLabel.TabIndex = 52;
            ItemAxeLabel.Text = "物品斧力:";
            // 
            // ItemDamageTypeComboBox
            // 
            ItemDamageTypeComboBox.FormattingEnabled = true;
            ItemDamageTypeComboBox.Items.AddRange(new object[] { "/*战士*/DamageClass.Melee", "/*战士(不吃攻速加成)*/DamageClass.MeleeNoSpeed", "/*射手*/DamageClass.Ranged", "/*法师*/DamageClass.Magic", "/*召唤*/DamageClass.Summon", "/*全属性*/DamageClass.Generic", "/*无属性*/DamageClass.Default" });
            ItemDamageTypeComboBox.Location = new Point(688, 97);
            ItemDamageTypeComboBox.Name = "ItemDamageTypeComboBox";
            ItemDamageTypeComboBox.Size = new Size(471, 32);
            ItemDamageTypeComboBox.TabIndex = 49;
            // 
            // ItemDamageTypeLabel
            // 
            ItemDamageTypeLabel.AutoSize = true;
            ItemDamageTypeLabel.Location = new Point(586, 100);
            ItemDamageTypeLabel.Margin = new Padding(5, 0, 5, 0);
            ItemDamageTypeLabel.Name = "ItemDamageTypeLabel";
            ItemDamageTypeLabel.Size = new Size(86, 24);
            ItemDamageTypeLabel.TabIndex = 44;
            ItemDamageTypeLabel.Text = "伤害类型:";
            // 
            // ItemCritLabel
            // 
            ItemCritLabel.AutoSize = true;
            ItemCritLabel.Location = new Point(2, 100);
            ItemCritLabel.Margin = new Padding(5, 0, 5, 0);
            ItemCritLabel.Name = "ItemCritLabel";
            ItemCritLabel.Size = new Size(104, 24);
            ItemCritLabel.TabIndex = 42;
            ItemCritLabel.Text = "物品暴击率:";
            // 
            // ItemCritNumericUpDown
            // 
            ItemCritNumericUpDown.Location = new Point(105, 98);
            ItemCritNumericUpDown.Margin = new Padding(5, 4, 5, 4);
            ItemCritNumericUpDown.Name = "ItemCritNumericUpDown";
            ItemCritNumericUpDown.Size = new Size(471, 30);
            ItemCritNumericUpDown.TabIndex = 43;
            ItemCritNumericUpDown.Value = new decimal(new int[] { 20, 0, 0, 0 });
            // 
            // ItemDamageLabel
            // 
            ItemDamageLabel.AutoSize = true;
            ItemDamageLabel.Location = new Point(2, 63);
            ItemDamageLabel.Margin = new Padding(5, 0, 5, 0);
            ItemDamageLabel.Name = "ItemDamageLabel";
            ItemDamageLabel.Size = new Size(86, 24);
            ItemDamageLabel.TabIndex = 38;
            ItemDamageLabel.Text = "物品伤害:";
            // 
            // ItemDamageNumericUpDown
            // 
            ItemDamageNumericUpDown.Location = new Point(105, 60);
            ItemDamageNumericUpDown.Margin = new Padding(5, 4, 5, 4);
            ItemDamageNumericUpDown.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            ItemDamageNumericUpDown.Name = "ItemDamageNumericUpDown";
            ItemDamageNumericUpDown.Size = new Size(471, 30);
            ItemDamageNumericUpDown.TabIndex = 39;
            ItemDamageNumericUpDown.Value = new decimal(new int[] { 25, 0, 0, 0 });
            // 
            // ItemKnockbackNumericUpDown
            // 
            ItemKnockbackNumericUpDown.Location = new Point(688, 60);
            ItemKnockbackNumericUpDown.Margin = new Padding(5, 4, 5, 4);
            ItemKnockbackNumericUpDown.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            ItemKnockbackNumericUpDown.Name = "ItemKnockbackNumericUpDown";
            ItemKnockbackNumericUpDown.Size = new Size(471, 30);
            ItemKnockbackNumericUpDown.TabIndex = 41;
            ItemKnockbackNumericUpDown.Value = new decimal(new int[] { 6, 0, 0, 0 });
            // 
            // ItemKnockbackLabel
            // 
            ItemKnockbackLabel.AutoSize = true;
            ItemKnockbackLabel.Location = new Point(585, 63);
            ItemKnockbackLabel.Margin = new Padding(5, 0, 5, 0);
            ItemKnockbackLabel.Name = "ItemKnockbackLabel";
            ItemKnockbackLabel.Size = new Size(86, 24);
            ItemKnockbackLabel.TabIndex = 40;
            ItemKnockbackLabel.Text = "物品击退:";
            // 
            // ItemItemCheckBox
            // 
            ItemItemCheckBox.AutoSize = true;
            ItemItemCheckBox.Location = new Point(6, 29);
            ItemItemCheckBox.Name = "ItemItemCheckBox";
            ItemItemCheckBox.Size = new Size(72, 28);
            ItemItemCheckBox.TabIndex = 37;
            ItemItemCheckBox.Text = "启用";
            ItemItemCheckBox.UseVisualStyleBackColor = true;
            // 
            // ItemMovementGroup
            // 
            ItemMovementGroup.Controls.Add(ItemNoUseGraphicComboBox);
            ItemMovementGroup.Controls.Add(ItemUseTurnComboBox);
            ItemMovementGroup.Controls.Add(ItemUseStyleComboBox);
            ItemMovementGroup.Controls.Add(ItemUseStyleLabel);
            ItemMovementGroup.Controls.Add(ItemAutoReuseComboBox);
            ItemMovementGroup.Controls.Add(ItemNoUseGraphicLabel);
            ItemMovementGroup.Controls.Add(ItemAutoReuseLabel);
            ItemMovementGroup.Controls.Add(ItemUseTurnLabel);
            ItemMovementGroup.Controls.Add(ItemUseAnimationNumericUpDown);
            ItemMovementGroup.Controls.Add(ItemUseAnimationLabel);
            ItemMovementGroup.Controls.Add(ItemUseTimeNumericUpDown);
            ItemMovementGroup.Controls.Add(ItemMovementCheckBox);
            ItemMovementGroup.Controls.Add(ItemUseTimeLabel);
            ItemMovementGroup.Location = new Point(3, 113);
            ItemMovementGroup.Name = "ItemMovementGroup";
            ItemMovementGroup.Size = new Size(1166, 180);
            ItemMovementGroup.TabIndex = 34;
            ItemMovementGroup.TabStop = false;
            ItemMovementGroup.Text = "物品动画";
            // 
            // ItemNoUseGraphicComboBox
            // 
            ItemNoUseGraphicComboBox.FormattingEnabled = true;
            ItemNoUseGraphicComboBox.Items.AddRange(new object[] { "true", "false" });
            ItemNoUseGraphicComboBox.Location = new Point(718, 136);
            ItemNoUseGraphicComboBox.Name = "ItemNoUseGraphicComboBox";
            ItemNoUseGraphicComboBox.Size = new Size(441, 32);
            ItemNoUseGraphicComboBox.TabIndex = 49;
            ItemNoUseGraphicComboBox.Text = "false";
            // 
            // ItemUseTurnComboBox
            // 
            ItemUseTurnComboBox.FormattingEnabled = true;
            ItemUseTurnComboBox.Items.AddRange(new object[] { "true", "false" });
            ItemUseTurnComboBox.Location = new Point(718, 98);
            ItemUseTurnComboBox.Name = "ItemUseTurnComboBox";
            ItemUseTurnComboBox.Size = new Size(441, 32);
            ItemUseTurnComboBox.TabIndex = 45;
            ItemUseTurnComboBox.Text = "true";
            // 
            // ItemUseStyleComboBox
            // 
            ItemUseStyleComboBox.FormattingEnabled = true;
            ItemUseStyleComboBox.Items.AddRange(new object[] { "ItemUseStyleID.None/*无动画*/", "ItemUseStyleID.Swing/*剑挥舞*/", "ItemUseStyleID.EatFood/*吃食物*/", "ItemUseStyleID.Thrust/*伞*/", "ItemUseStyleID.HoldUp/*举起*/", "ItemUseStyleID.Shoot/*射击*/", "ItemUseStyleID.DrinkLong/*药水服用1*/", "ItemUseStyleID.DrinkOld/*药水服用(旧)*/", "ItemUseStyleID.GolfPlay/*高尔夫*/", "ItemUseStyleID.DrinkLiquid/*药水服用2*/", "ItemUseStyleID.HiddenAnimation/*类似整蛊坐垫*/", "ItemUseStyleID.MowTheLawn/*割草机*/", "ItemUseStyleID.Guitar/*类似星星吉他*/", "ItemUseStyleID.Rapier/*短剑*/", "ItemUseStyleID.RaiseLamp/*类似夜光*/" });
            ItemUseStyleComboBox.Location = new Point(134, 136);
            ItemUseStyleComboBox.Name = "ItemUseStyleComboBox";
            ItemUseStyleComboBox.Size = new Size(442, 32);
            ItemUseStyleComboBox.TabIndex = 48;
            // 
            // ItemUseStyleLabel
            // 
            ItemUseStyleLabel.AutoSize = true;
            ItemUseStyleLabel.Location = new Point(2, 139);
            ItemUseStyleLabel.Margin = new Padding(5, 0, 5, 0);
            ItemUseStyleLabel.Name = "ItemUseStyleLabel";
            ItemUseStyleLabel.Size = new Size(122, 24);
            ItemUseStyleLabel.TabIndex = 47;
            ItemUseStyleLabel.Text = "物品使用动画:";
            // 
            // ItemAutoReuseComboBox
            // 
            ItemAutoReuseComboBox.FormattingEnabled = true;
            ItemAutoReuseComboBox.Items.AddRange(new object[] { "true", "false" });
            ItemAutoReuseComboBox.Location = new Point(134, 98);
            ItemAutoReuseComboBox.Name = "ItemAutoReuseComboBox";
            ItemAutoReuseComboBox.Size = new Size(442, 32);
            ItemAutoReuseComboBox.TabIndex = 44;
            ItemAutoReuseComboBox.Text = "true";
            // 
            // ItemNoUseGraphicLabel
            // 
            ItemNoUseGraphicLabel.AutoSize = true;
            ItemNoUseGraphicLabel.Location = new Point(586, 139);
            ItemNoUseGraphicLabel.Margin = new Padding(5, 0, 5, 0);
            ItemNoUseGraphicLabel.Name = "ItemNoUseGraphicLabel";
            ItemNoUseGraphicLabel.Size = new Size(104, 24);
            ItemNoUseGraphicLabel.TabIndex = 46;
            ItemNoUseGraphicLabel.Text = "物品不绘制:";
            // 
            // ItemAutoReuseLabel
            // 
            ItemAutoReuseLabel.AutoSize = true;
            ItemAutoReuseLabel.Location = new Point(2, 101);
            ItemAutoReuseLabel.Margin = new Padding(5, 0, 5, 0);
            ItemAutoReuseLabel.Name = "ItemAutoReuseLabel";
            ItemAutoReuseLabel.Size = new Size(122, 24);
            ItemAutoReuseLabel.TabIndex = 43;
            ItemAutoReuseLabel.Text = "物品自动挥舞:";
            // 
            // ItemUseTurnLabel
            // 
            ItemUseTurnLabel.AutoSize = true;
            ItemUseTurnLabel.Location = new Point(586, 101);
            ItemUseTurnLabel.Margin = new Padding(5, 0, 5, 0);
            ItemUseTurnLabel.Name = "ItemUseTurnLabel";
            ItemUseTurnLabel.Size = new Size(122, 24);
            ItemUseTurnLabel.TabIndex = 41;
            ItemUseTurnLabel.Text = "使用自动转身:";
            // 
            // ItemUseAnimationNumericUpDown
            // 
            ItemUseAnimationNumericUpDown.Location = new Point(718, 61);
            ItemUseAnimationNumericUpDown.Margin = new Padding(5, 4, 5, 4);
            ItemUseAnimationNumericUpDown.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            ItemUseAnimationNumericUpDown.Name = "ItemUseAnimationNumericUpDown";
            ItemUseAnimationNumericUpDown.Size = new Size(441, 30);
            ItemUseAnimationNumericUpDown.TabIndex = 39;
            ItemUseAnimationNumericUpDown.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // ItemUseAnimationLabel
            // 
            ItemUseAnimationLabel.AutoSize = true;
            ItemUseAnimationLabel.Location = new Point(586, 65);
            ItemUseAnimationLabel.Margin = new Padding(5, 0, 5, 0);
            ItemUseAnimationLabel.Name = "ItemUseAnimationLabel";
            ItemUseAnimationLabel.Size = new Size(122, 24);
            ItemUseAnimationLabel.TabIndex = 38;
            ItemUseAnimationLabel.Text = "物品动画速度:";
            // 
            // ItemUseTimeNumericUpDown
            // 
            ItemUseTimeNumericUpDown.Location = new Point(134, 61);
            ItemUseTimeNumericUpDown.Margin = new Padding(5, 4, 5, 4);
            ItemUseTimeNumericUpDown.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            ItemUseTimeNumericUpDown.Name = "ItemUseTimeNumericUpDown";
            ItemUseTimeNumericUpDown.Size = new Size(442, 30);
            ItemUseTimeNumericUpDown.TabIndex = 37;
            ItemUseTimeNumericUpDown.Value = new decimal(new int[] { 8, 0, 0, 0 });
            // 
            // ItemMovementCheckBox
            // 
            ItemMovementCheckBox.AutoSize = true;
            ItemMovementCheckBox.Location = new Point(6, 29);
            ItemMovementCheckBox.Name = "ItemMovementCheckBox";
            ItemMovementCheckBox.Size = new Size(72, 28);
            ItemMovementCheckBox.TabIndex = 36;
            ItemMovementCheckBox.Text = "启用";
            ItemMovementCheckBox.UseVisualStyleBackColor = true;
            // 
            // ItemUseTimeLabel
            // 
            ItemUseTimeLabel.AutoSize = true;
            ItemUseTimeLabel.Location = new Point(2, 63);
            ItemUseTimeLabel.Margin = new Padding(5, 0, 5, 0);
            ItemUseTimeLabel.Name = "ItemUseTimeLabel";
            ItemUseTimeLabel.Size = new Size(122, 24);
            ItemUseTimeLabel.TabIndex = 34;
            ItemUseTimeLabel.Text = "物品使用速度:";
            // 
            // ItemRareComboBox
            // 
            ItemRareComboBox.FormattingEnabled = true;
            ItemRareComboBox.Items.AddRange(new object[] { "-1/*灰色*/", "0/*白色(仅此级会被熔岩烧)*/", "1/*蓝色*/", "2/*绿色*/", "3/*橙色*/", "4/*浅红色*/", "5/*粉红色*/", "6/*浅紫色*/", "7/*青柠色*/", "8/*黄色*/", "9/*青色*/", "10/*红色*/", "11/*紫色*/", "-12/*彩虹色(专家模式专用物品色)*/", "-13/*火红色(大师模式专用物品色)*/", "-11/*琥珀色(任务物品色)*/" });
            ItemRareComboBox.Location = new Point(108, 75);
            ItemRareComboBox.Name = "ItemRareComboBox";
            ItemRareComboBox.Size = new Size(471, 32);
            ItemRareComboBox.TabIndex = 33;
            // 
            // ItemSoundLabel
            // 
            ItemSoundLabel.AutoSize = true;
            ItemSoundLabel.Location = new Point(589, 78);
            ItemSoundLabel.Margin = new Padding(5, 0, 5, 0);
            ItemSoundLabel.Name = "ItemSoundLabel";
            ItemSoundLabel.Size = new Size(86, 24);
            ItemSoundLabel.TabIndex = 31;
            ItemSoundLabel.Text = "物品声音:";
            // 
            // ItemSoundNumericUpDown
            // 
            ItemSoundNumericUpDown.Location = new Point(691, 76);
            ItemSoundNumericUpDown.Margin = new Padding(5, 4, 5, 4);
            ItemSoundNumericUpDown.Maximum = new decimal(new int[] { 69, 0, 0, 0 });
            ItemSoundNumericUpDown.Name = "ItemSoundNumericUpDown";
            ItemSoundNumericUpDown.Size = new Size(471, 30);
            ItemSoundNumericUpDown.TabIndex = 32;
            // 
            // ItemRareLabel
            // 
            ItemRareLabel.AutoSize = true;
            ItemRareLabel.Location = new Point(5, 78);
            ItemRareLabel.Margin = new Padding(5, 0, 5, 0);
            ItemRareLabel.Name = "ItemRareLabel";
            ItemRareLabel.Size = new Size(104, 24);
            ItemRareLabel.TabIndex = 29;
            ItemRareLabel.Text = "物品稀有度:";
            // 
            // ItemValueLabel
            // 
            ItemValueLabel.AutoSize = true;
            ItemValueLabel.Location = new Point(589, 40);
            ItemValueLabel.Margin = new Padding(5, 0, 5, 0);
            ItemValueLabel.Name = "ItemValueLabel";
            ItemValueLabel.Size = new Size(86, 24);
            ItemValueLabel.TabIndex = 27;
            ItemValueLabel.Text = "物品价值:";
            // 
            // ItemValueNumericUpDown
            // 
            ItemValueNumericUpDown.Location = new Point(691, 38);
            ItemValueNumericUpDown.Margin = new Padding(5, 4, 5, 4);
            ItemValueNumericUpDown.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 });
            ItemValueNumericUpDown.Name = "ItemValueNumericUpDown";
            ItemValueNumericUpDown.Size = new Size(471, 30);
            ItemValueNumericUpDown.TabIndex = 28;
            ItemValueNumericUpDown.Value = new decimal(new int[] { 500, 0, 0, 0 });
            // 
            // ItemMaxStackLabel
            // 
            ItemMaxStackLabel.AutoSize = true;
            ItemMaxStackLabel.Location = new Point(5, 40);
            ItemMaxStackLabel.Margin = new Padding(5, 0, 5, 0);
            ItemMaxStackLabel.Name = "ItemMaxStackLabel";
            ItemMaxStackLabel.Size = new Size(86, 24);
            ItemMaxStackLabel.TabIndex = 25;
            ItemMaxStackLabel.Text = "物品堆叠:";
            // 
            // ItemMaxStackNumericUpDown
            // 
            ItemMaxStackNumericUpDown.Location = new Point(108, 38);
            ItemMaxStackNumericUpDown.Margin = new Padding(5, 4, 5, 4);
            ItemMaxStackNumericUpDown.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            ItemMaxStackNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            ItemMaxStackNumericUpDown.Name = "ItemMaxStackNumericUpDown";
            ItemMaxStackNumericUpDown.Size = new Size(471, 30);
            ItemMaxStackNumericUpDown.TabIndex = 26;
            ItemMaxStackNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // ItemHeightLabel
            // 
            ItemHeightLabel.AutoSize = true;
            ItemHeightLabel.Location = new Point(5, 3);
            ItemHeightLabel.Margin = new Padding(5, 0, 5, 0);
            ItemHeightLabel.Name = "ItemHeightLabel";
            ItemHeightLabel.Size = new Size(86, 24);
            ItemHeightLabel.TabIndex = 21;
            ItemHeightLabel.Text = "物品高度:";
            // 
            // ItemHeightNumericUpDown
            // 
            ItemHeightNumericUpDown.Location = new Point(108, 0);
            ItemHeightNumericUpDown.Margin = new Padding(5, 4, 5, 4);
            ItemHeightNumericUpDown.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            ItemHeightNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            ItemHeightNumericUpDown.Name = "ItemHeightNumericUpDown";
            ItemHeightNumericUpDown.Size = new Size(471, 30);
            ItemHeightNumericUpDown.TabIndex = 22;
            ItemHeightNumericUpDown.Value = new decimal(new int[] { 80, 0, 0, 0 });
            // 
            // ItemWidthNumericUpDown
            // 
            ItemWidthNumericUpDown.Location = new Point(691, 0);
            ItemWidthNumericUpDown.Margin = new Padding(5, 4, 5, 4);
            ItemWidthNumericUpDown.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            ItemWidthNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            ItemWidthNumericUpDown.Name = "ItemWidthNumericUpDown";
            ItemWidthNumericUpDown.Size = new Size(471, 30);
            ItemWidthNumericUpDown.TabIndex = 24;
            ItemWidthNumericUpDown.Value = new decimal(new int[] { 80, 0, 0, 0 });
            // 
            // ItemWidthLabel
            // 
            ItemWidthLabel.AutoSize = true;
            ItemWidthLabel.Location = new Point(588, 3);
            ItemWidthLabel.Margin = new Padding(5, 0, 5, 0);
            ItemWidthLabel.Name = "ItemWidthLabel";
            ItemWidthLabel.Size = new Size(86, 24);
            ItemWidthLabel.TabIndex = 23;
            ItemWidthLabel.Text = "物品宽度:";
            // 
            // ItemAddRecipesTabPage
            // 
            ItemAddRecipesTabPage.BackColor = Color.FromArgb(192, 255, 255);
            ItemAddRecipesTabPage.Location = new Point(4, 33);
            ItemAddRecipesTabPage.Name = "ItemAddRecipesTabPage";
            ItemAddRecipesTabPage.Padding = new Padding(3);
            ItemAddRecipesTabPage.Size = new Size(1210, 739);
            ItemAddRecipesTabPage.TabIndex = 1;
            ItemAddRecipesTabPage.Text = "AddRecipes";
            // 
            // SaveButton
            // 
            SaveButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            SaveButton.Location = new Point(1679, 917);
            SaveButton.Margin = new Padding(5, 4, 5, 4);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(294, 34);
            SaveButton.TabIndex = 24;
            SaveButton.Text = "保存当前显示的代码并保存图片";
            SaveButton.UseVisualStyleBackColor = true;
            // 
            // OriginalCode
            // 
            OriginalCode.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            OriginalCode.Location = new Point(1242, 917);
            OriginalCode.Margin = new Padding(5, 4, 5, 4);
            OriginalCode.Name = "OriginalCode";
            OriginalCode.Size = new Size(130, 32);
            OriginalCode.TabIndex = 23;
            OriginalCode.Text = "源文件代码";
            OriginalCode.UseVisualStyleBackColor = true;
            // 
            // PreviewCode
            // 
            PreviewCode.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            PreviewCode.Location = new Point(1382, 917);
            PreviewCode.Margin = new Padding(5, 4, 5, 4);
            PreviewCode.Name = "PreviewCode";
            PreviewCode.Size = new Size(118, 32);
            PreviewCode.TabIndex = 22;
            PreviewCode.Text = "预览代码";
            PreviewCode.UseVisualStyleBackColor = true;
            // 
            // CodeViewRichTextBox
            // 
            CodeViewRichTextBox.AcceptsTab = true;
            CodeViewRichTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CodeViewRichTextBox.Location = new Point(1242, 76);
            CodeViewRichTextBox.Margin = new Padding(5, 4, 5, 4);
            CodeViewRichTextBox.Name = "CodeViewRichTextBox";
            CodeViewRichTextBox.Size = new Size(731, 833);
            CodeViewRichTextBox.TabIndex = 21;
            CodeViewRichTextBox.TabStop = false;
            CodeViewRichTextBox.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1024, 143);
            label3.Name = "label3";
            label3.Size = new Size(70, 24);
            label3.TabIndex = 25;
            label3.Text = "开发中!";
            // 
            // ItemSettings
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 255, 255);
            ClientSize = new Size(1987, 962);
            Controls.Add(label3);
            Controls.Add(SaveButton);
            Controls.Add(OriginalCode);
            Controls.Add(PreviewCode);
            Controls.Add(CodeViewRichTextBox);
            Controls.Add(ItemSettingsTabControl);
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
            Load += ItemSettings_Load;
            ((System.ComponentModel.ISupportInitialize)ItemImagePictureBox).EndInit();
            ItemSettingsTabControl.ResumeLayout(false);
            ItemSetDefaultsTabPage.ResumeLayout(false);
            ItemSetDefaultsTabPage.PerformLayout();
            ItemShootGroup.ResumeLayout(false);
            ItemShootGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ItemShootSpeedNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)ItemShootNumericUpDown).EndInit();
            ItemItemGroup.ResumeLayout(false);
            ItemItemGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ItemHammerNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)ItemPickNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)ItemAxeNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)ItemCritNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)ItemDamageNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)ItemKnockbackNumericUpDown).EndInit();
            ItemMovementGroup.ResumeLayout(false);
            ItemMovementGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ItemUseAnimationNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)ItemUseTimeNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)ItemSoundNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)ItemValueNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)ItemMaxStackNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)ItemHeightNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)ItemWidthNumericUpDown).EndInit();
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
        private TabControl ItemSettingsTabControl;
        private TabPage ItemSetDefaultsTabPage;
        private TabPage ItemAddRecipesTabPage;
        private Label ItemHeightLabel;
        private NumericUpDown ItemHeightNumericUpDown;
        private NumericUpDown ItemWidthNumericUpDown;
        private Label ItemWidthLabel;
        private Label ItemMaxStackLabel;
        private NumericUpDown ItemMaxStackNumericUpDown;
        private Label ItemValueLabel;
        private NumericUpDown ItemValueNumericUpDown;
        private ComboBox ItemRareComboBox;
        private Label ItemSoundLabel;
        private NumericUpDown ItemSoundNumericUpDown;
        private Label ItemRareLabel;
        private GroupBox ItemMovementGroup;
        private NumericUpDown ItemUseAnimationNumericUpDown;
        private Label ItemUseAnimationLabel;
        private NumericUpDown ItemUseTimeNumericUpDown;
        private CheckBox ItemMovementCheckBox;
        private Label ItemUseTimeLabel;
        private ComboBox ItemUseTurnComboBox;
        private ComboBox ItemAutoReuseComboBox;
        private Label ItemAutoReuseLabel;
        private Label ItemUseTurnLabel;
        private ComboBox ItemNoUseGraphicComboBox;
        private ComboBox ItemUseStyleComboBox;
        private Label ItemUseStyleLabel;
        private Label ItemNoUseGraphicLabel;
        private GroupBox ItemItemGroup;
        private CheckBox ItemItemCheckBox;
        private Label ItemDamageTypeLabel;
        private Label ItemCritLabel;
        private NumericUpDown ItemCritNumericUpDown;
        private Label ItemDamageLabel;
        private NumericUpDown ItemDamageNumericUpDown;
        private NumericUpDown ItemKnockbackNumericUpDown;
        private Label ItemKnockbackLabel;
        private ComboBox ItemDamageTypeComboBox;
        private Label ItemPickLabel;
        private NumericUpDown ItemPickNumericUpDown;
        private NumericUpDown ItemAxeNumericUpDown;
        private Label ItemAxeLabel;
        private ComboBox ItemNoMeleeComboBox;
        private Label ItemHammerLabel;
        private NumericUpDown ItemHammerNumericUpDown;
        private Label ItemNoMeleeLabel;
        private GroupBox ItemShootGroup;
        private CheckBox ItemShootIUOPCheckBox;
        private ComboBox ItemShootUOPComboBox;
        private Label ItemShootLabel;
        private NumericUpDown ItemShootNumericUpDown;
        private CheckBox ItemShootCheckBox;
        private Label ItemShootSpeedLabel;
        private NumericUpDown ItemShootSpeedNumericUpDown;
        private Button SaveButton;
        private Button OriginalCode;
        private Button PreviewCode;
        private RichTextBox CodeViewRichTextBox;
        private Label label2;
        private RichTextBox SetDefaultsOtherCodes;
        private Label label3;
    }
}