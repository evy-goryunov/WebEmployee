using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Diagnostics;

namespace WebEmployeeClient
{
	class DataBase
	{
		public static ObservableCollection<Employee> dbEmployee;

		public DataBase()
		{
			dbEmployee = new ObservableCollection<Employee>();
		}

		public static void ReadFromBD()
		{
			for (int i = 0; i < dbEmployee.Count; i++)
			{
				dbEmployee.RemoveAt(i);
			}
			Employee newEmployee = new Employee();
			try
			{

				using (SqlConnection newConnect = new SqlConnection(@" Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=EmployeeDB;Integrated Security=True;Pooling=False"))
				{
					newConnect.Open();
					var sql = @" SELECT * FROM People";
					SqlCommand command = new SqlCommand(sql, newConnect);
					SqlDataReader reader = command.ExecuteReader();

					while (reader.Read())
					{

						dbEmployee.Add(new Employee(newEmployee._firstName = $"{reader["FIRSTNAME"]}",
													newEmployee._sureName = $"{reader["SURENAME"]}",
													newEmployee._department = $"{reader["DEPARTMENT"]}",
													newEmployee._age = int.Parse($"{reader["AGE"]}"),
													newEmployee._salary = int.Parse($"{reader["SALARY"]}"),
													newEmployee._id = int.Parse($"{reader["ID"]}")));
					}
				}
			}
			catch (Exception e)
			{
				Debug.WriteLine(e.Message);
			}
		}
	}
}
