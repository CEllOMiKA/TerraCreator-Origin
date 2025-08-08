namespace TerraCreator
{
    partial class AddItem
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
            ListViewGroup listViewGroup1 = new ListViewGroup("tMod项", HorizontalAlignment.Left);
            ListViewGroup listViewGroup2 = new ListViewGroup("其他", HorizontalAlignment.Left);
            ListViewGroup listViewGroup3 = new ListViewGroup("通用项", HorizontalAlignment.Left);
            ListViewItem listViewItem1 = new ListViewItem(new string[] { "物品", "ModItem", "基本物品" }, -1);
            ListViewItem listViewItem2 = new ListViewItem(new string[] { "射弹", "ModProjectile", "基本射弹" }, -1);
            ListViewItem listViewItem3 = new ListViewItem("物块");
            ListViewItem listViewItem4 = new ListViewItem("NPC");
            ListViewItem listViewItem5 = new ListViewItem("粒子");
            ListViewItem listViewItem6 = new ListViewItem("效果");
            ListViewItem listViewItem7 = new ListViewItem("文本文件");
            ListViewItem listViewItem8 = new ListViewItem("PNG图片");
            ListViewItem listViewItem9 = new ListViewItem("语言化文件");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddItem));
            list = new ListView();
            ItemName = new ColumnHeader();
            ItemType = new ColumnHeader();
            ItemInstruction = new ColumnHeader();
            newitemlabel = new Label();
            CreateGroupBox = new GroupBox();
            SuspendLayout();
            // 
            // list
            // 
            list.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            list.BackColor = Color.FromArgb(192, 255, 255);
            list.Columns.AddRange(new ColumnHeader[] { ItemName, ItemType, ItemInstruction });
            listViewGroup1.Header = "tMod项";
            listViewGroup1.Name = "tmlitem";
            listViewGroup2.Header = "其他";
            listViewGroup2.Name = "other";
            listViewGroup3.Header = "通用项";
            listViewGroup3.Name = "General";
            list.Groups.AddRange(new ListViewGroup[] { listViewGroup1, listViewGroup2, listViewGroup3 });
            listViewItem1.Group = listViewGroup1;
            listViewItem1.Tag = "Item";
            listViewItem1.ToolTipText = "添加物品(Item)";
            listViewItem2.Group = listViewGroup1;
            listViewItem2.Tag = "Projectile";
            listViewItem2.ToolTipText = "添加射弹(Projectile)";
            listViewItem3.Group = listViewGroup1;
            listViewItem3.Tag = "Projectile";
            listViewItem3.ToolTipText = "添加物块(Tile)";
            listViewItem4.Group = listViewGroup1;
            listViewItem4.Tag = "NPC";
            listViewItem4.ToolTipText = "新建NPC";
            listViewItem5.Group = listViewGroup1;
            listViewItem5.ToolTipText = "新建粒子";
            listViewItem6.Group = listViewGroup1;
            listViewItem6.ToolTipText = "新建Buff";
            listViewItem7.Group = listViewGroup2;
            listViewItem7.ToolTipText = "新建文件";
            listViewItem8.Group = listViewGroup2;
            listViewItem8.ToolTipText = "新建PNG材质";
            listViewItem9.Group = listViewGroup3;
            listViewItem9.ToolTipText = "新建语言文件";
            list.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2, listViewItem3, listViewItem4, listViewItem5, listViewItem6, listViewItem7, listViewItem8, listViewItem9 });
            list.Location = new Point(8, 30);
            list.Margin = new Padding(2);
            list.Name = "list";
            list.Size = new Size(616, 358);
            list.TabIndex = 0;
            list.UseCompatibleStateImageBehavior = false;
            list.View = View.Details;
            list.SelectedIndexChanged += list_SelectedIndexChanged;
            // 
            // ItemName
            // 
            ItemName.Text = "名称";
            ItemName.Width = 80;
            // 
            // ItemType
            // 
            ItemType.Text = "类型";
            ItemType.Width = 120;
            // 
            // ItemInstruction
            // 
            ItemInstruction.Text = "说明";
            ItemInstruction.Width = 600;
            // 
            // newitemlabel
            // 
            newitemlabel.AutoSize = true;
            newitemlabel.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            newitemlabel.Location = new Point(8, 6);
            newitemlabel.Margin = new Padding(2, 0, 2, 0);
            newitemlabel.Name = "newitemlabel";
            newitemlabel.Size = new Size(58, 22);
            newitemlabel.TabIndex = 4;
            newitemlabel.Text = "新建项";
            // 
            // CreateGroupBox
            // 
            CreateGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CreateGroupBox.Location = new Point(8, 393);
            CreateGroupBox.Name = "CreateGroupBox";
            CreateGroupBox.Size = new Size(615, 149);
            CreateGroupBox.TabIndex = 7;
            CreateGroupBox.TabStop = false;
            CreateGroupBox.Text = "未选择";
            // 
            // AddItem
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 255, 255);
            ClientSize = new Size(635, 554);
            Controls.Add(CreateGroupBox);
            Controls.Add(newitemlabel);
            Controls.Add(list);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "AddItem";
            Text = "新建项";
            FormClosing += AddItem_FormClosing;
            Load += AddItem_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView list;
        private Label newitemlabel;
        private ColumnHeader ItemName;
        private ColumnHeader ItemType;
        private ColumnHeader ItemInstruction;
        private GroupBox CreateGroupBox;
    }
}