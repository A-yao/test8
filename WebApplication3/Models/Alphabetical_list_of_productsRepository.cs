using System;
using System.Linq;
using System.Collections.Generic;
	
namespace WebApplication3.Models
{   
	public  class Alphabetical_list_of_productsRepository : EFRepository<Alphabetical_list_of_products>, IAlphabetical_list_of_productsRepository
	{

	}

	public  interface IAlphabetical_list_of_productsRepository : IRepository<Alphabetical_list_of_products>
	{

	}
}