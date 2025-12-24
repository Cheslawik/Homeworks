using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson11.Classes
{
    internal class Pair<S, T>
    {
        public S First { get; }
        public T Second { get; }

        public Pair(S first, T second)
        {
            First = first; 
            Second = second;
        }
    }
}
