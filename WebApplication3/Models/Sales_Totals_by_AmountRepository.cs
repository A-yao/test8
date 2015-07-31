using System;
using System.Linq;
using System.Collections.Generic;
	
namespace WebApplication3.Models
{   
	public  class Sales_Totals_by_AmountRepository : EFRepository<Sales_Totals_by_Amount>, ISales_Totals_by_AmountRepository
	{

	}

	public  interface ISales_Totals_by_AmountRepository : IRepository<Sales_Totals_by_Amount>
	{

	}
}