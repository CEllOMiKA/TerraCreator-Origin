using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TerraCreator
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }











        private void Settings_Load(object sender, EventArgs e)
        {

            this.BackColor = TerraCreatorData.FormBackColor;

            try
            {
                string ConfigFileContent = File.ReadAllText(TerraCreatorData.TerraCreatorConfigFileName);
                SettingsTextBox.Text = ConfigFileContent;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reading settings: " + ex.Message);
            }


        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                File.WriteAllText(TerraCreatorData.TerraCreatorConfigFileName, SettingsTextBox.Text);
                MessageBox.Show("Settings saved successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving settings: " + ex.Message);
            }
        }

    }
}
