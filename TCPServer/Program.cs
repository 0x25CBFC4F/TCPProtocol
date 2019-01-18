using System;

namespace TCPServer
{
    internal class Program
    {
        private static void Main()
        {
            Console.Title = "XServer";
            Console.ForegroundColor = ConsoleColor.White;

            var server = new XServer();
            server.Start();
            server.AcceptClients();
        }
    }
}
