namespace ConsoleWebServer.Framework.Exceptions
{
    using System;using System.Linq;

    public class HttpNotFoundException : Exception
    {
        public const string ClassName = "HttpNotFoundException";

        public HttpNotFoundException(string message) : base(message)
        {
        }
    }
}