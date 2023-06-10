using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MoveMentor.Models;

namespace MoveMentor.Data
{
	public class ApplicationDbContext : IdentityDbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
			: base(options)
		{
		}
		public DbSet<MoveMentor.Models.SportType>? SportType { get; set; }
		public DbSet<MoveMentor.Models.Trening>? Trening { get; set; }
	}
}