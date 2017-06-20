using System;
using Microsoft.Owin.Hosting;
using Owin;

namespace NancyApp
{
	public class Startup
	{
		public void Configuration(IAppBuilder app)
		{
			app.UseNancy();
		}

		static void Main(string[] args)
		{
			var url = "http://+:8080";
			using (var app = WebApp.Start<Startup>(url))
			{
				Console.WriteLine("Running on {0}", url);
				Console.WriteLine("Press enter to exit");
				Console.ReadLine();
				app.Dispose();
			}
		}
	}
}
