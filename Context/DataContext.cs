using Microsoft.EntityFrameworkCore;
using WebApplication1.Entity;

namespace WebApplication1.Context
{
	public class DataContext : DbContext
	{
		public DataContext(DbContextOptions<DataContext> options) : base(options)
		{
		}

		public DbSet<Product> Products { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			base.OnConfiguring(optionsBuilder);
			optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=BASEAPRENDIZADO;Trusted_Connection=true;TrustServerCertificate=true;");
		}
	}
}
