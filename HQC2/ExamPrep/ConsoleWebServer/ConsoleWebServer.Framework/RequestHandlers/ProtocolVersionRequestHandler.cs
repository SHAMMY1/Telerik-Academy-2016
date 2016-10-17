namespace ConsoleWebServer.Framework.RequestHandlers
{
    using System;
    using System.Linq;
    using System.Net;
    using System.Reflection;
    using ConsoleWebServer.Framework;
    using ConsoleWebServer.Framework.Controllers;
    using ConsoleWebServer.Framework.Exceptions;
    using ConsoleWebServer.Framework.HttpUnits;
    using ConsoleWebServer.Framework.RequestHandlers.Contracts;

    public class ProtocolVersionRequestHandler : RequestHandler
    {
        protected override bool CanHandle(HttpRequest request)
        {
            return request.ProtocolVersion.Major < 3;
        }

        protected override HttpResponse Handle(HttpRequest request)
        {
            HttpResponse response;
            try
            {
                var controller = new ControllerFactory().CreateController(request);
                var actionInvoker = new ActionInvoker();
                var actionResult = actionInvoker.InvokeAction(controller, request.Action);
                response = actionResult.GetResponse();
            }
            catch (HttpNotFoundException exception)
            {
                response = new HttpResponse(request.ProtocolVersion, HttpStatusCode.NotFound, exception.Message);
            }

            return response;
        }
    }
}