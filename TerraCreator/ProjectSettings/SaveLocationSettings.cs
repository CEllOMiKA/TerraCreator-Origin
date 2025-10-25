using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TerraCreator.projectsettings
{
    public partial class SaveLocationSettings : Form
    {
        public SaveLocationSettings()
        {
            InitializeComponent();
        }

        private void SaveLocationSettings_Load(object sender, EventArgs e)
        {
            this.BackColor = TerraCreator.TerraCreatorData.FormBackColor;
            SaveLocationPanel.BackColor = TerraCreatorData.FormToolColor;

            Libs.ReadProjectConfigFile(ProjectData.ProjectPath);
            //MessageBox.Show(ProjectData.ProjectModItemSavePath+"\n" + ProjectData.ProjectModProjectileSavePath);
            ItemSaveLocationTextBox.Text = ProjectData.ProjectModItemSavePath;
            ProjectileSaveLocationTextBox.Text = ProjectData.ProjectModProjectileSavePath;
        }

        private void ItemSaveLocationButton_Click(object sender, EventArgs e)
        {
            OpenFolderDialog ChooseItemSaveLoaction = new OpenFolderDialog();
            ChooseItemSaveLoaction.Title = "选择物品保存位置文件夹";
            ChooseItemSaveLoaction.DefaultDirectory = ProjectData.ProjectPath;
            bool? result = ChooseItemSaveLoaction.ShowDialog();
            if (result == true)
            {
                ItemSaveLocationTextBox.Text = ChooseItemSaveLoaction.FolderName.Replace(ProjectData.ProjectPath, "");
            }
        }

        private void ProjectileSaveLocationButton_Click(object sender, EventArgs e)
        {
            OpenFolderDialog ChooseProjectileSaveLoaction = new OpenFolderDialog();
            ChooseProjectileSaveLoaction.Title = "选择射弹保存位置文件夹";
            ChooseProjectileSaveLoaction.DefaultDirectory = ProjectData.ProjectPath;
            bool? result = ChooseProjectileSaveLoaction.ShowDialog();
            if (result == true)
            {
                ProjectileSaveLocationTextBox.Text = ChooseProjectileSaveLoaction.FolderName.Replace(ProjectData.ProjectPath, "");
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            string ProjectConfigFilePath = ProjectData.ProjectPath + TerraCreatorData.ProjectConfigFilePath + TerraCreatorData.ProjectConfigFileName;
            Dictionary<string, string> ProjectConfigData = new Dictionary<string, string>();
            ProjectConfigData.Add("ProjectModItemSavePath", ItemSaveLocationTextBox.Text);
            ProjectConfigData.Add("ProjectModProjectileSavePath", ProjectileSaveLocationTextBox.Text);
            Libs.WriteProjectConfigFile(ProjectConfigFilePath, ProjectConfigData);

        }


    }
}
