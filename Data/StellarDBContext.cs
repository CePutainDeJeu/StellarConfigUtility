using Microsoft.EntityFrameworkCore;
using StellarConfigUtility.Models;

namespace StellarConfigUtility.Data
{
	public class StellarDBContext : DbContext
	{
		public StellarDBContext(DbContextOptions<StellarDBContext> options) : base(options) { }

		public DbSet<Technology> Technologies { get; set; }
	}
}
