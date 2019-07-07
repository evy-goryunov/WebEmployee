using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebEmployeeClient
{
	interface IView
	{
		string sureName { get; set; }  //Фамилия
		string firstName { get; set; } //Имя
		string department { get; set; }//Отчество
		string salary { get; set; }    //Зарплата
		string age { get; set; }       //Возраст
	}
}
