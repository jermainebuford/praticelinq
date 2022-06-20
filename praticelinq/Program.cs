using System;
using System.Linq;
    internal class Program
    {
        static void Main(string[] args)
        {
            string [] videogamenames = {"the legend of zelda", "metal gear solid", "devil may cry","final fantasy","kingdom hearts"};

        videogamenames.OrderBy(x => x.Length).ToList().ForEach(Console.WriteLine);
        }
    }

