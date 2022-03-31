using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace Linq
{
    class Class1
    {
        static void Main(string[] args)
        {
            int[] array1 = new int[] { 100, 20, 10, 50, 60, 30, 40, 70, 80, 90 };
            var query = from i in array1 select i;

            foreach(int i in query)
            {
                Console.WriteLine(i);
            }
        }
    }
}
