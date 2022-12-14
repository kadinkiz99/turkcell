using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using turkcell.Helpers;
using turkcell.Models;

namespace turkcell
{
	public class Program
	{

		public static void Main(string[] args)
		{
			CreateHostBuilder(args).Build().Run();
		}
		//builder.Services.AddSingleton<Helper ,Helper>();
		public static IHostBuilder CreateHostBuilder(string[] args) =>
			Host.CreateDefaultBuilder(args)
				.ConfigureWebHostDefaults(webBuilder =>
				{
					webBuilder.UseStartup<Startup>();
				});

	
		
	}
	
}    
