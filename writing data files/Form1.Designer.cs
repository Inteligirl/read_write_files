namespace writing_data_files
{
    partial class friendFile
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
            this.friendLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.writeNameButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.addTextButton = new System.Windows.Forms.Button();
            this.openFileButton = new System.Windows.Forms.Button();
            this.viewFileLabel = new System.Windows.Forms.Label();
            this.fileDisplayLabel = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.openDialogButton = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.saveDialogButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // friendLabel
            // 
            this.friendLabel.AutoSize = true;
            this.friendLabel.Location = new System.Drawing.Point(14, 22);
            this.friendLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.friendLabel.Name = "friendLabel";
            this.friendLabel.Size = new System.Drawing.Size(128, 15);
            this.friendLabel.TabIndex = 0;
            this.friendLabel.Text = "Enter a friend\'s name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(148, 22);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(228, 23);
            this.nameTextBox.TabIndex = 1;
            // 
            // writeNameButton
            // 
            this.writeNameButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.writeNameButton.Location = new System.Drawing.Point(18, 144);
            this.writeNameButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.writeNameButton.Name = "writeNameButton";
            this.writeNameButton.Size = new System.Drawing.Size(88, 53);
            this.writeNameButton.TabIndex = 2;
            this.writeNameButton.Text = "&New File with Text";
            this.writeNameButton.UseVisualStyleBackColor = false;
            this.writeNameButton.Click += new System.EventHandler(this.writeNameButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Location = new System.Drawing.Point(340, 265);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(88, 27);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // addTextButton
            // 
            this.addTextButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.addTextButton.Location = new System.Drawing.Point(112, 144);
            this.addTextButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.addTextButton.Name = "addTextButton";
            this.addTextButton.Size = new System.Drawing.Size(88, 53);
            this.addTextButton.TabIndex = 4;
            this.addTextButton.Text = "A&dd Text to File";
            this.addTextButton.UseVisualStyleBackColor = false;
            this.addTextButton.Click += new System.EventHandler(this.addTextButton_Click);
            // 
            // openFileButton
            // 
            this.openFileButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.openFileButton.Location = new System.Drawing.Point(206, 144);
            this.openFileButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.openFileButton.Name = "openFileButton";
            this.openFileButton.Size = new System.Drawing.Size(88, 53);
            this.openFileButton.TabIndex = 5;
            this.openFileButton.Text = "Read &Previous File";
            this.openFileButton.UseVisualStyleBackColor = false;
            this.openFileButton.Click += new System.EventHandler(this.openFileButton_Click);
            // 
            // viewFileLabel
            // 
            this.viewFileLabel.BackColor = System.Drawing.Color.White;
            this.viewFileLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.viewFileLabel.Location = new System.Drawing.Point(144, 75);
            this.viewFileLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.viewFileLabel.Name = "viewFileLabel";
            this.viewFileLabel.Size = new System.Drawing.Size(232, 39);
            this.viewFileLabel.TabIndex = 6;
            // 
            // fileDisplayLabel
            // 
            this.fileDisplayLabel.AutoSize = true;
            this.fileDisplayLabel.Location = new System.Drawing.Point(14, 75);
            this.fileDisplayLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fileDisplayLabel.Name = "fileDisplayLabel";
            this.fileDisplayLabel.Size = new System.Drawing.Size(96, 15);
            this.fileDisplayLabel.TabIndex = 7;
            this.fileDisplayLabel.Text = "Contents of File:";
            // 
            // openDialogButton
            // 
            this.openDialogButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.openDialogButton.Location = new System.Drawing.Point(312, 144);
            this.openDialogButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.openDialogButton.Name = "openDialogButton";
            this.openDialogButton.Size = new System.Drawing.Size(88, 27);
            this.openDialogButton.TabIndex = 8;
            this.openDialogButton.Text = "Open a &File";
            this.openDialogButton.UseVisualStyleBackColor = false;
            this.openDialogButton.Click += new System.EventHandler(this.openDialogButton_Click);
            // 
            // saveDialogButton
            // 
            this.saveDialogButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.saveDialogButton.Location = new System.Drawing.Point(312, 177);
            this.saveDialogButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.saveDialogButton.Name = "saveDialogButton";
            this.saveDialogButton.Size = new System.Drawing.Size(88, 27);
            this.saveDialogButton.TabIndex = 9;
            this.saveDialogButton.Text = "S&ave a File";
            this.saveDialogButton.UseVisualStyleBackColor = false;
            this.saveDialogButton.Click += new System.EventHandler(this.saveDialogButton_Click);
            // 
            // friendFile
            // 
            this.AcceptButton = this.writeNameButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = global::writing_data_files.Properties.Resources.code;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(442, 306);
            this.Controls.Add(this.saveDialogButton);
            this.Controls.Add(this.openDialogButton);
            this.Controls.Add(this.fileDisplayLabel);
            this.Controls.Add(this.viewFileLabel);
            this.Controls.Add(this.openFileButton);
            this.Controls.Add(this.addTextButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.writeNameButton);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.friendLabel);
            this.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "friendFile";
            this.Text = "Friend File";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label friendLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button writeNameButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button addTextButton;
        private System.Windows.Forms.Button openFileButton;
        private System.Windows.Forms.Label viewFileLabel;
        private System.Windows.Forms.Label fileDisplayLabel;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button openDialogButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Button saveDialogButton;
    }
}

