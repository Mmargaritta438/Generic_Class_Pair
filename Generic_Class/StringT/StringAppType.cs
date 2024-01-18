﻿using System;

namespace Generic_Class.StringT
{
    class StringAppType
    {

        public static void Main()
        {

            ReportCompare(new String<int>(1, 2),
                          new String<int>(1));
            ReportCompare(new String<string>("1", "2", "3"),
                          new String<string>("1"));
            ReportCompare(new String<double>(0.5, 1.7, 3.0),
                          new String<double>(1.0, 1.7, 3.0));
            ReportCompare(new String<bool>(true, false),
                          new String<bool>(false, true));
            
        }

        public static void ReportCompare<T>(String<T> s, String<T> t)
          where T : IComparable<T>
        {
            Console.WriteLine("Result of comparing {0} and {1}: {2}",
                              s, t, s.CompareTo(t));
        }
    }
}