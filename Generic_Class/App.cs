using System;

namespace Generic_Class 
{
    class App
    {

        public static void Main()
        {

            ComparablePair<int, bool> cp1 = new ComparablePair<int, bool>(4, false),
                                      cp2 = new ComparablePair<int, bool>(4, true);

            int res = cp1.CompareTo(cp2);

            Console.WriteLine("Result of comparison: {0}", res);

        }
    }
}