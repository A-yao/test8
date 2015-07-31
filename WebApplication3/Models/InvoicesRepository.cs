using System;
using System.Linq;
using System.Collections.Generic;
	
namespace WebApplication3.Models
{   
	public  class InvoicesRepository : EFRepository<Invoices>, IInvoicesRepository
	{

	}

	public  interface IInvoicesRepository : IRepository<Invoices>
	{

	}
}