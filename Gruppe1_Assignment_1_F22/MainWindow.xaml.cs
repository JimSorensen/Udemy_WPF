﻿using Gruppe1_Assignment_1_F22.ViewModels;
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

namespace Gruppe1_Assignment_1_F22
{
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void btnDepartment_Click(object sender, RoutedEventArgs e)
		{
			IbIWindowName.Content = "Department List";
			DataContext = new DepartmentViewModel();
		}
	}
}
