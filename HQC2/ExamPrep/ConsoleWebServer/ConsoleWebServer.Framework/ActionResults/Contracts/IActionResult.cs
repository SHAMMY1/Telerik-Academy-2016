using ConsoleWebServer.Framework.HttpUnits;

namespace ConsoleWebServer.Framework.ActionResults.Contracts
{
    public interface IActionResult
    {
        HttpResponse GetResponse();
    }
}