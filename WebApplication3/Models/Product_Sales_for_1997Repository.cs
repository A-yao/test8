using System;
using System.Linq;
using System.Collections.Generic;
	
namespace WebApplication3.Models
{   
	public  class Product_Sales_for_1997Repository : EFRepository<Product_Sales_for_1997>, IProduct_Sales_for_1997Repository
	{

	}

	public  interface IProduct_Sales_for_1997Repository : IRepository<Product_Sales_for_1997>
	{

	}
}