namespace MaturitaOOP.Constructors
{
    public class BasicMaths
    {
        public int Vysledek { get; set; }

        public BasicMaths()
        {
            this.Vysledek = 0; 
        }

        public BasicMaths(int a)
        {
            this.Zdvojnasob(a);
        }

        public BasicMaths(int a, int b)
        {
            this.Secti(a, b);
        }

        private void Zdvojnasob(int a)
        {
            this.Vysledek = a * 2;
        }

        private void Secti(int a, int b)
        {
            this.Vysledek = a + b;
        }
    }
}
