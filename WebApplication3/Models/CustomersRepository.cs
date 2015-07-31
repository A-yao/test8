using System;
using System.Linq;
using System.Collections.Generic;
	
namespace WebApplication3.Models
{   
	public  class CustomersRepository : EFRepository<Customers>, ICustomersRepository
	{

	}

	public  interface ICustomersRepository : IRepository<Customers>
	{

	}
}