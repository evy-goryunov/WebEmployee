using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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
	public partial class MainWindow : Window, IView
	{
		public MainWindow()
		{
			InitializeComponent();
			Data myData = new Data();
			myData.getData();
			LvEmp.ItemsSource = Data.emp;
		}

		public string firstName //Имя
		{
			get => FirstName.Text;
			set
			{
				FirstName.Text = value;
			}
		}
		public string department //Отчество
		{
			get => Department.Text;
			set => Department.Text = value;
		}
		public string sureName //Фамилия
		{
			get => SureName.Text;
			set => SureName.Text = value;
		}
		public string salary //Зарплата
		{
			get => Age.Text;
			set => Age.Text = value;
		}
		public string age //Возраст
		{
			get => Age.Text;
			set => Age.Text = value;
		}
	}
}
