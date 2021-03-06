using MongoDB.Driver;
using Server.Domain;
using Server.Settings;
using System.Collections.Generic;
using System.Linq;

namespace Server.Services
{
	public class SaleService
	{
		#region Fields

		private readonly IMongoCollection<Sale> Sales;

		#endregion Fields

		#region Constructors

		public SaleService(IDatabaseSettings settings)
		{
			var client = new MongoClient(settings.ConnectionString);
			var database = client.GetDatabase(settings.DatabaseName);

			Sales = database.GetCollection<Sale>(settings.SaleCollectionName);
		}

		#endregion Constructors

		#region Methods

		public IEnumerable<Sale> All()
		{
			return
			Sales.Find(sale => true)
				 .ToList();
		}

		public Sale Get(string id) => Sales.Find(sale => sale.Id == id).FirstOrDefault();

		public Sale Save(Sale sale)
		{
			Sales.InsertOne(sale);
			return sale;
		}

		public void Update(string id, Sale sale) => Sales.ReplaceOne(saved => saved.Id == id, sale);

		public void Remove(Sale sale) => Sales.DeleteOne(saved => saved.Id == sale.Id);

		public void Remove(string id) => Sales.DeleteOne(sale => sale.Id == id);

		public void Clean()
		{
			Sales.DeleteMany(sale => true);
		}

		#endregion Methods
	}
}