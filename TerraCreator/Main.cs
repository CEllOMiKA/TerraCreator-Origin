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

        //ͻ������
        public static void ColortheCode()
        {
            // ��ȡ������ʵ�������Ƚ���
            var rtb = Main.codes;
            if (rtb == null) return;

            // ��ֹ�Լ����ı����� UI����ֵ�ɵ���
            const int MaxLengthToHighlight = 200_000;
            if (rtb.Text.Length > MaxLengthToHighlight) return;

            // �ؼ��֣�Сд�Ƚ��� IgnoreCase��
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

            // ��ɫ����
            Color defaultColor = Color.Black;
            Color keywordColor = Color.Blue;
            Color commentColor = Color.Green;
            Color functionColor = Color.Red;
            Color numberColor = Color.DarkGreen;
            Color callColor = Color.Orange;

            // �����ػ�
            NativeMethods.SendMessage(rtb.Handle, NativeMethods.WM_SETREDRAW, false, 0);
            rtb.SuspendLayout();

            // ������
            int selStart = rtb.SelectionStart;
            int selLength = rtb.SelectionLength;

            // ������ȫ���ı���ɫ
            rtb.SelectAll();
            rtb.SelectionColor = defaultColor;

            // ���ȸ��� �ַ�����ע�ͣ�����ؼ�����ע��/�ַ�����Ҳ������
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

            // �����ؼ��֣����Դ�Сд��
            foreach (string kw in keywords)
            {
                var matches = System.Text.RegularExpressions.Regex.Matches(rtb.Text, $@"\b{System.Text.RegularExpressions.Regex.Escape(kw)}\b", System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                foreach (System.Text.RegularExpressions.Match m in matches)
                {
                    rtb.Select(m.Index, m.Length);
                    rtb.SelectionColor = keywordColor;
                }
            }

            // ����
            var numberMatches = System.Text.RegularExpressions.Regex.Matches(rtb.Text, @"\b\d+(\.\d+)?\b");
            foreach (System.Text.RegularExpressions.Match m in numberMatches)
            {
                rtb.Select(m.Index, m.Length);
                rtb.SelectionColor = numberColor;
            }

            // ���������������� name(...), ���� name��
            var callMatches = System.Text.RegularExpressions.Regex.Matches(rtb.Text, @"\b([A-Za-z_]\w*)\s*\(");
            foreach (System.Text.RegularExpressions.Match m in callMatches)
            {
                int idx = m.Groups[1].Index;
                int len = m.Groups[1].Length;
                rtb.Select(idx, len);
                rtb.SelectionColor = callColor;
            }

            // ����/����������������Ϊ functionColor��
            var funcRegex = new System.Text.RegularExpressions.Regex(@"\b(public|private|protected|internal|static|virtual|override|sealed|async|extern|unsafe|partial|new)\s+[\w<>\[\],\s]+\s+([A-Za-z_]\w*)\s*\(", System.Text.RegularExpressions.RegexOptions.Compiled | System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            var funcMatches = funcRegex.Matches(rtb.Text);
            foreach (System.Text.RegularExpressions.Match m in funcMatches)
            {
                int funcNameIndex = m.Groups[2].Index;
                int funcNameLength = m.Groups[2].Length;
                rtb.Select(funcNameIndex, funcNameLength);
                rtb.SelectionColor = functionColor;
            }

            // �ָ����
            rtb.SelectionStart = selStart;
            rtb.SelectionLength = selLength;
            rtb.SelectionColor = defaultColor;

            rtb.ResumeLayout();
            NativeMethods.SendMessage(rtb.Handle, NativeMethods.WM_SETREDRAW, true, 0);
            rtb.Invalidate();
        }



        // Win32 API ���ڶ���/�ָ��ػ�
        internal static class NativeMethods
        {
            public const int WM_SETREDRAW = 0x0b;
            [System.Runtime.InteropServices.DllImport("user32.dll")]
            public static extern int SendMessage(IntPtr hWnd, int wMsg, bool wParam, int lParam);
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
                        ImageFileOpened();
                    }
                    else
                    {
                        CodeFileOpened();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"�޷���ȡ�ļ�: \n{ex.Message}", "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                CodeCount.Text = "����:" + Convert.ToString(codes.Text.Count());

                var ColortheCodeToolStripItem = FileViewEdit.Items.Add("������ɫ");
                ColortheCodeToolStripItem.Text = "������ɫ";
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
                CodeCount.Text = "ͼƬ";
                ImageBox.SizeMode = PictureBoxSizeMode.CenterImage;
                ImageBox.Image = Image.FromFile(fileInfo.FullName);

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
                        // ֻȡ������ȥ�������ռ�ͷ��Ͳ�����
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
                MessageBox.Show($"���ض����б�ʧ��: {ex.Message}", "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        // ��������б���ͼѡ���¼�

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
                    MessageBox.Show("�޷����ʴ˶����Tag\n(Tag�д�Ŷ���·��)", "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        MessageBox.Show($"�޷�������Ʒ����: \n{ex.Message}", "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        MessageBox.Show($"�޷������䵯����: \n{ex.Message}", "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

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
            if (ProjectData.ProjectChecked)
            {
                Form ProjectSettings = new ProjectSettings();
                ProjectSettings.Show();
            }
            else
            {
                MessageBox.Show("�㻹û�д���Ŀ", "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void terraCreatorReToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("explorer", "https://github.com/CEllOMiKA/TerraCreator-Origin");
        }


        //ͼƬ����
        private void ImageBox_Click(object sender, EventArgs e)
        {

            ImageBox.SizeMode = PictureBoxSizeMode.Zoom;

        }


    }



}
        


