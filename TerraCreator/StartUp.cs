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
    public partial class StartUp : Form
    {
        public StartUp()
        {
            InitializeComponent();
        }

        private void StartUp_Load(object sender, EventArgs e)
        {
            this.BackColor = TerraCreatorData.FormBackColour;
        }
    }
}
