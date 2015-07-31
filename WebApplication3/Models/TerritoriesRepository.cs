using System;
using System.Linq;
using System.Collections.Generic;
	
namespace WebApplication3.Models
{   
	public  class TerritoriesRepository : EFRepository<Territories>, ITerritoriesRepository
	{

	}

	public  interface ITerritoriesRepository : IRepository<Territories>
	{

	}
}