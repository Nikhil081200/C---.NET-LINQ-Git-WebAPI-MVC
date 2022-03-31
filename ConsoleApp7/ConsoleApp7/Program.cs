using System;
using System.Text;


//namespace ConsoleApp7
//{
//    enum product { printer = 347, projector, desktopPC = 765, laptop }

//    struct accdet
//    {
//        public int acno;
//        public string achname;
//        public double depamt;

//        public void print()
//        {
//            Console.WriteLine(acno + "," + achname + "," + depamt);
//        }
//    }

//    struct product1
//    {
//        public int pcoden;
//        public string pname;
//        public double unitprice;
//    }



//    class Program
//    {
//        static void Main(string[] args)
//        {

//Control statements:
//2 types of Control statements

//1.Conditional
//if-else,nested - elseif,switch-case

//2.Iterational(loops)
//while,do -while,for,for-each


//How to print output:-

//Console.WriteLine("Enter your name:-");
//string name = Console.ReadLine();

//How to take input:-

//Console.WriteLine("Enter your age:");
//int age = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Is employee or not");
//bool isemployee = Convert.ToBoolean(Console.ReadLine());
//Console.WriteLine();

//Console.WriteLine("You entered these values: " + name + ", Age = " + age + "");
//Console.WriteLine("You entered these values: Name = {0}, Age = {1}", name, age);
//Console.WriteLine($"You entered these values: Name = {name}, Age = {age}");

//Console.WriteLine("Please enter first number");
//int num1 = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Please enter second number");
//int num2 = Convert.ToInt32(Console.ReadLine());

//if-else:-

//if (num1 > 0 && num2 > 0)
//{
//    Console.WriteLine($"Add result = { num1 + num2}");
//}
//else
//{
//    Console.WriteLine("Either num1 or num2 is less than 0");
//}


//==============================================================

//for-loop

//for (int i = 0; i < 10; i++)
//{
//    Console.WriteLine("Value of I: "+i);
//}
//=============================================================

//while -loop

//int i = 10;
//while (i < 15)
//{
//    Console.WriteLine(i);
//    i++;
//}


//// //=============================================================
//do-while loop:-

//int i = 10;
//do
//{
//    Console.WriteLine(i);
//    i++;
//} while (i < 15);


//// =============================================================


//break and continue statement:-

//for (int i = 0; i < 20; i++)
//{
//    if (i == 8)
//    {
//        //break;
//        continue;
//    }
//    Console.WriteLine(i);
//}

//Arrays:It is a collection of homogenous elements/ group of elements of same-kind.


//            int[] array1 = new int[5] { 10, 20, 30, 40, 50 };

//            int[] array2 = new int[10];

////how to print elements one by one
//            for (int i = 0; i < array1.Length; i++)   // 0-4
//            {
//                Console.WriteLine("array [" + i + "] = " + array1[i]);
//            }

//            Console.WriteLine("============================");

//            for (int i = 0; i < array1.Length; i++)   // 0-4
//            {
//                Console.Write(i);
//            }
//            Console.WriteLine("\n");

////how to enter elements in array using for loop:-

//            Console.WriteLine("Enter the array elements");
//            for (int i = 0; i < array2.Length; i++)
//            {
//                array2[i] = int.Parse(Console.ReadLine());
//            }

//            for (int i = 0; i < array2.Length; i++)
//            {
//                Console.Write("array [" + i + "] = " + array2[i]);
//            }

//=========================================================================
//int[] array1 = new int[5];

//int[] array2 = new int[5];
//int[] array3 = new int[5];

//Console.WriteLine("Enter the array elements for array1");
//for (int i = 0; i < array1.Length; i++)
//{
//    array1[i] = int.Parse(Console.ReadLine());
//}

//Console.WriteLine("Enter the array elements for array2");
//for (int i = 0; i < array2.Length; i++)
//{
//    array2[i] = int.Parse(Console.ReadLine());
//}

//Console.WriteLine("Sum of array elements");
//for (int i = 0; i < array1.Length; i++)
//{
//    array3[i] = array1[i] + array2[i];
//    Console.WriteLine("array3 [" + i + "] = " + array3[i]);
//}

//=========================================================================
//Creating objects:-collection of heterogenous elements

//object[] product = new object[] { 1, "LCD", 4.45, 2, "LED", 6.67 };                 //product is our new created object

//for (int i = 0; i < product.Length; i += 2)
//{
//    Console.WriteLine(product[i]);
//}
//Console.WriteLine("------------------------------------");

//foreach (object i in product)
//{
//    Console.WriteLine(i);
//}

//=========================================================================


//Two - dimensional Array:

//int[,] array1 = new int[2, 2];

//          j = 0      j = 1     j = 2

// i = 0    10[00]   20[01]   100[02]


// i = 1    30[10]   40[11]   200[12]


// i = 2    50[20]   60[21]   90[22]

//int[,] array1 = new int[2, 2] { { 10, 20 }, { 30, 40 } };

//for (int i = 0; i < 2; i++)
//{
//    for (int j = 0; j < 2; j++)
//    {
//        Console.WriteLine(array1[i, j] + "\t");
//    }
//    Console.WriteLine("\n");
//}
//=========================================================================


//matrix input:-

//int[,] array1 = new int[2, 2];

//Console.WriteLine("enter the array elements");

//for (int i = 0; i < 2; i++)  //i=1  2 times
//{
//    for (int j = 0; j < 2; j++) //4 times
//    {
//        array1[i, j] = int.Parse(Console.ReadLine());
//    }
//}

//for (int i = 0; i < 2; i++)  //i=1  2 times
//{
//    for (int j = 0; j < 2; j++) //4 times
//    {
//        Console.Write("[" + i + "," + j + "]=" + array1[i, j] + "\t");
//    }
//    Console.WriteLine("\n");
//}

//=========================================================================
//Jagged Array: collection of array's

//int[][] Jarray = new int[4][];

//Jarray[0] = new int[] { 10, 20, 30, 40 };
//Jarray[1] = new int[] { 10, 20 };
//Jarray[2] = new int[] { 100, 200, 300, 400, 500, 600 };
//Jarray[3] = new int[] { 100, 200, 300 };

//for (int i = 0; i < Jarray.Length; i++)
//{
//    for (int j = 0; j < Jarray[i].Length; j++)
//    {
//        Console.Write(Jarray[i][j] + "\t");
//    }
//    Console.WriteLine("\n");
//}

//=========================================================================


//object arrays:-  it can store any type of input, maybe int or string or double or any datatype
//object[][] course = new object[3][];

//course[0] = new object[] { 1, 2, 3, 4 };
//course[1] = new object[] { "C#.NET", "SQL", "JAVA", "PHP" };
//course[2] = new object[] { "1 month", "15 days", "1 month", "1.5 month" };

//for (int i = 0; i < course.Length; i++)
//{
//    for (int j = 0; j < course[i].Length; j++)
//    {
//        Console.Write(course[i][j] + "\t");
//    }
//    Console.WriteLine("\n");
//}

//=========================================================================

//Parse and tryParse:-

//Tryparse:

//int result;

//Console.WriteLine("input a number");
//bool b = int.TryParse(Console.ReadLine(), out result);

//Console.WriteLine(b + "," + result);

//=========================================================================

//Parse:

//char ch;
//Console.WriteLine("input a char");
//ch = char.Parse(Console.ReadLine());

//if (ch >= '0' && ch <= '9')
//    Console.WriteLine("It is a number");
//else if (ch >= 'a' && ch <= 'z')
//    Console.WriteLine("It is a alpha");
//else
//    Console.WriteLine("It is a special");

//=========================================================================

//Convert.ToInt32:-

//bool var1 = true; //0
//int res;
//res = Convert.ToInt32(var1);

//Console.WriteLine(res);


//// res1 =int.Parse(var1);

//=========================================================================

//String in C#:- strings in c# is immutable(we cannot modify the string)

//string str = "welcome to c# programming";
//string str1 = "welcome to c# programming";

////function returning int value
//Console.WriteLine(str.Length);
//Console.WriteLine(str.IndexOf('m'));
//Console.WriteLine(str.LastIndexOf('m'));

////function returning bool values
//Console.WriteLine(str.StartsWith('w'));
//Console.WriteLine(str.EndsWith('g'));
//Console.WriteLine(str.Contains('z'));
//Console.WriteLine(str.Equals(str1));

//Console.WriteLine(string.Compare(str, str1)); //0,1,-1

//=========================================================================

//Copy:-

//string str1 = "welcome ";
//string str2 = "to c# programming";

//Console.WriteLine(string.Concat(str1, str2));

//string str3 = string.Copy(str1); //copy
//Console.WriteLine(str3);

//string str4 = (string)str1.Clone(); //reference
//Console.WriteLine(str4);

//=========================================================================

//char array:-

//string str = "welcome to c# programming";

//CharEnumerator ch = str.GetEnumerator();
//while (ch.MoveNext())
//{
//    Console.WriteLine(ch.Current);
//}


//char[] charray = str.ToCharArray();
//foreach (char i in charray)
//{
//    Console.WriteLine(i);
//}

//=========================================================================

//split:-

//string str = "welcome to c# programming";

//string[] strarray = str.Split(' ');
//foreach (string i in strarray)
//{
//    Console.WriteLine(i);
//}

//string[] strarray1 = { "welcome", "to", "VB.NET", "PROGRAMMING" };
//string newstring = string.Join("-", strarray1);
//Console.WriteLine(newstring);

////copyto
//char[] charray = new char[35];
//// str.CopyTo(0, charray, 0, str.Length);
//str.CopyTo(11, charray, 0, 14);
//Console.WriteLine(charray);

//=========================================================================

//string methods:-

//string str = "welcome to c# programming";

//Console.WriteLine(str.Remove(7));

//Console.WriteLine(str.Substring(7));

//Console.WriteLine(str.Replace('c', 'j'));

//Console.WriteLine(str.Replace("c#", "VB.NET"));

//Console.WriteLine(str.Insert(13, ".NET "));

//=========================================================================

//== and equals


//==
//->It is operator.
//->returns bool value.
//->compare the reference

//equals
//->it is method
//->returns bool value.
//->compare the content / value.

//string str = "welcome";
//string str1 = "welcome";

//Console.WriteLine(str.Equals(str1));
//Console.WriteLine(str == str1);

//object str2 = "welcome";
//char[] charray = { 'w', 'e', 'l', 'c', 'o', 'm', 'e' };
//object str3 = new string(charray);

//Console.WriteLine(str2.Equals(str3));
//Console.WriteLine(str2 == str3);

//=========================================================================

//stringbuilder:stringbuilder in c# is mutable.
//using System.Text;

//StringBuilder str = new StringBuilder("hello");

//Console.WriteLine(str);

//=========================================================================

// enum :- set of named integer constants

//Console.WriteLine((int)product.printer);
//Console.WriteLine(Convert.ToInt32(product.laptop));

//=======================================================

// Structure:-group of business-entities/data-member of different datatypes

//accdet firstdet;

//firstdet.acno = 1;
//firstdet.achname = "jay";
//firstdet.depamt = 35000;

//Console.WriteLine(firstdet.acno + "," + firstdet.achname + "," + firstdet.depamt);

//------------------------------------------------

// WAP to store product Details using struct.
//            1.pcode,pname,unitprice
//2.store and display the product details for 3 products.

//product1 firstpro;

//firstpro.pcoden = 12;
//firstpro.pname = "Oliveoil";
//firstpro.unitprice = 510;

//Console.WriteLine(firstpro.pcoden + "," + firstpro.pname + "," + firstpro.unitprice);

//product1 secondpro;

//secondpro.pcoden = 18;
//secondpro.pname = "Shampoo";
//secondpro.unitprice = 708;

//Console.WriteLine(secondpro.pcoden + "," + secondpro.pname + "," + secondpro.unitprice);

//product1 thirdpro;
//thirdpro.pcoden = 64;
//thirdpro.pname = "Books";
//thirdpro.unitprice = 4852;

//Console.WriteLine(thirdpro.pcoden + "," + thirdpro.pname + "," + thirdpro.unitprice);


//=======================================================

//nullable (?):-

//int empid = null;

//Nullable<int> empid = 12;
//Console.WriteLine(empid);

//Nullable<double> proprice = null;
//Console.WriteLine(proprice);

//int? custage = null;
//Console.WriteLine(custage.GetValueOrDefault());

//Console.WriteLine(custage.HasValue);

//=======================================================

//value and reference type:

//value type:
//--> uses stack memory
//--> holds the data within its own memory.

//predefined datatypes(int, char, double, decimal, float),enum,struct

//    reference types:
//-->uses heap memory
//-->contains a pointer to another memory location,that holds the data.

//string, stringbuilder,class,object,array,interface,property,indexer.

//string-->string in c# are "ref" type.they behave like value type.

//string str = "hello";

//=============================================================================

//Boxing and Unboxing:


//boxing: -method of converting value type to ref type.
// int x = 100;
//object y = x;  //boxing

//Unboxing: method of converting ref type to value type.

//int result = (int)y; //unboxing


//int x = 100;

//object y = x;  //boxing,implicit conversion

//Console.WriteLine(y);

//int result = (int)y; //unboxing,explicit conversion

//Console.WriteLine(result);

//=============================================================================

//WAP to input 10 array elements for integer array and
//1.display index of every element with value.
//2.display the sum of all array elements.

//int[] array1 = new int[10];

//Console.WriteLine("Enter the array elements:-");

//for (int i = 0; i < array1.Length; i++)
//{
//    array1[i] = int.Parse(Console.ReadLine());
//}

//int sum = 0;
//foreach (int j in array1)
//{
//    sum += j;
//}
//Console.WriteLine(sum);
//        }
//    }

//}
//=============================================================================


//OOPS: 

//1.Class and Object
//2.constructor and destructor
//3.Inheritance(single, multi-level, multiple, heirarchial, hybrid)
//base class,derived class
//static const, instance const
// 4.Interface 
//5.Polymorphism[compile - time, runtime]

//static:
//static variable and non-static variable
//static method and non-static method
//static const, instance const
//static class

//1.Class and Object:

//Class->
//It acts like template.
//collection of business entities and methods/functions.

//access specifier->private,protected,public

//internal,protected internal

namespace ConsoleApp7
{
    /*
    class Employee
    {
        int eid;
        string ename;
        string dept;

        public void getempdet()
        {
            Console.Write("Enter employee detials(id,name,dept)\n");
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

    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee();
            e1.getempdet();
            e1.printempdet();

            Employee e2 = new Employee();
            e2.getempdet();
            e2.printempdet();
        }
    }

    //================================================================
    

    class Sample
    {
        int no1, no2;

        public void getnumbers(int no1, int no2)
        {
            this.no1 = no1;
            this.no2 = no2;
        }

        public int addnumbers()
        {
            return (this.no1 + this.no2);
        }

        public int subnumbers()
        {
            return (this.no1 - this.no2);
        }

        public int checkgreater()
        {
            if (no1 > no2)
                return no1;
            else
                return no2;

            // return no1 > no2 ? no1 : no2;

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
              Sample obj = new Sample();
              obj.getnumbers(10, 20);
              Console.WriteLine(obj.addnumbers());
              Console.WriteLine(obj.subnumbers());
              Console.WriteLine("Greater no. is:- " + obj.checkgreater());
        }
    }

    
    //================================================================
    

    class amount
    {
        int accno;
        string acchname;
        string DepAmt;

        public void getempdet(int accno,string acchname,string DepAmt)
        {
            this.accno = accno;
            this.acchname = acchname;
            this.DepAmt = DepAmt;
        }
        public void printempdet()
        {
            Console.WriteLine("accno={0},acchname={1},DepAmt={2}", this.accno, this.acchname, this.DepAmt);
        }

    }
    class program
    {
        static void Main(string[] args)
        {
            int a;
            string b,c;

            Console.WriteLine("Enter the accno.,acchname.,DepAmt:-");
            a = Convert.ToInt32(Console.ReadLine());
            b = Console.ReadLine();
            c = Console.ReadLine();

            amount e1 = new amount();
            e1.getempdet(a,b,c);
            e1.printempdet();
        }
    }
    
    //================================================================
    
    //constructor and Destructor:

    //constructor :
    //->It is special member of class,which intialises the data-members.
    //->constructor name is same as class name.
    //->constructor should be public.
    //->constructor can parameterised.

    //3 types
    //1.Default
    //2.Parameterised
    //3.copy

    class Book
    {
        int bid;
        string bname;
        double price;

        public Book()                                      //default constructor
        {
            bid = 1;
            bname = "C#_PRO";
            price = 5600;
        } 

        public Book(int bid, string bname, double price)  //parameterised constructor
        {
            this.bid = bid;
            this.bname = bname;
            this.price = price;
        }

        public Book(Book obj)                             //copy constructor
        {
            this.bid = obj.bid;
            this.bname = obj.bname;
            this.price = obj.price;
        }

        public void show()
        {
            Console.WriteLine($"bookid={bid},BookName={bname},Price={price}");
        }
        ~Book()       // Destructor: Memory deallocation occurs but can't be seen
        {

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Book obj1 = new Book();
            obj1.show();

            Book obj2 = new Book(2, "SQL", 3400);
            obj2.show();

            Book obj3 = new Book(obj1);
            obj3.show();
        }
    }
   
    
//Destructor:
//->It is member of class.
//->Destructor deallocates the memory space used by objects.
//->Destructor  name is same class name.preceded by ~ operator


    //================================================================
    

    class pdetails
    {
        string pname;
        int unitprice;
        int noofitems;

        public pdetails()
        {
            string pname = "Chocolates";
            int unitprice = 5;
            int noofitems = 10;
        }

        public pdetails(string pname,int unitprice, int noofitems)
        {
            this.pname = pname;
            this.unitprice = unitprice;
            this.noofitems = noofitems;
        }

        public pdetails(pdetails obj)
        {
            this.pname = pname;
            this.unitprice = unitprice;
            this.noofitems = noofitems;
        }

        public void totalprice()
        {
            Console.WriteLine("Totalprice of your goods is:-" + unitprice * noofitems);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            pdetails p1 = new pdetails();
            p1.totalprice();

            pdetails p2 = new pdetails("Icecream", 10, 50);
            p2.totalprice();

            pdetails p3 = new pdetails(p1);
            p3.totalprice();
        }
    }
    
    //================================================================
    

    //    Inheritance:
    //->It is method of deriving features of an old class(base) into a new class(derived).
    //->code-reusability.

    //Single Inheritance.

    class Data
    {
        protected int coord1, coord2;

        public void getdata()
        {
            Console.WriteLine("enter 2 co-ordinates");
            coord1 = Convert.ToInt32(Console.ReadLine());
            coord2 = Convert.ToInt32(Console.ReadLine());
        }
    }

    class Data1 : Data
    {
        public void compute()
        {
            double res = Math.Sqrt(coord1 * coord2);
            Console.WriteLine("Result=" + res);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Data1 obj = new Data1();
            obj.getdata();
            obj.compute();
        }
    }

     //================================================================

    class Student
    {

        protected string Regno, name;
        protected int m1, m2, m3, m4;

        public void getmarks()
        {
            Console.WriteLine("Enter student Regno. and Name:-");
            Regno = Console.ReadLine();
            name = Console.ReadLine();
            Console.WriteLine("Enter your four subjects marks:- ");
            m1 = Convert.ToInt32(Console.ReadLine());
            m2 = Convert.ToInt32(Console.ReadLine());
            m3 = Convert.ToInt32(Console.ReadLine());
            m4 = Convert.ToInt32(Console.ReadLine());
        }
    }
    class Result : Student
    {
        public void output()
        {
            double Total = m1 + m2 + m3 + m4;
            double Avg = Total / 4;

            Console.WriteLine($" Students Registration No.:{Regno}\n Student Name:{name}\n Students Total Marks:{Total}\n Students Average:{Avg}");

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Result obj = new Result();
            obj.getmarks();
            obj.output();
        }
    }

    //================================================================
    

    //Multi-level Inheritance:-

    class employee
    {
        protected int empid;
        protected string empname;

        public void getdata()
        {
            Console.WriteLine("enter employee Details:id,name");
            empid = Convert.ToInt32(Console.ReadLine());
            empname = Console.ReadLine();
        }
    }

    class Dept : employee
    {
        protected string deptname;
        protected string deptloc;

        public void getdeptdata()
        {
            Console.WriteLine("enter Dept Details:name,loc");
            deptname = (Console.ReadLine());
            deptloc = Console.ReadLine();
        }
    }

    class Final : Dept
    {
        public void display()
        {
            Console.WriteLine("EmpId=" + empid + "," + "Empname=" + empname);
            Console.WriteLine("Deptname=" + deptname + "," + "DeptLoc=" + deptloc);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Final obj = new Final();
            obj.getdata();
            obj.getdeptdata();
            obj.display();
        }
    }
    
    //================================================================
    
    class Student
    {
        protected string Regno, name;

        public void getinfo()
        {
            Console.WriteLine("Enter the students Registration NO. and Name:-");
            Regno = Console.ReadLine();
            name = Console.ReadLine();
        }
    }
    class Course : Student
    {
        protected string cname, cduration;
        protected double cfee;

        public void getcoinfo()
        {
            Console.WriteLine("Enter Course Detials[ Course_Name, Course_Duration, Course_Fee]");
            cname = Console.ReadLine();
            cduration = Console.ReadLine();
            cfee = Convert.ToInt32(Console.ReadLine());
        }
    }
    class Final : Course
    {
        public void display()
        {
            Console.WriteLine($" Students Registration No.:-{Regno}\n Students Name:-{name}\n Students Course Name:-{cname}\n" +
                $" Course Duration:-{cduration}\n Course Fees:-{cfee}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Final obj = new Final();
            obj.getinfo();
            obj.getcoinfo();
            obj.display();
        }
    }
    
    //================================================================
    

    //Heirarchial Inheritance:-

    class data
    {
        protected int a, b;
        public void getdata()
        {
            Console.WriteLine("enter 2 nos");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
        }
    }
    class Demo1 : data
    {
        public void add()
        {
            Console.WriteLine("Sum of  2nos=" + (a + b));
        }
    }
    class Demo2 : data
    {
        public void sub()
        {
            Console.WriteLine("Diff of  2nos=" + (a - b));
        }
    }
    class Demo3 : data
    {
        public void Pro()
        {
            Console.WriteLine("Product of  2nos=" + (a * b));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Demo1 obj1 = new Demo1();
            obj1.getdata();
            obj1.add();

            Demo2 obj2 = new Demo2();
            obj2.getdata();
            obj2.sub();

            Demo3 obj3 = new Demo3();
            obj3.getdata();
            obj3.Pro();
        }
    }
    
    //================================================================
    

    class Company
    {
        protected string comp_name, comp_id;

        public void getdata()
        {
            Console.WriteLine("Enter details[ Company_Name and Company_Id]:-");
            comp_name = Console.ReadLine();
            comp_id = Console.ReadLine();
        }
    }
    class branch1 : Company
    {
        protected int noofemp;
        protected string location;

        public void brdetails()
        {
            Console.WriteLine("Enter details[ No_of_Employees and Location]:-");
            noofemp = Convert.ToInt32(Console.ReadLine());
            location = Console.ReadLine();
        }
    }
    class branch2 : Company
    {
        protected int noofemp;
        protected string location;

        public void brdetails()
        {
            Console.WriteLine("Enter details[ No_of_Employees and Location]:-");
            noofemp = Convert.ToInt32(Console.ReadLine());
            location = Console.ReadLine();
        }
    }
    class branch3 : Company
    {
        protected int noofemp;
        protected string location;
        public void brdetails()
        {
            Console.WriteLine("Enter details[ No_of_Employees and Location]:-");
            noofemp = Convert.ToInt32(Console.ReadLine());
            location = Console.ReadLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            branch1 obj1 = new branch1();
            obj1.getdata();
            obj1.brdetails();

            branch2 obj2 = new branch2();
            obj2.brdetails();

            branch3 obj3 = new branch3();
            obj3.brdetails();
        }
    }
    
    //================================================================
    
    //constructors in derived class:
    //constructor inheritance:-

    class category : Object
    {
        protected string cname, cdesc;
        public category(string cname, string cdesc)
        {
            this.cname = cname;
            this.cdesc = cdesc;
        }
    }
    class Product : category
    {
        string pname;
        double price;
        public Product(string cname, string cdesc, string pname, double price) : base(cname, cdesc)
        {
            this.pname = pname;
            this.price = price;
        }
        public void displaydet()
        {
            Console.WriteLine("category_name:" + cname + "," + "Cdesc=" + cdesc);
            Console.WriteLine("Product_name:" + pname + "," + "Price=" + price);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Product p1 = new Product("stationary", "All engg and Medical books", "C#_PRO", 6800);
            p1.displaydet();
        }
    }

    
    //================================================================
    

    // 2 types:
    //    concrete methods->method with definition
    //abstract methods->method without definition

    //Interface:
    //->collection of abstract methods.
    //->variable are not allowed to declare.
    //->methods of interface are public by default.
    //->All methods of interface should be implemented in class.

    interface InterfaceOne
    {
        void display();
        void print(string str);
    }

    class Demo : InterfaceOne
    {
        public void display()
        {
            Console.WriteLine("this is interface method");
        }

        public void print(string str)
        {
            Console.WriteLine(string.Concat("hello=", str));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //InterfaceOne obj = new InterfaceOne();
            Demo obj = new Demo();
            obj.display();
            obj.print("WORLD");
        }
    }
    
    //================================================================
    

    interface InterfaceOne
    {
        void method1(int a, int b);
        double method2(int a);
        void method3(string a, string b, string c);
    }
    class Demo : InterfaceOne
    {
        public void method1(int a, int b)
        {
            Console.WriteLine("Product=" + (a * b));
        }
        public double method2(int a)
        {
            return (Math.Sqrt(a * a));
        }
        public void method3(string a, string b, string c)
        {
            Console.WriteLine(string.Concat(a, b, c));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //InterfaceOne obj = new InterfaceOne();
            Demo obj = new Demo();
            obj.method1(10, 30);
            Console.WriteLine("Result=" + obj.method2(25));
            obj.method3("C#", "_PROGRAMMING", " IS INTRESTING");
        }
    }
    
    //================================================================
    
    interface InterfacOne
    {
        void method1(int a, int b);
        void method2(double a);
        void method3(string s1, string s2, string s3);
    }

    class Demo : InterfacOne
    {
        public void method1(int a, int b)
        {
            Console.WriteLine($"{a}, {b}");
        }

        public void method2(double a)
        {
            Console.WriteLine($"{a}");
        }

        public void method3(string s1, string s2, string s3)
        {
            Console.WriteLine(string.Concat(s1, s2, s3));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Demo obj = new Demo();
            obj.method1(10, 20);
            obj.method2(24050);
            obj.method3("Nikhil", " is in ", "Capgemini");
        }
    }

    //=============================================================================
    

    interface Myinterface
    {
        int area1(int a, int b);
        double area2(int b, int h);
    }

    class Demo : Myinterface
    {
        public int area1(int a, int b)
        {
            return (a * b);
        }

        public double area2(int b, int h)
        {
            return (b * h) * 1 / 2;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Demo obj = new Demo();
            Console.WriteLine("Area of rectangle:- " + obj.area1(10, 20));
            Console.WriteLine("Area of Triangle:- " + obj.area2(10, 20));
        }
    }
    
    //=============================================================================
    

    interface interfaceone
    {
        void display();
    }

    interface interfacetwo
    {
        void display();
    }

    class Demo : interfaceone, interfacetwo
    {
        void interfaceone.display()
        {
            Console.WriteLine("Method from interface_one");
        }

        void interfacetwo.display()
        {
            Console.WriteLine("Method from interface_two");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Demo obj = new Demo();
            ((interfaceone)obj).display();
            ((interfacetwo)obj).display();
        }
    }
    
    //=============================================================================
    

    //static:

    //    static method and non-static method.
    //static variable and non-static variable.
    //static constructor and non-static constructor.(base and derived)
    //static class

    class Demo
    {
        public void print()
        {
            Console.WriteLine("It is non-static method");
        }

        public static void display()
        {
            Console.WriteLine("It is static method");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Demo obj1 = new Demo();
            obj1.print();

            Demo obj2 = new Demo();
            obj2.print();

            Demo.display();
        }
    }
    
    //=============================================================================
    

    //static variable and non-static variable
    //static constructor and non-static constructor:-

    class Demo
    {
        int radius;
        static double pi;

        public Demo(int radius)
        {
            this.radius = radius;
        }

        static Demo()
        {
            Demo.pi = Math.PI;
        }

        public void print()
        {
            Console.WriteLine("Area of circle=" + pi * radius * radius);
            Console.WriteLine(pi);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Demo obj1 = new Demo(10);
            obj1.print();

            Demo obj2 = new Demo(20);
            obj2.print();

            // Console.WriteLine(Demo.pi);
        }
    }
    
    //=============================================================================
    

    class Demo
    {
        int radius;

        static double pi;

        public Demo(int radius)
        {
            this.radius = radius;
        }

        static Demo()
        {
            Demo.pi = Math.PI;
        }

        public void print()
        {
            //Console.WriteLine("Area of circle="+Demo.pi*this.radius*this.radius);
            Console.WriteLine("Area of circle=" + pi * radius * radius);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Demo obj1 = new Demo(10);
            obj1.print();

            Demo obj2 = new Demo(20);
            obj2.print();
        }
    }
    
    //=============================================================================
    

    class Demo
    {
        public Demo()
        {
            Console.WriteLine("non-static");
        }

        static Demo()
        {
            Console.WriteLine("static");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Demo obj1 = new Demo();

            Demo obj2 = new Demo();
        }
    }
    
    //=============================================================================
    

    class Demo
    {
        public Demo()
        {
            Console.WriteLine("A");
        }

        static Demo()
        {
            Console.WriteLine("B");
        }
    }
    class Demo1 : Demo
    {
        public Demo1() : base()
        {
            Console.WriteLine("C");
        }

        static Demo1()
        {
            Console.WriteLine("D");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Demo1 obj1 = new Demo1();  //D B A C


        }
    }
    
    //=============================================================================
    

    interface I1
    {
        void function1(int x);
        void function2(string x);
    }

    interface I2
    {
        double area(int r);
        double volume(int r, int h);
    }

    class Demo : I1, I2
    {
        void I1.function1(int x)
        {
            Console.WriteLine(x);
        }

        void I1.function2(string x)
        {
            Console.WriteLine(x);
        }
        double I2.area(int r)
        {
            return 2 * Math.PI * r;
        }

        double I2.volume(int r, int h)
        {
            return Math.PI * r * r * h;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Demo obj = new Demo();
            ((I1)obj).function1(10);

            Demo obj1 = new Demo();
            ((I1)obj).function2("We are in Capgemini");

            Demo obj2 = new Demo();
            ((I2)obj).area(10);

            Demo obj3 = new Demo();
            ((I2)obj).volume(20, 30);

        }
    }
    
    //=============================================================================
    

    //    static class:

    //static class cannot be instantiated.
    //static class contains only static variables and methods.

    static class Demo
    {
        static int id;
        static string name;
        static Demo()
        {
            id = 1;
            name = "Sam";
        }
        public static void display()
        {
            Console.WriteLine(id + "," + name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Demo obj1 = new Demo(); 
            Demo.display();
        }
    }
    
    //=============================================================================
    

    //    Polymorphism:

    //Poly->multiple
    //morphism->forms/behaviours

    // 2 types:
    //1.Compile-time/early binding/static polymorphism/function overloading

    //2.runtime/late binding/dynamic polymorphism/function overriding

    //base(mtd)--->derived(mtd)


    //Overloading:-

    class Demo
    {
        public void display()
        {
            Console.WriteLine("HELLO WORLD");
        }
        public void display(string s1)
        {
            Console.WriteLine("HELLO=" + s1);
        }
        public string display(string s1, string s2)
        {
            return string.Concat(s1, s2);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Demo obj1 = new Demo();
            obj1.display();
            obj1.display("jay");
            Console.WriteLine(obj1.display("NEW", "YORK"));
        }
    }
    
    //=============================================================================
    

    //Overriding:-

    class Demo1
    {
        public virtual void print()
        {
            Console.WriteLine("base class");
        }
    }
    class Demo2 : Demo1
    {
        public override void print()
        {
            Console.WriteLine("derived class");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Demo2 obj1 = new Demo2();
            obj1.print();
        }
    }
    
    //=============================================================================
    

    class vehicle
    {
        protected string vname;
        protected double price;

        public vehicle(string vname, double price)
        {
            this.vname = vname;
            this.price = price;
        }
        public virtual void print() { }
    }
    class TWOWH : vehicle
    {
        string desc;
        public TWOWH(string vname, double price, string desc) : base(vname, price)
        {
            this.desc = desc;
        }
        public override void print()
        {
            Console.WriteLine("two wheeler Details");
            Console.WriteLine(vname + "," + price + desc);
        }
    }
    class FOURWH : vehicle
    {
        string desc;
        public FOURWH(string vname, double price, string desc) : base(vname, price)
        {
            this.desc = desc;
        }
        public override void print()
        {
            Console.WriteLine("FOUR wheeler Details");
            Console.WriteLine(vname + "," + price + "," + desc);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            TWOWH obj1 = new TWOWH("HONDA ACTIVA", 55000, "SILVER");
            obj1.print();
            FOURWH obj2 = new FOURWH("INNOVA CRYSTA", 2700000, "WHITE");
            obj2.print();
        }
    }
    
    //=============================================================================
    

    //Abstract class
    //    Sealed class
    //    Partial class (partial methods)
    //static class


    //Abstract class:
    //1.collection of abstract and non-abstract methods.
    //2.variables are allowed to declare.
    //3.Abstract class cannot be instantiated but can be inherited.


    abstract class Sample
    {
        protected double d1, d2;
        public void print()
        {
            Console.WriteLine("enter 2 dimension");
            d1 = double.Parse(Console.ReadLine());
            d2 = double.Parse(Console.ReadLine());
        }
        public abstract double calculate();
    }
    class Sample1 : Sample
    {
        public override double calculate()
        {
            return (0.5 * d1 * d2);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Sample obj = new Sample();
            Sample1 obj = new Sample1();
            obj.print();
            Console.WriteLine("Area of triangle=" + obj.calculate());
        }
    }
    
    //=============================================================================
    */

    //Sealed class:
    //1.collection of non-abstract methods.
    //2.variables are allowed to declare.
    //3.Sealed class can be instantiated but cannot be inherited.

    sealed class Sample
    {
        protected double d1, d2;
        public void print()
        {
            Console.WriteLine("enter 2 dimension");
            d1 = double.Parse(Console.ReadLine());
            d2 = double.Parse(Console.ReadLine());
        }
        public double areaRt()
        {
            return (d1 * d2);
        }

        public double areaTR()
        {
            return (0.5 * d1 * d2);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Sample obj = new Sample();
            obj.print();
            Console.WriteLine("Area of triangle=" + obj.areaTR());
            Console.WriteLine("Area of rectangle=" + obj.areaRt());
        }
    }
}


