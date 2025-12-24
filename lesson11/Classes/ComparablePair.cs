using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson11.Classes
{
    internal class ComparablePair<T, U> : Pair<T, U>, IComparable<ComparablePair<T, U>> 
        where T : IComparable<T> 
        where U : IComparable<U>
    {
        public ComparablePair(T first, U second) : base(first, second) { }

        public int CompareTo(ComparablePair<T, U> other) 
        {
            if (other == null)
            {
                return 1;
            }

            int firstCompare = First.CompareTo(other.First);

            if (firstCompare != 0)
            {
                return firstCompare;
            }
            return Second.CompareTo(other.Second);
        }
    }
}
