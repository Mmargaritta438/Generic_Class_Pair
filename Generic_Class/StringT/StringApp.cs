using Generic_Class.StringT;
using System;

namespace Generic_Class.StringT
{
    class StringApp
    {

        public static void Main()
        {

            ReportCompare(new String<int>(), new String<int>(1));
            ReportCompare(new String<int>(1), new String<int>(1));
            ReportCompare(new String<int>(1, 2, 3), new String<int>(1));
            ReportCompare(new String<bool>(false),
                          new String<bool>(false, true, false));
            ReportCompare(new String<bool>(true, true, false),
                          new String<bool>(true, true, false));
        }

        public static void ReportCompare<T>(String<T> s, String<T> t)
          where T : IComparable<T>
        {
            Console.WriteLine("Result of comparing {0} and {1}: {2}",
                              s, t, s.CompareTo(t));
        }
    }
}