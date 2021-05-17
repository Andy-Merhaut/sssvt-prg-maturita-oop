using System;
using MaturitaOOP.Constructors;

namespace MaturitaOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            BasicMaths maths = new BasicMaths();
            Console.WriteLine(maths.Vysledek);

            BasicMaths mathz = new BasicMaths(1);
            Console.WriteLine(mathz.Vysledek);

            BasicMaths math = new BasicMaths(1, 2);
            Console.WriteLine(math.Vysledek);

            Console.ReadKey();
        }
    }
}
