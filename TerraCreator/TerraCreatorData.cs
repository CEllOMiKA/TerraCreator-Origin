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
        public static string Language = "en-US";

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
            "Language\r\n" +
            "en-US";
        public static string TerraCreatorConfigFileName = "TerraCreator.userconfig.tcdata";
        //Notice: Settings.cs!

    }



}

