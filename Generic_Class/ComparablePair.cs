using System;

namespace Generic_Class 
{
    public class ComparablePair<T, U> : PairST<T, U>, IComparable<ComparablePair<T, U>>
      where T : IComparable<T>
      where U : IComparable<U>
    {

        public ComparablePair(T first, U second) : base(first, second)
        {
        }

        public int CompareTo(ComparablePair<T, U> other)
        {
            int firstCompare = this.First.CompareTo(other.First);
            if (firstCompare != 0)
                return firstCompare;
            else
                return this.Second.CompareTo(other.Second);
        }
    }
}