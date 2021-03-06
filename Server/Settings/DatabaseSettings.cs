namespace Server.Settings
{
	public class DatabaseSettings : IDatabaseSettings
	{
		public string SaleCollectionName { get; set; }
		public string ConnectionString { get; set; }
		public string DatabaseName { get; set; }
	}

	public interface IDatabaseSettings
	{
		string SaleCollectionName { get; set; }
		string ConnectionString { get; set; }
		string DatabaseName { get; set; }
	}
}