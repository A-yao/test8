using System;
using System.Linq;
using System.Collections.Generic;
	
namespace WebApplication3.Models
{   
	public  class Summary_of_Sales_by_YearRepository : EFRepository<Summary_of_Sales_by_Year>, ISummary_of_Sales_by_YearRepository
	{

	}

	public  interface ISummary_of_Sales_by_YearRepository : IRepository<Summary_of_Sales_by_Year>
	{

	}
}