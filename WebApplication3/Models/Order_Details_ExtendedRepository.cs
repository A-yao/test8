using System;
using System.Linq;
using System.Collections.Generic;
	
namespace WebApplication3.Models
{   
	public  class Order_Details_ExtendedRepository : EFRepository<Order_Details_Extended>, IOrder_Details_ExtendedRepository
	{

	}

	public  interface IOrder_Details_ExtendedRepository : IRepository<Order_Details_Extended>
	{

	}
}