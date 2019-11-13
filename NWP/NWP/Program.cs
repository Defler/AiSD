using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NWP
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] tabWiersze = { 'a', 'b', 'a', 'a', 'b', 'b', 'a', 'a', 'a' };
            char[] tabKolumny = { 'b', 'a', 'b', 'a', 'b' };
            int[,] tablica = new int[tabKolumny.Length + 1, tabWiersze.Length + 1];

            for(int i = 0; i<tabKolumny.Length+1; i++)
            {
                tablica[i, 0] = 0;
            }
            for(int i = 0; i<tabWiersze.Length+1; i++)
            {
                tablica[0, i] = 0;
            }

            for(int i = 1; i<tabKolumny.Length+1; i++)
            {
                for(int j = 1; j<tabWiersze.Length+1; j++)
                {
                    if (tabKolumny[i - 1] == tabWiersze[j - 1])
                        tablica[i, j] = tablica[i - 1, j - 1] + 1;
                    else
                    {
                        if (tablica[i - 1, j] > tablica[i, j - 1])
                            tablica[i, j] = tablica[i - 1, j];
                        else
                            tablica[i, j] = tablica[i, j - 1];
                    }
                }
            }

            int n = tabKolumny.Length;
            int m = tabWiersze.Length;
            while(tablica[n, m] != 0)
            {
                if (tablica[n, m-1] == tablica[n, m])
                    m--;
                else if (tablica[n -1 , m] == tablica[n, m])
                    n--;
                else
                {
                    Console.Write(tabKolumny[n - 2] + " ");
                    n--;
                    m--;
                }
                
            }
            Console.WriteLine();
            for(int i = 0; i<tabKolumny.Length+1; i++)
            {
                for(int j = 0; j<tabWiersze.Length+1; j++)
                {
                    Console.Write(tablica[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
