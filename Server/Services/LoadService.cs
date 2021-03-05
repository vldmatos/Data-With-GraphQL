using Server.Domain;
using Server.Domain.Entities;
using System;
using System.Collections.Generic;

namespace Server.Services
{
	public class LoadService 
	{
		private readonly SaleService _saleService;

		public LoadService(SaleService saleService)
		{
			_saleService = saleService;
		}

		public void Start()
		{
			_saleService.Clean();

			_saleService.Save(new Sale()
			{
				Id = Guid.NewGuid().ToString(),
				Date = new DateTime(2021, 2, 1),
				Customer = new Customer { Register = "A5R3454", FirstName = "Oliver", LastName = "Oniper", Age = 21 },
				Cars = new List<Car>() 
				{
					new Car { Model = "Fusion", Color = "White", Manufacturer = "Ford", Year = 2000, Price = 80000 },
					new Car { Model = "Golf", Color = "Black", Manufacturer = "Volkswagem", Year = 2005, Price = 75000 }
				}
			});


			_saleService.Save(new Sale()
			{
				Id = Guid.NewGuid().ToString(),
				Date = new DateTime(2021, 1, 3),
				Customer = new Customer { Register = "AT63421", FirstName = "John", LastName = "Lorks", Age = 33 },
				Cars = new List<Car>()
				{
					new Car { Model = "Uno", Color = "Red", Manufacturer = "Fiat", Year = 2012, Price = 23000 },
					new Car { Model = "A45", Color = "Black", Manufacturer = "Mercedes-Benz", Year = 2020, Price = 150000 },
				}
			});


			_saleService.Save(new Sale()
			{
				Id = Guid.NewGuid().ToString(),
				Date = new DateTime(2021, 2, 15),
				Customer = new Customer { Register = "G837H32", FirstName = "Chris", LastName = "Mork", Age = 28 },
				Cars = new List<Car>()
				{
					new Car { Model = "550i", Color = "Gray", Manufacturer = "BMW", Year = 2003, Price = 77200 },
					new Car { Model = "Cruze", Color = "Red",  Manufacturer = "Chevrolet", Year = 2001, Price = 55900 }
				}
			});

			_saleService.Save(new Sale()
			{
				Id = Guid.NewGuid().ToString(),
				Date = new DateTime(2021, 1, 8),
				Customer = new Customer { Register = "RE23453", FirstName = "Ted", LastName = "Islem", Age = 55 },
				Cars = new List<Car>()
				{
					new Car { Model = "Civic", Color = "Gray",  Manufacturer = "Honda", Year = 2020, Price = 98000 }
				}
			});

			_saleService.Save(new Sale()
			{
				Id = Guid.NewGuid().ToString(),
				Date = new DateTime(2021, 2, 22),
				Customer = new Customer { Register = "REE3222", FirstName = "Bily", LastName = "Ontty", Age = 41 },
				Cars = new List<Car>()
				{
					new Car { Model = "Corolla", Color = "Black",  Manufacturer = "Toyota", Year = 2020, Price = 122000 }
				}
			});
		}
	}
}
