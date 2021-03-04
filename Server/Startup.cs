using GraphiQl;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Server
{
	public class Startup
	{
		private const string routeGraphQL = "/graphql";

		public IConfiguration Configuration { get; }

		public Startup(IConfiguration configuraiton)
		{
			Configuration = configuraiton;
		}

		public void ConfigureServices(IServiceCollection services)
		{
			services.AddDbContext<Data.Database>(x => x.UseSqlite(Configuration.GetConnectionString("DefaultConnection")));
		}

		public void Configure(IApplicationBuilder application, IWebHostEnvironment environment)
		{
			if (environment.IsDevelopment())
			{
				application.UseDeveloperExceptionPage();
			}

			application.UseRouting();
			application.UseGraphiQl(routeGraphQL);

			application.UseEndpoints(endpoints =>
			{
				endpoints.MapGet("/", async context =>
				{
					await context.Response.WriteAsync($"Data with GraphQL, playgroud route {routeGraphQL}");
				});
			});
		}
	}
}
