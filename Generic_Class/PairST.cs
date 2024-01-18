using System;

namespace Generic_Class 
{
    public class PairST<S, T>
    {
        private S first;
        private T second;

        public PairST(S first, T second)
        {
            this.first = first; this.second = second;
        }

        public S First
        {
            get { return first; }
        }

        public T Second
        {
            get { return second; }
        }
    }
}