using System;
using System.Linq;
using System.Collections.Generic;
	
namespace WebApplication3.Models
{   
	public  class ShippersRepository : EFRepository<Shippers>, IShippersRepository
	{

	}

	public  interface IShippersRepository : IRepository<Shippers>
	{

	}
}