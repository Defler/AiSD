using System;
using System.Collections.Generic;
using System.Text;

namespace Kolejka
{
    class SD : IAiSD
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

        public void Pop()
        {
            int[] nowa = new int[this.dane.Length - 1];
            for(int i = 1; i<this.dane.Length; i++)
            {
                nowa[i - 1] = this.dane[i];
            }
            this.dane = nowa;
        }

        public void Push(int a)
        {
            var nowa = this.Przepisz();
            nowa[nowa.Length - 1] = a;
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
}
