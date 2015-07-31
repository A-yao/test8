using System;
using System.Linq;
using System.Collections.Generic;
	
namespace WebApplication3.Models
{   
	public  class Category_Sales_for_1997Repository : EFRepository<Category_Sales_for_1997>, ICategory_Sales_for_1997Repository
	{

	}

	public  interface ICategory_Sales_for_1997Repository : IRepository<Category_Sales_for_1997>
	{

	}
}