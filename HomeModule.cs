using Nancy;

namespace NancyApp
{
	public class HomeModule : NancyModule
	{
		public HomeModule()
		{
			Get["/"] = _ => "Hello World!";
		}
	}
}
