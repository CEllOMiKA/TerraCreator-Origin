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


        //����
        private void toolst_about_Click(object sender, EventArgs e)
        {
            Form about = new about();
            about.Show();
        }

        //�˳�����
        private void toolst_exitprog_Click(object sender, EventArgs e)
        {
            DialogResult ConfirmExit = MessageBox.Show("�Ƿ��˳�TerraCreator", "�˳�", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (ConfirmExit == DialogResult.OK)
            {
                this.Close();
            }

        }

        //�½�����
        private void toolst_newitem_Click(object sender, EventArgs e)
        {
            NewItem();
        }

        //������Ŀ
        private void toolst_newproj_Click(object sender, EventArgs e)
        {
            if (ProjectData.ProjectChecked)
            {
                DialogResult IfWantToRestartApp =
                MessageBox.Show("�ص�����������������\n�Ƿ�رճ���", "��ʾ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
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
                MessageBox.Show("�ص�����������������\n�Ƿ�رճ���", "��ʾ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
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

        //��ʾ����
        private void codes_TextChanged(object sender, EventArgs e)
        {

            codes.LanguageOption = RichTextBoxLanguageOptions.UIFonts;

            CodeCount.Text = "����:" + Convert.ToString(codes.Text.Count());

        }

        //ˢ���ļ���ͼ�Ͷ�����ͼ
        private void fresh_Click(object sender, EventArgs e)
        {

            Fresh();


        }

        //����
        private void toolst_save_Click(object sender, EventArgs e)
        {
            SaveFile();

        }

        //����
        private void save_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        // �½�����
        private void additem_Click(object sender, EventArgs e)
        {
            NewItem();
        }

        // �����ô���
        private void settings_Click(object sender, EventArgs e)
        {
            Form Settings = new Settings();
            Settings.Show();
        }

        // ����Ŀ����
        private void ProjectSettings_Click(object sender, EventArgs e)
        {
            if (!ProjectData.ProjectChecked)
            {
                MessageBox.Show("�㻹û�д���Ŀ", "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Form ProjectSettings = new ProjectSettings();
            ProjectSettings.Show();

        }


        // ѡ���ļ��� �����ļ�����ͼѡ���¼�
        private void fileview_AfterSelect(object sender, TreeViewEventArgs e)
        {
            fileTreeView_AfterSelect(ProjectData.ProjectPath, e);
        }

        // �����ļ�����ͼѡ���¼�
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
                MessageBox.Show("�㻹û�д���Ŀ", "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        // �ݹ�����ļ���Ŀ¼������ͼ
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

        // �ж��ļ����Ͳ���ʾ����
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
                        CodeCount.Text = "����:0";
                        ImageBox.Image = Image.FromFile(fileInfo.FullName);
                    }
                    else
                    {
                        codes.Visible = true;
                        ImageBox.Visible = false;
                        ImageBox.Image = null;
                        FilePropt.Text = fileInfo.Name;
                        codes.Text = File.ReadAllText(fileInfo.FullName);
                        CodeCount.Text = "����:" + Convert.ToString(codes.Text.Count());
                        ;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"�޷���ȡ�ļ�: \n{ex.Message}", "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }




        //�ɴ���
        //public static List<string> GetClassBaseTypes(string folderPath)
        //{
        //    var result = new List<string>();
        //    var csFiles = Directory.GetFiles(folderPath, "*.cs", SearchOption.AllDirectories);
        //    // ƥ�� public class ���� : ����[,�ӿ�...]
        //    var regex = new Regex(@"public\s+class\s+\w+\s*:\s*([^{,\s]+)", RegexOptions.Compiled);

        //    foreach (var file in csFiles)
        //    {
        //        var content = File.ReadAllText(file);
        //        foreach (Match match in regex.Matches(content))
        //        {
        //            // match.Groups[1] �Ǽ̳еĻ��ࣨ��һ��ð�ź�����ͣ�
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



        //��.cs�ļ��е���������ObjectListView��
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

                    // ���������
                    if (baseType == "Mod")
                    {
                        continue; // ���� Mod ����
                    }
                    if (baseType == "ModItem" && ObjectListView.Groups.Count > 0)
                    {
                        item.Group = ObjectListView.Groups[0];
                        item.Tag = file; // ���� Tag Ϊ Item ·��
                    }
                    else if (baseType == "ModProjectile" && ObjectListView.Groups.Count > 1)
                    {
                        item.Group = ObjectListView.Groups[1];
                        item.Tag = file; // ���� Tag Ϊ Projectile ·��
                    }
                    ObjectListView.Items.Add(item);
                }
            }
        }




        // ��������б���ͼѡ���¼�

        private void ObjectListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.Item.Tag == null)
            {
                MessageBox.Show("�޷����ʴ˶����Tag\n(Tag�д�Ŷ���·��)", "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    MessageBox.Show($"�޷������䵯����: \n{ex.Message}", "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }






        // ����ļ�����Ŀ
        private void toolst_additemintoproj_Click(object sender, EventArgs e)
        {

            bool CopyChecked = false;
            string ChooseFilePath = "";
            string ChooseFolderPath = "";
            string ChooseFileName = "";

            if (ProjectData.ProjectChecked)
            {

                OpenFileDialog ChooseAddFile = new OpenFileDialog();
                ChooseAddFile.Filter = "�����ļ�(*.*)|*.*";
                ChooseAddFile.Title = "ѡ��Ҫ������ļ�";
                ChooseAddFile.FilterIndex = 0;
                DialogResult result = ChooseAddFile.ShowDialog();

                if (result == DialogResult.OK)
                {
                    ChooseFilePath = ChooseAddFile.FileName;
                    ChooseFileName = ChooseAddFile.SafeFileName;

                    FolderBrowserDialog ChooseWhichFolder = new FolderBrowserDialog();
                    ChooseWhichFolder.SelectedPath = ProjectData.ProjectPath;
                    ChooseWhichFolder.Description = "ѡ��Ҫ������ļ���";
                    DialogResult FolderChoosen = ChooseWhichFolder.ShowDialog();
                    if (FolderChoosen == DialogResult.OK)
                    {
                        DialogResult ConfirmCopy = MessageBox.Show(
                            $"�����ļ�����Ŀ�ļ��лḲ���ļ�" +
                            $"\nԴ�ļ���ַ:{ChooseAddFile.FileName}" +
                            $"\n�����ļ��е�ַ:{ChooseWhichFolder.SelectedPath}",
                            "��ʾ",
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
                MessageBox.Show("�㻹û�д���Ŀ", "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //copy
            if (CopyChecked)
            {
                try
                {
                    System.IO.File.Copy(ChooseFilePath, ChooseFolderPath + "\\" + ChooseFileName, true);
                    Fresh(); // ˢ���ļ���ͼ
                    MessageBox.Show($"����ɹ�\n�ļ���ַ:{ChooseFilePath}", "����ɹ�", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"����ʧ��:\n {ex.Message}\n���ֶ�����", "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }

        // ��Ӳ��
        private void addon_Click(object sender, EventArgs e)
        {
            MessageBox.Show("������...", "��ʾ");
        }

        // �������Ϊ
        private void toolst_SaveAs_Click(object sender, EventArgs e)
        {
            SaveAsFile();

        }

        // ����tModLoader
        private void RuntML_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("explorer", "steam://rungameid/1281930");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"�޷���\n��ȷ���㰲װ��Steam��tModLoader\n{ex.Message}", "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show($"�޷���\n��ȷ���㰲װ��Steam��tModLoader\n{ex.Message}", "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ��csproj�ļ�
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
                    MessageBox.Show($"�޷���.csproj�ļ�\n{ex.Message}", "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("�㻹û�д���Ŀ", "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    MessageBox.Show($"�޷���.csproj�ļ�\n{ex.Message}", "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("�㻹û�д���Ŀ", "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }































        //�����ļ�
        void SaveFile()
        {
            if (ProjectData.ProjectChecked)
            {
                if (codes.Text == "")
                {
                    MessageBox.Show("�㻹û�д��ı��ļ�", "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (fileview.SelectedNode != null && fileview.SelectedNode.Tag is FileInfo fileInfo)
                {

                    if (!File.Exists(fileInfo.FullName))
                    {
                        //MessageBox.Show("û������ļ�\n�������Ϊ", "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        // Save As
                        SaveAsFile();
                        return;
                    }
                    else
                    {
                        try
                        {
                            File.WriteAllText(fileInfo.FullName, codes.Text);
                            MessageBox.Show("�ļ��ѱ���", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            RefreshFileViewAndSelect(fileInfo.FullName); // ����
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"�����ļ�ʧ��: {ex.Message}", "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                }
                else
                {
                    MessageBox.Show("��ѡ��Ҫ������ļ�", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            else
            {
                MessageBox.Show("�㻹û�д���Ŀ", "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //�½�����
        void NewItem()
        {
            if (ProjectData.ProjectChecked)
            {
                Form additem = new AddItem();
                additem.Show();
            }
            else
            {
                MessageBox.Show("�㻹û�д���Ŀ", "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        //���Ϊ�ļ�
        void SaveAsFile()
        {
            if (ProjectData.ProjectChecked)
            {

                if (codes.Text == "")
                {
                    MessageBox.Show("�㻹û�д��ı��ļ�", "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (fileview.SelectedNode != null && fileview.SelectedNode.Tag is FileInfo fileInfo)
                {

                    //SaveAs
                    SaveFileDialog ChooseSaveAsPath = new SaveFileDialog();
                    ChooseSaveAsPath.Filter = ChooseSaveAsPath.Filter = "�ı��ļ�|*.txt|C#�����ļ�|*.cs|�����ļ�|*.*";
                    ChooseSaveAsPath.RestoreDirectory = true;
                    ChooseSaveAsPath.FilterIndex = 2;
                    ChooseSaveAsPath.Title = "���Ϊ�ļ�";

                    //ifPressOK
                    if (ChooseSaveAsPath.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            string filePath = ChooseSaveAsPath.FileName;
                            File.WriteAllText(filePath, codes.Text);
                            MessageBox.Show("�ļ����Ϊ�ɹ���", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            Fresh();
                            RefreshFileViewAndSelect(filePath); // ˢ���ļ���ͼ��ѡ���±�����ļ�
                            // ����

                            //// reflash fileview
                            //fileview.Nodes.Clear();
                            //LoadFileTreeView(ProjectData.ProjectPath);
                            //fileview.ExpandAll();

                            //// ѡ���±�����ļ�
                            //SelectFileNode(fileview, filePath);

                            //// �ݹ���Ҳ�ѡ��ָ���ļ�·���Ľڵ�
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
                            MessageBox.Show($"�޷����Ϊ:\n{ex.Message}", "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                }
                else
                {
                    MessageBox.Show("��ѡ��Ҫ���Ϊ���ļ�", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }


            }
            else
            {
                MessageBox.Show("�㻹û�д���Ŀ", "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }





        //ѡ��ָ���ļ�·���Ľڵ�
        void RefreshFileViewAndSelect(string filePath)
        {
            //Fresh(); // ˢ���ļ���ͼ

            // �ݹ���Ҳ�ѡ��ָ���ļ�·���Ľڵ�
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


        // ˢ���ļ���ͼ�Ͷ�����ͼ
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
                MessageBox.Show("�㻹û�д���Ŀ", "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ��Ŀ����ToolStripMenuItem_Click(object sender, EventArgs e)
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
        


















