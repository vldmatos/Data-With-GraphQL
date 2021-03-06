using GraphiQl;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using Server.Graph.Queries;
using Server.Graph.Schemas;
using Server.Services;
using Server.Settings;

namespace Server
{
	public class Startup
	{
		public IConfiguration Configuration { get; }

		public Startup(IConfiguration configuraiton)
		{
			Configuration = configuraiton;
		}

		public void ConfigureServices(IServiceCollection services)
		{
			services.AddControllers().AddNewtonsoftJson(options => options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
);
			services.Configure<DatabaseSettings>(Configuration.GetSection(nameof(DatabaseSettings)));

			services.AddSingleton<IDatabaseSettings>(x => x.GetRequiredService<IOptions<DatabaseSettings>>().Value);
			services.AddSingleton<SaleService>();
			services.AddSingleton<LoadService>();

			services.AddScoped<SaleSchema>();
			services.AddScoped<SaleQuery>();

			services.AddScoped<SaleType>();
			services.AddScoped<CustomerType>();
			services.AddScoped<CarType>();
		}

		public void Configure(IApplicationBuilder application, IWebHostEnvironment environment, LoadService loadService)
		{
			if (environment.IsDevelopment())
			{
				application.UseDeveloperExceptionPage();
			}

			application.UseRouting();
			application.UseGraphiQl($"/{RouteSettings.Graph}",
									$"/{RouteSettings.Api}");			
			
			
			application.UseEndpoints(endpoints =>
			{
				endpoints.MapControllers();
			});

			loadService.Start();
		}
	}
}