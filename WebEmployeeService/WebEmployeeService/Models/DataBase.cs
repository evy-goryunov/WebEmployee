using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebEmployeeService.Models
{
	public class DataBase
	{
		private SqlConnection sqlConnection;

		public DataBase()
		{
			string connectionPath = @"Data Source=(localdb)\MSSQLLocalDB;
										Initial Catalog=Lesson7;
										Integrated Security=True;
										Connect Timeout=30;Encrypt=False;
										TrustServerCertificate=False;
										ApplicationIntent=ReadWrite;
										MultiSubnetFailover=False";
			sqlConnection = new SqlConnection(connectionPath);
			sqlConnection.Open();
		}
		// получение всех сотрудников из БД
		public List<Employee> GetList()
		{
			List<Employee> list = new List<Employee>();

			string sql = @"SELECT * FROM People";

			using (SqlCommand command = new SqlCommand(sql, sqlConnection))
			{
				using (SqlDataReader reader = command.ExecuteReader())
				{
					while (reader.Read())
					{
						list.Add(new Employee()
						{
							_firstName = reader["FIRSTNAME"].ToString(),
							_sureName = reader["SURENAME"].ToString(),
							_department = reader["DEPARTMENT"].ToString(),
							_id = reader["id"].ToString(),
							_salary = reader["SALARY"].ToString(),
							_age = reader["AGE"].ToString()
						});
					}
				}
			}

			return list;
		}
		// получение сотрудника по ID
		public Employee GetEmployeeById(int id)
		{
			string sql = $@"SELECT * FROM People WHERE id = {id}";
			Employee tempEmployee = new Employee();
			using (SqlCommand command = new SqlCommand(sql, sqlConnection))
			{
				using (SqlDataReader reader = command.ExecuteReader())
				{
					while (reader.Read())
					{
						tempEmployee = new Employee()
						{
							_firstName = reader["FIRSTNAME"].ToString(),
							_sureName = reader["SURENAME"].ToString(),
							_department = reader["DEPARTMENT"].ToString(),
							_salary = reader["SALARY"].ToString(),
							_age = reader["AGE"].ToString()
						};
					}
				}
			}
			return tempEmployee;
		}
		// добавление сотрудника
		public bool AddEmployee(Employee emp)
		{
			try
			{
				string sqlAdd = $@"INSERT INTO People (FIRSTNAME, SURENAME, DEPARTMENT, SALARY, AGE) 
								VALUES( N'{emp._firstName}',
										N'{emp._sureName}',
										N'{emp._department}',
										N'{emp._salary}',
										N'{emp._age}')";
			}
			catch
			{

				return false;
			}

			return true;
		}
	}
}