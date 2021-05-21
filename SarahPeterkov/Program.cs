using MarkovSharp.TokenisationStrategies;
using System;
using System.IO;
using System.Linq;

namespace SarahPeterkov
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines = File.ReadAllLines("corpus.txt");

            var model = new StringMarkov(2);
            model.Learn(lines);

            while (true)
            {
                Console.WriteLine(model.Walk().First());
                Console.ReadLine();
            }
        }
    }
}
