using System;
using System.Collections.Generic;
using System.Text;
using MyLib1;

namespace ConsoleApp1
{

    class Lecture
    {
        static void Main(string[] args)
        {
            MyLib1.Class1 obj = new Class1();
            obj.method1(10, 20);
            Console.WriteLine("Area of circle:" + obj.method2(10));
            Console.WriteLine("Circumference of circle:" + obj.method3(10));
        }
    }
}
