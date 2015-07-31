using System;
using System.Linq;
using System.Collections.Generic;
	
namespace WebApplication3.Models
{   
	public  class OrdersRepository : EFRepository<Orders>, IOrdersRepository
	{

	}

	public  interface IOrdersRepository : IRepository<Orders>
	{

	}
}