using System;
using System.Linq;
using System.Collections.Generic;
	
namespace WebApplication3.Models
{   
	public  class Customer_and_Suppliers_by_CityRepository : EFRepository<Customer_and_Suppliers_by_City>, ICustomer_and_Suppliers_by_CityRepository
	{

	}

	public  interface ICustomer_and_Suppliers_by_CityRepository : IRepository<Customer_and_Suppliers_by_City>
	{

	}
}