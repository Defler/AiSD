using System;
using System.Collections.Generic;
using System.Text;

namespace Stos
{
    interface IAiSD
    {
        void push(int a);
        void pop();
        int Length { get; }

    }
}
