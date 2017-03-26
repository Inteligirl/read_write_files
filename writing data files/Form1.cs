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

namespace writing_data_files
{
    public partial class friendFile : Form
    {
        public friendFile()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void writeNameButton_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter outputFile;
                outputFile = File.CreateText("friends.txt");

                outputFile.WriteLine(nameTextBox.Text);

                outputFile.Close();

                MessageBox.Show("The name was written.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
