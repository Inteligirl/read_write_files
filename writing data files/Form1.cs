using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;        //for using stream read write

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
                //declare streamwriter variable named outputFile
                StreamWriter outputFile; 

                //var = method of object with argument of file name. creates file
                outputFile = File.CreateText("friends.txt");

                //writes the contents of nameTextBox to file
                outputFile.WriteLine(nameTextBox.Text);

                //close file
                outputFile.Close();

                //tell user info
                MessageBox.Show("The name was written.");

                //clear text box
                nameTextBox.Text = "";

                //reset focus to nameTextBox
                nameTextBox.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void addTextButton_Click(object sender, EventArgs e)
        {
            try
            {
                //declare streamwriter variable named outputFile
                StreamWriter outputFile;

                //var = method of object with argument of file name. creates file
                outputFile = File.AppendText("friends.txt");

                //writes the contents of nameTextBox to file
                outputFile.WriteLine(nameTextBox.Text);

                //close file
                outputFile.Close();

                //tell user info
                MessageBox.Show("The name was written.");

                //clear text box
                nameTextBox.Text = "";

                //reset focus to nameTextBox
                nameTextBox.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}

