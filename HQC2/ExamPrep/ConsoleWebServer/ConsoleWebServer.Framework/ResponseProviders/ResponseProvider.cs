namespace ConsoleWebServer.Framework.ResponseProviders
{
    using System;
    using System.Linq;
    using System.Net;
    using ConsoleWebServer.Framework.HttpUnits;
    using ConsoleWebServer.Framework.Parsers;
    using ConsoleWebServer.Framework.RequestHandlers.Contracts;
    using ConsoleWebServer.Framework.ResponseProviders.Contracts;

    public class ResponseProvider : IResponseProvider
    {
        private readonly IHttpRequestParser requestParser;

        private readonly IRequestHandler requestHendler;

        public ResponseProvider(IRequestHandler requestHandler, IHttpRequestParser requestParser)
        {
            this.requestParser = requestParser;
            this.requestHendler = requestHandler;
        }

        public HttpResponse GetResponse(string requestAsString)
        {
            HttpRequest request;

            try
            {
                request = requestParser.Parse(requestAsString);
            }
            catch (Exception ex)
            {
                return new HttpResponse(new Version(1, 1), HttpStatusCode.BadRequest, ex.Message);
            }

            try
            {
                return this.requestHendler.Process(request);
            }
            catch (Exception ex)
            {
                return new HttpResponse(request.ProtocolVersion, HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}