using System;

namespace CiagFibonacciego
{
    class Program
    {
        static int Fibo(int n)
        {
            int poprzednia = 1;
            int zapoprzednia = 1;
            int liczba = 0;
            int pom;
            if (n == 1)
                liczba = poprzednia;
            else if (n == 2)
                liczba = zapoprzednia;
            else
            {
                for (int i = 3; i <= n; i++)
                {
                    liczba = poprzednia + zapoprzednia;
                    pom = poprzednia;
                    poprzednia = liczba;
                    zapoprzednia = pom;
                }
            }
            return liczba;
        }
        static void Main(string[] args)
        {
            string wczytane;
            int n;
            Console.WriteLine("Podaj n: ");
            wczytane = Console.ReadLine();
            n = int.Parse(wczytane);
            Console.WriteLine("N-ta liczba Fibo: " + Fibo(n));

            Console.ReadKey();

        }
    }
}
