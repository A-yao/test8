using System;
using System.Linq;
using System.Collections.Generic;
	
namespace WebApplication3.Models
{   
	public  class Products_by_CategoryRepository : EFRepository<Products_by_Category>, IProducts_by_CategoryRepository
	{

	}

	public  interface IProducts_by_CategoryRepository : IRepository<Products_by_Category>
	{

	}
}