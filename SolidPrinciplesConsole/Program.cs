using System;
using System.IO;

namespace SolidPrinciplesConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var fs = File.OpenRead("text.txt");
            var sr = new StreamReader(fs);

            Console.WriteLine(sr.ReadToEnd());
        }
    }
}
