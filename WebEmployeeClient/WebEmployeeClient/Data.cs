using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace WebEmployeeClient
{
	class Data
	{
		HttpClient client = new HttpClient();
		private string url = "http://localhost:65417/getlist";
		public static ObservableCollection<Employee> emp = new ObservableCollection<Employee>();

		public void getEmp()
		{
			client.DefaultRequestHeaders.Add("Accept", "application/json");
			client.GetAsync(url);
		}

	}
}
