using System;

namespace Stos
{
    class SD: IAiSD
    {
        int[] dane;
        public int Length => this.dane.Length;
        public int this[int index]
        {
            get { return this.dane[index]; }
            set { this.dane[index] = value; }
        }

        public SD()
        {
            this.dane = new int[0];
        }
        public void push(int a)
        {
            var nowa = this.Przepisz();
            nowa[nowa.Length - 1] = a;
            this.dane = nowa;
        }

        public void pop()
        {
            int[] nowa = new int[this.dane.Length - 1];
            for(int i = 0; i<nowa.Length; i++)
            {
                nowa[i] = this.dane[i];
            }
            this.dane = nowa;
        }

        int[] Przepisz()
        {
            int[] nowa = new int[this.dane.Length + 1];
            for (int i = 0; i < this.dane.Length; i++)
            {
                nowa[i] = this.dane[i];
            }
            return nowa;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
