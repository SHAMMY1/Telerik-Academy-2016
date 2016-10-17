namespace ConsoleWebServer.Framework.ActionResults
{
    using ConsoleWebServer.Framework.ActionResults.Contracts;

    public class ActionResultWithCorsDecorator : ActionResultDecorator
    {
        private readonly string corsSettings;

        public ActionResultWithCorsDecorator(IActionResult actionResult, string corsSettings) : base(actionResult)
        {
            this.corsSettings = corsSettings;
        }


        protected override void UpdateResponse(HttpUnits.HttpResponse resultHttpResponse)
        {
            resultHttpResponse.AddHeader("Access-Control-Allow-Origin", corsSettings);
        }
    }
}