using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TerraCreator.projectsettings
{
    public partial class OutlookSettings : Form
    {
        string DisplayName = "";
        string Author = "";
        string Version = "";
        string Description = "";
        string Description_Workshop = "";
        Image Icon = null;
        Image IconSWS = null;

        string[] BuildFileContent = { "" };
        string Description_WorkshopFileContent;
        string DescriptionFileContent;

        string BuildFilePath = ProjectData.ProjectPath + "\\build.txt";
        string DescriptionFilePath = ProjectData.ProjectPath + "\\description.txt";
        string Description_WorkshopFilePath = ProjectData.ProjectPath + "\\description_workshop.txt";

        string IconPath = ProjectData.ProjectPath + "\\icon.png";
        string IconSWSPath = ProjectData.ProjectPath + "\\icon_workshop.png";
        string IconOriginPath = ProjectData.ProjectPath + "\\icon.png";
        string IconOriginSWSPath = ProjectData.ProjectPath + "\\icon_workshop.png";

        public OutlookSettings()
        {



            InitializeComponent();

            //Read File
            try
            {
                BuildFileContent = System.IO.File.ReadAllLines(BuildFilePath);
                Description = System.IO.File.ReadAllText(DescriptionFilePath);
                ProjectDescriptionRichTextBox.Text = Description;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"文件读取错误\n{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //Read SteamWorkshop Description
            try
            {
                Description_Workshop = System.IO.File.ReadAllText(Description_WorkshopFilePath);
                ProjectDescriptionSWSRichTextBox.Text = Description_Workshop;
            }
            catch (Exception ex)
            {
                //MessageBox.Show($"文件读取错误\n{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //Read Icon
            try
            {
                using (var img = Image.FromFile(IconPath))
                {
                    ProjectIconPictureBox.Image = new Bitmap(img);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"文件读取错误\n{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //Read SWS Icon
            try
            {
                using (var img = Image.FromFile(IconSWSPath))
                {
                    ProjectIconSWSPictureBox.Image = new Bitmap(img);
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show($"文件读取错误\n{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //BuildFile!!!
            try
            {
                Regex CheckDisplayName = new Regex(@"^[Dd]isplayName\s*=\s*(?<ProjectNameInFile>.+)", RegexOptions.IgnoreCase);
                Regex CheckAuthor = new Regex(@"^[Aa]uthor\s*=\s*(?<ProjectAuthor>.+)", RegexOptions.IgnoreCase);
                Regex CheckVersion = new Regex(@"^[Vv]ersion\s*=\s*(?<ProjectVersion>.+)", RegexOptions.IgnoreCase);

                foreach (var line in BuildFileContent)
                {
                    Match CheckNameMatch = CheckDisplayName.Match(line);
                    Match CheckAuthorMatch = CheckAuthor.Match(line);
                    Match CheckVersionMatch = CheckVersion.Match(line);
                    if (CheckNameMatch.Success)
                    {
                        ProjectNameTextBox.Text = CheckNameMatch.Groups["ProjectNameInFile"].Value;

                    }
                    if (CheckAuthorMatch.Success)
                    {
                        ProjectAuthorTextBox.Text = CheckAuthorMatch.Groups["ProjectAuthor"].Value;
                    }
                    if (CheckVersionMatch.Success)
                    {
                        ProjectVersionTextBox.Text = CheckVersionMatch.Groups["ProjectVersion"].Value;
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"稀有错误,匹配错误\n{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.Refresh();

        }

        // 选择图片按钮
        private void ProjectIconChooseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ChooseIconDialog = new OpenFileDialog();
            ChooseIconDialog.InitialDirectory = ProjectData.ProjectPath;
            ChooseIconDialog.Filter = "PNG图片(*.png)|*.png";
            ChooseIconDialog.Multiselect = false;
            ChooseIconDialog.CheckFileExists = true;
            DialogResult CheckResult = ChooseIconDialog.ShowDialog();
            if (CheckResult == DialogResult.OK)
            {
                using (var img = Image.FromFile(ChooseIconDialog.FileName))
                {
                    ProjectIconPictureBox.Image = new Bitmap(img);
                }
                IconPath = ChooseIconDialog.FileName;
            }

        }

        private void ProjectIconOriginButton_Click(object sender, EventArgs e)
        {
            ProjectIconPictureBox.Image = Image.FromFile(IconOriginPath);
            IconPath = IconOriginPath;
        }

        private void ProjectIconSWSChooseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ChooseIconSWSDialog = new OpenFileDialog();
            ChooseIconSWSDialog.InitialDirectory = ProjectData.ProjectPath;
            ChooseIconSWSDialog.Filter = "PNG图片(*.png)|*.png";
            ChooseIconSWSDialog.Multiselect = false;
            ChooseIconSWSDialog.CheckFileExists = true;
            DialogResult CheckResult = ChooseIconSWSDialog.ShowDialog();
            if (CheckResult == DialogResult.OK)
            {
                using (var img = Image.FromFile(ChooseIconSWSDialog.FileName))
                {
                    ProjectIconSWSPictureBox.Image = new Bitmap(img);
                }
                IconSWSPath = ChooseIconSWSDialog.FileName;
            }
        }

        private void ProjectIconSWSOriginButton_Click(object sender, EventArgs e)
        {
            ProjectIconSWSPictureBox.Image = Image.FromFile(IconOriginSWSPath);
            IconSWSPath = IconOriginSWSPath;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if
            (
                ProjectIconSWSPictureBox.Image == null ||
                ProjectIconPictureBox.Image == null ||
                ProjectNameTextBox.Text == "" ||
                ProjectVersionTextBox.Text == "" ||
                ProjectAuthorTextBox.Text == "" ||
                ProjectDescriptionRichTextBox.Text == "" ||
                ProjectDescriptionSWSRichTextBox.Text == ""
            )
            {
                MessageBox.Show("请填满所有内容", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string WriteBuildContent =
                "displayName = " + ProjectNameTextBox.Text + "\r\n" +
                "author = " + ProjectAuthorTextBox.Text + "\r\n" +
                "version = " + ProjectVersionTextBox.Text + "\r\n";

            try
            {
                System.IO.File.WriteAllText(BuildFilePath, WriteBuildContent, Encoding.UTF8);
                MessageBox.Show("build.txt已保存！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ProjectData.ProjectBuild = WriteBuildContent;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"build.txt保存失败: {ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            try
            {
                System.IO.File.WriteAllText(DescriptionFilePath, ProjectDescriptionRichTextBox.Text, Encoding.UTF8);
                System.IO.File.WriteAllText(Description_WorkshopFilePath, ProjectDescriptionSWSRichTextBox.Text, Encoding.UTF8);
                MessageBox.Show("description.txt,description_workshop.txt已保存", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ProjectData.ProjectDescription = ProjectDescriptionRichTextBox.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"介绍保存失败: {ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                ProjectIconPictureBox.Image?.Dispose();
                ProjectIconSWSPictureBox.Image?.Dispose();
                if (File.Exists(ProjectData.ProjectPath + "\\icon_tmp.png"))
                    File.Delete(ProjectData.ProjectPath + "\\icon_tmp.png");
                if (File.Exists(ProjectData.ProjectPath + "\\icon_workshop_tmp.png"))
                    File.Delete(ProjectData.ProjectPath + "\\icon_workshop_tmp.png");
                File.Copy(IconPath, ProjectData.ProjectPath + "\\icon_tmp.png");
                File.Copy(IconSWSPath, ProjectData.ProjectPath + "\\icon_workshop_tmp.png");
                if (File.Exists(IconPath))
                    File.Delete(IconOriginPath);
                if (File.Exists(IconSWSPath))
                    File.Delete(IconOriginSWSPath);
                File.Copy(ProjectData.ProjectPath + "\\icon_tmp.png", ProjectData.ProjectPath + "\\icon.png");
                File.Copy(ProjectData.ProjectPath + "\\icon_workshop_tmp.png", ProjectData.ProjectPath + "\\icon_workshop.png");
                File.Delete(ProjectData.ProjectPath + "\\icon_tmp.png");
                File.Delete(ProjectData.ProjectPath + "\\icon_workshop_tmp.png");
                MessageBox.Show("icon.png,icon_workshop.png已保存", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                if (File.Exists(ProjectData.ProjectPath + "\\icon_tmp.png"))
                    File.Delete(ProjectData.ProjectPath + "\\icon_tmp.png");
                if (File.Exists(ProjectData.ProjectPath + "\\icon_workshop_tmp.png"))
                    File.Delete(ProjectData.ProjectPath + "\\icon_workshop_tmp.png");
                MessageBox.Show($"图片保存失败: {ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Close();
        }

        private void OutlookSettings_Load(object sender, EventArgs e)
        {
            this.BackColor = TerraCreatorData.FormBackColor;
            OutlookSettingsPanel.BackColor = TerraCreatorData.FormToolColor;
        }

    }
}


//

