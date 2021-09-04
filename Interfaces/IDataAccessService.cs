using Microsoft.EntityFrameworkCore;
using StellarConfigUtility.Data;
using StellarConfigUtility.Models;
using System.Collections.Generic;

namespace StellarConfigUtility.Interfaces
{
	public interface IDataAccessService
	{
		public IDbContextFactory<StellarDBContext> _contextFactory { get; set; }
		public List<Technology> GetTechnologies();
		public Technology GetTechnology(int techId);
		public void CreateTechnology(Technology tech);
		public void DeleteTechnology(int techId);
		public void UpdateTechnology(Technology tech);
	}
}
