using System.Text.RegularExpressions;
using System.Windows.Forms;
using TerraCreator;
using System.IO;

namespace TerraCreator
{
    public partial class Main : Form
    {


        public Main()
        {
            InitializeComponent();
        }

        //Main
        private void Main_Load(object sender, EventArgs e)
        {
            fileview.BackColor = TerraCreatorData.FormToolColour;
            codes.BackColor = TerraCreatorData.FormToolColour;
            this.BackColor = TerraCreatorData.FormBackColour;
            ObjectList.BackColor = TerraCreatorData.FormToolColour;


        }



        private void toolst_about_Click(object sender, EventArgs e)
        {
            Form about = new about();
            about.Show();
        }

        private void toolst_exitprog_Click(object sender, EventArgs e)
        {
            DialogResult ConfirmExit = MessageBox.Show("是否退出TerraCreator", "退出", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (ConfirmExit == DialogResult.OK)
            {
                this.Close();
            }

        }

        private void toolst_newitem_Click(object sender, EventArgs e)
        {
            NewItem();
        }

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



        private void codes_TextChanged(object sender, EventArgs e)
        {

            codes.LanguageOption = RichTextBoxLanguageOptions.UIFonts;

            CodeCount.Text = "字数:" + Convert.ToString(codes.Text.Count());

        }

        private void fresh_Click(object sender, EventArgs e)
        {

            fileview.Nodes.Clear();
            LoadFileTreeView(ProjectData.ProjectPath);
            fileview.ExpandAll();
            codes.Text = "";

        }

        private void toolst_save_Click(object sender, EventArgs e)
        {
            SaveFile();

        }


        private void save_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void additem_Click(object sender, EventArgs e)
        {
            NewItem();
        }

        private void settings_Click(object sender, EventArgs e)
        {
            Form Settings = new Settings();
            Settings.Show();
        }

        private void ProjectSettings_Click(object sender, EventArgs e)
        {
            if(!ProjectData.ProjectChecked)
            {
                MessageBox.Show("你还没有打开项目", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Form ProjectSettings = new ProjectSettings();
            ProjectSettings.Show();

        }



        private void fileview_AfterSelect(object sender, TreeViewEventArgs e)
        {
            fileTreeView_AfterSelect(ProjectData.ProjectPath, e);
        }

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
                    MessageBox.Show($"导入成功\n文件地址:{ChooseFilePath}", "导入成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"复制失败:\n {ex.Message}\n请手动导入", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }

        private void addon_Click(object sender, EventArgs e)
        {
            MessageBox.Show("开发中...", "提示");
        }


        private void toolst_SaveAs_Click(object sender, EventArgs e)
        {
            SaveAsFile();

        }


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


        private void OpenCsproj_Click(object sender, EventArgs e)
        {
            if (ProjectData.ProjectChecked)
            {
                MessageBox.Show(ProjectData.ProjectPath + "\\" + ProjectData.ProjectNamespace + ".csproj");
                System.Diagnostics.Process.Start("explorer", ProjectData.ProjectPath + "\\" + ProjectData.ProjectNamespace + ".csproj");
            }
            else
            {
                MessageBox.Show("你还没有打开项目", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



































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

                            RefreshFileViewAndSelect(fileInfo.FullName); // 保存

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





        // 在 Main 类内添加此方法
        void RefreshFileViewAndSelect(string filePath)
        {
            fileview.Nodes.Clear();
            LoadFileTreeView(ProjectData.ProjectPath);
            fileview.ExpandAll();

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


    }



}
        


















