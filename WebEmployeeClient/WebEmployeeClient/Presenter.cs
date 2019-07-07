using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebEmployeeClient
{
	class Presenter
	{
		private IView _view;

		public Presenter(IView view)
		{
			this._view = view;
		}

		public Employee CreateNewEmployee()
		{

			Data.AddEmployee();

			Employee newEmp = new Employee();
			{
				newEmp._sureName = _view.sureName;
				newEmp._firstName = _view.firstName;
				newEmp._department = _view.department;
				newEmp._age = int.Parse(_view.age);
				newEmp._salary = int.Parse(_view.salary);
			}


			return newEmp;
		}
	}
}
