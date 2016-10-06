namespace ConsoleWebServer.Framework.Parsers
{
    using System.IO;
    using ConsoleWebServer.Framework.Exceptions;
    using ConsoleWebServer.Framework.HttpUnits;
    using System;

    public class HttpParser : IHttpRequestParser
    {
        private const string InvalidFormatMessage = "Invalid format for the first request line. Expected format: [Method] [Uri] HTTP/[Version]";


        public HttpRequest Parse(string requestAsString)
        {
            var textReader = new StringReader(requestAsString);
            var firstLine = textReader.ReadLine();
            var requestObject = CreateRequest(firstLine);

            string line;
            while ((line = textReader.ReadLine()) != null)
            {
                this.AddHeaderToRequest(requestObject, line);
            }

            return requestObject;
        }

        private HttpRequest CreateRequest(string firstRequestLine)
        {
            var firstRequestLineParts = firstRequestLine.Split(' ');
            if (firstRequestLineParts.Length != 3)
            {
                throw new ParserException(InvalidFormatMessage);
            }

            var requestObject = new HttpRequest(
                firstRequestLineParts[0],
                firstRequestLineParts[1],
                Version.Parse(firstRequestLineParts[2].ToLower().Replace("HTTP/".ToLower(), string.Empty)));

            return requestObject;
        }

        private void AddHeaderToRequest(HttpRequest request, string headerLine)
        {
            var hp = headerLine.Split(new[] { ':' }, 2);
            var hn = hp[0].Trim();
            var hv = hp.Length == 2 ? hp[1].Trim() : string.Empty;
            request.AddHeader(hn, hv);
        }
    }
}
