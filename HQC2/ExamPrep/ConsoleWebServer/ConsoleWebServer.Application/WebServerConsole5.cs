namespace ConsoleWebServer.Application
{
    using System;
    using System.Linq;
    using System.Text;
    using ConsoleWebServer.Framework.ResponseProviders;
    using ConsoleWebServer.Framework.Parsers;
    using ConsoleWebServer.Framework.RequestHandlers;

    public class WebServerConsole5
    {
        private readonly ResponseProvider responseProvider;

        public WebServerConsole5()
        {
            var parser = new HttpParser();
            var handler = new HeadHandler()
                .SetSuccessor(new OptionsMethodRequestHandler())
                .SetSuccessor(new StaticFileHandler())
                .SetSuccessor(new ProtocolVersionRequestHandler());

            this.responseProvider = new ResponseProvider(handler, parser);

        }

        public void Start()
        {
            var requestBuilder = new StringBuilder();
            string inputLine;
            while ((inputLine = Console.ReadLine()) != null)
            {
                if (string.IsNullOrWhiteSpace(inputLine))
                {
                    var response = this.responseProvider.GetResponse(requestBuilder.ToString());
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine(response);
                    Console.ResetColor();
                    requestBuilder.Clear();
                    continue;
                }

                requestBuilder.AppendLine(inputLine);
            }
        }
    }
}