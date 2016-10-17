using ConsoleWebServer.Framework.HttpUnits;

namespace ConsoleWebServer.Framework.Parsers
{
    public interface IHttpRequestParser
    {
        HttpRequest Parse(string requestAsString);
    }
}