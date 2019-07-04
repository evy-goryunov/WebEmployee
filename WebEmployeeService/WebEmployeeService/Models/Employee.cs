using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebEmployeeService.Models
{
	public class Employee
	{
		public string _firstName { get; set; } //Имя
		public string _sureName { get; set; }  //Фамилия
		public string _department { get; set; }//Отдел
		public string _id { get; set; }           //ID
		public string _salary { get; set; }       //Зарплата
		public string _age { get; set; }          //Возраст

		//public Employee()
		//{

		//}

		//public Employee(string firstName, string sureName, string department, int id, int salary, int age)
		//{
		//	this._firstName = firstName;
		//	this._sureName = sureName;
		//	this._salary = salary;
		//	this._department = department;
		//	this._age = age;
		//	this._id = id;
		//}

		//public Employee(string firstName, string sureName, string department, int salary, int age)
		//{
		//	this._firstName = firstName;
		//	this._sureName = sureName;
		//	this._salary = salary;
		//	this._department = department;
		//	this._age = age;
		//}


	}
}