using System;
using System.Linq;
using System.Collections.Generic;
	
namespace WebApplication3.Models
{   
	public  class RegionRepository : EFRepository<Region>, IRegionRepository
	{

	}

	public  interface IRegionRepository : IRepository<Region>
	{

	}
}