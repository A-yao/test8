using System;
using System.Linq;
using System.Collections.Generic;
	
namespace WebApplication3.Models
{   
	public  class CustomerDemographicsRepository : EFRepository<CustomerDemographics>, ICustomerDemographicsRepository
	{

	}

	public  interface ICustomerDemographicsRepository : IRepository<CustomerDemographics>
	{

	}
}