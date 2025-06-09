using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TerraCreator
{
    public partial class about : Form
    {
        public about()
        {
            InitializeComponent();

        }

        private void ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void icon_Click(object sender, EventArgs e)
        {
            MessageBox.Show("暂时就用TML图标吧");
        }



        private void about_Load(object sender, EventArgs e)
        {
            this.BackColor = TerraCreatorData.FormBackColour;
        }

        private void name_MouseEnter(object sender, EventArgs e)
        {
            int r;
            int g;
            int b;
            Random random = new Random();
            r = random.Next(0, 255);
            g = random.Next(0, 255);
            b = random.Next(0, 255);
            name.ForeColor = Color.FromArgb(r, g, b);
        }
    }
}
