namespace ConsoleWebServer.Framework.ActionResults.Contracts
{
    using System;
    using ConsoleWebServer.Framework.HttpUnits;
    using System.Collections.Generic;

    public abstract class ActionResultDecorator : IActionResult
    {
        private readonly IActionResult actionResult;

        public ActionResultDecorator(IActionResult actionResult)
        {
            this.actionResult = actionResult;
        }

        public HttpResponse GetResponse()
        {
            var resultHttpResponse = this.actionResult.GetResponse();

            UpdateResponse(resultHttpResponse);

            return resultHttpResponse;
        }

        protected abstract void UpdateResponse(HttpResponse resultHttpResponse);

    }
}
