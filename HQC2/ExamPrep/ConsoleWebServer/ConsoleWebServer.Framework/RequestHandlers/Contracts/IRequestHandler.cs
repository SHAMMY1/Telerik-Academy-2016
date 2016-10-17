namespace ConsoleWebServer.Framework.RequestHandlers.Contracts
{
using ConsoleWebServer.Framework.HttpUnits;

    public interface IRequestHandler
    {
        HttpResponse Process(HttpRequest request);
    }
}
