﻿using System;
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

                //test to see if user did not enter a name
                if (nameTextBox.Text != "")
                {
                    //var = method of object with argument of file name. creates file
                    outputFile = File.CreateText("friends.txt");
                    //if passing file location as argument in create method
                    //use outputFile = File.CreateText(@"C:\Users\Tammy\Documents\friends.txt");

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

                    //reset view file label field
                    viewFileLabel.Text = "";
                }
                else { MessageBox.Show("You did not enter a name"); }
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

                //test to see if user did not enter a name
                if (nameTextBox.Text != "")
                {
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

                    //reset view file label field
                    viewFileLabel.Text = "";
                }
                else { MessageBox.Show("You did not enter a name"); }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void openFileButton_Click(object sender, EventArgs e)
        {
            try
            { //reset view file label field
                viewFileLabel.Text = "";

                //declare a variable to hold an item read from the file.
                string fileData;

                //Declare a StreamReader variable
                StreamReader inputFile;

                //open file and get a StreamReader object.
                inputFile = File.OpenText("friends.txt");

                //loop to read until end of file
                while (!inputFile.EndOfStream) { 

                //read and display the name
                fileData = inputFile.ReadLine();
                viewFileLabel.Text += " " + fileData;
            }
                //close the file
                inputFile.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
                    
                    }

        private void openDialogButton_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader inputFile;

                //open file default directory must use @ to ignore escape sequence \
                openFileDialog.InitialDirectory = @"C:\Users\tempest\Desktop";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    inputFile = File.OpenText(openFileDialog.FileName);

                    //declare a variable to hold an item read from the file.
                    string fileData;

                    //loop to read until end of file
                    while (!inputFile.EndOfStream)
                    {

                        //read and display the name
                        fileData = inputFile.ReadLine();
                        viewFileLabel.Text += " " + fileData;
                    }
                    //close the file
                    inputFile.Close();
                }
                else
                {
                    MessageBox.Show("You clicked the Cancel Button.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    private void saveDialogButton_Click(object sender, EventArgs e)
        {
            StreamWriter outputFile;
            saveFileDialog.InitialDirectory = @"C:\Users\tempest\Desktop";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                outputFile = File.CreateText(saveFileDialog.FileName);
            }
            else
            {
                MessageBox.Show("You clicked the cancel button");
            }
        }
    }
    }


