namespace TerraCreator
{
    partial class NewProject
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewProject));
            newprojlabel = new Label();
            tmlyouneed = new Label();
            clickto = new LinkLabel();
            choosefolder = new Button();
            folderpositiontext = new Label();
            create = new Button();
            typenamespace = new Label();
            ProjectNameSpaceTextBox = new TextBox();
            SuspendLayout();
            // 
            // newprojlabel
            // 
            resources.ApplyResources(newprojlabel, "newprojlabel");
            newprojlabel.Name = "newprojlabel";
            // 
            // tmlyouneed
            // 
            resources.ApplyResources(tmlyouneed, "tmlyouneed");
            tmlyouneed.Name = "tmlyouneed";
            // 
            // clickto
            // 
            resources.ApplyResources(clickto, "clickto");
            clickto.Name = "clickto";
            clickto.TabStop = true;
            clickto.LinkClicked += clickto_LinkClicked;
            // 
            // choosefolder
            // 
            resources.ApplyResources(choosefolder, "choosefolder");
            choosefolder.Name = "choosefolder";
            choosefolder.UseVisualStyleBackColor = true;
            choosefolder.Click += choosefolder_Click;
            // 
            // folderpositiontext
            // 
            resources.ApplyResources(folderpositiontext, "folderpositiontext");
            folderpositiontext.Name = "folderpositiontext";
            // 
            // create
            // 
            resources.ApplyResources(create, "create");
            create.Name = "create";
            create.UseVisualStyleBackColor = true;
            create.Click += create_Click;
            // 
            // typenamespace
            // 
            resources.ApplyResources(typenamespace, "typenamespace");
            typenamespace.Name = "typenamespace";
            // 
            // ProjectNameSpaceTextBox
            // 
            resources.ApplyResources(ProjectNameSpaceTextBox, "ProjectNameSpaceTextBox");
            ProjectNameSpaceTextBox.Name = "ProjectNameSpaceTextBox";
            ProjectNameSpaceTextBox.KeyDown += ProjectNameSpaceTextBox_KeyUp;
            // 
            // NewProject
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 255, 255);
            Controls.Add(ProjectNameSpaceTextBox);
            Controls.Add(typenamespace);
            Controls.Add(create);
            Controls.Add(folderpositiontext);
            Controls.Add(choosefolder);
            Controls.Add(clickto);
            Controls.Add(tmlyouneed);
            Controls.Add(newprojlabel);
            Name = "NewProject";
            Load += NewProject_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label newprojlabel;
        private Label tmlyouneed;
        private LinkLabel clickto;
        private Button choosefolder;
        private Label folderpositiontext;
        private Button create;
        private Label typenamespace;
        private TextBox ProjectNameSpaceTextBox;
    }
}