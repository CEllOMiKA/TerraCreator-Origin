using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        public static string ItemPathGlobal = "";

        public ItemSettings(string ItemPath, string ItemNamespace)
        {

            ItemPathGlobal = ItemPath;
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
            OriginCodeFilePath.Text = ItemPath.Replace(ProjectData.ProjectPath, "res:");
            try
            {
                ItemImagePathLabel.Text = (ItemPath.Replace(".cs", ".png")).Replace(ProjectData.ProjectPath, "res:");            //后续此处需改为代码内路径
                ItemImagePictureBox.Image = Image.FromFile(ItemPath.Replace(".cs", ".png"));
            }
            catch (Exception e)
            {

            }



            //检测文件 将Item属性put进空间内
            try
            {
                //正则表达式匹配每项
                //SetDefaults
                //基础属性
                Regex ReadItemHeightFromFile = new Regex(@"[Ii]tem.[Hh]eight\s*=\s*(\d+);");
                Regex ReadItemWidthFromFile = new Regex(@"[Ii]tem.[Ww]idth\s*=\s*(\d+);");
                Regex ReadMaxStackFromFile = new Regex(@"[Ii]tem.[Mm]ax[Ss]tack\s*=\s*(\d+);");
                Regex ReadValueFromFile = new Regex(@"[Ii]tem.[Vv]alue\s*=\s*(\d+);");
                Regex ReadRareFromFile = new Regex(@"[Ii]tem.[Rr]are\s*=\s*(.*);");
                Regex ReadUseSoundFromFile = new Regex(@"[Ii]tem.[Uu]se[Ss]ound\s*=\s*(\d+);");

                //物品动画
                Regex ReadUseTimeFromFile = new Regex(@"[Ii]tem.[Uu]se[Tt]ime\s*=\s*(\d+);");
                Regex ReadUseAnimationFromFile = new Regex(@"[Ii]tem.[Uu]se[Aa]nimation\s*=\s*(\d+);");
                Regex ReadAutoReuseFromFile = new Regex(@"[Ii]tem.[Aa]uto[Rr]e[Uu]se\s*=\s*([Tt]rue|[Ff]alse);");
                Regex ReadUseTurnFromFile = new Regex(@"[Ii]tem.[Uu]se[Tt]urn\s*=\s*([Tt]rue|[Ff]alse);");
                Regex ReadUseStyleFromFile = new Regex(@"[Ii]tem.[Uu]se[Ss]tyle\s*=\s*(.*);");
                Regex ReadNoUseGraphicFromFile = new Regex(@"[Ii]tem.[Nn]o[Uu]se[Gg]raphic\s*=\s*([Tt]rue|[Ff]alse);");

                //武器工具属性
                Regex ReadDamageFromFile = new Regex(@"[Ii]tem.[Dd]amage\s*=\s*(\d+);");
                Regex ReadKnockBackFromFile = new Regex(@"[Ii]tem.[Kk]nock[Bb]ack\s*=\s*(\d+);");
                Regex ReadCritFromFile = new Regex(@"[Ii]tem.[Cc]rit\s*=\s*(\d+);");
                Regex ReadDamageTypeFromFile = new Regex(@"[Ii]tem.[Dd]amage[Tt]ype\s*=\s*(.*);");
                Regex ReadPickFromFile = new Regex(@"[Ii]tem.[Pp]ick\s*=\s*(\d+);");
                Regex ReadAxeFromFile = new Regex(@"[Ii]tem.[Aa]xe\s*=\s*(\d+);");
                Regex ReadHammerFromFile = new Regex(@"[Ii]tem.[Hh]ammer\s*=\s*(\d+);");
                Regex ReadNoMeleeFromFile = new Regex(@"[Ii]tem.[Nn]o[Mm]elee\s*=\s*([Tt]rue|[Ff]alse);");

                //发射
                Regex ReadShootFromFile = new Regex(@"[Ii]tem.[Ss]hoot\s*=\s*(\d+);");
                Regex ReadShootUOPFromFile = new Regex(@"[Ii]tem.[Ss]hoot\s*=\s*(.*);");
                Regex ReadShootSpeedFromFile = new Regex(@"[Ii]tem.[Ss]hoot[Ss]peed\s*=\s*(\d+)");

                //SetDefaults总代码
                Regex ReadSetDefaultsFromFile = new Regex(@"public\s+override\s+void\s+SetDefaults\s*\(\s*\)\s*\{([\s\S]*?)\}", RegexOptions.Multiline);



                if (ItemContent[0] != "")
                {
                    //重新获取文件内容
                    foreach (string EachLineFromFile in ItemContent)
                    {
                        ItemContentWithoutLineRead += EachLineFromFile;
                        ItemContentWithoutLineRead += Environment.NewLine;
                    }
                    CodeViewRichTextBox.Text = ItemContentWithoutLineRead;

                    //匹配SetDefaults
                    string ItemSetDefaultsContent = "";
                    string OriginItemSetDefaultsContent = "";
                    Match MatchSetDefaults = ReadSetDefaultsFromFile.Match(ItemContentWithoutLineRead);
                    if (MatchSetDefaults.Success)
                    {
                        ItemSetDefaultsContent = MatchSetDefaults.Groups[1].Value;
                        OriginItemSetDefaultsContent = MatchSetDefaults.Groups[1].Value;
                    }
                    else
                    {
                        MessageBox.Show("未匹配到SetDefauts", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    //正则表达式匹配每一项 同时去除
                    if (ItemSetDefaultsContent != "")
                    {

                        if (ReadItemHeightFromFile.Match(ItemSetDefaultsContent).Success)
                        {
                            ItemHeightNumericUpDown.Value = Convert.ToInt16(ReadItemHeightFromFile.Match(ItemSetDefaultsContent).Groups[1].Value);
                            ItemSetDefaultsContent = ItemSetDefaultsContent.Replace(ReadItemHeightFromFile.Match(ItemSetDefaultsContent).Groups[0].Value, "");
                        }
                        if (ReadItemWidthFromFile.Match(ItemSetDefaultsContent).Success)
                        {
                            ItemWidthNumericUpDown.Value = Convert.ToInt16(ReadItemWidthFromFile.Match(ItemSetDefaultsContent).Groups[1].Value);
                            ItemSetDefaultsContent = ItemSetDefaultsContent.Replace(ReadItemWidthFromFile.Match(ItemSetDefaultsContent).Groups[0].Value, "");
                        }
                        if (ReadMaxStackFromFile.Match(ItemSetDefaultsContent).Success)
                        {
                            ItemMaxStackNumericUpDown.Value = Convert.ToInt16(ReadMaxStackFromFile.Match(ItemSetDefaultsContent).Groups[1].Value);
                            ItemSetDefaultsContent = ItemSetDefaultsContent.Replace(ReadMaxStackFromFile.Match(ItemSetDefaultsContent).Groups[0].Value, "");
                        }
                        if (ReadValueFromFile.Match(ItemSetDefaultsContent).Success)
                        {
                            ItemValueNumericUpDown.Value = Convert.ToInt32(ReadValueFromFile.Match(ItemSetDefaultsContent).Groups[1].Value);
                            ItemSetDefaultsContent = ItemSetDefaultsContent.Replace(ReadValueFromFile.Match(ItemSetDefaultsContent).Groups[0].Value, "");
                        }
                        if (ReadRareFromFile.Match(ItemSetDefaultsContent).Success)
                        {
                            ItemRareComboBox.Text = ReadRareFromFile.Match(ItemSetDefaultsContent).Groups[1].Value.Trim();
                            ItemSetDefaultsContent = ItemSetDefaultsContent.Replace(ReadRareFromFile.Match(ItemSetDefaultsContent).Groups[0].Value, "");
                        }
                        if (ReadUseSoundFromFile.Match(ItemSetDefaultsContent).Success)
                        {
                            ItemSoundNumericUpDown.Value = Convert.ToInt32(ReadUseSoundFromFile.Match(ItemSetDefaultsContent).Groups[1].Value);
                            ItemSetDefaultsContent = ItemSetDefaultsContent.Replace(ReadUseSoundFromFile.Match(ItemSetDefaultsContent).Groups[0].Value, "");
                        }
                        // 物品动画
                        if (ReadUseTimeFromFile.Match(ItemSetDefaultsContent).Success)
                        {
                            ItemMovementCheckBox.Checked = true;
                            ItemUseTimeNumericUpDown.Value = Convert.ToInt16(ReadUseTimeFromFile.Match(ItemSetDefaultsContent).Groups[1].Value);
                            ItemSetDefaultsContent = ItemSetDefaultsContent.Replace(ReadUseTimeFromFile.Match(ItemSetDefaultsContent).Groups[0].Value, "");
                        }
                        if (ReadUseAnimationFromFile.Match(ItemSetDefaultsContent).Success)
                        {
                            ItemMovementCheckBox.Checked = true;
                            ItemUseAnimationNumericUpDown.Value = Convert.ToInt16(ReadUseAnimationFromFile.Match(ItemSetDefaultsContent).Groups[1].Value);
                            ItemSetDefaultsContent = ItemSetDefaultsContent.Replace(ReadUseAnimationFromFile.Match(ItemSetDefaultsContent).Groups[0].Value, "");
                        }
                        if (ReadAutoReuseFromFile.Match(ItemSetDefaultsContent).Success)
                        {
                            ItemMovementCheckBox.Checked = true;
                            ItemAutoReuseComboBox.Text = ReadAutoReuseFromFile.Match(ItemSetDefaultsContent).Groups[1].Value;
                            ItemSetDefaultsContent = ItemSetDefaultsContent.Replace(ReadAutoReuseFromFile.Match(ItemSetDefaultsContent).Groups[0].Value, "");
                        }
                        if (ReadUseTurnFromFile.Match(ItemSetDefaultsContent).Success)
                        {
                            ItemMovementCheckBox.Checked = true;
                            ItemUseTurnComboBox.Text = ReadUseTurnFromFile.Match(ItemSetDefaultsContent).Groups[1].Value;
                            ItemSetDefaultsContent = ItemSetDefaultsContent.Replace(ReadUseTurnFromFile.Match(ItemSetDefaultsContent).Groups[0].Value, "");
                        }
                        if (ReadUseStyleFromFile.Match(ItemSetDefaultsContent).Success)
                        {
                            ItemMovementCheckBox.Checked = true;
                            ItemUseStyleComboBox.Text = ReadUseStyleFromFile.Match(ItemSetDefaultsContent).Groups[1].Value;
                            ItemSetDefaultsContent = ItemSetDefaultsContent.Replace(ReadUseStyleFromFile.Match(ItemSetDefaultsContent).Groups[0].Value, "");
                        }
                        if (ReadNoUseGraphicFromFile.Match(ItemSetDefaultsContent).Success)
                        {
                            ItemMovementCheckBox.Checked = true;
                            ItemNoUseGraphicComboBox.Text = ReadNoUseGraphicFromFile.Match(ItemSetDefaultsContent).Groups[1].Value;
                            ItemSetDefaultsContent = ItemSetDefaultsContent.Replace(ReadNoUseGraphicFromFile.Match(ItemSetDefaultsContent).Groups[0].Value, "");
                        }
                        // 武器工具属性
                        if (ReadDamageFromFile.Match(ItemSetDefaultsContent).Success)
                        {
                            ItemItemCheckBox.Checked = true;
                            ItemDamageNumericUpDown.Value = Convert.ToInt16(ReadDamageFromFile.Match(ItemSetDefaultsContent).Groups[1].Value);
                            ItemSetDefaultsContent = ItemSetDefaultsContent.Replace(ReadDamageFromFile.Match(ItemSetDefaultsContent).Groups[0].Value, "");
                        }
                        if (ReadKnockBackFromFile.Match(ItemSetDefaultsContent).Success)
                        {
                            ItemItemCheckBox.Checked = true;
                            ItemKnockbackNumericUpDown.Value = Convert.ToInt16(ReadKnockBackFromFile.Match(ItemSetDefaultsContent).Groups[1].Value);
                            ItemSetDefaultsContent = ItemSetDefaultsContent.Replace(ReadKnockBackFromFile.Match(ItemSetDefaultsContent).Groups[0].Value, "");
                        }
                        if (ReadCritFromFile.Match(ItemSetDefaultsContent).Success)
                        {
                            ItemItemCheckBox.Checked = true;
                            ItemCritNumericUpDown.Value = Convert.ToInt16(ReadCritFromFile.Match(ItemSetDefaultsContent).Groups[1].Value);
                            ItemSetDefaultsContent = ItemSetDefaultsContent.Replace(ReadCritFromFile.Match(ItemSetDefaultsContent).Groups[0].Value, "");
                        }
                        if (ReadDamageTypeFromFile.Match(ItemSetDefaultsContent).Success)
                        {
                            ItemItemCheckBox.Checked = true;
                            ItemDamageTypeComboBox.Text = ReadDamageTypeFromFile.Match(ItemSetDefaultsContent).Groups[1].Value.Trim();
                            ItemSetDefaultsContent = ItemSetDefaultsContent.Replace(ReadDamageTypeFromFile.Match(ItemSetDefaultsContent).Groups[0].Value, "");
                        }
                        if (ReadPickFromFile.Match(ItemSetDefaultsContent).Success)
                        {
                            ItemItemCheckBox.Checked = true;
                            ItemPickNumericUpDown.Value = Convert.ToInt16(ReadPickFromFile.Match(ItemSetDefaultsContent).Groups[1].Value);
                            ItemSetDefaultsContent = ItemSetDefaultsContent.Replace(ReadPickFromFile.Match(ItemSetDefaultsContent).Groups[0].Value, "");
                        }
                        if (ReadAxeFromFile.Match(ItemSetDefaultsContent).Success)
                        {
                            ItemItemCheckBox.Checked = true;
                            ItemAxeNumericUpDown.Value = Convert.ToInt16(ReadAxeFromFile.Match(ItemSetDefaultsContent).Groups[1].Value);
                            ItemSetDefaultsContent = ItemSetDefaultsContent.Replace(ReadAxeFromFile.Match(ItemSetDefaultsContent).Groups[0].Value, "");
                        }
                        if (ReadHammerFromFile.Match(ItemSetDefaultsContent).Success)
                        {
                            ItemItemCheckBox.Checked = true;
                            ItemHammerNumericUpDown.Value = Convert.ToInt16(ReadHammerFromFile.Match(ItemSetDefaultsContent).Groups[1].Value);
                            ItemSetDefaultsContent = ItemSetDefaultsContent.Replace(ReadHammerFromFile.Match(ItemSetDefaultsContent).Groups[0].Value, "");
                        }
                        if (ReadNoMeleeFromFile.Match(ItemSetDefaultsContent).Success)
                        {
                            ItemItemCheckBox.Checked = true;
                            ItemNoMeleeComboBox.Text = ReadNoMeleeFromFile.Match(ItemSetDefaultsContent).Groups[1].Value;
                            ItemSetDefaultsContent = ItemSetDefaultsContent.Replace(ReadNoMeleeFromFile.Match(ItemSetDefaultsContent).Groups[0].Value, "");
                        }
                        // 发射
                        if (ReadShootFromFile.Match(ItemSetDefaultsContent).Success)
                        {
                            ItemShootCheckBox.Checked = true;
                            ItemShootNumericUpDown.Value = Convert.ToInt32(ReadShootFromFile.Match(ItemSetDefaultsContent).Groups[1].Value);
                            ItemSetDefaultsContent = ItemSetDefaultsContent.Replace(ReadShootFromFile.Match(ItemSetDefaultsContent).Groups[0].Value, "");
                        }
                        if (ReadShootUOPFromFile.Match(ItemSetDefaultsContent).Success)
                        {
                            ItemShootIUOPCheckBox.Checked = true;
                            ItemShootCheckBox.Checked = true;
                            ItemShootUOPComboBox.Text = ReadShootUOPFromFile.Match(ItemSetDefaultsContent).Groups[1].Value.Trim();
                            ItemSetDefaultsContent = ItemSetDefaultsContent.Replace(ReadShootUOPFromFile.Match(ItemSetDefaultsContent).Groups[0].Value, "");
                        }
                        if (ReadShootSpeedFromFile.Match(ItemSetDefaultsContent).Success)
                        {
                            ItemShootCheckBox.Checked = true;
                            ItemShootSpeedNumericUpDown.Value = Convert.ToInt16(ReadShootSpeedFromFile.Match(ItemSetDefaultsContent).Groups[1].Value);
                            ItemSetDefaultsContent = ItemSetDefaultsContent.Replace(ReadShootSpeedFromFile.Match(ItemSetDefaultsContent).Groups[0].Value, "");
                        }
                        SetDefaultsOtherCodes.Text = ItemSetDefaultsContent;

                    }
                    else
                    {

                    }

                    //获取Projectile并放入ItemShootUOPComboBox
                    List<string> ProjectileAllItemNamespace = null;
                    List<string> ProjectileAllItemPath = null;
                    int CycleTime = 0;
                    while (CycleTime < Main.ObjectListView.Groups[1].Items.Count)
                    {



                        ItemShootUOPComboBox.Items.Add($"ModContent.ProjectileType<{Main.ObjectListView.Groups[1].Items[CycleTime].ToString().Replace("ListViewItem: {", "").Replace("}", "")}>()");
                        //ModContent.ProjectileType<ExampleSimpleMinion>()
                        //using <Modname>.<Projectile>
                        CycleTime++;
                    }


                }



            }
            catch (Exception e)
            {
                MessageBox.Show("稀有错误,匹配错误", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //刷新窗体
            this.Refresh();


        }

        //写代码
        public string WriteItemCode()
        {
            var sb = new StringBuilder();
            string ns = ProjectData.ProjectNamespace + ".Items";
            string className = ItemNamespaceTextBox.Text.Trim();
            string itemName = ItemNameTextBox.Text.Trim();

            // 1. 基础using语句
            sb.AppendLine("using Terraria;");
            sb.AppendLine("using Terraria.ID;");
            sb.AppendLine("using Terraria.ModLoader;");
            sb.AppendLine("using Microsoft.Xna.Framework;");

            // 2. 自动添加using语句（如ModContent.ProjectileType<nature>()）
            var usingSet = new HashSet<string>();
            if (ItemShootIUOPCheckBox.Checked && !string.IsNullOrWhiteSpace(ItemShootUOPComboBox.Text))
            {
                // 解析泛型类型名
                var match = System.Text.RegularExpressions.Regex.Match(ItemShootUOPComboBox.Text, @"ModContent\.ProjectileType<(\w+)>");
                if (match.Success)
                {
                    string projClass = match.Groups[1].Value;
                    // 在ObjectListView的Projectile分组中查找Tag
                    var group = Main.ObjectListView.Groups.Count > 1 ? Main.ObjectListView.Groups[1] : null;
                    if (group != null)
                    {
                        foreach (ListViewItem item in group.Items)
                        {
                            if (item.Text == projClass && item.Tag is string filePath)
                            {
                                var relPath = filePath.Replace(ProjectData.ProjectPath, "res:");
                                var nsPathMatch = System.Text.RegularExpressions.Regex.Match(relPath, @"res:\\(?<folders>.+)\\[^\\]+$");
                                if (nsPathMatch.Success)
                                {
                                    var folders = nsPathMatch.Groups["folders"].Value.Replace("\\", ".");
                                    usingSet.Add($"using {ProjectData.ProjectNamespace}.{folders};");
                                }
                                break;
                            }
                        }
                    }
                }
            }
            foreach (var u in usingSet)
                sb.AppendLine(u);

            sb.AppendLine($"namespace {ns}");
            sb.AppendLine("{");
            sb.AppendLine($"    public class {className} : ModItem");
            sb.AppendLine("    {");
            sb.AppendLine("        public override void SetDefaults()");
            sb.AppendLine("        {");
            sb.AppendLine($"            Item.width = {ItemWidthNumericUpDown.Value};");
            sb.AppendLine($"            Item.height = {ItemHeightNumericUpDown.Value};");
            sb.AppendLine($"            Item.maxStack = {ItemMaxStackNumericUpDown.Value};");
            sb.AppendLine($"            Item.value = {ItemValueNumericUpDown.Value};");
            sb.AppendLine($"            Item.rare = {ItemRareComboBox.Text.Split('/')[0].Trim()};");
            sb.AppendLine($"            Item.useSound = {ItemSoundNumericUpDown.Value};");

            if (ItemMovementCheckBox.Checked)
            {
                sb.AppendLine($"            Item.useTime = {ItemUseTimeNumericUpDown.Value};");
                sb.AppendLine($"            Item.useAnimation = {ItemUseAnimationNumericUpDown.Value};");
                sb.AppendLine($"            Item.autoReuse = {ItemAutoReuseComboBox.Text.ToLower()};");
                sb.AppendLine($"            Item.useTurn = {ItemUseTurnComboBox.Text.ToLower()};");
                sb.AppendLine($"            Item.useStyle = {ItemUseStyleComboBox.Text.Split('/')[0].Trim()};");
                sb.AppendLine($"            Item.noUseGraphic = {ItemNoUseGraphicComboBox.Text.ToLower()};");
            }

            if (ItemItemCheckBox.Checked)
            {
                sb.AppendLine($"            Item.damage = {ItemDamageNumericUpDown.Value};");
                sb.AppendLine($"            Item.knockBack = {ItemKnockbackNumericUpDown.Value};");
                sb.AppendLine($"            Item.crit = {ItemCritNumericUpDown.Value};");
                sb.AppendLine($"            Item.DamageType = {ItemDamageTypeComboBox.Text};");
                sb.AppendLine($"            Item.pick = {ItemPickNumericUpDown.Value};");
                sb.AppendLine($"            Item.axe = {ItemAxeNumericUpDown.Value};");
                sb.AppendLine($"            Item.hammer = {ItemHammerNumericUpDown.Value};");
                sb.AppendLine($"            Item.noMelee = {ItemNoMeleeComboBox.Text.ToLower()};");
            }

            if (ItemShootCheckBox.Checked)
            {
                if (ItemShootIUOPCheckBox.Checked && !string.IsNullOrWhiteSpace(ItemShootUOPComboBox.Text))
                {
                    sb.AppendLine($"            Item.shoot = {ItemShootUOPComboBox.Text};");
                }
                else
                {
                    sb.AppendLine($"            Item.shoot = {ItemShootNumericUpDown.Value};");
                }
                sb.AppendLine($"            Item.shootSpeed = {ItemShootSpeedNumericUpDown.Value};");
            }

            // 3. 追加自定义代码（已在PreviewCode_Click做了重复判断）
            if (!string.IsNullOrWhiteSpace(SetDefaultsOtherCodes.Text))
            {
                sb.AppendLine($"            {SetDefaultsOtherCodes.Text.Replace(Environment.NewLine, Environment.NewLine + "            ")}");
            }

            sb.AppendLine("        }");
            sb.AppendLine("    }");
            sb.AppendLine("}");

            return sb.ToString();
        }

        private void ItemSettings_Load(object sender, EventArgs e)
        {
            this.BackColor = TerraCreatorData.FormBackColor;
            ItemSetDefaultsTabPage.BackColor = TerraCreatorData.FormToolColor;
            ItemAddRecipesTabPage.BackColor = TerraCreatorData.FormToolColor;
        }



        private void PreviewCode_Click(object sender, EventArgs e)
        {
            // 检查自定义代码是否有重复行
            var customCode = SetDefaultsOtherCodes.Text;
            var lines = customCode.Split(new[] { "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries);
            var duplicates = lines.GroupBy(x => x.Trim()).Where(g => g.Count() > 1 && !string.IsNullOrWhiteSpace(g.Key)).Select(g => g.Key).ToList();
            if (duplicates.Count > 0)
            {
                MessageBox.Show($"自定义代码有重复项:\n{string.Join("\n", duplicates)}", "重复代码", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 检查属性重复
            var propertyList = new[]
            {
                "Item.width",
                "Item.height",
                "Item.maxStack",
                "Item.value",
                "Item.rare",
                "Item.useSound",
                "Item.useTime",
                "Item.useAnimation",
                "Item.autoReuse",
                "Item.useTurn",
                "Item.useStyle",
                "Item.noUseGraphic",
                "Item.damage",
                "Item.knockBack",
                "Item.crit",
                "Item.DamageType",
                "Item.pick",
                "Item.axe",
                "Item.hammer",
                "Item.noMelee",
                "Item.shoot",
                "Item.shootSpeed"
            };

            var customCodeLower = customCode.ToLower();
            var repeatedProps = new List<string>();
            foreach (var prop in propertyList)
            {
                // 检查自定义代码是否有该属性赋值
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

            CodeViewRichTextBox.Text = WriteItemCode();
        }

        private void OriginalCode_Click(object sender, EventArgs e)
        {
            CodeViewRichTextBox.Text = ItemContentWithoutLineRead;
        }

        // 1. 添加贴图选择按钮事件
        private string selectedImagePath = "";

        private void SelectImageButton_Click(object sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog())
            {
                ofd.Filter = "PNG图片|*.png";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    selectedImagePath = ofd.FileName;
                    ItemImagePictureBox.Image = Image.FromFile(selectedImagePath);
                    ItemImagePathLabel.Text = selectedImagePath;
                }
            }
        }

        // 2. 检查控件数据是否为空
        private bool CheckControlsForEmpty()
        {
            var controlsToCheck = new Control[]
            {
                ItemNamespaceTextBox,
                ItemNameTextBox,
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

        // 3. 保存代码和贴图
        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (CheckControlsForEmpty()) return;

            DialogResult confirm = MessageBox.Show("你确定要保存当前代码和贴图吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (confirm == DialogResult.OK)
            {
                try
                {
                    // 保存代码
                    File.WriteAllText(ItemPathGlobal, CodeViewRichTextBox.Text);

                    // 保存贴图
                    if (!string.IsNullOrWhiteSpace(selectedImagePath))
                    {
                        var targetImagePath = ItemPathGlobal.Replace(".cs", ".png");
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
    }
}
