using ConsoleWebServer.Framework.HttpUnits;

namespace ConsoleWebServer.Framework.ResponseProviders.Contracts
{
    public interface IResponseProvider
    {
        HttpResponse GetResponse(string requestAsString);
    }
}