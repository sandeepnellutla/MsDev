using Nancy;

namespace MSDev
{
    public class HomeModule:NancyModule
    {
        public HomeModule()
        {
            Get["/"] = _ => "Hello World";
        }
    }
}
