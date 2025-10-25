using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using TerraCreator.projectsettings;

namespace TerraCreator
{
    public partial class ProjectSettings : Form
    {
        public ProjectSettings()
        {
            InitializeComponent();
        }

        private void ProjectSettings_Load(object sender, EventArgs e)
        {
            this.BackColor = TerraCreatorData.FormBackColor;
            SettingsListView.BackColor = TerraCreatorData.FormToolColor;
            SettingsPanel.BackColor = TerraCreatorData.FormToolColor;
        }

        private void SettingsListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.SettingsListView.Groups[0].Items[0].Selected)
            {
                SettingsPanel.Controls.Clear();
                Form OutlookSettingsForm = new OutlookSettings();
                OutlookSettingsForm.TopLevel = false;

                OutlookSettingsForm.Show();
                SettingsPanel.Controls.Add(OutlookSettingsForm);
            }
            if (this.SettingsListView.Groups[0].Items[1].Selected)
            {
                SettingsPanel.Controls.Clear();
                Form SaveLocationSettings = new SaveLocationSettings();
                SaveLocationSettings.TopLevel = false;

                SaveLocationSettings.Show();
                SettingsPanel.Controls.Add(SaveLocationSettings);
            }
        }
























        //OldCode
        void DefaultCodesSaveLocationSettings()
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

            Label title = new Label();
            title.Text = "代码保存位置设置";
            title.Height = 35;
            title.Location = new Point(2, y * 0);
            title.Font = new Font("Microsoft YaHei UI", 12);
            title.AutoSize = true;

            //Mod Item Save Path
            Label ModItemSavePathLabel = new Label();
            ModItemSavePathLabel.Text = "ModItem保存路径: \\"+ProjectData.ProjectNamespace+"\\Items\\";
            ModItemSavePathLabel.Location = new Point(r1, y + 2);
            ModItemSavePathLabel.AutoSize = true;

            Label ModProjectileSavePathLabel = new Label();
            ModProjectileSavePathLabel.Text = "ModProjectile保存路径: \\" + ProjectData.ProjectNamespace + "\\Projectiles\\";
            ModProjectileSavePathLabel.Location = new Point(r1, y * 2 + d * 2);
            ModProjectileSavePathLabel.AutoSize = true;

            Label Notice = new Label();
            Notice.Text = "预计2025.9.1更新";
            Notice.Location = new Point(r1, y * 3 + d * 3);
            Notice.AutoSize = true;

            SettingsPanel.Controls.Add(title);
            SettingsPanel.Controls.Add(ModItemSavePathLabel);
            SettingsPanel.Controls.Add(ModProjectileSavePathLabel);
            SettingsPanel.Controls.Add(Notice);


        }


















        void BasicSettings()
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

            string DisplayName="";
            string Author = "";
            string Version = "";
            string Description = "";
            //string Descriptin_Workshop = "";

            string[] BuildFileContent;
            //string Description_WorkshopFileContent;
            string DescriptionFileContent;

            string BuildFilePath = ProjectData.ProjectPath + "\\build.txt";
            string DescriptionFilePath = ProjectData.ProjectPath + "\\description.txt";
            //string Description_WorkshopFilePath = ProjectData.ProjectPath + "\\description_workshop.txt";



            Label title = new Label();
            title.Text = "项目配置";
            title.Height = 35;
            title.Location = new Point(2, y * 0);
            title.Font = new Font("Microsoft YaHei UI", 12);
            title.AutoSize = true;

            //Display Name
            Label DisplayNameLabel = new Label();
            DisplayNameLabel.Text = "模组展示名";
            DisplayNameLabel.Location = new Point(r1, y + 2);
            DisplayNameLabel.AutoSize= true;
            TextBox DisplayNameTextBox = new TextBox();
            DisplayNameTextBox.Width = w1;
            DisplayNameTextBox.Font = new Font("Microsoft YaHei UI", 11);
            DisplayNameTextBox.Location = new Point(r2, y + 2);

            //Author
            Label AuthorLabel = new Label();
            AuthorLabel.Text = "模组作者";
            AuthorLabel.Location = new Point(r1, y*2 + d * 2);
            AuthorLabel.AutoSize = true;
            TextBox AuthorTextBox = new TextBox();
            AuthorTextBox.Width = w1;
            AuthorTextBox.Font = new Font("Microsoft YaHei UI", 11);
            AuthorTextBox.Location = new Point(r2, y * 2 + d * 2);

            //Version
            Label VersionLabel = new Label();
            VersionLabel.Text = "模组版本号";
            VersionLabel.Location = new Point(r1, y * 3 + d * 3);
            VersionLabel.AutoSize = true;
            TextBox VersionTextBox = new TextBox();
            VersionTextBox.Width = w1;
            VersionTextBox.Font = new Font("Microsoft YaHei UI", 11);
            VersionTextBox.Location = new Point(r2, y * 3 + d * 3);


            //Description
            Label DescriptionLabel = new Label();
            DescriptionLabel.Text = "模组描述";
            DescriptionLabel.Location = new Point(r1, y * 4 + d * 4);
            DescriptionLabel.AutoSize = true;
            RichTextBox DescriptionTextBox = new RichTextBox();
            DescriptionTextBox.Width = w1;
            DescriptionTextBox.Height = h4;
            DescriptionTextBox.Font = new Font("Microsoft YaHei UI", 11);
            DescriptionTextBox.Location = new Point(r2, y * 4 + d * 4);
            DescriptionTextBox.LanguageOption= RichTextBoxLanguageOptions.UIFonts;

            //Language Mods
            Label LanguageModsLabel = new Label();
            LanguageModsLabel.Text = "语言化模组";
            LanguageModsLabel.Location = new Point(r1, y * 4 + d * 4);
            LanguageModsLabel.AutoSize = true;
            //Needed Mods
            //Logo
            //WIP(Update Later)

            try
            {
                BuildFileContent = System.IO.File.ReadAllLines(BuildFilePath);
                Description = System.IO.File.ReadAllText(DescriptionFilePath);
                //Descriptin_Workshop = System.IO.File.ReadAllText(Description_WorkshopFilePath);

                try
                {
                    Regex CheckDisplayName = new Regex(@"^displayName\s*=\s*(.+)$", RegexOptions.IgnoreCase);
                    Regex CheckAuthor = new Regex(@"^author\s*=\s*(.+)$", RegexOptions.IgnoreCase);
                    Regex CheckVersion = new Regex(@"^version\s*=\s*(.+)$", RegexOptions.IgnoreCase);

                    foreach (var line in BuildFileContent)
                    {
                        if (CheckDisplayName.IsMatch(line)) 
                            DisplayNameTextBox.Text = line.Replace("displayName = ", "").Trim();
                        if (CheckAuthor.IsMatch(line)) 
                            AuthorTextBox.Text = line.Replace("author = ", "").Trim();
                        if (CheckVersion.IsMatch(line)) 
                            VersionTextBox.Text = line.Replace("version = ", "").Trim();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"分析build.txt失败: {ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                DescriptionTextBox.Text = Description;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"读取文件失败: {ex.Message}\n很可能文件破坏", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


















            //Save Button
            Button SaveButton = new Button();
            SaveButton.Text = "保存设置";
            SaveButton.Width = w3;
            SaveButton.Height = h3;
            SaveButton.Location = new Point(r1, y * 8 + d * 8);
            SaveButton.Click+=new EventHandler(SaveButton_Click);

            void SaveButton_Click(object sender, EventArgs e)
            {

                if (DisplayNameTextBox.Text=="" || AuthorTextBox.Text=="" || VersionTextBox.Text=="" || DescriptionTextBox.Text=="")
                {
                    MessageBox.Show($"请将上面文字框全填满再保存", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
        


                string WriteBuild =
                    "displayName = " + DisplayNameTextBox.Text + "\r\n" +
                    "author = " + AuthorTextBox.Text + "\r\n" +
                    "version = " + VersionTextBox.Text + "\r\n";

                string WriteDescription = DescriptionTextBox.Text;

                try
                {
                    System.IO.File.WriteAllText(BuildFilePath, WriteBuild, Encoding.UTF8);
                    MessageBox.Show("build.txt已保存！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ProjectData.ProjectBuild = WriteBuild;
                }
                catch(Exception ex) 
                {
                    MessageBox.Show($"保存失败: {ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }

                try
                {
                    System.IO.File.WriteAllText(DescriptionFilePath, WriteDescription, Encoding.UTF8);
                    //System.IO.File.WriteAllText(Description_WorkshopFilePath, WriteDescription, Encoding.UTF8);
                    MessageBox.Show("description.txt已保存！\n请手动保存description_workshop.txt", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ProjectData.ProjectDescription = WriteDescription;
                }
                catch (Exception ex) 
                {
                    MessageBox.Show($"保存失败: {ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }



            }

            SettingsPanel.Controls.Add(title);
            SettingsPanel.Controls.Add(DescriptionTextBox);
            SettingsPanel.Controls.Add(DescriptionLabel);
            SettingsPanel.Controls.Add(AuthorTextBox);
            SettingsPanel.Controls.Add(AuthorLabel);
            SettingsPanel.Controls.Add(DisplayNameTextBox);
            SettingsPanel.Controls.Add(DisplayNameLabel);
            SettingsPanel.Controls.Add(VersionLabel);
            SettingsPanel.Controls.Add(VersionTextBox);
            SettingsPanel.Controls.Add(SaveButton);
            SettingsPanel.AutoScroll = true;
            
            //SettingsPanel.HorizontalScroll.Enabled = false;
        }





    }
}
