using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrzeszukiwanieWGlab
{
    class Node
    {
        public int wartosc;

        

        public Node(int wartosc)
        {
            this.wartosc = wartosc;
        }

        public override string ToString()
        {
            return this.wartosc.ToString();
        }
    }

    class Krawedz
    {
        public Node start;
        public Node koniec;
        public int waga;

        List<Node> Odwiedzone;

        public void PrzechodzenieDFS(Node Start)
        {
            this.Odwiedzone = new List<Node>();
            this.DFS(Start);
            //mozna wypisac kolejne node'y
        }

        List<Node> OdwiedzoneBFS;
        List<Node> KolejkaBFS;


        public void PrzejdzBFS(Node start)
        {
            this.OdwiedzoneBFS = new List<Node>();
            this.KolejkaBFS = new List<Node>() { start };

            for (int i = 0; i < this.KolejkaBFS.Count; i++)
            {
                this.BFS(this.KolejkaBFS[i]);
            }

            Console.WriteLine( string.Join(" ", this.OdwiedzoneBFS));
        }


        void BFS(Node n)
        {
            if (this.OdwiedzoneBFS.Contains(n))
                return;

            this.OdwiedzoneBFS.Add(n);
            var sasiedzi = this.ZnajdzSomsiadow(n);

            this.KolejkaBFS.AddRange(sasiedzi);
        }


        //void BFS(Node p)
        //{
        //    Node n = p;
        //    this.OdwiedzoneBFS = new List<Node>();
        //    this.Odwiedzone.Add(n);
        //    this.KolejkaBFS = new List<Node>();
        //    this.KolejkaBFS.Add(n);
        //    foreach(var l in this.ZnajdzSomsiadow(n))
        //    {
        //        this.KolejkaBFS.Add(l);
        //    }
        //    int k = 1;
        //    n = this.KolejkaBFS[k];
        //    while(this.KolejkaBFS[k] != null)
        //    {
        //        bool czyNalezy = false;
        //        foreach(var l in this.OdwiedzoneBFS)
        //        {
        //            if (l == n)
        //            {
        //                czyNalezy = true;
        //                break;
        //            }
        //        }
        //        if (czyNalezy == false)
        //        {
        //            this.OdwiedzoneBFS.Add(n);
        //            foreach (var j in this.ZnajdzSomsiadow(n))
        //            {
        //                this.KolejkaBFS.Add(j);
        //            }
        //        }
        //        k++;
        //        n = this.KolejkaBFS[k];
                
        //    }
            
        //}

        List<Node> ZnajdzSomsiadow(Node n)
        {
            List<Node> wynik = new List<Node>();
            foreach(var k in this.krawedzie)
            {
                if (k.start == n)
                    wynik.Add(k.koniec);
                else if (k.koniec == n)
                    wynik.Add(k.start);
            }
            return wynik;
        }

        void DFS(Node n)
        {
            if (this.Odwiedzone.Contains(n))
                return;
            else
                this.Odwiedzone.Add(n);

            var krawedzie = this.ZnajdzKrawedzie(n);
            foreach(var k in Odwiedzone){
                var drugi = k.ZnajdzDrugi(n);
                DFS(drugi);
            }
        }

        List<Krawedz> ZnajdzKrawedzie(Node n)
        {
            List<Krawedz> wynik = new List<Krawedz>();
            foreach(var k in this.Krawedzie)
            {
                if(k.start == n || k.koniec == n)
                {
                    wynik.Add(k);
                }
            }
            return wynik;
        }

        public Krawedz(Node s, Node k, int w=1)
        {
            this.start = s;
            this.koniec = k;
            this.waga = w;
        }

        public override string ToString()
        {
            return $"{this.start} - {this.koniec}({this.waga})";
        }

        public Node ZnajdzDrugi(Node m)
        {
            return this.start == m ? this.koniec : this.start;
        }
    }
    static class Program
    {
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
