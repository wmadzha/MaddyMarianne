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
                if(checkBasicCommandLine(cmd))
                {
                    var result = cmdrouter.ProcessCommand(cmd);
                    Console.WriteLine(result.Message);
                }
            }
        }
        static bool checkBasicCommandLine(string cmd)
        {
            bool shouldContinue = true;
            if (cmd == "cls")
            { Console.Clear(); shouldContinue = false; }
            if (cmd == "exit")
            { Environment.Exit(0); shouldContinue = false; }
            return shouldContinue;
        }
    }
}
