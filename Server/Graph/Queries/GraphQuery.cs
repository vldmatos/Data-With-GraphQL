
namespace Server.Graph.Queries
{
	public class GraphQuery
	{
		public string OperationName { get; set; }

		public string NamedQuery { get; set; }

		public string Query { get; set; }

		public dynamic Variables { get; set; }
	}
}