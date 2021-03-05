using GraphiQl;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
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
			services.Configure<DatabaseSettings>(Configuration.GetSection(nameof(DatabaseSettings)));

			services.AddSingleton<IDatabaseSettings>(x => x.GetRequiredService<IOptions<DatabaseSettings>>().Value);
			services.AddSingleton<SaleService>();
			services.AddSingleton<LoadService>();
		}

		public void Configure(IApplicationBuilder application, IWebHostEnvironment environment, LoadService loadService)
		{
			if (environment.IsDevelopment())
			{
				application.UseDeveloperExceptionPage();
			}
			
			application.UseRouting();
			application.UseGraphiQl("/graph");

			loadService.Start();
		}
	}
}
