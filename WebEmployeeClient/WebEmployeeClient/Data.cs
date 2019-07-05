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
		private string url = "http://localhost:65417/getlist";
		public static ObservableCollection<Employee> emp;

		public void getData()
		{
			HttpClient client = new HttpClient();
			client.DefaultRequestHeaders.Add("Accept", "application/json");
			var res = client.GetStringAsync(url).Result;
			emp = JsonConvert.DeserializeObject<ObservableCollection<Employee>>(res);
			foreach (var item in emp)
			{
				Console.WriteLine(item);
			}
		}

	}
}
