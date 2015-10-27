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

namespace ClientProject
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

		private ConverterHost converter = new ConverterHost();

		private void btnUpper_Click(object sender, RoutedEventArgs e)
		{
			txtUpperContent.Text = converter.ToUpper(txtContent.Text);
		}

		private void btnLower_Click(object sender, RoutedEventArgs e)
		{
			txtLowerContent.Text = converter.ToLower(txtContent.Text);
		}
	}
}
