﻿// TODO: Describe patterns, SOLID, bugs and bottleneck in Documentation.txt
namespace ConsoleWebServer.Application
{
    public static class StartUp
    {
        public static void Main()
        {
            var webSever = new WebServerConsole5();

            webSever.Start();
        }
    }
}