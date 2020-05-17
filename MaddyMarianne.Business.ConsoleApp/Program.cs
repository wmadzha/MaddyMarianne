using MaddyMarianne.Business.Core.Router;
using System;

namespace MaddyMarianne.Business.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            CommandRouter cmdrouter = new CommandRouter();
            while (true)
            {
                Console.Write("YourCommand>");
                var cmd = Console.ReadLine();
                var result = cmdrouter.ProcessCommand(cmd);
                Console.WriteLine(result.Message);
            }
        }
    }
}
