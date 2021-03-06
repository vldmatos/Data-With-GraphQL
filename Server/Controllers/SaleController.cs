using GraphQL;
using GraphQL.Types;
using Microsoft.AspNetCore.Mvc;
using Server.Graph.Queries;
using Server.Graph.Schemas;
using Server.Services;
using Server.Settings;
using System.Threading.Tasks;

namespace Server.Controllers
{
	[ApiController]
	[Route(RouteSettings.Api)]	
	public class SaleController : ControllerBase
	{
		private readonly SaleService _saleService;
		private readonly SaleSchema _saleSchema;

		public SaleController(SaleSchema saleSchema, SaleService saleService) => 
			(_saleSchema, _saleService) = (saleSchema, saleService);

		[HttpPost]
		public async Task<IActionResult> Post([FromBody] GraphQuery query)
		{
			var inputs = query.Variables?.ToInputs();

			var schema = new Schema
			{
				Query = new SaleQuery(_saleService)
			};

			var result = await new DocumentExecuter().ExecuteAsync(_ =>
			{
				_.Schema = schema;
				_.Query = query.Query;
				_.OperationName = query.OperationName;
				_.Inputs = inputs;
			});

			if (result.Errors?.Count > 0)
				return BadRequest();

			return Ok(result);
		}
	}
}