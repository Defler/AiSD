using System;

namespace SortowanieScalanie
{

    class Program
    {
        static double[] L_pom;

        static void Scalanie(double[] L, int poczatek, int sr, int koniec)
        {
            for (int p = poczatek; p <= koniec; p++)
                L_pom[p] = L[p];
            int i = poczatek, j = sr + 1;
            for (int k = poczatek; k <= koniec; k++)
            {
                if (i <= sr)
                {
                    if (j <= koniec)
                    {
                        L[k] = (L_pom[j] < L_pom[i]) ? L_pom[j++] : L_pom[i++];
                    }
                    else
                    {
                        L[k] = L_pom[i++];
                    }
                }
                else
                {
                    L[k] = L_pom[j++];
                }
            }
        }

        static void sortuj(double[] L, int poczatek, int koniec)
        {
            if (koniec <= poczatek)
                return;
            int sr = (koniec + poczatek) / 2;
            sortuj(L, poczatek, sr);
            sortuj(L, sr + 1, koniec);
            Scalanie(L, poczatek, sr, koniec);
        }
        static void Main(string[] args)
        {

            double[] tab = { 12, 6, 4, 7, 2, 19 };
            int n = tab.Length;
            L_pom = new double[n];

            for(int i = 0; i<n; i++)
            {
                Console.Write("{0} ", tab[i]);
            }

            sortuj(tab, 0, n - 1);
            Console.WriteLine("\nPo posortowaniu:");
            for (int i = 0; i < n; i++)
                Console.Write("{0} ", tab[i]);
            Console.ReadKey();
        }
    }
}
