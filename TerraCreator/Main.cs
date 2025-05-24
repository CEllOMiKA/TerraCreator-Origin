using System.Windows.Forms;
using TerraCreator;

namespace TerraCreator
{
    public partial class Main : Form
    {


        public Main()
        {
            InitializeComponent();
        }

        private void toolst_about_Click(object sender, EventArgs e)
        {
            Form about = new about();
            about.Show();
        }

        private void toolst_exitprog_Click(object sender, EventArgs e)
        {
            this.Close();
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
                MessageBox.Show("�ص�����������������\n�Ƿ�رճ���", "��ʾ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (IfWantToRestartApp == DialogResult.Yes)
                {
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

        }

        private void fresh_Click(object sender, EventArgs e)
        {
            fileview.Nodes.Clear();
            LoadFileTreeView(ProjectData.ProjectPath);
            fileview.ExpandAll();
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
                MessageBox.Show("�㻹û�д���Ŀ", "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    codes.Text = File.ReadAllText(fileInfo.FullName);
                }
                catch (Exception ex)
                {
                    codes.Text = $"�޷���ȡ�ļ�: {ex.Message}";
                }
            }
        }





        void SaveFile()
        {
            if (ProjectData.ProjectChecked)
            {
                if (codes.Text == "")
                {
                    MessageBox.Show("�㻹û�д��ļ�", "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (fileview.SelectedNode != null && fileview.SelectedNode.Tag is FileInfo fileInfo)
                {
                    try
                    {
                        File.WriteAllText(fileInfo.FullName, codes.Text);
                        MessageBox.Show("�ļ��ѱ���", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"�����ļ�ʧ��: {ex.Message}", "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void toolst_additemintoproj_Click(object sender, EventArgs e)
        {
            MessageBox.Show("���ǻ�û������һ������");
        }
    }
}