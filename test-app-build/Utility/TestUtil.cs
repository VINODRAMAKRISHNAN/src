using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace test_app_build.Utility
{
    public class TestUtil
    {
        public int instanceData = 32; // Noncompliant df

        static readonly int x = 1;  // Noncompliant
        static readonly int y = x + 4; // Noncompliant
        static readonly string s = "Bar";  // Noncompliant vvSDSER

        const int x1 = 1;
        const int y1 = x1 + 4;
        const string s1 = "Bar";

        public int Calcualte(int a, int b)
        {
            int k = 1;
            k = 1;
            k = 1;
          

            GC.Collect(2, GCCollectionMode.Optimized); // Noncompliant rr f
            Console.WriteLine("so far, so good..."); // Noncompliant  dsfsd
            GC.Collect(2, GCCollectionMode.Optimized); // Noncompliant rr f
            return a + b + 10;
        }
    }
}