using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TerraCreator
{
    public class Libs
    {
        //读取项目配置文件
        public static bool ReadProjectConfigFile(string ProjectFolderPath)
        {
            try
            {

                string ProjectConfigFileContent = File.ReadAllText(
                    ProjectFolderPath + TerraCreatorData.ProjectConfigFilePath + TerraCreatorData.ProjectConfigFileName
                    );
                string[] ProjectConfigFileLines = File.ReadAllLines(
                    ProjectFolderPath + TerraCreatorData.ProjectConfigFilePath + TerraCreatorData.ProjectConfigFileName
                    );
                Regex ProjectModItemSavePathRegex = new Regex(@"ProjectModItemSavePath\s*=\s*""(?<ProjectModItemSavePath>.*)"";");
                Regex ProjectModProjectileSavePathRegex = new Regex(@"ProjectModProjectileSavePath\s*=\s*""(?<ProjectModProjectileSavePath>.*)"";");
                foreach (string line in ProjectConfigFileLines)
                {
                    Match ProjectModItemSavePathMatch = ProjectModItemSavePathRegex.Match(line);
                    Match ProjectModProjectileSavePathMatch = ProjectModProjectileSavePathRegex.Match(line);
                    if (ProjectModItemSavePathMatch.Success)
                    {
                        ProjectData.ProjectModItemSavePath = ProjectModItemSavePathMatch.Groups["ProjectModItemSavePath"].Value;
                    }
                    if (ProjectModProjectileSavePathMatch.Success)
                    {
                        ProjectData.ProjectModProjectileSavePath = ProjectModProjectileSavePathMatch.Groups["ProjectModProjectileSavePath"].Value;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"读取配置文件失败\n部分内容可能无法保存\n{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        //创建项目配置文件
        public static bool CreateProjectConifgFile(string ProjectFolderPath)
        {
            try
            {
                
                if (!Directory.Exists(ProjectFolderPath + TerraCreatorData.ProjectConfigFilePath))
                {
                    MessageBox.Show($"我们将会在项目根目录下创建配置文件\n{ProjectFolderPath + TerraCreatorData.ProjectConfigFilePath}");
                    Directory.CreateDirectory(ProjectFolderPath + TerraCreatorData.ProjectConfigFilePath);
                }
                if (!File.Exists(ProjectFolderPath + TerraCreatorData.ProjectConfigFilePath + TerraCreatorData.ProjectConfigFileName))
                {
                    File.WriteAllText(
                        ProjectFolderPath + TerraCreatorData.ProjectConfigFilePath + TerraCreatorData.ProjectConfigFileName,
                        TerraCreatorData.ExampleProjectConfigFileContent
                        );
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show($"我们无法创建配置文件,部分内容可能无法保存", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public static bool WriteProjectConfigFile(string ProjectConfigFilePath, Dictionary<string, string> ProjectConfigData)
        {
            string NewProjectConfigFileContent =
                "[ProjectData]" + Environment.NewLine +
                $"ProjectModItemSavePath = \"{ProjectConfigData["ProjectModItemSavePath"]}\";" + Environment.NewLine +
                $"ProjectModProjectileSavePath = \"{ProjectConfigData["ProjectModProjectileSavePath"]}\";" + Environment.NewLine;

            try
            {
                File.WriteAllText(ProjectConfigFilePath, NewProjectConfigFileContent);
                
                ReadProjectConfigFile(ProjectData.ProjectPath);
                MessageBox.Show($"配置文件已保存\n{File.ReadAllText(ProjectConfigFilePath)}", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"写入配置文件失败\n部分内容可能无法保存\n{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;

        }

    }


}
