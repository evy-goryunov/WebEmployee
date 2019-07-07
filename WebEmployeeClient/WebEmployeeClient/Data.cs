using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;
using System.Diagnostics;

namespace WebEmployeeClient
{
	class Data
	{
		private static HttpClient client;

		public Data()
		{
			client = new HttpClient();
		}
		public static ObservableCollection<Employee> emp;

		public void getData()
		{
			string urlGetList = "http://localhost:65417/getlist";
			client.DefaultRequestHeaders.Add("Accept", "application/json");
			var res = client.GetStringAsync(urlGetList).Result;
			emp = JsonConvert.DeserializeObject<ObservableCollection<Employee>>(res);
			foreach (var item in emp)
			{
				Console.WriteLine(item);
			}
		}

		public static void AddEmployee(Employee emp)
		{
			string AddUrl = "http://localhost:65417/addemployee";
			HttpContent content = new StringContent(emp, Encoding.UTF8, "application/json");
			var res = client.PostAsync(AddUrl, content);
		}
		
			//string obj = "qwe";

			//HttpClient AddClient = new HttpClient();

			//private static string urlAddEmp = "http://localhost:65417/addemployee";

			//HttpContent content = new StringContent(emp, Encoding.UTF8, "application/json");

			//var res = AddClient.PostAsync(urlAddEmp, content).result;
		

	}
}
