using System;
using System.Linq;
using System.Collections.Generic;
	
namespace WebApplication3.Models
{   
	public  class Order_SubtotalsRepository : EFRepository<Order_Subtotals>, IOrder_SubtotalsRepository
	{

	}

	public  interface IOrder_SubtotalsRepository : IRepository<Order_Subtotals>
	{

	}
}