using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace FileSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBrowser_Click(object sender, EventArgs e)
        {
            OpenFileDialog folderBrowserDialog = new OpenFileDialog();
            folderBrowserDialog.ShowDialog();

            txtPath.Text = folderBrowserDialog.FileName;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string textInFile = File.ReadAllText(txtPath.Text);

            string[] allKeyword = textInFile.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);

            int matchedNumber = 0;

            foreach (string keyword in allKeyword)
            {
                if (keyword.Contains(txtTextToFind.Text) == true)
                {
                    matchedNumber = matchedNumber + 1;
                }
            }

            lblResult.Text = matchedNumber + " keyword find in the file.";
        }
    }
}
