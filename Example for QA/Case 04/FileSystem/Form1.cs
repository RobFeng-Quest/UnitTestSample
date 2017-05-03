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
            KeywordFinder finder = new KeywordFinder(new DataFileReader());
            int matchedNumber = finder.FindMatchedKeyword(txtPath.Text, txtTextToFind.Text);

            lblResult.Text = matchedNumber + " keyword find in the file.";
        }
    }
}
