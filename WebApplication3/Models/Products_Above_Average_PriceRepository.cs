using System;
using System.Linq;
using System.Collections.Generic;
	
namespace WebApplication3.Models
{   
	public  class Products_Above_Average_PriceRepository : EFRepository<Products_Above_Average_Price>, IProducts_Above_Average_PriceRepository
	{

	}

	public  interface IProducts_Above_Average_PriceRepository : IRepository<Products_Above_Average_Price>
	{

	}
}