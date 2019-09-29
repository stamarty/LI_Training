using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;


namespace CubeButtons {
	/// <summary>
	/// Interaction logic for Window1.xaml
	/// </summary>

	public partial class Window1 : System.Windows.Window {

		public Window1() {
			InitializeComponent();
			SaveButton.Click += new RoutedEventHandler(SaveButton_Click);
			OkButton.Click += new RoutedEventHandler(OkButton_Click);
			CancelButton.Click += new RoutedEventHandler(CancelButton_Click);
		}

		void CancelButton_Click(object sender, RoutedEventArgs e) {
			MessageTextBlock.Text = "Cancel";
		}

		void OkButton_Click(object sender, RoutedEventArgs e) {
			MessageTextBlock.Text = "OK";
		}

		void SaveButton_Click(object sender, RoutedEventArgs e) {
			MessageTextBlock.Text = "Save";
		}

	}
}