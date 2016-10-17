namespace ConsoleWebServer.Framework.HttpUnits.Contracts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public abstract class HttpUnit : IHttpUnit
    {
        public Version ProtocolVersion { get; protected set; }

        public IDictionary<string, ICollection<string>> Headers { get; protected set; }

        public HttpUnit(Version httpVersion)
        {
            this.ProtocolVersion = Version.Parse(httpVersion.ToString().ToLower().Replace("HTTP/".ToLower(), string.Empty));

            this.Headers = new SortedDictionary<string, ICollection<string>>();
        }

        public void AddHeader(string name, string value)
        {
            if (!this.Headers.ContainsKey(name))
            {
                this.Headers.Add(name, new HashSet<string>(new List<string>()));
            }

            this.Headers[name].Add(value);
        }
    }
}
