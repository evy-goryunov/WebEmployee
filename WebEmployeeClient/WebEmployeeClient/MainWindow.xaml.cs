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
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();

			string obj = "qwe";

			HttpClient client = new HttpClient();

			string url = "http://localhost:65417/addemployee";
			string url2 = "http://localhost:65417/getlist";
			string url3 = "http://localhost:65417/getlist/id";

			HttpContent content = new StringContent(obj, Encoding.UTF8, "application/json");

			var res = client.PostAsync(url, content).Result;

			var res2 = client.GetAsync(url2).Result;

			var res3 = client.GetAsync(url3).Result;
		}
	}
}
