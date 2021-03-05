using GraphQL.Types;
using Server.Domain;

namespace Server.Schemas
{
	public class Graph : ObjectGraphType<Sale>
	{
		public Graph()
		{
			Name = "Contex";

			Field(_ => _.Customer).Description("Customer");
			Field(_ => _.Cars).Description("List of Cars");
		}
	}
}
