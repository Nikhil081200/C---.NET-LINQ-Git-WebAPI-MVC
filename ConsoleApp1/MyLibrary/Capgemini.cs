using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Employee
    {
        int eid;
        string ename;
        string dept;


        public void getempdet()
        {
            Console.Write("Enter employee detials(id,name,dept)");
            eid = Convert.ToInt32(Console.ReadLine());
            ename = Console.ReadLine();
            dept = Console.ReadLine();
        }

        public void printempdet()
        {
            Console.WriteLine("id = {0}, ename ={1},dept={2}", eid, ename, dept);
            Console.WriteLine("id=" + eid + "ename=" + ename + "dept=" + dept);
            Console.WriteLine($"EmpId={eid},Empname={ename},EmpDept={dept}");  //Strting Interpolition

        }
    }

    class Lecture
    {
        public void Main(string[] args)
        {
            Employee e1 = new Employee();
            e1.getempdet();
            e1.printempdet();

            Employee e2 = new Employee();
            e2.getempdet();
            e2.printempdet();
        }
    }
}
