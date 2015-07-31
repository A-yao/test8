using System;
using System.Linq;
using System.Collections.Generic;
	
namespace WebApplication3.Models
{   
	public  class Orders_QryRepository : EFRepository<Orders_Qry>, IOrders_QryRepository
	{

	}

	public  interface IOrders_QryRepository : IRepository<Orders_Qry>
	{

	}
}