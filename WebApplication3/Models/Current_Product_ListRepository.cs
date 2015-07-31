using System;
using System.Linq;
using System.Collections.Generic;
	
namespace WebApplication3.Models
{   
	public  class Current_Product_ListRepository : EFRepository<Current_Product_List>, ICurrent_Product_ListRepository
	{

	}

	public  interface ICurrent_Product_ListRepository : IRepository<Current_Product_List>
	{

	}
}