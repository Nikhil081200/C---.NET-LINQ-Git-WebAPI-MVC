using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Linq
{
    class ConsoleApp3
    {
        static void Main(string[] args)
        {
            int[] array1 = new int[] { 100, 20, 10, 50, 60, 30, 40, 70, 80, 90 };
            var query = from i in array1 select i;

            foreach (int i in query)
            {
                Console.WriteLine(i);
            }
        }
    }
}
