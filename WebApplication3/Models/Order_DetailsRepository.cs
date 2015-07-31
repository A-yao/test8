using System;
using System.Linq;
using System.Collections.Generic;
	
namespace WebApplication3.Models
{   
	public  class Order_DetailsRepository : EFRepository<Order_Details>, IOrder_DetailsRepository
	{

	}

	public  interface IOrder_DetailsRepository : IRepository<Order_Details>
	{

	}
}