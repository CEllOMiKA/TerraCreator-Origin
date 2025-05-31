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
            ListViewItem listViewItem1 = new ListViewItem("物品");
            ListViewItem listViewItem2 = new ListViewItem("射弹");
            ListViewItem listViewItem3 = new ListViewItem("文本代码文件");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddItem));
            list = new ListView();
            itempanel = new Panel();
            newitemlabel = new Label();
            tips = new Label();
            SuspendLayout();
            // 
            // list
            // 
            list.BackColor = Color.FromArgb(192, 255, 255);
            listViewGroup1.Header = "tMod项";
            listViewGroup1.Name = "tmlitem";
            listViewGroup2.Header = "其他";
            listViewGroup2.Name = "other";
            list.Groups.AddRange(new ListViewGroup[] { listViewGroup1, listViewGroup2 });
            listViewItem1.Group = listViewGroup1;
            listViewItem1.Tag = "item";
            listViewItem1.ToolTipText = "添加物品(Item)";
            listViewItem2.Group = listViewGroup1;
            listViewItem2.Tag = "projectile";
            listViewItem2.ToolTipText = "添加射弹(Projectile)";
            listViewItem3.Group = listViewGroup2;
            listViewItem3.ToolTipText = "新建文件";
            list.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2, listViewItem3 });
            list.Location = new Point(12, 43);
            list.Name = "list";
            list.Size = new Size(253, 612);
            list.TabIndex = 0;
            list.UseCompatibleStateImageBehavior = false;
            list.View = View.SmallIcon;
            list.SelectedIndexChanged += list_SelectedIndexChanged;
            // 
            // itempanel
            // 
            itempanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            itempanel.BackColor = Color.FromArgb(192, 255, 255);
            itempanel.Location = new Point(271, 43);
            itempanel.Name = "itempanel";
            itempanel.Size = new Size(1125, 612);
            itempanel.TabIndex = 3;
            // 
            // newitemlabel
            // 
            newitemlabel.AutoSize = true;
            newitemlabel.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            newitemlabel.Location = new Point(12, 9);
            newitemlabel.Name = "newitemlabel";
            newitemlabel.Size = new Size(86, 31);
            newitemlabel.TabIndex = 4;
            newitemlabel.Text = "新建项";
            // 
            // tips
            // 
            tips.AutoSize = true;
            tips.Location = new Point(49, 681);
            tips.Name = "tips";
            tips.Size = new Size(163, 72);
            tips.TabIndex = 5;
            tips.Text = "提示:\r\n你觉得功能太少了?\r\n那就快去催更作者!";
            // 
            // AddItem
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 255, 255);
            ClientSize = new Size(1408, 667);
            Controls.Add(tips);
            Controls.Add(newitemlabel);
            Controls.Add(itempanel);
            Controls.Add(list);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AddItem";
            Text = "新建项";
            Load += AddItem_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView list;
        private Panel itempanel;
        private Label newitemlabel;
        private Label tips;
    }
}