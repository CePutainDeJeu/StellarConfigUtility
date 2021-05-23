using Microsoft.EntityFrameworkCore;
using StellarConfigUtility.Interfaces;
using StellarConfigUtility.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StellarConfigUtility.Data
{
	public class StellarDataAccessService : IDataAccessService
	{
		public IDbContextFactory<StellarDBContext> _contextFactory { get; set; }

		public StellarDataAccessService(IDbContextFactory<StellarDBContext> contextFactory)
		{
			_contextFactory = contextFactory;

			using (StellarDBContext context = _contextFactory.CreateDbContext())
			{
				context.Database.EnsureCreated();
			}
		}

		public async void CreateTechnology(Technology tech)
		{
			using (StellarDBContext context = _contextFactory.CreateDbContext())
			{
				context.Technologies.Add(tech);
				await context.SaveChangesAsync();
			}
		}

		public async void DeleteTechnology(int techId)
		{
			using (StellarDBContext context = _contextFactory.CreateDbContext())
			{
				context.Technologies.Remove(GetTechnology(techId));
				await context.SaveChangesAsync();
			}
		}

		public List<Technology> GetTechnologies()
		{
			using (StellarDBContext context = _contextFactory.CreateDbContext())
			{
				return context.Technologies.ToList();
			}
		}

		public Technology GetTechnology(int techId)
		{
			using (StellarDBContext context = _contextFactory.CreateDbContext())
			{
				return context.Technologies.Where(tech => tech.TechnologyId == techId).FirstOrDefault();
			}
		}
	}
}
