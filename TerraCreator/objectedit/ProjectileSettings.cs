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
using System.IO;

namespace TerraCreator
{
    public partial class ProjectileSettingForm : Form
    {

        string ProjectileContentWithoutLineRead = "";
        public static string ProjectilePathGlobal = "";
        private string selectedImagePath = "";

        public ProjectileSettingForm(string ProjectilePath, string ProjectileNamespace)
        {
            //读取射弹文件每一列
            string[] ProjectileContent = { "" };
            try
            {
                ProjectileContent = File.ReadAllLines(ProjectilePath);
            }
            catch (Exception e)
            {

            }
            //创建窗体和项目
            InitializeComponent();
            //初步重设窗体
            ProjectileNamespaceTextBox.Text = ProjectileNamespace;
            OriginCodeFilePath.Text = ProjectilePath.Replace(ProjectData.ProjectPath, "res:");
            try
            {
                ProjectileImagePathLabel.Text = (ProjectilePath.Replace(".cs", ".png")).Replace(ProjectData.ProjectPath, "res:");            //后续此处需改为代码内路径
                ProjectileImagePictureBox.Image = Image.FromFile(ProjectilePath.Replace(".cs", ".png"));
            }
            catch (Exception e)
            {

            }

            //检测文件 将射弹属性put进空间内
            try
            {
                //正则表达式匹配每项
                Regex ReadProjectileHeightFromFile = new Regex(@"[Pp]rojectile.[Hh]eight\s*=\s*(\d+);");
                Regex ReadProjectileWidthFromFile = new Regex(@"[Pp]rojectile.[Ww]idth\s*=\s*(\d+);");
                Regex ReadProjectileScaleFromFile = new Regex(@"[Pp]rojectile.[Ss]cale\s*=\s*(\d+(\.\d+)?)f;");
                Regex ReadProjectileAlphaFromFile = new Regex(@"[Pp]rojectile.[Aa]lpha\s*=\s*(\d+);");
                Regex ReadProjectileTimeLeftFromFile = new Regex(@"[Pp]rojectile.[Tt]ime[Ll]eft\s*=\s*(\d+);");
                Regex ReadProjectilePenetrateFromFile = new Regex(@"[Pp]rojectile.[Pp]enetrate\s*=\s*([-]?\d+);");
                Regex ReadProjectileFriendlyFromFile = new Regex(@"[Pp]rojectile.[Ff]riendly\s*=\s*([Tt]rue|[Ff]alse);");
                Regex ReadProjectileHostileFromFile = new Regex(@"[Pp]rojectile.[Hh]ostile\s*=\s*([Tt]rue|[Ff]alse);");
                Regex ReadProjectileDamageFromFile = new Regex(@"[Pp]rojectile.[Dd]amage\s*=\s*(\d+);");
                Regex ReadProjectileAIStyleFromFile = new Regex(@"[Pp]rojectile.[Aa][Ii][Ss]tyle\s*=\s*([-]?\d+);");

                Regex[] PatternsToRemove =
                {
                    ReadProjectileHeightFromFile,
                    ReadProjectileWidthFromFile,
                    ReadProjectileScaleFromFile,
                    ReadProjectileAlphaFromFile,
                    ReadProjectileTimeLeftFromFile,
                    ReadProjectilePenetrateFromFile,
                    ReadProjectileFriendlyFromFile,
                    ReadProjectileHostileFromFile,
                    ReadProjectileDamageFromFile,
                    ReadProjectileAIStyleFromFile
                };


                if (ProjectileContent[0] != " ")
                    foreach (var EachLineFromFile in ProjectileContent)
                    {
                        if (Regex.Match(EachLineFromFile, ReadProjectileHeightFromFile.ToString()).Success)
                        {
                            ProjectileHeightNumericUpDown.Value = Convert.ToInt16(ReadProjectileHeightFromFile.Match(EachLineFromFile).Groups[1].Value);
                        }
                        if (Regex.Match(EachLineFromFile, ReadProjectileWidthFromFile.ToString()).Success)
                        {
                            ProjectileWidthNumericUpDown.Value = Convert.ToInt16(ReadProjectileWidthFromFile.Match(EachLineFromFile).Groups[1].Value);
                        }
                        if (Regex.Match(EachLineFromFile, ReadProjectileScaleFromFile.ToString()).Success)
                        {
                            ProjectileScaleTextBox.Text = ReadProjectileScaleFromFile.Match(EachLineFromFile).Groups[1].Value+"f";
                        }
                        if (Regex.Match(EachLineFromFile, ReadProjectileAlphaFromFile.ToString()).Success)
                        {
                            ProjectileAlphaNumericUpDown.Value = Convert.ToInt16(ReadProjectileAlphaFromFile.Match(EachLineFromFile).Groups[1].Value);
                        }
                        if (Regex.Match(EachLineFromFile, ReadProjectileTimeLeftFromFile.ToString()).Success)
                        {
                            ProjectileTimeLeftNumericUpDown.Value = Convert.ToInt16(ReadProjectileTimeLeftFromFile.Match(EachLineFromFile).Groups[1].Value);
                        }
                        if (Regex.Match(EachLineFromFile, ReadProjectilePenetrateFromFile.ToString()).Success)
                        {
                            ProjectilePenetrateNumericUpDown.Value = Convert.ToInt16(ReadProjectilePenetrateFromFile.Match(EachLineFromFile).Groups[1].Value);
                        }
                        if (Regex.Match(EachLineFromFile, ReadProjectileFriendlyFromFile.ToString()).Success)
                        {
                            ProjectileFriendlyComboBox.Text = ReadProjectileFriendlyFromFile.Match(EachLineFromFile).Groups[1].Value;
                        }
                        if (Regex.Match(EachLineFromFile, ReadProjectileHostileFromFile.ToString()).Success)
                        {
                            ProjectileHostileComboBox.Text = ReadProjectileHostileFromFile.Match(EachLineFromFile).Groups[1].Value;
                        }
                        if (Regex.Match(EachLineFromFile, ReadProjectileDamageFromFile.ToString()).Success)
                        {
                            ProjectileDamageNumericUpDown.Value = Convert.ToInt16(ReadProjectileDamageFromFile.Match(EachLineFromFile).Groups[1].Value);
                        }
                        if (Regex.Match(EachLineFromFile, ReadProjectileAIStyleFromFile.ToString()).Success)
                        {
                            ProjectileAIStyleNumericUpDown.Value = Convert.ToInt16(ReadProjectileAIStyleFromFile.Match(EachLineFromFile).Groups[1].Value);
                        }

                        ProjectileContentWithoutLineRead += EachLineFromFile;
                        ProjectileContentWithoutLineRead += Environment.NewLine;
                    }
                CodeViewRichTextBox.Text = ProjectileContentWithoutLineRead;

                string result = ExtractSetDefaultsBodyAndRemoveMatches(ProjectileContentWithoutLineRead, PatternsToRemove);
                ProjectileSetDefaultsCodesRichTextBox.Text = result;

            }
            catch (Exception e)
            {
                MessageBox.Show("稀有错误,匹配错误", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //刷新窗体
            this.Refresh();

        }

        public string WriteProjctileCode()
        {
            string WrittedCodes = "";
            string ClassDefine = "";

            ClassDefine = ProjectData.ProjectNamespace + ".Projectiles";

            @WrittedCodes =
                "using Microsoft.Xna.Framework;" + Environment.NewLine +
                "using Terraria;" + Environment.NewLine +
                "using Terraria.ID;" + Environment.NewLine +
                "using Terraria.ModLoader;" + Environment.NewLine +
              $"namespace {ClassDefine}" + Environment.NewLine +
                "{" + Environment.NewLine +
              $"    public class {ProjectileNamespaceTextBox.Text}:ModProjectile" + Environment.NewLine +
                "    {" + Environment.NewLine +
                "        public override void SetDefaults()" + Environment.NewLine +
                "        {" + Environment.NewLine +
              $"            Projectile.height = {ProjectileHeightNumericUpDown.Value};//射弹高度" + Environment.NewLine +
              $"            Projectile.width = {ProjectileWidthNumericUpDown.Value};//射弹宽度" + Environment.NewLine +
              $"            Projectile.friendly = {ProjectileFriendlyComboBox.Text};//射弹是否可以攻击敌方" + Environment.NewLine +
              $"            Projectile.timeLeft = {ProjectileTimeLeftNumericUpDown.Value};//射弹存在时间" + Environment.NewLine +
              $"            Projectile.scale = {ProjectileScaleTextBox.Text};//射弹缩放倍率" + Environment.NewLine +
              $"            Projectile.hostile = {ProjectileHostileComboBox.Text};//射弹是否可以攻击友方和NPC" + Environment.NewLine +
              $"            Projectile.alpha = {ProjectileAlphaNumericUpDown.Value};//射弹透明度" + Environment.NewLine +
              $"            Projectile.penetrate = {ProjectilePenetrateNumericUpDown.Value};//射弹穿透次数" + Environment.NewLine +
              $"            Projectile.damage = {ProjectileDamageNumericUpDown.Value};//射弹伤害" + Environment.NewLine +
              $"            Projectile.aiStyle = {ProjectileAIStyleNumericUpDown.Value};//射弹AI" + Environment.NewLine +
              $"            {ProjectileSetDefaultsCodesRichTextBox.Text}" + Environment.NewLine +
                "        }" + Environment.NewLine +
                "    }" + Environment.NewLine +
                "}";

            return WrittedCodes;
        }

        private void ProjectileSettingForm_Load(object sender, EventArgs e)
        {
            this.BackColor = TerraCreatorData.FormBackColor;
            SetDefaultsTabPage.BackColor = TerraCreatorData.FormToolColor;
            AITabPage.BackColor = TerraCreatorData.FormToolColor;
            OtherTabPage.BackColor = TerraCreatorData.FormToolColor;
            HeadTabPage.BackColor = TerraCreatorData.FormToolColor;
        }

        private void OriginalCode_Click(object sender, EventArgs e)
        {
            CodeViewRichTextBox.Text = ProjectileContentWithoutLineRead;
        }

        private bool CheckControlsForEmpty()
        {
            var controlsToCheck = new Control[]
            {
                ProjectileNamespaceTextBox,
                ProjectileScaleTextBox,
                ProjectileFriendlyComboBox,
                ProjectileHostileComboBox
                // 可根据实际需要添加更多控件
            };
            foreach (var ctrl in controlsToCheck)
            {
                if (string.IsNullOrWhiteSpace(ctrl.Text))
                {
                    MessageBox.Show($"控件“{ctrl.Name}”内容为空，请填写完整。", "内容缺失", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return true;
                }
            }
            return false;
        }

        private void PreviewCode_Click(object sender, EventArgs e)
        {
            if (CheckControlsForEmpty()) return;
            // 自动生成属性列表
            var propertyList = new[]
            {
                "Projectile.Height",
                "Projectile.Width",
                "Projectile.Friendly",
                "Projectile.timeLeft",
                "Projectile.Scale",
                "Projectile.Hostile",
                "Projectile.Alpha",
                "Projectile.Penetrate",
                "Projectile.Damage",
                "Projectile.aiStyle"
            };

            var customCode = ProjectileSetDefaultsCodesRichTextBox.Text;
            var customCodeLower = customCode.ToLower();
            var repeatedProps = new List<string>();
            foreach (var prop in propertyList)
            {
                var regex = new Regex($@"{Regex.Escape(prop.ToLower())}\s*=");
                if (regex.IsMatch(customCodeLower))
                {
                    repeatedProps.Add(prop);
                }
            }
            if (repeatedProps.Count > 0)
            {
                MessageBox.Show($"以下属性在自动生成和自定义代码中均有赋值，可能冲突：\n{string.Join("\n", repeatedProps)}", "属性重复", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //return;
            }

            string PreviewCode = WriteProjctileCode();
            CodeViewRichTextBox.Text = PreviewCode;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (CheckControlsForEmpty()) return;

            DialogResult ConfirmSaveProjectileCode = MessageBox.Show("你确定要保存当前代码和贴图吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (ConfirmSaveProjectileCode == DialogResult.OK)
            {
                try
                {
                    File.WriteAllText(ProjectilePathGlobal, CodeViewRichTextBox.Text);

                    // 保存贴图
                    if (!string.IsNullOrWhiteSpace(selectedImagePath))
                    {
                        var targetImagePath = ProjectilePathGlobal.Replace(".cs", ".png");
                        File.Copy(selectedImagePath, targetImagePath, true);
                    }

                    MessageBox.Show("保存成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"保存错误\n{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void ProjectileSetDefaultsCodesRichTextBox_TextChanged(object sender, EventArgs e)
        {

        }

    
        public static string ExtractSetDefaultsBodyAndRemoveMatches(string code, Regex[] patternsToRemove)
        {
            // 匹配 public override void SetDefaults() { ... }
            var match = Regex.Match(
                code,
                @"public\s+override\s+void\s+SetDefaults\s*\(\s*\)\s*\{([\s\S]*?)\}",
                RegexOptions.Multiline);

            if (!match.Success)
                return string.Empty;

            string body = match.Groups[1].Value;

            // 依次移除所有需要去除的内容（整行）
            foreach (var pattern in patternsToRemove)
            {
                // 直接用 pattern 替换整行（含注释）
                body = pattern.Replace(body, "");
            }

            return body.Trim();
        }

        private void SelectImageButton_Click(object sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog())
            {
                ofd.Filter = "PNG图片|*.png";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    selectedImagePath = ofd.FileName;
                    ProjectileImagePictureBox.Image = Image.FromFile(selectedImagePath);
                    ProjectileImagePathLabel.Text = selectedImagePath;
                }
            }
        }
    }
    
}


