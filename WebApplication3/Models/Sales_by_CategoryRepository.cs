using System;
using System.Linq;
using System.Collections.Generic;
	
namespace WebApplication3.Models
{   
	public  class Sales_by_CategoryRepository : EFRepository<Sales_by_Category>, ISales_by_CategoryRepository
	{

	}

	public  interface ISales_by_CategoryRepository : IRepository<Sales_by_Category>
	{

	}
}