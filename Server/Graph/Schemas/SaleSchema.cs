using GraphQL.Types;
using GraphQL.Utilities;
using Server.Graph.Queries;
using System;

namespace Server.Graph.Schemas
{
	public class SaleSchema : Schema
	{
		public SaleSchema(IServiceProvider serviceProvider) : base(serviceProvider)
		{
			Query = serviceProvider.GetRequiredService<SaleQuery>();
		}
	}
}