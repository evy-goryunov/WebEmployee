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

namespace WebEmployeeClient
{
	/// <summary>
	/// Логика взаимодействия для MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
			DataBase db = new DataBase();
			//Employee newEmp = new Employee("Горюнов","Евгений","IT",31,999);
			//DataBase.dbEmployee.Add(newEmp);
			DataBase.ReadFromBD();
			LvEmp.ItemsSource = DataBase.dbEmployee;
		}
	}
}
