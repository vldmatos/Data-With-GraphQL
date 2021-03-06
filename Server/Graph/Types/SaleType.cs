using GraphQL.Types;
using Server.Domain;

namespace Server.Graph.Schemas
{
	public class SaleType : ObjectGraphType<Sale>
	{
		public SaleType()
		{
			Name = nameof(Sale);

			Field(sale => sale.Id).Description("Sale's identifier");
			Field(sale => sale.Date).Description("Sale date");

			Field(sale => sale.Customer, type: typeof(CustomerType)).Description("Customer who made the purchase");
			Field(sale => sale.Cars, type: typeof(ListGraphType<CarType>)).Description("Cars sold");
		}
	}
}