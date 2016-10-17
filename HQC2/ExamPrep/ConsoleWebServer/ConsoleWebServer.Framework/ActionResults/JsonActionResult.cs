namespace ConsoleWebServer.Framework.ActionResults
{
    using System;
    using ConsoleWebServer.Framework.ActionResults.Contracts;
    using ConsoleWebServer.Framework.HttpUnits;
    using Newtonsoft.Json;

    public class JsonActionResult : ActionResult, IActionResult
    {
        public JsonActionResult(HttpRequest request, object model)
            : base(request, model)
        {
        }

        protected override string GetContent()
        {
            return JsonConvert.SerializeObject(Model);
        }

        protected override string GetContentType()
        {
            return "application/json";
        }
    }
}