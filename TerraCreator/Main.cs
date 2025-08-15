using System.Text.RegularExpressions;
using System.Windows.Forms;
using TerraCreator;
using System.IO;
using System.Collections.Generic;
using System.Diagnostics;
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
                        codes.Visible = false;
                        ImageBox.Visible = true;
                        codes.Text = "";
                        FilePropt.Text = fileInfo.Name;
                        CodeCount.Text = "字数:0";
                        ImageBox.Image = Image.FromFile(fileInfo.FullName);
                    }
                    else
                    {
                        codes.Visible = true;
                        ImageBox.Visible = false;
                        ImageBox.Image = null;
                        FilePropt.Text = fileInfo.Name;
                        codes.Text = File.ReadAllText(fileInfo.FullName);
                        CodeCount.Text = "字数:" + Convert.ToString(codes.Text.Count());
                        ;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"无法读取文件: \n{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
            var csFiles = Directory.GetFiles(folderPath, "*.cs", SearchOption.AllDirectories);
            var regex = new Regex(@"public\s+class\s+(\w+)\s*:\s*([^{,\s]+)", RegexOptions.Compiled);

            foreach (var file in csFiles)
            {
                var content = File.ReadAllText(file);
                foreach (Match match in regex.Matches(content))
                {
                    string className = match.Groups[1].Value;
                    string baseType = match.Groups[2].Value;
                    var item = new ListViewItem($"{className}");

                    // 按基类分组
                    if (baseType == "Mod")
                    {
                        continue; // 忽略 Mod 基类
                    }
                    if (baseType == "ModItem" && ObjectListView.Groups.Count > 0)
                    {
                        item.Group = ObjectListView.Groups[0];
                        item.Tag = file; // 设置 Tag 为 Item 路径
                    }
                    else if (baseType == "ModProjectile" && ObjectListView.Groups.Count > 1)
                    {
                        item.Group = ObjectListView.Groups[1];
                        item.Tag = file; // 设置 Tag 为 Projectile 路径
                    }
                    ObjectListView.Items.Add(item);
                }
            }
        }




        // 处理对象列表视图选择事件

        private void ObjectListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.Item.Tag == null)
            {
                MessageBox.Show("无法访问此对象的Tag\n(Tag中存放对象路径)", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string SelectedObjectPath = e.Item.Tag.ToString();
            string SelectedObjectNamespace = e.Item.Text;

            if (e.Item.Group.Name == "ModItem")
            {
                ObjectPanel.Controls.Clear();
            }
            if (e.Item.Group.Name == "ModProjectile")
            {
                ObjectPanel.Controls.Clear();
                try
                {
                    Form ProjectileSettingForm = new ProjectileSettingForm(SelectedObjectPath, SelectedObjectNamespace);
                    ProjectileSettingForm.TopLevel = false;
                    ProjectileSettingForm.Parent = ObjectPanel;
                    ProjectileSettingForm.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"无法加载射弹设置: \n{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            Form ProjectSettings = new ProjectSettings();
            ProjectSettings.Show();

        }

        private void terraCreatorReToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("explorer", "https://github.com/CEllOMiKA/TerraCreator-Origin");
        }
    }



}
        


















