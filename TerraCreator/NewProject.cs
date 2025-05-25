using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Reflection.Emit;
using System.Reflection;
using TerraCreator;


namespace TerraCreator
{
    public partial class NewProject : Form
    {
        string ProjectFolderPath="";
        public NewProject()
        {
            InitializeComponent();
        }

        private void clickto_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", "https://tmodloadermodder.fandom.com/zh/wiki/%E9%80%9A%E8%BF%87tModLoader%E5%88%9B%E5%BB%BA%E5%B1%9E%E4%BA%8E%E8%87%AA%E5%B7%B1%E7%9A%84Mod");
        }

        private void choosefolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog choosefolderpath = new FolderBrowserDialog();
            choosefolderpath.Description = "选择项目位置";
            choosefolderpath.RootFolder = Environment.SpecialFolder.MyDocuments;
            DialogResult folderpath_result = choosefolderpath.ShowDialog();
            if (folderpath_result == DialogResult.OK)
            {
                ProjectFolderPath = choosefolderpath.SelectedPath;
                folderpositiontext.Text = "你选择的文件夹地址:" + ProjectFolderPath;
            }
        }

        private void create_Click(object sender, EventArgs e)
        {
            if (ProjectData.ProjectChecked)
            {
                MessageBox.Show("重导入需重新启动程序\n还有你是怎么做到打开了项目还能打开这个的","提示",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            }
            else
            {
                if (ProjectFolderPath != "")
                {


                    DirectoryInfo ProjectDictInfo = new DirectoryInfo(ProjectFolderPath);
                    ProjectData.ProjectChecked = true;

                    try
                    {
                        string ProjectBuildFile = File.ReadAllText(ProjectFolderPath + "\\build.txt");
                        ProjectData.ProjectBuild = ProjectBuildFile;
                        string ProjectDescriptionFile = File.ReadAllText(ProjectFolderPath + "\\Description.txt");
                        ProjectData.ProjectDescription = ProjectDescriptionFile;
                        string ProjectLaunchSettingsFile = File.ReadAllText(ProjectFolderPath + "\\Properties\\launchSettings.json");
                        ProjectData.ProjectLaunchSettings = ProjectLaunchSettingsFile;
                        string ProjectMainFile = File.ReadAllText(ProjectFolderPath + "\\" + ProjectNameSpaceTextBox.Text + ".cs");
                        ProjectData.ProjectMain = ProjectMainFile;
                        ProjectData.ProjectNamespace = ProjectNameSpaceTextBox.Text;

                    }
                    catch (Exception ex)
                    {
                        ProjectData.ProjectChecked = false;
                        ProjectData.ProjectBuild = "";
                        ProjectData.ProjectDescription = "";
                        ProjectData.ProjectLaunchSettings = "";
                        ProjectData.ProjectMain = "";
                        ProjectData.ProjectNamespace = "";

                        MessageBox.Show(
                            $"无法找到文件或类\n" +
                            $"{ex.Message}\n" +
                            $"\n" +
                            $"确保模组内部名称填写正确\n" +
                            $"如果文件夹没有build.txt,description.txt,launchSettings.json文件\n" +
                            $"建议重新创建项目"
                        );
                    }

                    if (ProjectData.ProjectChecked)
                    {

                        ProjectDictInfo.Create();
                        ProjectDictInfo.CreateSubdirectory("Items");
                        ProjectDictInfo.CreateSubdirectory("Projectiles");
                        ProjectDictInfo.CreateSubdirectory("Localization");

                        ProjectData.ProjectPath = ProjectFolderPath;
                        Main.fileview.Nodes.Clear();
                        Main.LoadFileTreeView(ProjectData.ProjectPath);
                        Main.fileview.ExpandAll();
                        Main.codes.Text = "";

                        MessageBox.Show("已完成导入");
                        this.Close();
                    }


                }
                else
                {
                    MessageBox.Show("你是来搞笑的", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}
