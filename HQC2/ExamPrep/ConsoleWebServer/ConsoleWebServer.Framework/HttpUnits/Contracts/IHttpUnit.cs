namespace ConsoleWebServer.Framework.HttpUnits.Contracts
{
    using System;
    using System.Collections.Generic;

    //TODO: Fined where to use
    public interface IHttpUnit
    {
        Version ProtocolVersion { get; }

        IDictionary<string, ICollection<string>> Headers { get; }

        void AddHeader(string name, string value);
    }
}