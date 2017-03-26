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
            this.SuspendLayout();
            // 
            // friendLabel
            // 
            this.friendLabel.AutoSize = true;
            this.friendLabel.Location = new System.Drawing.Point(12, 19);
            this.friendLabel.Name = "friendLabel";
            this.friendLabel.Size = new System.Drawing.Size(109, 13);
            this.friendLabel.TabIndex = 0;
            this.friendLabel.Text = "Enter a friend\'s name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(127, 19);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(196, 20);
            this.nameTextBox.TabIndex = 1;
            // 
            // writeNameButton
            // 
            this.writeNameButton.Location = new System.Drawing.Point(12, 207);
            this.writeNameButton.Name = "writeNameButton";
            this.writeNameButton.Size = new System.Drawing.Size(75, 23);
            this.writeNameButton.TabIndex = 2;
            this.writeNameButton.Text = "&Write Name";
            this.writeNameButton.UseVisualStyleBackColor = true;
            this.writeNameButton.Click += new System.EventHandler(this.writeNameButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(215, 207);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // addTextButton
            // 
            this.addTextButton.Location = new System.Drawing.Point(117, 207);
            this.addTextButton.Name = "addTextButton";
            this.addTextButton.Size = new System.Drawing.Size(75, 23);
            this.addTextButton.TabIndex = 4;
            this.addTextButton.Text = "A&dd Text";
            this.addTextButton.UseVisualStyleBackColor = true;
            this.addTextButton.Click += new System.EventHandler(this.addTextButton_Click);
            // 
            // friendFile
            // 
            this.AcceptButton = this.writeNameButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 265);
            this.Controls.Add(this.addTextButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.writeNameButton);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.friendLabel);
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
    }
}

