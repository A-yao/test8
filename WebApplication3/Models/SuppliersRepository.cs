using System;
using System.Linq;
using System.Collections.Generic;
	
namespace WebApplication3.Models
{   
	public  class SuppliersRepository : EFRepository<Suppliers>, ISuppliersRepository
	{

	}

	public  interface ISuppliersRepository : IRepository<Suppliers>
	{

	}
}