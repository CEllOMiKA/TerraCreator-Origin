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




        private void AddItemtoPanel_NewTMLItem()
        {
            int y = 40; //distance
            int d = 2; //distance down

            int w1 = 600; //main
            int w2 = 500; //other
            int w3 = 120; //button

            int h3 = y - 5; //button
            int h4 = 145; //richbox

            int r1 = 16;//right
            int r2 = 132;//mid

            string codes = "";

            //title
            Label title = new Label();
            title.Text = "物品";
            title.Height = 35;
            title.Location = new Point(2, y * 0);
            title.Font = new Font("Microsoft YaHei UI", 12);

            //name
            Label namelabel = new Label();
            namelabel.Text = "物品名称";
            namelabel.Location = new Point(r1, y + 2);
            TextBox nametextbox = new TextBox();
            nametextbox.Width = w1;
            nametextbox.Font = new Font("Microsoft YaHei UI", 11);
            nametextbox.Location = new Point(r2, y + 2);

            //namespace
            Label namespacelabel = new Label();
            namespacelabel.Text = "物品定义名";
            namespacelabel.Location = new Point(r1, y * 2 + d*2);
            TextBox namespacetextbox = new TextBox();
            namespacetextbox.Width = w1;
            namespacetextbox.Font = new Font("Microsoft YaHei UI", 11);
            namespacetextbox.Location = new Point(r2, y * 2 + d*2);

            //image
            Label imagelabel = new Label();
            imagelabel.Text = "物品图片";
            imagelabel.Location = new Point(r1, y * 3 + d*3);
            Button imagechoosebutton = new Button();
            imagechoosebutton.Text = "选择图片";
            imagechoosebutton.Height = h3;
            imagechoosebutton.Width = w3;
            imagechoosebutton.Location = new Point(r2, y * 3 + d*3);
            OpenFileDialog imagechoosefile = new OpenFileDialog();

            Label ImagePath = new Label();
            ImagePath.Text = "";
            ImagePath.Width = 900;
            ImagePath.Location = new Point(r2+140, y * 3 + d * 3 + 5);

            string imagePath = "";

            imagechoosebutton.Click += new EventHandler(itemimagechoosebutton_click);
            void itemimagechoosebutton_click(object sender, EventArgs e)
            {
                if (string.IsNullOrEmpty(namespacetextbox.Text))
                {
                    MessageBox.Show("请先输入物品定义名", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                imagechoosefile.Filter = "PNG|*.png";
                imagechoosefile.Title = "选择物品图片";
                DialogResult imagechoosefile_result = imagechoosefile.ShowDialog();
                if (imagechoosefile_result == DialogResult.OK)
                {
                     imagePath = imagechoosefile.FileName;
                    ImagePath.Text = imagePath;
                }

               
            }

            //damagetype
            Label damagetypelabel = new Label();
            damagetypelabel.Text = "物品类型";
            damagetypelabel.Location = new Point(r1, y * 4 + d * 4);
            ComboBox damagetypecombobox = new ComboBox();
            damagetypecombobox.Font = new Font("Microsoft YaHei UI", 11);
            damagetypecombobox.Items.Add("/*战士*/DamageClass.Melee");
            damagetypecombobox.Items.Add("/*战士(不吃攻速加成)*/DamageClass.MeleeNoSpeed");
            damagetypecombobox.Items.Add("/*射手*/DamageClass.Ranged");
            damagetypecombobox.Items.Add("/*法师*/DamageClass.Magic");
            damagetypecombobox.Items.Add("/*召唤*/DamageClass.Summon");
            damagetypecombobox.Items.Add("/*全属性*/DamageClass.Generic");
            damagetypecombobox.Items.Add("/*无属性*/DamageClass.Default");
            damagetypecombobox.Width = 500;
            damagetypecombobox.Font = new Font("Microsoft YaHei UI", 11);
            damagetypecombobox.Location = new Point(r2, y * 4 + d * 4);

            //damage
            Label damagelabel = new Label();
            damagelabel.Text = "物品伤害";
            damagelabel.Location = new Point(r1, y * 5 + d * 5);
            NumericUpDown damagetextbox = new NumericUpDown();
            damagetextbox.Maximum = 10000000;
            damagetextbox.Minimum = 0;
            damagetextbox.Width = w2;
            damagetextbox.Font = new Font("Microsoft YaHei UI", 11);
            damagetextbox.Location = new Point(r2, y * 5 + d * 5);

            //knockback
            Label knockbacklabel = new Label();
            knockbacklabel.Text = "物品击退";
            knockbacklabel.Location = new Point(r1, y * 6 + d * 6);
            NumericUpDown knockbacktextbox = new NumericUpDown();
            knockbacktextbox.Maximum = 1000;
            knockbacktextbox.Minimum = 0;
            knockbacktextbox.Width = w2;
            knockbacktextbox.Font = new Font("Microsoft YaHei UI", 11);
            knockbacktextbox.Location = new Point(r2, y * 6 + d * 6);

            // usetime
            Label useTimeLabel = new Label();
            useTimeLabel.Text = "使用时间";
            useTimeLabel.Location = new Point(r1, y * 7 + d * 7);
            NumericUpDown useTimeNumeric = new NumericUpDown();
            useTimeNumeric.Maximum = 1000;
            useTimeNumeric.Minimum = 1;
            useTimeNumeric.Width = w2;
            useTimeNumeric.Font = new Font("Microsoft YaHei UI", 11);
            useTimeNumeric.Location = new Point(r2, y * 7 + d * 7);

            // max stack
            Label maxStackLabel = new Label();
            maxStackLabel.Text = "最大堆叠";
            maxStackLabel.Location = new Point(r1, y * 8 + d * 8);
            NumericUpDown maxStackNumeric = new NumericUpDown();
            maxStackNumeric.Maximum = 9999;
            maxStackNumeric.Minimum = 1;
            maxStackNumeric.Width = w2;
            maxStackNumeric.Font = new Font("Microsoft YaHei UI", 11);
            maxStackNumeric.Location = new Point(r2, y * 8 + d * 8);




            //codespreview
            Button codespreviewlabel = new Button();
            codespreviewlabel.Text = "代码预览";
            codespreviewlabel.Height = h3;
            codespreviewlabel.Width = w3;
            codespreviewlabel.Location = new Point(r1, y * 10 + d * 10);
            codespreviewlabel.Click += new EventHandler(itemcodespreviewlabel_click);

            void itemcodespreviewlabel_click(object sender, EventArgs e)
            {
                WriteCodes();
                MessageBox.Show(codes, "代码预览", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }



            //savebutton
            Button saveButton = new Button();
            saveButton.Text = "保存代码";
            saveButton.Height = h3;
            saveButton.Width = w3;
            saveButton.Location = new Point(r1, y * 11 + d * 11);
            saveButton.Click += new EventHandler(saveButton_Click);
            void saveButton_Click(object sender, EventArgs e)
            {
                WriteCodes();

                if (string.IsNullOrEmpty(imagePath))
                {
                    MessageBox.Show("请先选择图片", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //CopyImage
                DialogResult ConfirmCopy = MessageBox.Show($"图片复制到项目文件夹会覆盖文件" +
                    $"\n文件代码生成也会覆盖文件" +
                    $"\n文件夹地址:{ProjectData.ProjectPath + "\\Items\\"}", 
                    "提示", 
                    MessageBoxButtons.YesNo, 
                    MessageBoxIcon.Question
                    );
                if (ConfirmCopy == DialogResult.Yes)
                {

                    try
                    {
                        System.IO.File.Copy(imagePath, ProjectData.ProjectPath + "\\Items\\" + namespacetextbox.Text + ".png", true);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"复制失败: {ex.Message}\n请手动复制图片至文件夹", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                //CopyCodes
                string filePath = ProjectData.ProjectPath+"\\Items\\"+ namespacetextbox.Text + ".cs";
                try
                {
                    System.IO.File.WriteAllText(filePath, codes, Encoding.UTF8);
                    MessageBox.Show($"代码保存成功\n文件地址:{filePath}", "保存成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"保存失败: {ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }


            //WriteCodes
            void WriteCodes()
            {

                if (string.IsNullOrEmpty(namespacetextbox.Text))
                {
                    MessageBox.Show("请先输入物品定义名", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                codes = "";
                codes +=
                    "using Terraria;" + Environment.NewLine +
                    "using Terraria.ID;" + Environment.NewLine +
                    "using Terraria.ModLoader;" + Environment.NewLine +
                  $"namespace {ProjectData.ProjectNamespace}" + Environment.NewLine +
                    "{" + Environment.NewLine +
                  $"    public class {namespacetextbox.Text} : ModItem" + Environment.NewLine +
                    "    {" + Environment.NewLine +
                    "          public override void SetDefaults()" + Environment.NewLine +
                    "          {" + Environment.NewLine +
                  $"               Item.DamageType = {damagetypecombobox.Text};" + Environment.NewLine +
                  $"               Item.damage = {damagetextbox.Value};" + Environment.NewLine +
                  $"               Item.knockBack = {knockbacktextbox.Value};" + Environment.NewLine +
                  $"               Item.useTime = {useTimeNumeric.Value};" + Environment.NewLine +
                  $"               Item.maxStack = {maxStackNumeric.Value};" + Environment.NewLine +
                    "          }" + Environment.NewLine +
                    "    }" + Environment.NewLine +
                    "}";
            }



            //addtopanel
            itempanel.Controls.Add(title);
            itempanel.Controls.Add(namelabel);
            itempanel.Controls.Add(nametextbox);
            itempanel.Controls.Add(namespacelabel);
            itempanel.Controls.Add(namespacetextbox);
            itempanel.Controls.Add(imagelabel);
            itempanel.Controls.Add(imagechoosebutton);
            itempanel.Controls.Add(ImagePath);
            itempanel.Controls.Add(damagetypelabel);
            itempanel.Controls.Add(damagetypecombobox);
            itempanel.Controls.Add(damagelabel);
            itempanel.Controls.Add(damagetextbox);
            itempanel.Controls.Add(knockbacklabel);
            itempanel.Controls.Add(knockbacktextbox);
            itempanel.Controls.Add(useTimeLabel);
            itempanel.Controls.Add(useTimeNumeric);
            itempanel.Controls.Add(maxStackLabel);
            itempanel.Controls.Add(maxStackNumeric);
            itempanel.Controls.Add(codespreviewlabel);
            itempanel.Controls.Add(saveButton);
        }






        void AddItemtoPanel_NewCodes()
        {
            int y = 40; //distance
            int d = 2; //distance down

            int w1 = 600; //main
            int w2 = 500; //other
            int w3 = 120; //button

            int h3 = y - 5; //button
            int h4 = 145; //richbox

            int r1 = 16;//right
            int r2 = 132;//mid

           

            //title
            Label title = new Label();
            title.Text = "文本/代码文件";
            title.Height = 35;
            title.Width = 300;
            title.Location = new Point(2, y * 0);
            title.Font = new Font("Microsoft YaHei UI", 12);

            //name
            Label namelabel = new Label();
            namelabel.Text = "文件名称";
            namelabel.Location = new Point(r1, y + 2);
            TextBox nametextbox = new TextBox();
            nametextbox.Width = w1;
            nametextbox.Font = new Font("Microsoft YaHei UI", 11);
            nametextbox.Location = new Point(r2, y + 2);

            //path
            Label SavePathLabel = new Label();
            SavePathLabel.Text = "保存位置";
            SavePathLabel.Location = new Point(r1, y * 2 + d * 2);
            Button SavePathChooseButton = new Button();
            SavePathChooseButton.Text = "选择位置";
            SavePathChooseButton.Height = h3;
            SavePathChooseButton.Width = w3;
            SavePathChooseButton.Location = new Point(r2, y * 2 + d * 2);
            FolderBrowserDialog SavePathChooseDialog= new FolderBrowserDialog();
            Label SavePath = new Label();
            SavePath.Text = "";
            SavePath.Width = 900;
            SavePath.Location = new Point(r2 + 140, y * 2 + d * 2 + 5);
            string SelectPath = "";
            SavePathChooseButton.Click += new EventHandler(SavePathChooseDialog_click);
            
            void SavePathChooseDialog_click(object sender, EventArgs e)
            {
                
                DialogResult SavePathChooseDialog_result = SavePathChooseDialog.ShowDialog();

                if (SavePathChooseDialog_result == DialogResult.OK)
                {
                    
                    SelectPath = SavePathChooseDialog.SelectedPath;
                    SavePath.Text = SelectPath;
                }
            }

            //savebutton
            Button saveButton = new Button();
            saveButton.Text = "保存文件";
            saveButton.Height = h3;
            saveButton.Width = w3;
            saveButton.Location = new Point(r1, y * 4 + d * 4);
            saveButton.Click += new EventHandler(saveButton_Click);
            void saveButton_Click(object sender, EventArgs e)
            {
                if (string.IsNullOrEmpty(nametextbox.Text) || string.IsNullOrEmpty(SelectPath))
                {
                    MessageBox.Show("文件名或保存文件位置未指定", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                //CopyCodes
                try
                {
                    System.IO.File.WriteAllText(SelectPath+"\\"+nametextbox.Text, "", Encoding.UTF8);
                    MessageBox.Show($"文件创建成功\n文件地址:{SelectPath + "\\" + nametextbox.Text}", "创建成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"创建失败: {ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

            itempanel.Controls.Add(title);
            itempanel.Controls.Add(namelabel);
            itempanel.Controls.Add(nametextbox);
            itempanel.Controls.Add(SavePathChooseButton);
            itempanel.Controls.Add(SavePathLabel);
            itempanel.Controls.Add(SavePath);
            itempanel.Controls.Add(saveButton);
        }




        private void list_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (this.list.Groups[0].Items[0].Selected)
            {
                itempanel.Controls.Clear();
                AddItemtoPanel_NewTMLItem();
            }
            if (this.list.Groups[0].Items[1].Selected)
            {
                itempanel.Controls.Clear();
            }
            if (this.list.Groups[1].Items[0].Selected)
            {
                itempanel.Controls.Clear();
                AddItemtoPanel_NewCodes();

            }

        }

        
    }
}
