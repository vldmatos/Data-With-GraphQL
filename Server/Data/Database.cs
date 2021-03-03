using Microsoft.EntityFrameworkCore;
using Server.Models;

namespace Server.Data
{
	public class Database : DbContext
	{
		public Database(DbContextOptions<Database> options) : base(options) { }

		public virtual DbSet<Car> Cars { get; set; }

		public virtual DbSet<Customer> Customers { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Car>().HasData
			(
				new Car() { Id = 1, Model = "Fusion", Manufacturer = "Ford", Year = 2000 },
				new Car() { Id = 2, Model = "Golf", Manufacturer = "Volkswagem", Year = 2005 },
				new Car() { Id = 3, Model = "Uno", Manufacturer = "Fiat", Year = 2012 },
				new Car() { Id = 4, Model = "A45", Manufacturer = "Mercedes-Benz", Year = 2020 },
				new Car() { Id = 5, Model = "550i", Manufacturer = "BMW", Year = 2003 },
				new Car() { Id = 6, Model = "Cruze", Manufacturer = "Chevrolet", Year = 2001 }
			);

			modelBuilder.Entity<Customer>().HasData
			(
				new Customer() { Id = 1, FirstName = "Oliver", LastName = "Oniper", Age = 21 },
				new Customer() { Id = 2, FirstName = "John", LastName = "Lorks", Age = 30 },
				new Customer() { Id = 3, FirstName = "Chris", LastName = "Mork", Age = 45 }
			);
		}
	}
}
