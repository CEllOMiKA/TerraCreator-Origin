using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;

using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TerraCreator;


namespace TerraCreator
{
    public partial class AddItem : Form
    {
        public AddItem()
        {
            InitializeComponent();
        }

        private void AddItem_Load(object sender, EventArgs e)
        {
            this.BackColor = TerraCreatorData.FormBackColor;
            //itempanel.BackColor = TerraCreatorData.FormToolColor;
            list.BackColor = TerraCreatorData.FormToolColor;
            CreateGroupBox.BackColor = TerraCreatorData.FormToolColor;
        }


        //private void AddItemtoPanel_NewTMLItem()
        //{
        //    int y = 40; //distance
        //    int d = 2; //distance down

        //    int w1 = 800; //main
        //    int w2 = 500; //other
        //    int w3 = 120; //button

        //    int h3 = y - 5; //button
        //    int h4 = 145; //richbox

        //    int r1 = 16;//right
        //    int r2 = 132;//mid

        //    string codes = "";

        //    //title
        //    Label title = new Label();
        //    title.Text = "物品";
        //    title.Height = 35;
        //    title.Location = new Point(2, y * 0);
        //    title.Font = new Font("Microsoft YaHei UI", 12);

        //    //name
        //    Label namelabel = new Label();
        //    namelabel.Text = "物品名称";
        //    namelabel.Location = new Point(r1, y + 2);
        //    TextBox nametextbox = new TextBox();
        //    nametextbox.Width = w1;
        //    nametextbox.Font = new Font("Microsoft YaHei UI", 11);
        //    nametextbox.Location = new Point(r2, y + 2);

        //    //namespace
        //    Label namespacelabel = new Label();
        //    namespacelabel.Text = "物品定义名";
        //    namespacelabel.Location = new Point(r1, y * 2 + d * 2);
        //    TextBox namespacetextbox = new TextBox();
        //    namespacetextbox.Width = w1;
        //    namespacetextbox.Font = new Font("Microsoft YaHei UI", 11);
        //    namespacetextbox.Location = new Point(r2, y * 2 + d * 2);


        //    //ImageShow
        //    PictureBox ImageChooseBox = new PictureBox();
        //    ImageChooseBox.SizeMode = PictureBoxSizeMode.Zoom;
        //    ImageChooseBox.Width = 100;
        //    ImageChooseBox.Height = 100;
        //    ImageChooseBox.Location = new Point(r2 + 850, y * 1 + d * 1 - 10);
        //    ImageChooseBox.Image = null; //默认无图片



        //    //image
        //    Label imagelabel = new Label();
        //    imagelabel.Text = "物品图片";
        //    imagelabel.Location = new Point(r1, y * 3 + d * 3);
        //    Button imagechoosebutton = new Button();
        //    imagechoosebutton.Text = "选择图片";
        //    imagechoosebutton.Height = h3;
        //    imagechoosebutton.Width = w3;
        //    imagechoosebutton.Location = new Point(r2, y * 3 + d * 3);
        //    OpenFileDialog imagechoosefile = new OpenFileDialog();

        //    Label ImagePath = new Label();
        //    ImagePath.Text = "";
        //    ImagePath.Width = 900;
        //    ImagePath.Location = new Point(r2 + 140, y * 3 + d * 3 + 5);

        //    string imagePath = "";

        //    imagechoosebutton.Click += new EventHandler(itemimagechoosebutton_click);

        //    void itemimagechoosebutton_click(object sender, EventArgs e)  //ClickTheButtonToChooseImage
        //    {
        //        if (string.IsNullOrEmpty(namespacetextbox.Text))
        //        {
        //            MessageBox.Show("请先输入物品定义名", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            return;
        //        }
        //        imagechoosefile.Filter = "PNG|*.png";
        //        imagechoosefile.Title = "选择物品图片";
        //        DialogResult imagechoosefile_result = imagechoosefile.ShowDialog();
        //        if (imagechoosefile_result == DialogResult.OK)
        //        {
        //            imagePath = imagechoosefile.FileName;
        //            ImagePath.Text = imagePath;

        //            //Let ImageChooseBox Show Image
        //            try
        //            {
        //                ImageChooseBox.Image = Image.FromFile(imagePath);
        //            }
        //            catch (Exception ex)
        //            {
        //                //MessageBox.Show($"图片加载失败: {ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //                ImageChooseBox.Image = null;
        //            }

        //        }


        //    }

        //    //damagetype
        //    Label damagetypelabel = new Label();
        //    damagetypelabel.Text = "物品类型";
        //    damagetypelabel.Location = new Point(r1, y * 4 + d * 4);
        //    ComboBox damagetypecombobox = new ComboBox();
        //    damagetypecombobox.Font = new Font("Microsoft YaHei UI", 11);
        //    damagetypecombobox.Items.Add("/*战士*/DamageClass.Melee");
        //    damagetypecombobox.Items.Add("/*战士(不吃攻速加成)*/DamageClass.MeleeNoSpeed");
        //    damagetypecombobox.Items.Add("/*射手*/DamageClass.Ranged");
        //    damagetypecombobox.Items.Add("/*法师*/DamageClass.Magic");
        //    damagetypecombobox.Items.Add("/*召唤*/DamageClass.Summon");
        //    damagetypecombobox.Items.Add("/*全属性*/DamageClass.Generic");
        //    damagetypecombobox.Items.Add("/*无属性*/DamageClass.Default");
        //    damagetypecombobox.Width = 500;
        //    damagetypecombobox.Font = new Font("Microsoft YaHei UI", 11);
        //    damagetypecombobox.Location = new Point(r2, y * 4 + d * 4);

        //    //UseStyle
        //    Label UseStyleLabel = new Label();
        //    UseStyleLabel.Text = "使用方式";
        //    UseStyleLabel.Location = new Point(r1, y * 5 + d * 5);
        //    ComboBox UseStyleComboBox = new ComboBox();
        //    UseStyleComboBox.Font = new Font("Microsoft YaHei UI", 11);
        //    UseStyleComboBox.Items.Add("/*剑类挥舞*/ItemUseStyleID.Swing");
        //    UseStyleComboBox.Items.Add("/*短剑刺击(无动画)*/ItemUseStyleID.Thrust");
        //    UseStyleComboBox.Items.Add("/*举起(类似生命水晶)*/ItemUseStyleID.HoldUp");
        //    UseStyleComboBox.Items.Add("/*射击(枪,法杖,弓)*/ItemUseStyleID.Shoot");
        //    UseStyleComboBox.Items.Add("/*猛喝(!?)*/ItemUseStyleID.DrinkLong");
        //    UseStyleComboBox.Items.Add("/*食物服用*/ItemUseStyleID.EatFood");
        //    UseStyleComboBox.Items.Add("/*喝药水(旧版)*/ItemUseStyleID.DrinkOld");
        //    UseStyleComboBox.Items.Add("/*喝药水(新版)*/ItemUseStyleID.DrinkLiquid");
        //    UseStyleComboBox.Items.Add("/*高尔夫杆动作*/ItemUseStyleID.GolfPlay");
        //    UseStyleComboBox.Items.Add("/*割草机动作*/ItemUseStyleID.MowTheLawn");
        //    UseStyleComboBox.Items.Add("/*弹吉他*/ItemUseStyleID.Guitar");
        //    UseStyleComboBox.Items.Add("/*类似标尺,星光等动作*/ItemUseStyleID.Rapier");
        //    UseStyleComboBox.Items.Add("/*类似夜光等动作*/ItemUseStyleID.RaiseLamp");
        //    UseStyleComboBox.Items.Add("/*隐藏动作*/ItemUseStyleID.HiddenAnimation");
        //    UseStyleComboBox.Items.Add("/*无挥动效果*/ItemUseStyleID.None");
        //    UseStyleComboBox.Width = 500;
        //    UseStyleComboBox.Font = new Font("Microsoft YaHei UI", 11);
        //    UseStyleComboBox.Location = new Point(r2, y * 5 + d * 5);

        //    //damage
        //    Label damagelabel = new Label();
        //    damagelabel.Text = "物品伤害";
        //    damagelabel.Location = new Point(r1, y * 6 + d * 6);
        //    NumericUpDown damagetextbox = new NumericUpDown();
        //    damagetextbox.Maximum = 10000000;
        //    damagetextbox.Minimum = 0;
        //    damagetextbox.Width = w2;
        //    damagetextbox.Font = new Font("Microsoft YaHei UI", 11);
        //    damagetextbox.Location = new Point(r2, y * 6 + d * 6);

        //    //knockback
        //    Label knockbacklabel = new Label();
        //    knockbacklabel.Text = "物品击退";
        //    knockbacklabel.Location = new Point(r1, y * 7 + d * 7);
        //    NumericUpDown knockbacktextbox = new NumericUpDown();
        //    knockbacktextbox.Maximum = 1000;
        //    knockbacktextbox.Minimum = 0;
        //    knockbacktextbox.Width = w2;
        //    knockbacktextbox.Font = new Font("Microsoft YaHei UI", 11);
        //    knockbacktextbox.Location = new Point(r2, y * 7 + d * 7);

        //    // usetime
        //    Label useTimeLabel = new Label();
        //    useTimeLabel.Text = "使用时间";
        //    useTimeLabel.Location = new Point(r1, y * 8 + d * 8);
        //    NumericUpDown useTimeNumeric = new NumericUpDown();
        //    useTimeNumeric.Maximum = 1000;
        //    useTimeNumeric.Minimum = 1;
        //    useTimeNumeric.Width = w2;
        //    useTimeNumeric.Font = new Font("Microsoft YaHei UI", 11);
        //    useTimeNumeric.Location = new Point(r2, y * 8 + d * 8);

        //    // max stack
        //    Label maxStackLabel = new Label();
        //    maxStackLabel.Text = "最大堆叠";
        //    maxStackLabel.Location = new Point(r1, y * 9 + d * 9);
        //    NumericUpDown maxStackNumeric = new NumericUpDown();
        //    maxStackNumeric.Maximum = 9999;
        //    maxStackNumeric.Minimum = 1;
        //    maxStackNumeric.Width = w2;
        //    maxStackNumeric.Font = new Font("Microsoft YaHei UI", 11);
        //    maxStackNumeric.Location = new Point(r2, y * 9 + d * 9);

        //    //Item Value
        //    Label ItemValueLabel = new Label();
        //    ItemValueLabel.Text = "物品价值";
        //    ItemValueLabel.Location = new Point(r1, y * 10 + d * 10);
        //    NumericUpDown ItemValueNumeric = new NumericUpDown();//not support buyprice() sellprice() now,maybe later
        //    ItemValueNumeric.Maximum = 100000000;
        //    ItemValueNumeric.Minimum = 0;
        //    ItemValueNumeric.Width = w2;
        //    ItemValueNumeric.Font = new Font("Microsoft YaHei UI", 11);
        //    ItemValueNumeric.Location = new Point(r2, y * 10 + d * 10);

        //    //Shoot

        //    //Label ItemShootLabel = new Label();
        //    //ItemShootLabel.Text = "发射射弹";
        //    //ItemShootLabel.Location = new Point(r1, y * 11 + d * 11);
        //    //ComboBox ItemShootComboBox = new ComboBox();
        //    //ItemShootComboBox.Font = new Font("Microsoft YaHei UI", 11);
        //    //ItemShootComboBox.Items.Add("/*泰拉光束*/ItemShoot.TerraBeam");

        //    //wip

        //    //ShootSpeed
        //    //Axe
        //    //Pick
        //    //Hammer
        //    //...


        //    //codespreview
        //    Button codespreviewlabel = new Button();
        //    codespreviewlabel.Text = "代码预览";
        //    codespreviewlabel.Height = h3;
        //    codespreviewlabel.Width = w3;
        //    codespreviewlabel.Location = new Point(r1, y * 12 + d * 12);
        //    codespreviewlabel.Click += new EventHandler(itemcodespreviewlabel_click);

        //    void itemcodespreviewlabel_click(object sender, EventArgs e)
        //    {

        //        if(WriteCodes()) MessageBox.Show(codes, "代码预览", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }



        //    //savebutton
        //    Button saveButton = new Button();
        //    saveButton.Text = "保存代码";
        //    saveButton.Height = h3;
        //    saveButton.Width = w3;
        //    saveButton.Location = new Point(r1, y * 13 + d * 13);
        //    saveButton.Click += new EventHandler(saveButton_Click);
        //    void saveButton_Click(object sender, EventArgs e)
        //    {


        //        if (string.IsNullOrEmpty(imagePath))
        //        {
        //            MessageBox.Show("请先选择图片", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            return;
        //        }

        //        if (!WriteCodes()) return;

        //        //CheckIfWantToWrite
        //        DialogResult ConfirmCopy = MessageBox.Show($"图片复制到项目文件夹会覆盖文件" +
        //            $"\n文件代码生成也会覆盖文件" +
        //            $"\n文件夹地址:{ProjectData.ProjectPath + "\\Items\\"}",
        //            "提示",
        //            MessageBoxButtons.YesNo,
        //            MessageBoxIcon.Question
        //            );

        //        if (ConfirmCopy == DialogResult.Yes)
        //        {

        //            try
        //            {
        //                System.IO.File.Copy(imagePath, ProjectData.ProjectPath + "\\Items\\" + namespacetextbox.Text + ".png", true);
        //            }
        //            catch (Exception ex)
        //            {
        //                MessageBox.Show($"复制失败: {ex.Message}\n请手动复制图片至文件夹", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            }

        //            //CopyCodes
        //            string filePath = ProjectData.ProjectPath + "\\Items\\" + namespacetextbox.Text + ".cs";
        //            try
        //            {
        //                System.IO.File.WriteAllText(filePath, codes, Encoding.UTF8);
        //                MessageBox.Show($"代码保存成功\n文件地址:{filePath}", "保存成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //            }
        //            catch (Exception ex)
        //            {
        //                MessageBox.Show($"保存失败: {ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            }

        //        }

        //    }


        //    //WriteCodes
        //    bool WriteCodes()
        //    {

        //        if (string.IsNullOrEmpty(namespacetextbox.Text))
        //        {
        //            MessageBox.Show("请先输入物品定义名", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            return false;
        //        }

        //        codes = "";
        //        codes +=
        //            "using Terraria;" + Environment.NewLine +
        //            "using Terraria.ID;" + Environment.NewLine +
        //            "using Terraria.ModLoader;" + Environment.NewLine +
        //          $"namespace {ProjectData.ProjectNamespace}.Items" + Environment.NewLine +
        //            "{" + Environment.NewLine +
        //          $"    public class {namespacetextbox.Text} : ModItem" + Environment.NewLine +
        //            "    {" + Environment.NewLine +
        //            "          public override void SetDefaults()" + Environment.NewLine +
        //            "          {" + Environment.NewLine +
        //          $"               Item.DamageType = {damagetypecombobox.Text};" + Environment.NewLine +
        //          $"               Item.Damage = {damagetextbox.Value};" + Environment.NewLine +
        //          $"               Item.useStyle = {UseStyleComboBox.Text};" + Environment.NewLine +
        //          $"               Item.knockBack = {knockbacktextbox.Value};" + Environment.NewLine +
        //          $"               Item.useTime = {useTimeNumeric.Value};" + Environment.NewLine +
        //          $"               Item.maxStack = {maxStackNumeric.Value};" + Environment.NewLine +
        //          $"               Item.value = {ItemValueNumeric.Value};" + Environment.NewLine +
        //            "          }" + Environment.NewLine +
        //            "    }" + Environment.NewLine +
        //            "}";

        //        return true;
        //    }



        //    //addtopanel
        //    itempanel.Controls.Add(title);
        //    itempanel.Controls.Add(namelabel);
        //    itempanel.Controls.Add(nametextbox);
        //    itempanel.Controls.Add(namespacelabel);
        //    itempanel.Controls.Add(namespacetextbox);
        //    itempanel.Controls.Add(imagelabel);
        //    itempanel.Controls.Add(imagechoosebutton);
        //    itempanel.Controls.Add(ImagePath);
        //    itempanel.Controls.Add(damagetypelabel);
        //    itempanel.Controls.Add(damagetypecombobox);
        //    itempanel.Controls.Add(damagelabel);
        //    itempanel.Controls.Add(damagetextbox);
        //    itempanel.Controls.Add(knockbacklabel);
        //    itempanel.Controls.Add(knockbacktextbox);
        //    itempanel.Controls.Add(useTimeLabel);
        //    itempanel.Controls.Add(useTimeNumeric);
        //    itempanel.Controls.Add(maxStackLabel);
        //    itempanel.Controls.Add(maxStackNumeric);
        //    itempanel.Controls.Add(codespreviewlabel);
        //    itempanel.Controls.Add(saveButton);
        //    itempanel.Controls.Add(ImageChooseBox);
        //    itempanel.Controls.Add(UseStyleLabel);
        //    itempanel.Controls.Add(UseStyleComboBox);
        //    itempanel.Controls.Add(ItemValueLabel);
        //    itempanel.Controls.Add(ItemValueNumeric);
        //    itempanel.AutoScroll = true;
        //}






        //void AddItemtoPanel_NewCodes()
        //{
        //    int y = 40; //distance
        //    int d = 2; //distance down

        //    int w1 = 600; //main
        //    int w2 = 500; //other
        //    int w3 = 120; //button

        //    int h3 = y - 5; //button
        //    int h4 = 145; //richbox

        //    int r1 = 16;//right
        //    int r2 = 132;//mid



        //    //title
        //    Label title = new Label();
        //    title.Text = "文本/代码文件";
        //    title.Height = 35;
        //    title.Width = 300;
        //    title.Location = new Point(2, y * 0);
        //    title.Font = new Font("Microsoft YaHei UI", 12);

        //    //name
        //    Label namelabel = new Label();
        //    namelabel.Text = "文件名称";
        //    namelabel.Location = new Point(r1, y + 2);
        //    TextBox nametextbox = new TextBox();
        //    nametextbox.Width = w1;
        //    nametextbox.Font = new Font("Microsoft YaHei UI", 11);
        //    nametextbox.Location = new Point(r2, y + 2);

        //    //path
        //    Label SavePathLabel = new Label();
        //    SavePathLabel.Text = "保存位置";
        //    SavePathLabel.Location = new Point(r1, y * 2 + d * 2);
        //    Button SavePathChooseButton = new Button();
        //    SavePathChooseButton.Text = "选择位置";
        //    SavePathChooseButton.Height = h3;
        //    SavePathChooseButton.Width = w3;
        //    SavePathChooseButton.Location = new Point(r2, y * 2 + d * 2);
        //    FolderBrowserDialog SavePathChooseDialog = new FolderBrowserDialog();
        //    Label SavePath = new Label();
        //    SavePath.Text = "";
        //    SavePath.Width = 900;
        //    SavePath.Location = new Point(r2 + 140, y * 2 + d * 2 + 5);
        //    string SelectPath = "";
        //    SavePathChooseButton.Click += new EventHandler(SavePathChooseDialog_click);

        //    void SavePathChooseDialog_click(object sender, EventArgs e)
        //    {

        //        DialogResult SavePathChooseDialog_result = SavePathChooseDialog.ShowDialog();

        //        if (SavePathChooseDialog_result == DialogResult.OK)
        //        {

        //            SelectPath = SavePathChooseDialog.SelectedPath;
        //            SavePath.Text = SelectPath;
        //        }
        //    }

        //    //savebutton
        //    Button saveButton = new Button();
        //    saveButton.Text = "保存文件";
        //    saveButton.Height = h3;
        //    saveButton.Width = w3;
        //    saveButton.Location = new Point(r1, y * 4 + d * 4);
        //    saveButton.Click += new EventHandler(saveButton_Click);
        //    void saveButton_Click(object sender, EventArgs e)
        //    {
        //        if (string.IsNullOrEmpty(nametextbox.Text) || string.IsNullOrEmpty(SelectPath))
        //        {
        //            MessageBox.Show("文件名或保存文件位置未指定", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            return;
        //        }
        //        //CopyCodes
        //        try
        //        {
        //            System.IO.File.WriteAllText(SelectPath + "\\" + nametextbox.Text, "", Encoding.UTF8);
        //            MessageBox.Show($"文件创建成功\n文件地址:{SelectPath + "\\" + nametextbox.Text}", "创建成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show($"创建失败: {ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }

        //    }

        //    itempanel.Controls.Add(title);
        //    itempanel.Controls.Add(namelabel);
        //    itempanel.Controls.Add(nametextbox);
        //    itempanel.Controls.Add(SavePathChooseButton);
        //    itempanel.Controls.Add(SavePathLabel);
        //    itempanel.Controls.Add(SavePath);
        //    itempanel.Controls.Add(saveButton);
        //    itempanel.AutoScroll = true;
        //}





        //void AddItemtoPanel_NewTMLProjectile()
        //{
        //    int y = 40; //distance
        //    int d = 2; //distance down

        //    int w1 = 800; //main
        //    int w2 = 500; //other
        //    int w3 = 120; //button

        //    int h3 = y - 5; //button
        //    int h4 = 145; //richbox

        //    int r1 = 16;//right
        //    int r2 = 132;//mid

        //    string codes = "";

        //    //title
        //    Label title = new Label();
        //    title.Text = "射弹";
        //    title.Height = 35;
        //    title.Location = new Point(2, y * 0);
        //    title.Font = new Font("Microsoft YaHei UI", 12);

        //    //name
        //    Label namelabel = new Label();
        //    namelabel.Text = "射弹名称";
        //    namelabel.Location = new Point(r1, y + 2);
        //    TextBox nametextbox = new TextBox();
        //    nametextbox.Width = w1;
        //    nametextbox.Font = new Font("Microsoft YaHei UI", 11);
        //    nametextbox.Location = new Point(r2, y + 2);

        //    //namespace
        //    Label namespacelabel = new Label();
        //    namespacelabel.Text = "射弹定义名";
        //    namespacelabel.Location = new Point(r1, y * 2 + d * 2);
        //    TextBox namespacetextbox = new TextBox();
        //    namespacetextbox.Width = w1;
        //    namespacetextbox.Font = new Font("Microsoft YaHei UI", 11);
        //    namespacetextbox.Location = new Point(r2, y * 2 + d * 2);

        //    //Image
        //    Label ProjectileImageLabel = new Label();
        //    ProjectileImageLabel.Text = "物品图片";
        //    ProjectileImageLabel.Location = new Point(r1, y * 3 + d * 3);
        //    Button ProjectileImageChooseButton = new Button();
        //    ProjectileImageChooseButton.Text = "选择图片";
        //    ProjectileImageChooseButton.Height = h3;
        //    ProjectileImageChooseButton.Width = w3;
        //    ProjectileImageChooseButton.Location = new Point(r2, y * 3 + d * 3);
        //    OpenFileDialog ProjectileImageOpenFileDialog = new OpenFileDialog();

        //    Label ProjectileImagePathLabel = new Label();
        //    ProjectileImagePathLabel.Text = "";
        //    ProjectileImagePathLabel.Width = 900;
        //    ProjectileImagePathLabel.Location = new Point(r2 + 140, y * 3 + d * 3 + 5);


        //    //ImageShow
        //    PictureBox ProjectileImageChooseBox = new PictureBox();
        //    ProjectileImageChooseBox.SizeMode = PictureBoxSizeMode.Zoom;
        //    ProjectileImageChooseBox.Width = 100;
        //    ProjectileImageChooseBox.Height = 100;
        //    ProjectileImageChooseBox.Location = new Point(r2 + 850, y * 1 + d * 1 - 10);
        //    ProjectileImageChooseBox.Image = null; //默认无图片





        //    string ProjectileImagePath = "";

        //    ProjectileImageChooseButton.Click += new EventHandler(ProjectileImageChooseButton_click);

        //    void ProjectileImageChooseButton_click(object sender, EventArgs e)  //ClickTheButtonToChooseImage
        //    {
        //        if (string.IsNullOrEmpty(namespacetextbox.Text))
        //        {
        //            MessageBox.Show("请先输入射弹定义名", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            return;
        //        }
        //        ProjectileImageOpenFileDialog.Filter = "PNG|*.png";
        //        ProjectileImageOpenFileDialog.Title = "选择物品图片";
        //        DialogResult imagechoosefile_result = ProjectileImageOpenFileDialog.ShowDialog();
        //        if (imagechoosefile_result == DialogResult.OK)
        //        {
        //            ProjectileImagePath = ProjectileImageOpenFileDialog.FileName;
        //            ProjectileImagePathLabel.Text = ProjectileImagePath;


        //            //Let ImageChooseBox Show Image
        //            try
        //            {
        //                ProjectileImageChooseBox.Image = Image.FromFile(ProjectileImagePath);
        //            }
        //            catch (Exception ex)
        //            {
        //                //MessageBox.Show($"图片加载失败: {ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //                ProjectileImageChooseBox.Image = null;
        //            }

        //        }


        //    }








        //    //Width
        //    Label ProjectileWidth = new Label();
        //    ProjectileWidth.Text = "射弹宽度";
        //    ProjectileWidth.Location = new Point(r1, y * 4 + d * 4);
        //    NumericUpDown ProjectileWidthNumericUpDown = new NumericUpDown();
        //    ProjectileWidthNumericUpDown.Value = 32;
        //    ProjectileWidthNumericUpDown.Minimum = 1;
        //    ProjectileWidthNumericUpDown.Location = new Point(r2,y*4+ d * 4);
        //    ProjectileWidthNumericUpDown.Font = new Font("Microsoft YaHei UI", 11);
        //    ProjectileWidthNumericUpDown.Width = w2;

        //    //Height
        //    Label ProjectileHeight = new Label();
        //    ProjectileHeight.Text = "射弹高度";
        //    ProjectileHeight.Location = new Point(r1, y * 5 + d * 5);
        //    NumericUpDown ProjectileHeightNumericUpDown = new NumericUpDown();
        //    ProjectileHeightNumericUpDown.Value = 32;
        //    ProjectileHeightNumericUpDown.Minimum = 1;
        //    ProjectileHeightNumericUpDown.Location = new Point(r2, y * 5 + d * 5);
        //    ProjectileHeightNumericUpDown.Font = new Font("Microsoft YaHei UI", 11);
        //    ProjectileHeightNumericUpDown.Width = w2;

        //    //


        //    itempanel.Controls.Add(title);
        //    itempanel.Controls.Add(namespacelabel);
        //    itempanel.Controls.Add(namespacetextbox);
        //    itempanel.Controls.Add(namelabel);
        //    itempanel.Controls.Add(nametextbox);
        //    itempanel.Controls.Add(ProjectileWidth);
        //    itempanel.Controls.Add(ProjectileWidthNumericUpDown);
        //    itempanel.Controls.Add(ProjectileHeight);
        //    itempanel.Controls.Add(ProjectileHeightNumericUpDown);
        //    itempanel.Controls.Add(ProjectileImageLabel);
        //    itempanel.Controls.Add(ProjectileImageChooseButton);
        //    itempanel.Controls.Add(ProjectileImagePathLabel);
        //    itempanel.Controls.Add(ProjectileImageChooseBox);

        //    itempanel.AutoScroll = true;

        //}







        //    if (this.list.Groups[0].Items[0].Selected)
        //    {
        //        itempanel.Controls.Clear();
        //        AddItemtoPanel_NewTMLItem();
        //    }
        //    if (this.list.Groups[0].Items[1].Selected)
        //    {
        //        itempanel.Controls.Clear();
        //        AddItemtoPanel_NewTMLProjectile();
        //    }
        //    if (this.list.Groups[1].Items[0].Selected)
        //    {
        //        itempanel.Controls.Clear();
        //        AddItemtoPanel_NewCodes();

        //    }







        private void list_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Create Item
            if (list.Groups[0].Items[0].Selected)
            {
                CreateGroupBox.Text = "创建物品";
                CreateGroupBox.Controls.Clear();

                Label ItemNameLabel = new Label();
                ItemNameLabel.Text = "物品名称:";
                ItemNameLabel.Location = new Point(10, 20);
                TextBox ItemNameTextBox = new TextBox();
                ItemNameTextBox.Width = 300;
                ItemNameTextBox.Location = new Point(120, 20);

                Label ItemNamespaceLabel = new Label();
                ItemNamespaceLabel.Text = "物品定义名:";
                ItemNamespaceLabel.Location = new Point(10, 45);
                TextBox ItemNamespaceTextBox = new TextBox();
                ItemNamespaceTextBox.Width = 300;
                ItemNamespaceTextBox.Location = new Point(120, 45);

                Button CreateItemButton = new Button();
                CreateItemButton.Text = "创建";
                CreateItemButton.Location = new Point(10, 70);

                CreateItemButton.Click += new EventHandler(CreateItemButton_Click);
                void CreateItemButton_Click(object sender, EventArgs e)
                {
                    if (string.IsNullOrEmpty(ItemNamespaceTextBox.Text) || string.IsNullOrEmpty(ItemNameTextBox.Text))
                    {
                        MessageBox.Show("请填写物品名称和定义名", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    foreach (var EveryNamespaceChar in ItemNamespaceTextBox.Text)
                    {
                        if (!char.IsLetterOrDigit(EveryNamespaceChar) && EveryNamespaceChar != '_')
                        {
                            MessageBox.Show("物品定义名只能包含字母、数字和下划线", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }



                    string ItemCodes = "";
                    ItemCodes =
                        "using Terraria;" + Environment.NewLine +
                        "using Terraria.ID;" + Environment.NewLine +
                        "using Terraria.ModLoader;" + Environment.NewLine +
                      $"namespace {ProjectData.ProjectNamespace}.Items" + Environment.NewLine +
                        "{" + Environment.NewLine +
                      $"    public class {ItemNamespaceTextBox.Text} : ModItem" + Environment.NewLine +
                        "    {" + Environment.NewLine +
                        "        public override void SetDefaults()" + Environment.NewLine +
                        "        {" + Environment.NewLine + Environment.NewLine +

                        "        }" + Environment.NewLine +
                        "    }" + Environment.NewLine +
                        "}";


                    try
                    {
                        File.WriteAllText(Path.Combine(ProjectData.ProjectPath, "Items", ItemNamespaceTextBox.Text + ".cs"), ItemCodes, Encoding.UTF8);
                        MessageBox.Show($"物品代码已生成:\n{ItemCodes}\n", "代码预览", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"保存物品代码失败: {ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                }


                CreateGroupBox.Controls.Add(ItemNamespaceLabel);
                CreateGroupBox.Controls.Add(ItemNamespaceTextBox);
                CreateGroupBox.Controls.Add(ItemNameTextBox);
                CreateGroupBox.Controls.Add(ItemNameLabel);
                CreateGroupBox.Controls.Add(CreateItemButton);

            }

            //Create Projectile
            if (list.Groups[0].Items[1].Selected)
            {
                CreateGroupBox.Text = "创建射弹";
                CreateGroupBox.Controls.Clear();

                Label ProjectileNameLabel = new Label();
                ProjectileNameLabel.Text = "射弹名称:";
                ProjectileNameLabel.Location = new Point(10, 20);
                TextBox ProjectileNameTextBox = new TextBox();
                ProjectileNameTextBox.Width = 300;
                ProjectileNameTextBox.Location = new Point(120, 20);
                Label ProjectileNamespaceLabel = new Label();

                ProjectileNamespaceLabel.Text = "射弹定义名:";
                ProjectileNamespaceLabel.Location = new Point(10, 45);
                TextBox ProjectileNamespaceTextBox = new TextBox();
                ProjectileNamespaceTextBox.Width = 300;
                ProjectileNamespaceTextBox.Location = new Point(120, 45);

                Button CreateProjectileButton = new Button();
                CreateProjectileButton.Text = "创建";
                CreateProjectileButton.Location = new Point(10, 70);

                CreateProjectileButton.Click += new EventHandler(CreateProjectileButton_Click);
                void CreateProjectileButton_Click(object sender, EventArgs e)
                {
                    if (string.IsNullOrEmpty(ProjectileNamespaceTextBox.Text) || string.IsNullOrEmpty(ProjectileNameTextBox.Text))
                    {
                        MessageBox.Show("请填写射弹名称和定义名", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    foreach (var EveryNamespaceChar in ProjectileNamespaceTextBox.Text)
                    {
                        if (!char.IsLetterOrDigit(EveryNamespaceChar) && EveryNamespaceChar != '_')
                        {
                            MessageBox.Show("射弹定义名只能包含字母、数字和下划线", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    string ProjectileCodes = "";
                    ProjectileCodes =
                        "using Terraria;" + Environment.NewLine +
                        "using Terraria.ID;" + Environment.NewLine +
                        "using Terraria.ModLoader;" + Environment.NewLine +
                      $"namespace {ProjectData.ProjectNamespace}.Projectiles" + Environment.NewLine +
                        "{" + Environment.NewLine +
                      $"    public class {ProjectileNamespaceTextBox.Text} : ModProjectile" + Environment.NewLine +
                        "    {" + Environment.NewLine +
                        "        public override void SetDefaults()" + Environment.NewLine +
                        "        {" + Environment.NewLine + Environment.NewLine +

                        "        }" + Environment.NewLine +
                        "    }" + Environment.NewLine +
                        "}";

                    try
                    {
                        File.WriteAllText(Path.Combine(ProjectData.ProjectPath, "Projectiles", ProjectileNamespaceTextBox.Text + ".cs"), ProjectileCodes, Encoding.UTF8);
                        MessageBox.Show($"物品代码已生成:\n{ProjectileCodes}\n", "代码预览", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"保存射弹代码失败: {ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                }


                CreateGroupBox.Controls.Add(ProjectileNamespaceLabel);
                CreateGroupBox.Controls.Add(ProjectileNamespaceTextBox);
                CreateGroupBox.Controls.Add(ProjectileNameTextBox);
                CreateGroupBox.Controls.Add(ProjectileNameLabel);
                CreateGroupBox.Controls.Add(CreateProjectileButton);

            }

            //Create Tile (2025.7.5)
            if (list.Groups[0].Items[2].Selected)
            {
                CreateGroupBox.Text = "创建物块";
                CreateGroupBox.Controls.Clear();
            }

            //Create NPC (2025.7.6)
            if (list.Groups[0].Items[3].Selected)
            {
                CreateGroupBox.Text = "创建NPC";
                CreateGroupBox.Controls.Clear();
            }

            //Create Text/Code File (2025.7.4)

        }

        private void ObjectName_Click(object sender, EventArgs e)
        {

        }

        private void AddItem_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main.Fresh();
        }

    }
}
