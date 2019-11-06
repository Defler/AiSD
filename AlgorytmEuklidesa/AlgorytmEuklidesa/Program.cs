using System;

namespace AlgorytmEuklidesa
{
    class Program
    {
        static int Euklides(int a, int b)
        {
            int pom;
            if (a % b == 0)
                return b;
            else
            {
                while (a % b != 0)
                {
                    pom = a;
                    a = b;
                    b = pom % b;
                }
                return b;
            }

        }
        static void Main(string[] args)
        {
            int a, b;

            Console.WriteLine("Podaj liczbe a: ");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Podaj liczbe b: ");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("NWD tych liczb wynosi: " + Euklides(a, b));

            Console.ReadKey();
        }
    }
}
