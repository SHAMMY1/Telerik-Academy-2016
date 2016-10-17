namespace ConsoleWebServer.Framework.RequestHandlers.Contracts
{
    using System;
    using System.Linq;
    using System.Net;
    using ConsoleWebServer.Framework.HttpUnits;

    public abstract class RequestHandler : IRequestHandler
    {
        private RequestHandler nextHandler;

        public RequestHandler SetSuccessor(RequestHandler successor)
        {
            if (this.nextHandler == null)
            {
                this.nextHandler = successor;
            }
            else
            {
                this.nextHandler.SetSuccessor(successor);
            }

            return this;
        }

        public HttpResponse Process(HttpRequest request)
        {
            if (CanHandle(request))
            {
                return Handle(request);
            }
            else if (this.nextHandler != null)
            {
                return this.nextHandler.Process(request);
            }

            return new HttpResponse(request.ProtocolVersion, HttpStatusCode.NotImplemented, "Request cannot be handled.");
        }

        protected abstract bool CanHandle(HttpRequest request);

        protected abstract HttpResponse Handle(HttpRequest request);
    }
}
