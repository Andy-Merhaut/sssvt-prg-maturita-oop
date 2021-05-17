using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaturitaOOP.Polymorphism
{
    public class Tvar
    {
        public int Vyska { get; set; }
        public int Sirka { get; set; }

        public virtual void VykresliSe()
        {
            Console.WriteLine("TVAR");
        }
    }
}
