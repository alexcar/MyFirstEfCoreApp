using Microsoft.EntityFrameworkCore;
using MyFirstEfCoreApp.Entities;

namespace MyFirstEfCoreApp
{
	public class AppDbContext : DbContext
	{
		private const string ConnectionString =
			@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MyFirstEfCoreDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
		
		protected override void OnConfiguring(
			DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(ConnectionString);
		}

		public DbSet<Book> Books { get; set; }
	}
}
