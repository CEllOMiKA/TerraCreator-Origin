using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TerraCreator
{

    public class TerraCreatorData
    {

        public static Color FormToolColor = Color.FromArgb(192, 255, 255);
        public static Color FormBackColor = Color.FromArgb(128, 255, 255);
        public static Color FormFontColor = Color.Black;

        public static Color RichTextBoxColor = Color.Black;
        //public static Font RichTextBoxFont = new Font("")

        public static string ExampleTerraCreatorConfigFileContent =
            "FormToolColor\r\n" +
            "192\r\n" +
            "255\r\n" +
            "255\r\n" +
            "FormBackColor\r\n" +
            "128\r\n" +
            "255\r\n" +
            "255\r\n" +
            "Program only read line 2,3,4,6,7,8 (inProgram is line 1,2,3,5,6,7). If this file is broken , just delete!";
        public static string TerraCreatorConfigFileName = "TerraCreator.userconfig.tcdata";
        //Notice: Settings.cs!

    }



}

