using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Diagnostics;

namespace Promethium.JS
{

    class Program
    {
        static void Main(string[] args)
        {
            WebClient client = new WebClient();
            string clientVersion = "0.1";
            string version = client.DownloadString("https://pastebin.com/raw/cTYB3Zxk");
            if(!version.Contains(clientVersion))
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("[ OUTDATED CLIENT ]");
                Console.ReadKey();
                Environment.Exit(0);
            }
            Console.Title = "Promethium.JS | v" + version;
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("[ Promethium.JS ]");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("1) ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Download script");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("-> ");
            Console.ForegroundColor = ConsoleColor.White;
            string input = Console.ReadLine();
            if(input.Contains("1"))
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("[ Downloading ]");
                client.DownloadFile("https://secretserviceclub.000webhostapp.com/promethium.js", "promethium.js");
                Console.Write("[ Done ]");
                Console.ReadKey();
            }
        }
    }
}
