using GraphQL.Types;
using Server.Domain;

namespace Server.Schemas
{
	public class SaleSchema : ObjectGraphType<Sale>
	{
		public SaleSchema()
		{
			Name = nameof(Sale);

			Field(sale => sale.Id).Description("Sale's identifier");
			Field(sale => sale.Date).Description("Sale date");

			Field(sale => sale.Customer, type: typeof(CustomerSchema)).Description("Customer who made the purchase");
			Field(sale => sale.Cars, type: typeof(ListGraphType<CarSchema>)).Description("Cars sold");
		}
	}
}