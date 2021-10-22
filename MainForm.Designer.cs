
namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.folderBrowserDialog2 = new System.Windows.Forms.FolderBrowserDialog();
            this.selectFolder = new System.Windows.Forms.Button();
            this.folderNamesInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.message = new System.Windows.Forms.Label();
            this.formateStyle = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numberOfFoldersToCreateInpute = new System.Windows.Forms.TextBox();
            this.numberOfFoldersToCreateLable = new System.Windows.Forms.Label();
            this.prefixPostfixLabel = new System.Windows.Forms.Label();
            this.prefix = new System.Windows.Forms.TextBox();
            this.postfix = new System.Windows.Forms.TextBox();
            this.prefixLabel = new System.Windows.Forms.Label();
            this.postfixLable = new System.Windows.Forms.Label();
            this.messageFail = new System.Windows.Forms.Label();
            this.numberOfFoldersCreatedLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(14, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select the parent folder";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.Description = "dddddd";
            this.folderBrowserDialog.UseDescriptionForTitle = true;
            // 
            // selectFolder
            // 
            this.selectFolder.Cursor = System.Windows.Forms.Cursors.Default;
            this.selectFolder.ForeColor = System.Drawing.Color.Black;
            this.selectFolder.Location = new System.Drawing.Point(94, 62);
            this.selectFolder.Name = "selectFolder";
            this.selectFolder.Size = new System.Drawing.Size(101, 32);
            this.selectFolder.TabIndex = 3;
            this.selectFolder.Text = "Select Folder";
            this.selectFolder.UseVisualStyleBackColor = true;
            this.selectFolder.Click += new System.EventHandler(this.selectFolder_Click);
            // 
            // folderNamesInput
            // 
            this.folderNamesInput.Location = new System.Drawing.Point(10, 142);
            this.folderNamesInput.Multiline = true;
            this.folderNamesInput.Name = "folderNamesInput";
            this.folderNamesInput.Size = new System.Drawing.Size(273, 118);
            this.folderNamesInput.TabIndex = 4;
            this.folderNamesInput.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Enter folders names comma seperated";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(79, 397);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 53);
            this.button2.TabIndex = 6;
            this.button2.Text = "Generate Folders";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // message
            // 
            this.message.AutoSize = true;
            this.message.Location = new System.Drawing.Point(80, 456);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(138, 17);
            this.message.TabIndex = 7;
            this.message.Text = "Folders are generated";
            this.message.Visible = false;
            this.message.Click += new System.EventHandler(this.message_Click);
            // 
            // formateStyle
            // 
            this.formateStyle.FormattingEnabled = true;
            this.formateStyle.Location = new System.Drawing.Point(14, 293);
            this.formateStyle.Name = "formateStyle";
            this.formateStyle.Size = new System.Drawing.Size(265, 25);
            this.formateStyle.TabIndex = 8;
            this.formateStyle.SelectedIndexChanged += new System.EventHandler(this.changedFormatStyle);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Select format Style";
            // 
            // numberOfFoldersToCreateInpute
            // 
            this.numberOfFoldersToCreateInpute.Enabled = false;
            this.numberOfFoldersToCreateInpute.HideSelection = false;
            this.numberOfFoldersToCreateInpute.Location = new System.Drawing.Point(10, 347);
            this.numberOfFoldersToCreateInpute.Name = "numberOfFoldersToCreateInpute";
            this.numberOfFoldersToCreateInpute.Size = new System.Drawing.Size(45, 25);
            this.numberOfFoldersToCreateInpute.TabIndex = 10;
            this.numberOfFoldersToCreateInpute.Visible = false;
            // 
            // numberOfFoldersToCreateLable
            // 
            this.numberOfFoldersToCreateLable.AutoSize = true;
            this.numberOfFoldersToCreateLable.Location = new System.Drawing.Point(12, 330);
            this.numberOfFoldersToCreateLable.Name = "numberOfFoldersToCreateLable";
            this.numberOfFoldersToCreateLable.Size = new System.Drawing.Size(181, 17);
            this.numberOfFoldersToCreateLable.TabIndex = 11;
            this.numberOfFoldersToCreateLable.Text = "Number Of Folders To Create";
            this.numberOfFoldersToCreateLable.Visible = false;
            // 
            // prefixPostfixLabel
            // 
            this.prefixPostfixLabel.AutoSize = true;
            this.prefixPostfixLabel.Location = new System.Drawing.Point(15, 330);
            this.prefixPostfixLabel.Name = "prefixPostfixLabel";
            this.prefixPostfixLabel.Size = new System.Drawing.Size(181, 17);
            this.prefixPostfixLabel.TabIndex = 13;
            this.prefixPostfixLabel.Text = "Number Of Folders To Create";
            this.prefixPostfixLabel.Visible = false;
            // 
            // prefix
            // 
            this.prefix.Enabled = false;
            this.prefix.Location = new System.Drawing.Point(61, 349);
            this.prefix.Name = "prefix";
            this.prefix.Size = new System.Drawing.Size(45, 25);
            this.prefix.TabIndex = 12;
            this.prefix.Visible = false;
            // 
            // postfix
            // 
            this.postfix.Enabled = false;
            this.postfix.Location = new System.Drawing.Point(159, 349);
            this.postfix.Name = "postfix";
            this.postfix.Size = new System.Drawing.Size(45, 25);
            this.postfix.TabIndex = 14;
            this.postfix.Visible = false;
            // 
            // prefixLabel
            // 
            this.prefixLabel.AutoSize = true;
            this.prefixLabel.Location = new System.Drawing.Point(15, 353);
            this.prefixLabel.Name = "prefixLabel";
            this.prefixLabel.Size = new System.Drawing.Size(41, 17);
            this.prefixLabel.TabIndex = 15;
            this.prefixLabel.Text = "prefix";
            this.prefixLabel.Visible = false;
            // 
            // postfixLable
            // 
            this.postfixLable.AutoSize = true;
            this.postfixLable.Location = new System.Drawing.Point(112, 353);
            this.postfixLable.Name = "postfixLable";
            this.postfixLable.Size = new System.Drawing.Size(47, 17);
            this.postfixLable.TabIndex = 16;
            this.postfixLable.Text = "postfix";
            this.postfixLable.Visible = false;
            // 
            // messageFail
            // 
            this.messageFail.AutoSize = true;
            this.messageFail.Location = new System.Drawing.Point(98, 456);
            this.messageFail.Name = "messageFail";
            this.messageFail.Size = new System.Drawing.Size(102, 17);
            this.messageFail.TabIndex = 17;
            this.messageFail.Text = "Select path first!";
            this.messageFail.Visible = false;
            // 
            // numberOfFoldersCreatedLabel
            // 
            this.numberOfFoldersCreatedLabel.AutoSize = true;
            this.numberOfFoldersCreatedLabel.Location = new System.Drawing.Point(31, 456);
            this.numberOfFoldersCreatedLabel.Name = "numberOfFoldersCreatedLabel";
            this.numberOfFoldersCreatedLabel.Size = new System.Drawing.Size(0, 17);
            this.numberOfFoldersCreatedLabel.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(298, 482);
            this.Controls.Add(this.numberOfFoldersCreatedLabel);
            this.Controls.Add(this.postfixLable);
            this.Controls.Add(this.prefixLabel);
            this.Controls.Add(this.postfix);
            this.Controls.Add(this.prefixPostfixLabel);
            this.Controls.Add(this.prefix);
            this.Controls.Add(this.numberOfFoldersToCreateLable);
            this.Controls.Add(this.numberOfFoldersToCreateInpute);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.formateStyle);
            this.Controls.Add(this.message);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.folderNamesInput);
            this.Controls.Add(this.selectFolder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.messageFail);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Directory Creator App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog2;
        private System.Windows.Forms.Button selectFolder;
        private System.Windows.Forms.TextBox folderNamesInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label message;
        private System.Windows.Forms.ComboBox formateStyle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox numberOfFoldersToCreateInpute;
        private System.Windows.Forms.Label numberOfFoldersToCreateLable;
        private System.Windows.Forms.Label prefixPostfixLabel;
        private System.Windows.Forms.TextBox prefix;
        private System.Windows.Forms.TextBox postfix;
        private System.Windows.Forms.Label prefixLabel;
        private System.Windows.Forms.Label postfixLable;
        private System.Windows.Forms.Label messageFail;
        private System.Windows.Forms.Label numberOfFoldersCreatedLabel;
    }
}

