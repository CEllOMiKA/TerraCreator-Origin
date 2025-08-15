using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TerraCreator.objectedit
{
    public partial class ItemSettings : Form
    {
        string ItemContentWithoutLineRead = "";

        public ItemSettings(string ItemPath, string ItemNamespace)
        {
            //读取射弹文件每一列
            string[] ItemContent = { "" };
            try
            {
                ItemContent = File.ReadAllLines(ItemPath);
            }
            catch (Exception e)
            {

            }
            //创建窗体和项目
            InitializeComponent();
            //初步重设窗体
            ItemNamespaceTextBox.Text = ItemNamespace;
            OriginCodeFilePath.Text = ItemPath.Replace(ProjectData.ProjectPath,"res:");
            try
            {
                ItemImagePathLabel.Text = (ItemPath.Replace(".cs", ".png")).Replace(ProjectData.ProjectPath, "res:");            //后续此处需改为代码内路径
                ItemImagePictureBox.Image = Image.FromFile(ItemPath.Replace(".cs", ".png"));
            }
            catch (Exception e)
            {

            }

            //检测文件 将射弹属性put进空间内
            //try
            //{
            //    //正则表达式匹配每项
            //    Regex ReadProjectileHeightFromFile = new Regex(@"Projectile.[Hh]eight\s*=\s*(\d+);");
            //    Regex ReadProjectileWidthFromFile = new Regex(@"Projectile.[Ww]idth\s*=\s*(\d+);");
            //    Regex ReadProjectileScaleFromFile = new Regex(@"Projectile.[Ss]cale\s*=\s*(\d+(\.\d+)?)f;");
            //    Regex ReadProjectileAlphaFromFile = new Regex(@"Projectile.[Aa]lpha\s*=\s*(\d+);");
            //    Regex ReadProjectileTimeLeftFromFile = new Regex(@"Projectile.[Tt]ime[Ll]eft\s*=\s*(\d+);");
            //    Regex ReadProjectilePenetrateFromFile = new Regex(@"Projectile.[Pp]enetrate\s*=\s*(\d+);");
            //    Regex ReadProjectileFriendlyFromFile = new Regex(@"Projectile.[Ff]riendly\s*=\s*([Tt]rue|[Ff]alse);");
            //    Regex ReadProjectileHostileFromFile = new Regex(@"Projectile.[Hh]ostile\s*=\s*([Tt]rue|[Ff]alse);");
            //    Regex ReadSetDafaultsCodesFromFile = new Regex(@"[Pp]ublic\soverride\svoid\sSetDefaults()");
            //    Regex ReadProjectileDamageFromFile = new Regex(@"Projectile.[Dd]amage\s*=\s*(\d+);");
            //    Regex ReadProjectileAIStyleFromFile = new Regex(@"Projectile.[Aa][Ii][Ss]tyle\s*=\s*(\d+);");


            //    if (ProjectileContent[0] != " ")
            //        foreach (var EachLineFromFile in ProjectileContent)
            //        {
            //            if (Regex.Match(EachLineFromFile, ReadProjectileHeightFromFile.ToString()).Success)
            //            {
            //                ProjectileHeightNumericUpDown.Value = Convert.ToInt16(ReadProjectileHeightFromFile.Match(EachLineFromFile).Groups[1].Value);
            //            }
            //            if (Regex.Match(EachLineFromFile, ReadProjectileWidthFromFile.ToString()).Success)
            //            {
            //                ProjectileWidthNumericUpDown.Value = Convert.ToInt16(ReadProjectileWidthFromFile.Match(EachLineFromFile).Groups[1].Value);
            //            }
            //            if (Regex.Match(EachLineFromFile, ReadProjectileScaleFromFile.ToString()).Success)
            //            {
            //                ProjectileScaleTextBox.Text = ReadProjectileScaleFromFile.Match(EachLineFromFile).Groups[1].Value;
            //            }
            //            if (Regex.Match(EachLineFromFile, ReadProjectileAlphaFromFile.ToString()).Success)
            //            {
            //                ProjectileAlphaNumericUpDown.Value = Convert.ToInt16(ReadProjectileAlphaFromFile.Match(EachLineFromFile).Groups[1].Value);
            //            }
            //            if (Regex.Match(EachLineFromFile, ReadProjectileTimeLeftFromFile.ToString()).Success)
            //            {
            //                ProjectileTimeLeftNumericUpDown.Value = Convert.ToInt16(ReadProjectileTimeLeftFromFile.Match(EachLineFromFile).Groups[1].Value);
            //            }
            //            if (Regex.Match(EachLineFromFile, ReadProjectilePenetrateFromFile.ToString()).Success)
            //            {
            //                ProjectilePenetrateNumericUpDown.Value = Convert.ToInt16(ReadProjectilePenetrateFromFile.Match(EachLineFromFile).Groups[1].Value);
            //            }
            //            if (Regex.Match(EachLineFromFile, ReadProjectileFriendlyFromFile.ToString()).Success)
            //            {
            //                ProjectileFriendlyComboBox.Text = ReadProjectileFriendlyFromFile.Match(EachLineFromFile).Groups[1].Value;
            //            }
            //            if (Regex.Match(EachLineFromFile, ReadProjectileHostileFromFile.ToString()).Success)
            //            {
            //                ProjectileHostileComboBox.Text = ReadProjectileHostileFromFile.Match(EachLineFromFile).Groups[1].Value;
            //            }
            //            if (Regex.Match(EachLineFromFile, ReadProjectileDamageFromFile.ToString()).Success)
            //            {
            //                ProjectileDamageNumericUpDown.Value = Convert.ToInt16(ReadProjectileDamageFromFile.Match(EachLineFromFile).Groups[1].Value);
            //            }
            //            if (Regex.Match(EachLineFromFile, ReadProjectileAIStyleFromFile.ToString()).Success)
            //            {
            //                ProjectileAIStyleNumericUpDown.Value = Convert.ToInt16(ReadProjectileAIStyleFromFile.Match(EachLineFromFile).Groups[1].Value);
            //            }
            //            if (Regex.Match(EachLineFromFile, ReadSetDafaultsCodesFromFile.ToString()).Success)
            //            {
            //                //Working...
            //            }
            //            ProjectileContentWithoutLineRead += EachLineFromFile;
            //            ProjectileContentWithoutLineRead += Environment.NewLine;
            //        }
            //    CodeViewRichTextBox.Text = ProjectileContentWithoutLineRead;
            //}
            //catch (Exception e)
            //{
            //}

            //刷新窗体
            this.Refresh();

        }

    }
}
