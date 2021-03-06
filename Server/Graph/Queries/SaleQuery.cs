using GraphQL;
using GraphQL.Types;
using Server.Graph.Schemas;
using Server.Services;

namespace Server.Graph.Queries
{
	public class SaleQuery : ObjectGraphType
	{
		public SaleQuery(SaleService service)
		{
			Field<SaleType>(
			  "Sale",
			  arguments: new QueryArguments(new QueryArgument<IdGraphType> { Name = "id", Description = "The Identifier of sale." }),
			  resolve: context =>
			  {
				  var id = context.GetArgument<string>("id");
				  var sale = service.Get(id);

				  return sale;
			  });

			Field<ListGraphType<SaleType>>(
			  "Sales",
			  resolve: context =>
			  {
				  var sales = service.All();
				  return sales;
			  });
		}
	}
}