using System;
using System.Linq;
using System.Collections.Generic;
	
namespace WebApplication3.Models
{   
	public  class CategoriesRepository : EFRepository<Categories>, ICategoriesRepository
	{

	}

	public  interface ICategoriesRepository : IRepository<Categories>
	{

	}
}