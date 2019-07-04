using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebEmployeeService.Models;

namespace WebEmployeeService.Controllers
{
	public class EmployeeController : ApiController
	{
		private DataBase data = new DataBase();

		[Route("getlist")]
		public List<Employee> Get() => data.GetList();

		[Route("getlist/{id}")]
		public Employee GetEmployee(int id) => data.GetEmployeeById(id);

		[Route("addemployee")]
		public HttpResponseMessage Post([FromBody]Employee value)
		{
			if (data.AddEmployee(value))
			{
				return Request.CreateResponse(HttpStatusCode.Created);
			}
			else
			{
				return Request.CreateResponse(HttpStatusCode.BadRequest);
			}
		}
	}
}
