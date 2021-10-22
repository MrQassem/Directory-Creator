using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        static int count = 0;
        public Form1()
        {

            InitializeComponent();
            
            String[] items = { 
                "[index] - FOLDER_NAME ",
                "[FOLDER_NAME]",
                "[prefex] - FOLDER_NAME",
                "FOLDER_NAME - [postfix]",
                "[prefex] FOLDER_NAME [postfix]",
                "Create number of folders"
            };
            this.formateStyle.Items.AddRange(items);
            this.formateStyle.SelectedIndex=0;
            



        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void selectFolder_Click(object sender, EventArgs e)
        {
            this.folderBrowserDialog.ShowDialog();
            this.label1.Text = "Path: " + this.folderBrowserDialog.SelectedPath;
            this.messageFail.Visible = false;
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
//            this.formateStyle.

            String path = this.folderBrowserDialog.SelectedPath;
            if (path == "")
            {
                this.messageFail.Visible=true;
                return;
            }
            else
            {
                this.messageFail.Visible = false;
            }
           

            String input = this.folderNamesInput.Text;
            input = input.Replace("\n", "").Replace("\r", "").Replace("\t", "").Trim();
            String[] s = input.Split(",");
            IEnumerable<String> ss = s.Union(s);
            int i = 0;
            int selectedStyle = this.formateStyle.SelectedIndex;
            String prefix = this.prefix.Text;
            String postfix = this.postfix.Text;
            
            if (selectedStyle == 5) // create n folders ... 
            {

                //numberOfFoldersToCreateInpute.BackColor = Color.Red;

                int numberOfFoldersToCreate = Convert.ToInt32(this.numberOfFoldersToCreateInpute.Text);
                if (numberOfFoldersToCreate > 1)
                {
                    for (int j = 0; j < numberOfFoldersToCreate; j++)
                    {
                        Directory.CreateDirectory(path + "/" + "[" + (j + 1) + "]");
                    }
                    this.numberOfFoldersCreatedLabel.Text = numberOfFoldersToCreate + "";
                    this.message.Visible = true;
                }
            }
            else
            {
                foreach (var item in ss)
                {

                    if (item.Length > 0)
                    {
                        switch (selectedStyle)
                        {
                            //"[index] - FOLDER_NAME ",1
                            //"[FOLDER_NAME]",1
                            //"[prefex] - FOLDER_NAME",
                            //"FOLDER_NAME - [postfix]",
                            //"[prefex] FOLDER_NAME [postfix]",
                            //"Create number of folders [index]"
                            case 0: { Directory.CreateDirectory(path + "/" + "[" + i + "]" + " - " + item); break; }
                            case 1: { Directory.CreateDirectory(path + "/" + "[" + item + "]"); break; }
                            case 2: { Directory.CreateDirectory(path + "/" + "[" + prefix + "]" + " " + item); break; }
                            case 3: { Directory.CreateDirectory(path + "/" + item + "[" + postfix + "]"); break; }
                            case 4: { Directory.CreateDirectory(path + "/" + "[" + prefix + "]" + " " + item + "[" + postfix + "]"); break; }
                            // case 5 doesn't have items .. it is input .. number of folders to create

                            default: break;
                        }

                    }
                    i++;

                }
                this.numberOfFoldersCreatedLabel.Text = ss.Count()+"";
                this.message.Visible = true;

            }

        }

        private void changedFormatStyle(object sender, EventArgs e)
        {
            int selectedFormatStyle = this.formateStyle.SelectedIndex;

            if (selectedFormatStyle == 2 || selectedFormatStyle == 3 || selectedFormatStyle == 4)
            {
                this.prefixPostfixLabel.Visible = true;
                this.prefixLabel.Visible = true;
                this.postfixLable.Visible = true;
                this.prefix.Visible = true;
                this.postfix.Visible = true;
                this.prefix.Enabled = true;
                this.postfix.Enabled = true;
            }
            else
            {
                this.prefixPostfixLabel.Visible = false;
                this.prefixLabel.Visible = false;
                this.postfixLable.Visible = false;
                this.prefix.Visible = false;
                this.postfix.Visible = false;
                this.prefix.Enabled = false;
                this.postfix.Enabled = false;
            }

            if (selectedFormatStyle == 5)
            {
                this.numberOfFoldersToCreateInpute.Visible = true;
                this.numberOfFoldersToCreateLable.Visible = true;
                this.numberOfFoldersToCreateInpute.Enabled= true;
                this.numberOfFoldersToCreateLable.Enabled = true;
            }
            else
            {
                this.numberOfFoldersToCreateInpute.Visible = false;
                this.numberOfFoldersToCreateLable.Visible = false;
                this.numberOfFoldersToCreateInpute.Enabled = false;
                this.numberOfFoldersToCreateLable.Enabled = false;
            }
        }

        private void message_Click(object sender, EventArgs e)
        {

        }
    }
}
