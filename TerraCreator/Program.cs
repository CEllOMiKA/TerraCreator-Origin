using Microsoft.VisualBasic.Logging;
using System.Runtime.CompilerServices;
using System.IO;

namespace TerraCreator
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            //Set Application



            Console.WriteLine("Loading TerraCreator...");
            Console.WriteLine("Loading TerraCreator Data...");





            //CreateDataFile
            string DataFilePath = TerraCreatorData.TerraCreatorConfigFileName;
            
            if (!File.Exists(DataFilePath))
            {
                MessageBox.Show($"未检测到配置文件\n我们会在此程序的根目录下创建配置文件\n文件名为:{TerraCreatorData.TerraCreatorConfigFileName}","TerraCreator");
                string DataSimpletext = TerraCreatorData.ExampleTerraCreatorConfigFileContent;
                File.Create(DataFilePath).Close();
                File.WriteAllText(DataFilePath, DataSimpletext);
                
            }
            
            ////CreateAddonFolder
            //string FolderPath = "Addons";
            //if (!Directory.Exists(FolderPath))
            //{
            //    Directory.CreateDirectory(FolderPath);
            //}



            //ReadDataFile
            int DataLineCount = File.ReadLines(DataFilePath).Count();
            String[] Data = new string[DataLineCount];
            for (int i = 0; i <= DataLineCount-1; i++)
            {
                Data[i] = File.ReadLines(DataFilePath).ElementAt(i);
            }

            //SetDataFile
            try
            {
                //Color Settings
                TerraCreatorData.FormToolColor = Color.FromArgb(
                    Convert.ToInt32(Data[1]),
                    Convert.ToInt32(Data[2]),
                    Convert.ToInt32(Data[3])
                );
                TerraCreatorData.FormBackColor = Color.FromArgb(
                    Convert.ToInt32(Data[5]),
                    Convert.ToInt32(Data[6]),
                    Convert.ToInt32(Data[7])
                );

                //Language Settings
                TerraCreatorData.Language = Data[9];
                System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(Data[9]);

            }
            catch (Exception ex) 
            {
                MessageBox.Show($"配置文件读取错误\n{ex.Message}\n如果不能排查问题,请删除配置文件\n注意:新版本不支持旧版本配置文件","错误",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }


            Console.WriteLine("Starting TerraCreator...");

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Main());

            //Read Data File

            

        }
    }
}