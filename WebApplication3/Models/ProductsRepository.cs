using System;
using System.Linq;
using System.Collections.Generic;
	
namespace WebApplication3.Models
{   
	public  class ProductsRepository : EFRepository<Products>, IProductsRepository
	{

		internal IQueryable<Products> ��T��()
		{
			/**/
			return this.All().Take(3);
		}
	}

	public  interface IProductsRepository : IRepository<Products>
	{

	}
}