using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FileSystem.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnBrowser_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog folderBrowserDialog = new OpenFileDialog();
            folderBrowserDialog.ShowDialog();

            txtPath.Text = folderBrowserDialog.FileName;
        }

        private void btnFind_Click(object sender, RoutedEventArgs e)
        {
            KeywordFinder finder = new KeywordFinder();
            int matchedNumber = finder.FindMatchedKeyword(txtPath.Text, txtTextToFind.Text);

            lblResult.Content = matchedNumber + " keyword find in the file.";
        }
    }
}
