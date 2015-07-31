using System;
using System.Linq;
using System.Collections.Generic;
	
namespace WebApplication3.Models
{   
	public  class EmployeesRepository : EFRepository<Employees>, IEmployeesRepository
	{

	}

	public  interface IEmployeesRepository : IRepository<Employees>
	{

	}
}