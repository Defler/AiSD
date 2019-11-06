using System;
using System.Collections.Generic;
using System.Text;

namespace Kolejka
{
    interface IAiSD
    {
        int Length { get; }
        void Push(int a);
        void Pop();
    }
}
