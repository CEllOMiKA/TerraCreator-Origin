using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TerraCreator
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }


        Color FormBackColor = TerraCreatorData.FormBackColor;
        Color FormToolColor = TerraCreatorData.FormToolColor;
        string Language = TerraCreatorData.Language;


        private void Settings_ColorSetting()
        {
            int y = 40; //distance
            int d = 2; //distance down

            int w1 = 800; //main
            int w2 = 500; //other
            int w3 = 120; //button

            int h3 = y - 5; //button
            int h4 = 145; //richbox

            int r1 = 16;//right
            int r2 = 132;//mid


            //title
            Label title = new Label();
            title.Text = "颜色";
            title.Height = 35;
            title.Location = new Point(2, y * 0);
            title.Font = new Font("Microsoft YaHei UI", 12);

            //ChooseBackgroundColor
            Label ChooseBackgroundColorLabel = new Label();
            ChooseBackgroundColorLabel.Text = "窗体颜色";
            ChooseBackgroundColorLabel.Location = new Point(r1, y * 1 + d * 1);
            Button ChooseBackgroundColorButton = new Button();
            ChooseBackgroundColorButton.Text = "选择颜色";
            ChooseBackgroundColorButton.Height = h3;
            ChooseBackgroundColorButton.Width = w3;
            ChooseBackgroundColorButton.Location = new Point(r2, y * 1 + d * 1 - 5);
            ColorDialog ChooseBackgroundColor = new ColorDialog();
            Label ShowChoosedBackgroundColor = new Label();
            ShowChoosedBackgroundColor.Text = "未选择颜色";
            ShowChoosedBackgroundColor.ForeColor = FormBackColor;
            ShowChoosedBackgroundColor.BackColor = Color.White;
            ShowChoosedBackgroundColor.Location = new Point(r2 + 140, y * 1 + d * 1);
            ChooseBackgroundColorButton.Click += new EventHandler(ChooseBackgroundColorButton_Click);
            LinkLabel ResetChoosedBackgroundColor = new LinkLabel();
            ResetChoosedBackgroundColor.Text = "重置颜色";
            ResetChoosedBackgroundColor.Location = new Point(r2 + 140 + 150, y * 1 + d * 1);
            ResetChoosedBackgroundColor.LinkClicked += new LinkLabelLinkClickedEventHandler(ResetChoosedBackgroundColor_LinkClicked);

            void ResetChoosedBackgroundColor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
            {
                FormBackColor = TerraCreatorData.FormBackColor;
                ShowChoosedBackgroundColor.Text = "未选择颜色";
                ShowChoosedBackgroundColor.ForeColor = FormBackColor;
            }


            void ChooseBackgroundColorButton_Click(object sender, EventArgs e)
            {
                ChooseBackgroundColor.Color = TerraCreatorData.FormBackColor;
                DialogResult ChooseColorResult = ChooseBackgroundColor.ShowDialog();

                if (ChooseColorResult == DialogResult.OK)
                {
                    FormBackColor = ChooseBackgroundColor.Color;
                    ShowChoosedBackgroundColor.Text = ChooseBackgroundColor.Color.ToString();
                    ShowChoosedBackgroundColor.ForeColor = ChooseBackgroundColor.Color;
                }
            }



            //ChooseToolColor
            Label ChooseToolColorLabel = new Label();
            ChooseToolColorLabel.Text = "控件颜色";
            ChooseToolColorLabel.Location = new Point(r1, y * 2 + d * 2);
            Button ChooseToolColorButton = new Button();
            ChooseToolColorButton.Text = "选择颜色";
            ChooseToolColorButton.Height = h3;
            ChooseToolColorButton.Width = w3;
            ChooseToolColorButton.Location = new Point(r2, y * 2 + d * 2 - 5);
            ColorDialog ChooseToolColor = new ColorDialog();
            Label ShowChoosedToolColor = new Label();
            ShowChoosedToolColor.Text = "未选择颜色";
            ShowChoosedToolColor.BackColor = Color.White;
            ShowChoosedToolColor.ForeColor = FormToolColor;
            ShowChoosedToolColor.Location = new Point(r2 + 140, y * 2 + d * 2 );
            ChooseToolColorButton.Click += new EventHandler(ChooseToolColorButton_Click);
            LinkLabel ResetChoosedToolColor = new LinkLabel();
            ResetChoosedToolColor.Text = "重置颜色";
            ResetChoosedToolColor.Location = new Point(r2 + 140 + 150, y * 2 + d * 2);
            ResetChoosedToolColor.LinkClicked += new LinkLabelLinkClickedEventHandler(ResetChoosedToolColor_LinkClicked);

            void ResetChoosedToolColor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
            {
                FormToolColor = TerraCreatorData.FormToolColor;
                ShowChoosedToolColor.Text = "未选择颜色";
                ShowChoosedToolColor.ForeColor = FormToolColor;
            }

            void ChooseToolColorButton_Click(object sender, EventArgs e)
            {
                ChooseToolColor.Color = TerraCreatorData.FormToolColor;
                DialogResult ChooseColorResult = ChooseToolColor.ShowDialog();
                if (ChooseColorResult == DialogResult.OK)
                {
                    FormToolColor = ChooseToolColor.Color;
                    ShowChoosedToolColor.Text = ChooseToolColor.Color.ToString();
                    ShowChoosedToolColor.ForeColor = ChooseToolColor.Color;
                }
            }






            Panel.Controls.Add(title);
            Panel.Controls.Add(ChooseBackgroundColorLabel);
            Panel.Controls.Add(ChooseBackgroundColorButton);
            Panel.Controls.Add(ShowChoosedBackgroundColor);
            Panel.Controls.Add(ResetChoosedBackgroundColor);
            Panel.Controls.Add(ChooseToolColorLabel);
            Panel.Controls.Add(ChooseToolColorButton);
            Panel.Controls.Add(ShowChoosedToolColor);
            Panel.Controls.Add(ResetChoosedToolColor);


        }


        private void OtherSettings()
        {
            int y = 40; //distance
            int d = 2; //distance down
            int w1 = 800; //main
            int w2 = 500; //other
            int w3 = 120; //button
            int h3 = y - 5; //button
            int h4 = 145; //richbox
            int r1 = 16;//right
            int r2 = 132;//mid

            //title
            Label title = new Label();
            title.Text = "其他设置";
            title.Height = 35;
            title.Location = new Point(2, y * 0);
            title.Font = new Font("Microsoft YaHei UI", 12);
            title.AutoSize = true;

            //DeleteSettingFiles
            Label DeleteSettingFilesLabel = new Label();
            DeleteSettingFilesLabel.Text = "删除设置文件";
            DeleteSettingFilesLabel.Location = new Point(r1, y * 1 + d * 1);
            DeleteSettingFilesLabel.AutoSize = true;
            Button DeleteSettingFilesButton = new Button();
            DeleteSettingFilesButton.Text = "删除";
            DeleteSettingFilesButton.Location = new Point(r2, y * 1 + d * 1 - 5);
            DeleteSettingFilesButton.Height = h3;
            DeleteSettingFilesButton.Width = w3;
            DeleteSettingFilesButton.Click += new EventHandler(DeleteSettingFilesButton_Click);

            Label AlertLabel = new Label();
            AlertLabel.Text = "删除后别按保存!";
            AlertLabel.Location = new Point(r1, y * 2 + d * 2);
            AlertLabel.AutoSize = true;

            void DeleteSettingFilesButton_Click(object sender, EventArgs e)
            {
                if (File.Exists(TerraCreatorData.TerraCreatorConfigFileName))
                {
                    try
                    {
                        DialogResult CheckIfWant = MessageBox.Show("你确定要删除设置文件吗？\n删除后程序会在下次启动时重新生成设置文件！", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (CheckIfWant == DialogResult.Yes)
                        {
                            File.Delete(TerraCreatorData.TerraCreatorConfigFileName);
                            MessageBox.Show("设置文件已删除！\n重启程序会重生成", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("删除失败！\n" + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("文件已经被删除了！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            Panel.Controls.Add(title);
            Panel.Controls.Add(DeleteSettingFilesLabel);
            Panel.Controls.Add(DeleteSettingFilesButton);
            Panel.Controls.Add(AlertLabel);

        }










        private void Settings_Load(object sender, EventArgs e)
        {
            SettingSplit.Panel2.BackColor = TerraCreatorData.FormToolColor;
            SettingList.BackColor = TerraCreatorData.FormToolColor;
            this.BackColor = TerraCreatorData.FormBackColor;
        }



        private void SettingList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.SettingList.Groups[0].Items[0].Selected)
            {
                Panel.Controls.Clear();
                Settings_ColorSetting();
            }
            if(this.SettingList.Groups[1].Items[0].Selected)
            {
                Panel.Controls.Clear();
                OtherSettings();
            }
            if (this.SettingList.Groups[1].Items[1].Selected)
            {
                Panel.Controls.Clear();
                LanguageSettings();
            }

        }


        public void LanguageSettings()
        {
            int y = 40; //distance
            int d = 2; //distance down

            int w1 = 800; //main
            int w2 = 500; //other
            int w3 = 120; //button

            int h3 = y - 5; //button
            int h4 = 145; //richbox

            int r1 = 16;//right
            int r2 = 132;//mid


            //title
            Label title = new Label();
            title.Text = "语言";
            title.Height = 35;
            title.Location = new Point(2, y * 0);
            title.Font = new Font("Microsoft YaHei UI", 12);

            //
            Label LanguageNameLabel = new Label();
            LanguageNameLabel.Text = "语言:";
            LanguageNameLabel.Location = new Point(r1, y + 2);
            LanguageNameLabel.AutoSize = true;
            ComboBox LanguageComboBox = new ComboBox();
            LanguageComboBox.Width = w1;
            LanguageComboBox.Text = Language;
            LanguageComboBox.Items.Add("zh-CN");
            LanguageComboBox.Items.Add("en-US");
            LanguageComboBox.Font = new Font("Microsoft YaHei UI", 11);
            LanguageComboBox.Location = new Point(r2, y);
            Button ConfirmButton = new Button();
            ConfirmButton.Width = w3;
            ConfirmButton.Height =h3;
            ConfirmButton.Location = new Point(r1, y * 2 + d * 2);
            ConfirmButton.AutoSize = true;
            ConfirmButton.Text = "Confirm";
            ConfirmButton.Click += ConfirmButton_Click;

            void ConfirmButton_Click(object? sender, EventArgs e)
            {
                if (LanguageComboBox.Text == "zh-CN" || LanguageComboBox.Text == "en-US")
                    Language = LanguageComboBox.Text;
                else
                    MessageBox.Show($"我们不能保证{LanguageComboBox.Text}是否存在\n如果发现报错,请删除配置文件");
                        Language = LanguageComboBox.Text;
            }

            Panel.Controls.Add(LanguageComboBox);
            Panel.Controls.Add(LanguageNameLabel);
            Panel.Controls.Add(ConfirmButton);


        }



        private void SaveChanges_Click(object sender, EventArgs e)
        {

            try
            {
                string Data = "";
                Data =
                        "FormToolColor\r\n" +
                        FormToolColor.R + "\r\n" +
                        FormToolColor.G + "\r\n" +
                        FormToolColor.B + "\r\n" +
                        "FormBackColor\r\n" +
                        FormBackColor.R + "\r\n" +
                        FormBackColor.G + "\r\n" +
                        FormBackColor.B + "\r\n" +
                        "Language\r\n" +
                        Language;
                        
                File.WriteAllText(TerraCreatorData.TerraCreatorConfigFileName, Data);
                MessageBox.Show("保存成功！\n 设置重启程序有效", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("保存失败！\n" + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
