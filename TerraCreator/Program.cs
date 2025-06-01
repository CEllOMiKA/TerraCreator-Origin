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
            string DataFilePath = "TerraCreatorData.tcdata";
            
            if (!File.Exists(DataFilePath))
            {
                string DataSimpletext =
                    "FormToolColour\r\n" +
                    "192\r\n" +
                    "255\r\n" +
                    "255\r\n" +
                    "FormBackColour\r\n" +
                    "128\r\n" +
                    "255\r\n" +
                    "255\r\n" +
                    "Program only read line 2,3,4,6,7,8 (inProgram is line 1,2,3,5,6,7). If this file is broken , just delete!";
                File.Create(DataFilePath).Close();
                File.WriteAllText(DataFilePath, DataSimpletext);
            }






            //ReadDataFile
            int DataLineCount = File.ReadLines(DataFilePath).Count();
            String[] Data = new string[DataLineCount];
            for (int i = 0; i <= DataLineCount-1; i++)
            {
                Data[i] = File.ReadLines(DataFilePath).ElementAt(i);
            }

            //SetDataFile
            TerraCreatorData.FormToolColour = Color.FromArgb(
                Convert.ToInt32(Data[1]),
                Convert.ToInt32(Data[2]),
                Convert.ToInt32(Data[3])
            );
            TerraCreatorData.FormBackColour = Color.FromArgb(
                Convert.ToInt32(Data[5]),
                Convert.ToInt32(Data[6]),
                Convert.ToInt32(Data[7])
            );




            Console.WriteLine("Starting TerraCreator...");

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Main());

            //Read Data File

            

        }
    }
}