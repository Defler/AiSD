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
