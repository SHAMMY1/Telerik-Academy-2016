namespace ConsoleWebServer.Framework.RequestHandlers
{
    using System;
    using System.Linq;
    using System.Net;
    using System.Reflection;
    using ConsoleWebServer.Framework.ActionResults.Contracts;
    using ConsoleWebServer.Framework.Controllers;
    using ConsoleWebServer.Framework.HttpUnits;
    using ConsoleWebServer.Framework.RequestHandlers.Contracts;

    public class OptionsMethodRequestHandler : RequestHandler
    {
        protected override bool CanHandle(HttpRequest request)
        {
            return request.Method.ToLower() == "options";
        }

        protected override HttpResponse Handle(HttpRequest request)
        {
            var routes =
                Assembly.GetEntryAssembly()
                        .GetTypes()
                        .Where(x => x.Name.EndsWith("Controller") && typeof(Controller).IsAssignableFrom(x))
                        .Select(
                             x => new { x.Name, Methods = x.GetMethods().Where(m => m.ReturnType == typeof(IActionResult)) })
                        .SelectMany(
                             x => x.Methods.Select(
                                 m => string.Format("/{0}/{1}/{{parameter}}", x.Name.Replace("Controller", string.Empty), m.Name)))
                        .ToList();

            return new HttpResponse(request.ProtocolVersion, HttpStatusCode.OK, string.Join(Environment.NewLine, routes));
        }
    }
}