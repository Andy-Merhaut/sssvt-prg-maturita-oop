using System;
using MaturitaOOP.Constructors;
using MaturitaOOP.Inheritance;

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

            Auto auto = new Auto();
            auto.Zatroubit();
            Console.WriteLine(auto.Jmeno);

            Motorka motorka = new Motorka();
            Console.WriteLine(motorka.Jmeno);
            Console.WriteLine(motorka.Vykon);
            motorka.Zatroubit();

            Console.ReadKey();
        }
    }
}
