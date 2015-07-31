using System;
using System.Linq;
using System.Collections.Generic;
	
namespace WebApplication3.Models
{   
	public  class Summary_of_Sales_by_QuarterRepository : EFRepository<Summary_of_Sales_by_Quarter>, ISummary_of_Sales_by_QuarterRepository
	{

	}

	public  interface ISummary_of_Sales_by_QuarterRepository : IRepository<Summary_of_Sales_by_Quarter>
	{

	}
}