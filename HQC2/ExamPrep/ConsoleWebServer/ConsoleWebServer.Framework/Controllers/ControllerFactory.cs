namespace ConsoleWebServer.Framework.Controllers
{
    using System;
    using System.Linq;
    using System.Reflection;
    using ConsoleWebServer.Framework.Exceptions;
    using ConsoleWebServer.Framework.HttpUnits;

    public class ControllerFactory
    {
        public Controller CreateController(HttpRequest request)
        { 
                        var controllerClassName = request.Action.ControllerName + "Controller";
            var type =
                Assembly.GetEntryAssembly()
                        .GetTypes()
                        .FirstOrDefault(
                             x => x.Name.ToLower() == controllerClassName.ToLower() && typeof(Controller).IsAssignableFrom(x));
            if (type == null)
            {
                throw new HttpNotFoundException(
                    string.Format("Controller with name {0} not found!", controllerClassName));
            }

            var instance = (Controller)Activator.CreateInstance(type, request);
            return instance;
        }
    }
}
