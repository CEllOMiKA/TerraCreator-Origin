using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using TerraCreator;
using TerraCreator.objectedit;
using System.Media;
using Microsoft.VisualBasic.Logging;
namespace TerraCreator
{
    public partial class Main : Form
    {


        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            fileview.BackColor = TerraCreatorData.FormToolColor;
            codes.BackColor = TerraCreatorData.FormToolColor;
            this.BackColor = TerraCreatorData.FormBackColor;
            ObjectListView.BackColor = TerraCreatorData.FormToolColor;
            Panel.BackColor = TerraCreatorData.FormToolColor;
            ObjectPanel.BackColor = TerraCreatorData.FormToolColor;
            ObjectProject.BackColor = TerraCreatorData.FormToolColor;
        }


        //关于
        private void toolst_about_Click(object sender, EventArgs e)
        {
            Form about = new about();
            about.Show();
        }

        //退出程序
        private void toolst_exitprog_Click(object sender, EventArgs e)
        {
            DialogResult ConfirmExit = MessageBox.Show("是否退出TerraCreator", "退出", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (ConfirmExit == DialogResult.OK)
            {
                this.Close();
            }

        }

        //新建对象
        private void toolst_newitem_Click(object sender, EventArgs e)
        {
            NewItem();
        }

        //导入项目
        private void toolst_newproj_Click(object sender, EventArgs e)
        {
            if (ProjectData.ProjectChecked)
            {
                DialogResult IfWantToRestartApp =
                MessageBox.Show("重导入需重新启动程序\n是否关闭程序", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (IfWantToRestartApp == DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start("TerraCreator.exe");
                    this.Close();
                }
            }
            else
            {
                Form NewProject = new NewProject();
                NewProject.Show();
            }

        }

        private void ImportProject_Click(object sender, EventArgs e)
        {
            if (ProjectData.ProjectChecked)
            {
                DialogResult IfWantToRestartApp =
                MessageBox.Show("重导入需重新启动程序\n是否关闭程序", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (IfWantToRestartApp == DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start("TerraCreator.exe");
                    this.Close();
                }
            }
            else
            {
                Form NewProject = new NewProject();
                NewProject.Show();
            }
        }

        //显示字数
        private void codes_TextChanged(object sender, EventArgs e)
        {

            codes.LanguageOption = RichTextBoxLanguageOptions.UIFonts;

            CodeCount.Text = "字数:" + Convert.ToString(codes.Text.Count());

            Main.codes.SuspendLayout();
            //ColortheCode();
            
        }


        private void codes_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Control && e.KeyCode == Keys.Z)
            {
                Main.codes.ResumeLayout();
            }
        }

        //突出代码
        public static void ColortheCode()
        {
            // 获取主窗体实例（更稳健）
            var rtb = Main.codes;
            if (rtb == null) return;

            // 防止对极大文本阻塞 UI（阈值可调）
            const int MaxLengthToHighlight = 200_000;
            if (rtb.Text.Length > MaxLengthToHighlight) return;

            // 关键字（小写比较用 IgnoreCase）
            string[] keywords = new string[]
            {
                "abstract","as","base","bool","break","byte","case","catch","char","checked","class","const","continue",
                "decimal","default","delegate","do","double","else","enum","event","explicit","extern","false","finally",
                "fixed","float","for","foreach","goto","if","implicit","in","int","interface","internal","is","lock",
                "long","namespace","new","null","object","operator","out","override","params","private","protected",
                "public","readonly","ref","return","sbyte","sealed","short","sizeof","stackalloc","static","string",
                "struct","switch","this","throw","true","try","typeof","uint","ulong","unchecked","unsafe","ushort",
                "using","virtual","void","volatile","while","var","dynamic","get","set","partial","record",
                "init","when","with","yield"
            };

            // 颜色定义
            Color defaultColor = Color.Black;
            Color keywordColor = Color.Blue;
            Color commentColor = Color.Green;
            Color functionColor = Color.Red;
            Color numberColor = Color.DarkGreen;
            Color callColor = Color.Orange;

            // 冻结重绘
            NativeMethods.SendMessage(rtb.Handle, NativeMethods.WM_SETREDRAW, false, 0);
            rtb.SuspendLayout();

            // 保存光标
            int selStart = rtb.SelectionStart;
            int selLength = rtb.SelectionLength;

            // 先重置全部文本颜色
            rtb.SelectAll();
            rtb.SelectionColor = defaultColor;

            // 优先高亮 字符串与注释，避免关键字在注释/字符串里也被高亮
            var stringMatches = System.Text.RegularExpressions.Regex.Matches(rtb.Text, @"@?""([^""]|(""""))*""", System.Text.RegularExpressions.RegexOptions.Singleline);
            foreach (System.Text.RegularExpressions.Match m in stringMatches)
            {
                rtb.Select(m.Index, m.Length);
                rtb.SelectionColor = Color.Brown;
            }

            var singleLineMatches = System.Text.RegularExpressions.Regex.Matches(rtb.Text, @"//.*?$", System.Text.RegularExpressions.RegexOptions.Multiline);
            foreach (System.Text.RegularExpressions.Match m in singleLineMatches)
            {
                rtb.Select(m.Index, m.Length);
                rtb.SelectionColor = commentColor;
            }

            var multiLineMatches = System.Text.RegularExpressions.Regex.Matches(rtb.Text, @"/\*.*?\*/", System.Text.RegularExpressions.RegexOptions.Singleline);
            foreach (System.Text.RegularExpressions.Match m in multiLineMatches)
            {
                rtb.Select(m.Index, m.Length);
                rtb.SelectionColor = commentColor;
            }

            // 高亮关键字（忽略大小写）
            foreach (string kw in keywords)
            {
                var matches = System.Text.RegularExpressions.Regex.Matches(rtb.Text, $@"\b{System.Text.RegularExpressions.Regex.Escape(kw)}\b", System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                foreach (System.Text.RegularExpressions.Match m in matches)
                {
                    rtb.Select(m.Index, m.Length);
                    rtb.SelectionColor = keywordColor;
                }
            }

            // 数字
            var numberMatches = System.Text.RegularExpressions.Regex.Matches(rtb.Text, @"\b\d+(\.\d+)?\b");
            foreach (System.Text.RegularExpressions.Match m in numberMatches)
            {
                rtb.Select(m.Index, m.Length);
                rtb.SelectionColor = numberColor;
            }

            // 函数调用名（形如 name(...), 高亮 name）
            var callMatches = System.Text.RegularExpressions.Regex.Matches(rtb.Text, @"\b([A-Za-z_]\w*)\s*\(");
            foreach (System.Text.RegularExpressions.Match m in callMatches)
            {
                int idx = m.Groups[1].Index;
                int len = m.Groups[1].Length;
                rtb.Select(idx, len);
                rtb.SelectionColor = callColor;
            }

            // 方法/函数声明名（覆盖为 functionColor）
            var funcRegex = new System.Text.RegularExpressions.Regex(@"\b(public|private|protected|internal|static|virtual|override|sealed|async|extern|unsafe|partial|new)\s+[\w<>\[\],\s]+\s+([A-Za-z_]\w*)\s*\(", System.Text.RegularExpressions.RegexOptions.Compiled | System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            var funcMatches = funcRegex.Matches(rtb.Text);
            foreach (System.Text.RegularExpressions.Match m in funcMatches)
            {
                int funcNameIndex = m.Groups[2].Index;
                int funcNameLength = m.Groups[2].Length;
                rtb.Select(funcNameIndex, funcNameLength);
                rtb.SelectionColor = functionColor;
            }

            // 恢复光标
            rtb.SelectionStart = selStart;
            rtb.SelectionLength = selLength;
            rtb.SelectionColor = defaultColor;

            rtb.ResumeLayout();
            NativeMethods.SendMessage(rtb.Handle, NativeMethods.WM_SETREDRAW, true, 0);
            rtb.Invalidate();
        }



        // Win32 API 用于冻结/恢复重绘
        internal static class NativeMethods
        {
            public const int WM_SETREDRAW = 0x0b;
            [System.Runtime.InteropServices.DllImport("user32.dll")]
            public static extern int SendMessage(IntPtr hWnd, int wMsg, bool wParam, int lParam);
        }



        //刷新文件视图和对象视图
        private void fresh_Click(object sender, EventArgs e)
        {

            Fresh();


        }

        //保存
        private void toolst_save_Click(object sender, EventArgs e)
        {
            SaveFile();

        }

        //保存
        private void save_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        // 新建对象
        private void additem_Click(object sender, EventArgs e)
        {
            NewItem();
        }

        // 打开设置窗口
        private void settings_Click(object sender, EventArgs e)
        {
            Form Settings = new Settings();
            Settings.Show();
        }

        // 打开项目设置
        private void ProjectSettings_Click(object sender, EventArgs e)
        {
            if (!ProjectData.ProjectChecked)
            {
                MessageBox.Show("你还没有打开项目", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Form ProjectSettings = new ProjectSettings();
            ProjectSettings.Show();

        }


        // 选择文件树 处理文件树视图选择事件
        private void fileview_AfterSelect(object sender, TreeViewEventArgs e)
        {
            fileTreeView_AfterSelect(ProjectData.ProjectPath, e);
        }

        // 处理文件树视图选择事件
        public static void LoadFileTreeView(string folderPath)
        {
            if (ProjectData.ProjectChecked)
            {
                DirectoryInfo rootDir = new DirectoryInfo(folderPath);
                TreeNode rootNode = new TreeNode(rootDir.Name) { Tag = rootDir };
                fileview.Nodes.Add(rootNode);
                LoadFilesAndDirectories(rootDir, rootNode);

            }
            else
            {
                MessageBox.Show("你还没有打开项目", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        // 递归加载文件和目录到树视图
        private static void LoadFilesAndDirectories(DirectoryInfo directory, TreeNode parentNode)
        {
            foreach (var dir in directory.GetDirectories())
            {
                TreeNode dirNode = new TreeNode(dir.Name) { Tag = dir };
                parentNode.Nodes.Add(dirNode);
                LoadFilesAndDirectories(dir, dirNode);
            }

            foreach (var file in directory.GetFiles())
            {
                TreeNode fileNode = new TreeNode(file.Name) { Tag = file };
                parentNode.Nodes.Add(fileNode);
            }
        }

        // 判断文件类型并显示内容
        private void fileTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Tag is FileInfo fileInfo)
            {
                try
                {
                    Regex checkPNG = new Regex("^.*\\.(jpg|jpeg|png|gif|bmp|tiff)$");
                    Match matchPNG = checkPNG.Match(fileInfo.FullName);
                    if (matchPNG.Success)
                    {
                        ImageFileOpened();
                    }
                    else
                    {
                        CodeFileOpened();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"无法读取文件: \n{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            void CodeFileOpened()
            {
                codes.Visible = true;
                ImageBox.Visible = false;
                ImageBox.Image = null;
                FileViewEdit.Items.Clear();

                FilePropt.Text = fileInfo.Name;
                codes.Text = File.ReadAllText(fileInfo.FullName);
                CodeCount.Text = "字数:" + Convert.ToString(codes.Text.Count());

                var ColortheCodeToolStripItem = FileViewEdit.Items.Add("代码着色");
                ColortheCodeToolStripItem.Text = "代码着色";
                ColortheCodeToolStripItem.Click += ColortheCodeToolStripItem_Click;
                ColortheCodeToolStripItem.Image = Properties.Resources.ColortheCode;
                ColortheCodeToolStripItem.DisplayStyle = ToolStripItemDisplayStyle.Image;

                void ColortheCodeToolStripItem_Click(object? sender,EventArgs e)
                {
                    ColortheCode();
                }

            }

            void ImageFileOpened()
            {
                codes.Visible = false;
                ImageBox.Visible = true;
                codes.Text = "";
                FileViewEdit.Items.Clear();

                FilePropt.Text = fileInfo.Name;
                CodeCount.Text = "图片";
                ImageBox.SizeMode = PictureBoxSizeMode.CenterImage;
                ImageBox.Image = Image.FromFile(fileInfo.FullName);

            }



        }






        //旧代码
        //public static List<string> GetClassBaseTypes(string folderPath)
        //{
        //    var result = new List<string>();
        //    var csFiles = Directory.GetFiles(folderPath, "*.cs", SearchOption.AllDirectories);
        //    // 匹配 public class 类名 : 基类[,接口...]
        //    var regex = new Regex(@"public\s+class\s+\w+\s*:\s*([^{,\s]+)", RegexOptions.Compiled);

        //    foreach (var file in csFiles)
        //    {
        //        var content = File.ReadAllText(file);
        //        foreach (Match match in regex.Matches(content))
        //        {
        //            // match.Groups[1] 是继承的基类（第一个冒号后的类型）
        //            result.Add(match.Groups[1].Value);
        //        }
        //    }
        //    return result;
        //}
        //public static void PutClassBaseTypesIntoObjectListView(string folderPath)
        //{

        //    ObjectListView.Items.Clear();
        //    var baseTypes = GetClassBaseTypes(folderPath);
        //    foreach (var baseType in baseTypes)
        //    {
        //        var item = new ListViewItem(baseType);
        //        if (item.Text == "ModItem")
        //        {
        //            ObjectListView.Groups[0].Items.Add(item);
        //        }
        //        if(item.Text == "ModProjectile")
        //        {
        //            ObjectListView.Groups[1].Items.Add(item);
        //        }
        //    }

        //}



        //将.cs文件中的类基类放入ObjectListView中
        public static void PutClassBaseTypesIntoObjectListView(string folderPath)
        {
            ObjectListView.Items.Clear();
            try
            {
                var csFiles = Directory.GetFiles(folderPath, "*.cs", SearchOption.AllDirectories);
                var regex = new Regex(@"public\s+class\s+(\w+)\s*:\s*([^{,\s]+)", RegexOptions.Compiled);
                foreach (var file in csFiles)
                {
                    var content = File.ReadAllText(file);
                    foreach (Match match in regex.Matches(content))
                    {
                        string className = match.Groups[1].Value;
                        string baseTypeFull = match.Groups[2].Value;
                        // 只取短名（去掉命名空间和泛型参数）
                        var shortBase = baseTypeFull.Split('.').Last();
                        if (shortBase.Contains("<")) shortBase = shortBase.Substring(0, shortBase.IndexOf("<"));

                        var item = new ListViewItem(className);

                        if (shortBase.Equals("Mod")) continue;

                        if (shortBase.Equals("ModItem", StringComparison.OrdinalIgnoreCase) && ObjectListView.Groups.Count > 0)
                        {
                            item.Group = ObjectListView.Groups[0];
                            item.Tag = file;
                        }
                        else if (shortBase.Equals("ModProjectile", StringComparison.OrdinalIgnoreCase) && ObjectListView.Groups.Count > 1)
                        {
                            item.Group = ObjectListView.Groups[1];
                            item.Tag = file;
                        }
                        else if (shortBase.Equals("ModNPC", StringComparison.OrdinalIgnoreCase) && ObjectListView.Groups.Count > 2)
                        {
                            item.Group = ObjectListView.Groups[2];
                            item.Tag = file;
                        }
                        else if (shortBase.Equals("ModTile", StringComparison.OrdinalIgnoreCase) && ObjectListView.Groups.Count > 3)
                        {
                            item.Group = ObjectListView.Groups[3];
                            item.Tag = file;
                        }
                        ObjectListView.Items.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"加载对象列表失败: {ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        // 处理对象列表视图选择事件

        private void ObjectListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (ObjectListView.SelectedItems.Count > 0)
            {
                if(ObjectListView.SelectedItems.Count > 1)
                {
                    return;
                }
                if (e.Item.Group == null)
                {
                    return;
                }
                if (e.Item.Tag == null)
                {
                    MessageBox.Show("无法访问此对象的Tag\n(Tag中存放对象路径)", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string SelectedObjectPath = e.Item.Tag.ToString();
                string SelectedObjectNamespace = e.Item.Text;

                //Item
                if (e.Item.Group.Name == "ModItem")
                {
                    ObjectPanel.Controls.Clear();
                    try
                    {
                        Form ItemSettingFormVar = new ItemSettings(SelectedObjectPath, SelectedObjectNamespace);
                        //ItemSetting.ItemPathGlobal = SelectedObjectPath;
                        ItemSettingFormVar.TopLevel = false;
                        ItemSettingFormVar.Parent = ObjectPanel;
                        ItemSettingFormVar.Show();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"无法加载物品设置: \n{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                //Projectile
                if (e.Item.Group.Name == "ModProjectile")
                {
                    ObjectPanel.Controls.Clear();
                    try
                    {
                        Form ProjectileSettingFormVar = new ProjectileSettingForm(SelectedObjectPath, SelectedObjectNamespace);
                        ProjectileSettingForm.ProjectilePathGlobal = SelectedObjectPath;
                        ProjectileSettingFormVar.TopLevel = false;
                        ProjectileSettingFormVar.Parent = ObjectPanel;
                        ProjectileSettingFormVar.Show();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"无法加载射弹设置: \n{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }


            }

        }






        // 添加文件到项目
        private void toolst_additemintoproj_Click(object sender, EventArgs e)
        {

            bool CopyChecked = false;
            string ChooseFilePath = "";
            string ChooseFolderPath = "";
            string ChooseFileName = "";

            if (ProjectData.ProjectChecked)
            {

                OpenFileDialog ChooseAddFile = new OpenFileDialog();
                ChooseAddFile.Filter = "所有文件(*.*)|*.*";
                ChooseAddFile.Title = "选择要导入的文件";
                ChooseAddFile.FilterIndex = 0;
                DialogResult result = ChooseAddFile.ShowDialog();

                if (result == DialogResult.OK)
                {
                    ChooseFilePath = ChooseAddFile.FileName;
                    ChooseFileName = ChooseAddFile.SafeFileName;

                    FolderBrowserDialog ChooseWhichFolder = new FolderBrowserDialog();
                    ChooseWhichFolder.SelectedPath = ProjectData.ProjectPath;
                    ChooseWhichFolder.Description = "选择要导入的文件夹";
                    DialogResult FolderChoosen = ChooseWhichFolder.ShowDialog();
                    if (FolderChoosen == DialogResult.OK)
                    {
                        DialogResult ConfirmCopy = MessageBox.Show(
                            $"导入文件到项目文件夹会覆盖文件" +
                            $"\n源文件地址:{ChooseAddFile.FileName}" +
                            $"\n导入文件夹地址:{ChooseWhichFolder.SelectedPath}",
                            "提示",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question
                        );

                        if (ConfirmCopy == DialogResult.Yes)
                        {
                            ChooseFolderPath = ChooseWhichFolder.SelectedPath;
                            CopyChecked = true;
                        }

                    }
                }

            }
            else
            {
                MessageBox.Show("你还没有打开项目", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //copy
            if (CopyChecked)
            {
                try
                {
                    System.IO.File.Copy(ChooseFilePath, ChooseFolderPath + "\\" + ChooseFileName, true);
                    Fresh(); // 刷新文件视图
                    MessageBox.Show($"导入成功\n文件地址:{ChooseFilePath}", "导入成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"复制失败:\n {ex.Message}\n请手动导入", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }

        // 添加插件
        private void addon_Click(object sender, EventArgs e)
        {
            MessageBox.Show("开发中...", "提示");
        }

        // 按下另存为
        private void toolst_SaveAs_Click(object sender, EventArgs e)
        {
            SaveAsFile();

        }

        // 运行tModLoader
        private void RuntML_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("explorer", "steam://rungameid/1281930");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"无法打开\n请确保你安装了Steam和tModLoader\n{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OpenTML_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("explorer", "steam://rungameid/1281930");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"无法打开\n请确保你安装了Steam和tModLoader\n{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 打开csproj文件
        private void OpenCsproj_Click(object sender, EventArgs e)
        {
            if (ProjectData.ProjectChecked)
            {
                try
                {
                    MessageBox.Show(ProjectData.ProjectPath + "\\" + ProjectData.ProjectNamespace + ".csproj");
                    System.Diagnostics.Process.Start("explorer", ProjectData.ProjectPath + "\\" + ProjectData.ProjectNamespace + ".csproj");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"无法打开.csproj文件\n{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("你还没有打开项目", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OpenCsprojFile_Click(object sender, EventArgs e)
        {
            if (ProjectData.ProjectChecked)
            {
                try
                {
                    MessageBox.Show(ProjectData.ProjectPath + "\\" + ProjectData.ProjectNamespace + ".csproj");
                    System.Diagnostics.Process.Start("explorer", ProjectData.ProjectPath + "\\" + ProjectData.ProjectNamespace + ".csproj");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"无法打开.csproj文件\n{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("你还没有打开项目", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        //保存文件
        void SaveFile()
        {
            if (ProjectData.ProjectChecked)
            {
                if (codes.Text == "")
                {
                    MessageBox.Show("你还没有打开文本文件", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (fileview.SelectedNode != null && fileview.SelectedNode.Tag is FileInfo fileInfo)
                {

                    if (!File.Exists(fileInfo.FullName))
                    {
                        //MessageBox.Show("没有这个文件\n请点击另存为", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        // Save As
                        SaveAsFile();
                        return;
                    }
                    else
                    {
                        try
                        {
                            File.WriteAllText(fileInfo.FullName, codes.Text);
                            MessageBox.Show("文件已保存", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            RefreshFileViewAndSelect(fileInfo.FullName); // 保存
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"保存文件失败: {ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                }
                else
                {
                    MessageBox.Show("请选择要保存的文件", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            else
            {
                MessageBox.Show("你还没有打开项目", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //新建对象
        void NewItem()
        {
            if (ProjectData.ProjectChecked)
            {
                Form additem = new AddItem();
                additem.Show();
            }
            else
            {
                MessageBox.Show("你还没有打开项目", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        //另存为文件
        void SaveAsFile()
        {
            if (ProjectData.ProjectChecked)
            {

                if (codes.Text == "")
                {
                    MessageBox.Show("你还没有打开文本文件", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (fileview.SelectedNode != null && fileview.SelectedNode.Tag is FileInfo fileInfo)
                {

                    //SaveAs
                    SaveFileDialog ChooseSaveAsPath = new SaveFileDialog();
                    ChooseSaveAsPath.Filter = ChooseSaveAsPath.Filter = "文本文件|*.txt|C#代码文件|*.cs|所有文件|*.*";
                    ChooseSaveAsPath.RestoreDirectory = true;
                    ChooseSaveAsPath.FilterIndex = 2;
                    ChooseSaveAsPath.Title = "另存为文件";

                    //ifPressOK
                    if (ChooseSaveAsPath.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            string filePath = ChooseSaveAsPath.FileName;
                            File.WriteAllText(filePath, codes.Text);
                            MessageBox.Show("文件另存为成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            Fresh();
                            RefreshFileViewAndSelect(filePath); // 刷新文件视图并选中新保存的文件
                            // 保存

                            //// reflash fileview
                            //fileview.Nodes.Clear();
                            //LoadFileTreeView(ProjectData.ProjectPath);
                            //fileview.ExpandAll();

                            //// 选中新保存的文件
                            //SelectFileNode(fileview, filePath);

                            //// 递归查找并选中指定文件路径的节点
                            //void SelectFileNode(TreeView treeView, string filePath)
                            //{
                            //    foreach (TreeNode node in treeView.Nodes)
                            //    {
                            //        if (SelectFileNodeRecursive(node, filePath))
                            //            break;
                            //    }
                            //}

                            //bool SelectFileNodeRecursive(TreeNode node, string filePath)
                            //{
                            //    if (node.Tag is FileInfo fileInfo &&
                            //        string.Equals(fileInfo.FullName, filePath, StringComparison.OrdinalIgnoreCase))
                            //    {
                            //        node.TreeView.SelectedNode = node;
                            //        node.TreeView.Focus();
                            //        return true;
                            //    }
                            //    foreach (TreeNode child in node.Nodes)
                            //    {
                            //        if (SelectFileNodeRecursive(child, filePath))
                            //            return true;
                            //    }
                            //    return false;
                            //}


                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"无法另存为:\n{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                }
                else
                {
                    MessageBox.Show("请选择要另存为的文件", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }


            }
            else
            {
                MessageBox.Show("你还没有打开项目", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }





        //选中指定文件路径的节点
        void RefreshFileViewAndSelect(string filePath)
        {
            //Fresh(); // 刷新文件视图

            // 递归查找并选中指定文件路径的节点
            void SelectFileNode(TreeView treeView, string filePath)
            {
                foreach (TreeNode node in treeView.Nodes)
                {
                    if (SelectFileNodeRecursive(node, filePath))
                        break;
                }
            }

            bool SelectFileNodeRecursive(TreeNode node, string filePath)
            {
                if (node.Tag is FileInfo fileInfo &&
                    string.Equals(fileInfo.FullName, filePath, StringComparison.OrdinalIgnoreCase))
                {
                    node.TreeView.SelectedNode = node;
                    node.TreeView.Focus();
                    return true;
                }
                foreach (TreeNode child in node.Nodes)
                {
                    if (SelectFileNodeRecursive(child, filePath))
                        return true;
                }
                return false;
            }

            SelectFileNode(fileview, filePath);
        }


        // 刷新文件视图和对象视图
        public static void Fresh()
        {
            if (ProjectData.ProjectChecked)
            {
                fileview.Nodes.Clear();
                LoadFileTreeView(ProjectData.ProjectPath);
                fileview.ExpandAll();
                codes.Text = "";

                ObjectListView.Items.Clear();
                PutClassBaseTypesIntoObjectListView(ProjectData.ProjectPath);
            }
            else
            {
                MessageBox.Show("你还没有打开项目", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void 项目设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ProjectData.ProjectChecked)
            {
                Form ProjectSettings = new ProjectSettings();
                ProjectSettings.Show();
            }
            else
            {
                MessageBox.Show("你还没有打开项目", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void terraCreatorReToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("explorer", "https://github.com/CEllOMiKA/TerraCreator-Origin");
        }


        //图片缩放
        private void ImageBox_Click(object sender, EventArgs e)
        {

            ImageBox.SizeMode = PictureBoxSizeMode.Zoom;

        }


    }



}
        


