using System;

namespace SortowanieBabelkowe
{
    class Program
    {
        static void Sortowanko(int[] nowa)
        {
            bool zamiana = false;
            int pom;

            do
            {
                zamiana = false;
                for (int i = 0; i < nowa.Length - 1; i++)
                {
                    if (nowa[i] > nowa[i + 1])
                    {
                        pom = nowa[i];
                        nowa[i] = nowa[i + 1];
                        nowa[i + 1] = pom;
                        zamiana = true;
                    }
                }
            } while (zamiana == true);
        }
        static void Main(string[] args)
        {
            int[] tablica = { 2, 5, 3, 14, 6, 12 };

            Console.WriteLine("Przed sortowaniem: ");
            for(int i =0; i<tablica.Length; i++)
            {
                Console.Write(tablica[i] + " ");
            }

            Sortowanko(tablica);
            Console.WriteLine();
            Console.WriteLine("Po sortowaniu: ");
            for(int i = 0; i<tablica.Length; i++)
            {
                Console.Write(tablica[i] + " ");
            }

            Console.ReadKey();
        }
    }
}
