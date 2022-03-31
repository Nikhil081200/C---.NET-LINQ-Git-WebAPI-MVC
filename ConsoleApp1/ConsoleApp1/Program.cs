using System;
using System.Text;

namespace ConsoleApp1
{
    /*
    // enum product { printer = 347, projector, desktopPC = 765, laptop }

    struct accdet
    {
        public int acno;
        public string achname;
        public double depamt;
    }
    struct product
    {
        public int pcoden;
        public string pname;
        public double unitprice;
    }
    class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("Enter your name:");
             read a data from console
             string name = Console.ReadLine();

             Console.WriteLine("Enter your age:");
             int age = Convert.ToInt32(Console.ReadLine());

             Console.WriteLine("Is employee or not");
             bool isemployee = Convert.ToBoolean(Console.ReadLine());
             Console.WriteLine();

             Console.WriteLine("You entered these values: " + name + ", Age = " + age + "");
             Console.WriteLine("You entered these values: Name = {0}, Age = {1}", name, age);
             Console.WriteLine($"You entered these values: Name = {name}, Age = {age}");

            ===========================================================
            Console.WriteLine("Please enter first number");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter second number");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 > 0 && num2 > 0)
            {
                Console.WriteLine($"Add result = { num1 + num2}");
            }
            else
            {
                Console.WriteLine("Either num1 or num2 is less than 0");
            }
            
            ==============================================================
            for (int i = 0; i < 10; i++)
           {
               Console.WriteLine($"Value of I: {i}");
           }
            =============================================================
           
            int i = 10;
            while( i < 15)
            {
                Console.WriteLine(i);
                i++;
            }
            
            =============================================================
            
            int i = 10;
            do
            {
                Console.WriteLine(i);
                i++;
            } while (i < 15);
            
            =============================================================

            for( int i = 0; i < 20; i ++)
            {
                if(i == 8)
                {
                    //break;
                    continue;
                }
                Console.WriteLine(i);
            }
            =============================================================

            int[] array1 = new int[5] { 10, 20, 30, 40, 50 };

            int[] array2 = new int[10];


            for(int i = 0; i< array1.Length;i++)   // 0-4
            {
                Console.WriteLine("array ["+ i + "] = " + array1[i]);
            }


            Console.WriteLine("Enter the array elements");
            for (int i = 0; i < array2.Length; i++)   
            {
                array2[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < array2.Length; i++)   
            {
                Console.WriteLine("array [" + i + "] = " + array2[i]);
            }
            ==================================================================

            int[] array1 = new int[5];
            int[] array2 = new int[5];
            int[] array3 = new int[5];

            Console.WriteLine("Enter the array elements for array1");
            for (int i = 0; i < array1.Length; i++)  
            {
                array1[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter the array elements for array2");
            for (int i = 0; i < array2.Length; i++)
            {
                array2[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Sum of array elements");
            for (int i = 0; i < array1.Length; i++)
            {
                array3[i] = array1[i] + array2[i];
                Console.WriteLine("array3 [" + i + "] = " + array3[i]);
            }
            
            ===================================================================

            object[] product = new object[] { 1, "LCD", 4.45, 2, "LED", 6.67 };

            for (int i = 0; i<product.Length; i+=2)
            {
                Console.WriteLine(product[i]);
            }
            Console.WriteLine("------------------------------------");

            foreach( object i in product)
            {
                Console.WriteLine(i);
            }
            ==================================================================

            int[,] array1 = new int[2, 2] {{ 10, 20 },{ 30, 40} };

            for ( int i = 0; i < 2; i++)
            {
                for ( int j = 0; j < 2; j++)
                {
                    Console.WriteLine(array1[i, j]+"\t");
                }
                Console.WriteLine("\n");
            }
            ==================================================================
    */

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        int[,] array1 = new int[2, 2];

    //        Console.WriteLine("enter the array elements");

    //        for (int i = 0; i < 2; i++)
    //        {
    //            for (int j = 0; j < 2; j++)
    //            {
    //                array1[i, j] = int.Parse(Console.ReadLine());
    //            }
    //        }

    //        for (int i = 0; i < 2; i++)
    //        {
    //            for (int j = 0; j < 2; j++)
    //            {
    //                Console.WriteLine("[" + i + "," + j + "]=" + array1[i, j]);
    //            }
    //            Console.WriteLine("\n");
    //        }
    //    }
    //}
}
            /*
            ====================================================================
            // Jagged Arrays:-

            int[][] Jarray = new int[4][];

            Jarray[0] = new int[] { 10, 20, 30, 40 };
            Jarray[1] = new int[] { 10, 20 };
            Jarray[2] = new int[] { 100, 200, 300, 400, 500, 600 };
            Jarray[3] = new int[] { 100, 200, 300 };

            for(int i = 0; i < Jarray.Length; i++)
            {
                for(int j = 0; j< Jarray[i].Length; j++)
                {
                    Console.Write(Jarray[i][j]+ "\t");
                }
                Console.WriteLine("\n");
            }
            =======================================================================

            // Jagged arrays with object:-

            object[][] course = new object[3][];

            course[0] = new object[] { 1, 2, 3, 4 };
            course[1] = new object[] { "C#.NET", "SQL", "JAVA", "PHP" };
            course[2] = new object[] { "1 Month", "15 days", "1.5 month" };

            for (int i = 0; i < course.Length; i++)
            {
                for (int j = 0; j < course[i].Length; j++)
                {
                    Console.Write(course[i][j] + "\t");
                }
                Console.WriteLine("\n");
            }

            =====================================================================

            // Try Parse Method:-

            int result;

            Console.WriteLine("Input a number:- ");
            bool b = int.TryParse(Console.ReadLine(), out result);

            Console.WriteLine(b + "," + result);
            ===============================================================

            char ch;
            Console.WriteLine("Input a char");
            ch = char.Parse(Console.ReadLine());

            if (ch >= '0' && ch <= '9')
            {
                Console.WriteLine("It is a number");
                Console.WriteLine("The input char is = {0}", ch);
            }
            else if (ch >= 'a' && ch <= 'z')
                Console.WriteLine("It is a alpha");
            else
                Console.WriteLine("It is a special");

            ================================================================

            bool var1 = true;
            int res;
            Console.WriteLine("Input a number");
            res = Convert.ToInt32(var1);

            Console.WriteLine(res);

            ==============================================================
            
            // String methods;-

            string str = "Welcome to c# programming ";
            string str1 = "Welcome to c#";

            //functions returning int value
            Console.WriteLine(str.Length);
            Console.WriteLine(str.IndexOf('m'));
            Console.WriteLine(str.LastIndexOf('m'));

            //function returning boolean values
            Console.WriteLine(str.StartsWith('w'));
            Console.WriteLine(str.EndsWith('g'));
            Console.WriteLine(str.Contains('z'));
            Console.WriteLine(str.Equals(str1));

            Console.WriteLine(string.Compare(str, str1));   //0,1,-1

            Console.WriteLine(string.Concat(str,str1));

            string str3 = string.Copy(str1);
            Console.WriteLine(str3);

            string str4 = (string) str1.Clone();
            Console.WriteLine(str4);

            CharEnumerator ch = str.GetEnumerator();
            while (ch.MoveNext())
            {
                Console.WriteLine(ch.Current);
            }

            Char[] charray = str.ToCharArray();
            foreach(char i in charray)
            {
                Console.WriteLine(i);
            }

            ===============================================================

            // Split and Join Method

            string str = "Welcome to c# programming";

            string[] strarray = str.Split(' ');
            foreach(string i in strarray)
            {
                Console.WriteLine(i);
            }

            string[] strarray1 = { "Welcome", "to", "VB.Net", "Programming" };
            string newstring = string.Join(" ", strarray1);
            Console.WriteLine(newstring);

            char[] charray = new char[35];
            str.CopyTo(0, charray, 0, 14);
            Console.WriteLine(charray);
            str.CopyTo(11, charray, 0, 14);
            Console.WriteLine(charray);
            str.CopyTo(0, charray, 0, str.Length);
            Console.WriteLine(charray);

            ========================================================

            string str = "welcome to c# programming";


            Console.WriteLine(str.Remove(7));
            Console.WriteLine(str.Substring(7));
            Console.WriteLine(str.Replace('c','j'));
            Console.WriteLine(str.Replace("c#","sql"));
            Console.WriteLine(str.Insert(13, "sql"));

            =======================================================

            object str1 = "welcome";
            char[] charray = { 'w', 'e', 'l', 'c', 'o', 'm', 'e' };
            object str2 = new string(charray);

            Console.WriteLine(str1.Equals(str2));
            Console.WriteLine(str1 == str2);

            ========================================================

            // enum :-

            Console.WriteLine((int)product.printer);
            Console.WriteLine(Convert.ToInt32(product.laptop));

            =======================================================

            // Structure:-

            accdet firstdet;

            firstdet.acno = 1;
            firstdet.achname = "jay";
            firstdet.depamt = 35000;

            Console.WriteLine(firstdet.acno + "," + firstdet.achname + "," + firstdet.depamt);
            
            =================================================================

            Nullable<int> empid = 12;
            Console.WriteLine(empid);

            Nullable<double> proprice = null;
            Console.WriteLine(proprice);

            int? custage = null;
            Console.WriteLine(custage.GetValueOrDefault());

            Console.WriteLine(custage.HasValue);
            ================================================================

            int x = 100;  
            object y = x;               // Boxing : Implicit Conversion
            Console.WriteLine(y);

            int result = (int)y;        // Unboxing: Explicit Conversion
            Console.WriteLine(result);

            ================================================================

            product firstpro;

            firstpro.pcoden = 12;
            firstpro.pname = "Oliveoil";
            firstpro.unitprice = 510;

            Console.WriteLine(firstpro.pcoden + "," + firstpro.pname + "," + firstpro.unitprice);

            product secondpro;

            secondpro.pcoden = 18;
            secondpro.pname = "Shampoo";
            secondpro.unitprice = 708;

            Console.WriteLine(secondpro.pcoden + "," + secondpro.pname + "," + secondpro.unitprice);

            product thirdpro;
            thirdpro.pcoden = 64;
            thirdpro.pname = "Books";
            thirdpro.unitprice = 4852;

            Console.WriteLine(thirdpro.pcoden + "," + thirdpro.pname + "," + thirdpro.unitprice);

            =============================================================

            int[] array1 = new int[10];

            Console.WriteLine("Enter the array elements:-");

            for( int i = 0; i < array1.Length; i++)
            {
                array1[i] = int.Parse(Console.ReadLine());
            }

            int sum = 0;
            foreach(int j in array1)
            {
                sum += j;
            }
            Console.WriteLine(sum)
          
        }
    }*/

    //================================================================
    /*
     class employee
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
            /*if (no1 > no2)
                return no1;
            else
                return no2;*/

    /* return no1 > no2 ? no1 : no2;
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

==============================================================================

// Types of Cnstructor:-

class Book
{
 int bid;
 string bname;
 double price;

 public Book()
 {
     bid = 87;
     bname = "Ramayan";
     price = 8000;
 }  // Default Constructor

 public Book(int bid, string bname, double price)
 {
     this.bid = bid;
     this.bname = bname;
     this.price = price;
 }  // Parameterised Constructor

 public Book(Book obj)
 {
     this.bid = obj.bid;
     this.bname = obj.bname;
     this.price = obj.price;
 }  // Copy Object Constructor

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

     Book obj2 = new Book(2,"SQL",9824);
     obj2.show();

     Book obj3 = new Book(obj1);
     obj3.show();
 }
}
==============================================================================


class Store
{
 string pname;
 public double unitprice;
 public int noofitems;

 public Store()
 {
     pname = "watch";
     unitprice = 500;
     noofitems = 4;
 } 

 public Store(string pname, double unitprice, int noofitems)
 {
     this.pname = pname;
     this.unitprice = unitprice;
     this.noofitems = noofitems;
 }

 public Store(Store obj)
 {
     this.pname = obj.pname;
     this.unitprice = obj.unitprice;
     this.noofitems = obj.noofitems;
 }

 public void show()
 {
     Console.WriteLine($"ProductName={pname}, UnitPrice={unitprice}, NoOfItems={noofitems}");
     Console.WriteLine("Total_Price=" + unitprice * noofitems);

 }
}

class Program
{
 public static void Main(string[] args)
 {
     Store obj1 = new Store();
     obj1.show();

     Store obj2 = new Store("Toy", 500, 2);
     obj2.show();

     Store obj3 = new Store(obj1);
     obj3.show();
 }
}

=====================================================================

// Inheritance:-
    //Single:

class Data
{
 protected int coord1, coord2;

 public void getdata()
 {
     Console.WriteLine("Enter 2 Co-ordinates");
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

================================================================

class Student
{

 protected string Regno,name;
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

=====================================================================================================

// Multi-level Class Inheritance:-

class employee
{
 protected int empid;
 protected string empname;

 public void getdata()
 {
     Console.WriteLine("Enter employee details: Id, Name:-");
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
     Console.WriteLine("Enter your department details: Name, Location:-");
     deptname = Console.ReadLine();
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
 static void Main(string[] aargs)
 {
     Final obj = new Final();
     obj.getdata();
     obj.getdeptdata();
     obj.display();
 }
}

======================================================================================================================


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

=============================================================================

// Heirarchical Inheritance:-

class data
{
 protected int a, b;

 public void getdata()
 {
     Console.WriteLine("Enter 2 numners:-");
     a = Convert.ToInt32(Console.ReadLine());
     b = Convert.ToInt32(Console.ReadLine());
 }
}

class Demo1 : data
{
 public void add()
 {
     Console.WriteLine("Sum of 2 numbers:-" + (a + b));
 }
}

class Demo2 : data
{
 public void sub()
 {
     Console.WriteLine("Subtraction of 2 numbers:-"+ (a - b));
 }
}

class Demo3 : data
{
 public void multiplication()
 {
     Console.WriteLine("Multiplication of 2 numbers:-"+ (a * b));
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
     obj3.multiplication();
 }
}

=================================================================================================================


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

==========================================================================================================

// Constructor Inheritance:-

class category : Object
{
 protected string cname, cdesc;

 public category(string cname, string cdesc)
 {
     this.cname = cname;
     this.cdesc = cdesc;
 }
}

class Product:category
{
 string pname;
 double price;

 public Product(string cname, string cdesc, string pname, double price):base(cname, cdesc)
 {
     this.pname = pname;
     this.price = price;
 }

 public void displaydet()
 {
     Console.WriteLine("category_name:" + cname + "," + "cdesc=" + cdesc);
     Console.WriteLine("Product_name:" + pname + "," + "Price=" + price);
 }

 class Program
 {
     static void Main(string[] args)
     {
         Product p1 = new Product("stationary","All engiineering and medical books","C#",8000);
         p1.displaydet();
     }
 }
}

=================================================================================================

// Interface Method:-

interface InterfacOne
{
 void display();
 void print(string str);
}

class Demo : InterfacOne
{
 public void display()
 {
     Console.WriteLine("This is the interface method");
 }

 public void print(string str)
 {
     Console.WriteLine(string.Concat("hello", str));
 }
}

class Program
{
 static void Main(string[] args)
 {
     Demo obj = new Demo();
     obj.display();
     obj.print("World");
 }
}

======================================================================================================


interface InterfacOne
{
 void method1(int a, int b);
 void method2(double a);
 void method3(string s1, string s2, string s3);
}

class Demo:InterfacOne
{
 public void method1(int a, int b)
 {
     Console.WriteLine($"{a}, {b}");
 }

 public void method2(double a)
 {
     Console.WriteLine($"{a}");
 }

 public void method3(string s1,string s2, string s3)
 {
     Console.WriteLine(string.Concat(s1, s2, s3));
 }
}

class Program
{
 static void Main(string[] args)
 {
     Demo obj = new Demo();
     obj.method1(10,20);
     obj.method2(24050);
     obj.method3("Nikhil"," is in ","Capgemini");
 }
}

==========================================================================================================


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
     return ( b * h)*1/2;
 }
}

class Program
{
 static void Main(string[] args)
 {
     Demo obj = new Demo();
     Console.WriteLine("Area of rectangle:- "+obj.area1(10, 20));
     Console.WriteLine("Area of Triangle:- "+obj.area2(10, 20));
 }
}

=====================================================================================================

// Multiple Interfaces:- 

interface interfaceone
{
 void method1(int a, int b);
 double method2(int a);
 void method3(string a, string b, string c);
}

interface interfacetwo
{
 int calculate(int a, int b);
 double compute(int r);
}

class Demo : interfaceone, interfacetwo
{
 public int calculate(int a, int b)
 {
     return (a + b);
 }

 public double compute(int r)
 {
     return (3.14 * r * r);
 }

 public void method1(int a, int b)
 {
     Console.WriteLine("Product=" + (a * b));
 }

 public double method2(int a)
 {

 }

 public void method3(string a, string b, string c)
 {

 }
}

class Program
{
 static void Main(string[] args)
 {
     Demo obj = new Demo();
     obj.method1(10, 30);
     Console.WriteLine("Result=" + obj.method2(25));
     obj.method3("C#", " Programming", " Is interesting");
     Console.WriteLine("Sum=" + obj.calculate(10, 20));
     Console.WriteLine("Area of circle=" + obj.compute(25));
 }
}

==============================================================================================


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

=====================================================================================


// static and no-static method:-

class Demo
{
 public void print()
 {
     Console.WriteLine("This is non-static method");
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

===========================================================================================================

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

===========================================================================================================

class employee
{
 string ename;
 string edesig;
 static string dept;    //software development for all 3 objects

 public employee(string ename, string edesig)
 {
     this.ename = ename;
     this.edesig = edesig;
 }

 static employee()
 {
     employee.dept = "Software Development";
 }

 public void print()
 {
     Console.WriteLine(" Employee Name:-" + ename + "\n Employee Designation:-" + edesig +
         "\n Employee Department:-" + dept);
 }
}

class Program
{
 static void Main(string[] args)
 {
     employee obj1 = new employee("Nikhil","Junior Analyst");
     obj1.print();

     employee obj2 = new employee("Nilesh", "Senior Analyst");
     obj2.print();

     employee obj3 = new employee("Madhu", "Manager");
     obj3.print();

 }
}

===================================================================================

class Demo
{
 public Demo()
 {
     Console.WriteLine("Non-static");
 }

 static Demo()
 {
     Console.WriteLine("Static");
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

==================================================================================================

    // Constructor for derived class:-

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
        public Demo1():base()
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
            Demo1 obj1 = new Demo1();   //D-B-A-C
        }
    }

    =================================================================================================

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

    =========================================================================================================================


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
            Console.Write(id + "," + name);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Demo.display();
        }
    }

    ======================================================================================================

    // Polymorphism:-

    //Types:- 1. Compile Time/early binding/static polymorphism/ function overloading
      //      2. Runtime / late binding/ dynamic polymorphism/ function overriding


    // Compile Time Polymorphism:-
    class Demo
    {
        public void display()
        {
            Console.WriteLine("Hello World");
        }
        public void display(string s1)
        {
            Console.WriteLine("Hello" + s1);
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
            obj1.display("Jay");
            Console.WriteLine(obj1.display("New", "York"));
        }
    }

    ========================================================================================================


    class overloaded
    {

        public int compute(int a)
        {
            return a * a * a;
        }

        public int compute(int l, int b)
        {
            return l * b;
        }

        public int compute(int l, int b, int h)
        {
            return l * b * h;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            overloaded obj = new overloaded();
            Console.WriteLine("Area of cube:-" + obj.compute(10));
            Console.WriteLine("Area of rectangle:-" + obj.compute(10,20));
            Console.WriteLine("Volume of cube:-" + obj.compute(10,20,30));
        }
    }

    ===============================================================================================================


    // Run-Time Polymorphism:-

    class Demo1
    {
        public virtual void print()
        {
            Console.WriteLine("base class");
        }
    }

    class Demo2 : Demo1
    {
        public virtual void print()
        {
            Console.WriteLine("Derived class");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Demo1 obj1 = new Demo1();
            obj1.print();
        }
    }

    ===================================================================================================

    class vehicle
    {
        string vname;
        double price;

        public vehicle(string vname, double price)
        {
            this.vname = vname;
            this.price = price;
        }

        public virtual void print()
        {

        }
    }

    class twowh : vehicle
    {
        string desc;
        public twowh(string vname, double price, string desc):base(vname,price)
        {
            this.desc = desc;

            Console.WriteLine("Two Wheeler Details:-");
            Console.WriteLine(vname + "," + price +","+ desc);
        }
    }

    class fourwh : vehicle
    {
        string desc;
        public fourwh(string vname, double price, string desc) : base(vname, price)
        {
            this.desc = desc;

            Console.WriteLine("Four Wheeler Details:-");
            Console.WriteLine(vname + "," + price +"," + desc);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            twowh obj1 = new twowh("Honda Activa", 95000, "Black");
            obj1.print();

            fourwh obj2 = new fourwh("Maruti", 500000, "White");
            obj2.print();
        }
    }

=================================================================================================

    // Types of classes:1.Abstract class:- collectoin of abstract and non abstractmethods,variables are allowed to declare, it cannot be instantiated but can be inherited
        //              2. Sealed class:-  collectoin of non abstractmethods,variables are allowed to declare, it can instantiated but cannot be inherited
        //              3. Partial Class [UriPartial methods]
        //              4.Static class


    // Abstract Class:-

    abstract class sample
    {
        protected double d1, d2;

        public void print()
        {
            Console.WriteLine("Enter 2 dimensiona:-");
            d1 = double.Parse(Console.ReadLine());
            d2 = double.Parse(Console.ReadLine());
        }

        public abstract double calculate();
    }

    class sample1 : sample
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
            sample1 obj = new sample1();
            obj.print();

            Console.WriteLine("Area of triangle:- " + obj.calculate());
        }
    }

    =====================================================================================

    // Sealed Class:-

    sealed class sample
    {
        protected double d1, d2;

        public void print()
        {
            Console.WriteLine("Enter 2 dimensiona:-");
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
            sample obj1 = new sample();
            obj1.print();
            Console.WriteLine("Area of Triangle is:- " + obj1.areaTR());
            Console.WriteLine("Area of Rectangle:- " + obj1.areaRt());
        }
    }

    =========================================================================================================

    // Partial Class:-

    partial class sample
    {
        protected double d1, d2;
    }

    partial class sample
    {
        public void print()
        {
            Console.WriteLine("Enter 2 dimensiona:-");
            d1 = double.Parse(Console.ReadLine());
            d2 = double.Parse(Console.ReadLine());
        }
    }

    partial class sample
    {
        public double areaRt()
        {
            return (d1 * d2);
        }
    }

    partial class sample
    {
        public double areaTR()
        {
            return (0.5 * d1 * d2);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            sample obj1 = new sample();
            obj1.print();
            Console.WriteLine("Area of Triangle is:- " + obj1.areaTR());
            Console.WriteLine("Area of Rectangle:- " + obj1.areaRt());
        }
    }

    =================================================================================================================

    // Partial Method:-

    partial class sample
    {
        partial void method1();
        partial void method2();
    }

    partial class sample
    {
        int len, bh;

        public void getdetails()
        {
            Console.WriteLine("Input Data");
            len = Convert.ToInt32(Console.ReadLine());
            bh = Convert.ToInt32(Console.ReadLine());
            method1();
        }

        partial void method1()
        {
            Console.WriteLine("Area=" + (len * bh));
            method2();
        }

        partial void method2()
        {
            Console.WriteLine("Area=" + (Math.Sqrt(len * bh)));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            sample obj = new sample();
            obj.getdetails();
        }
    }

    =========================================================================================

    // operator overloading:-  syntax: static operator --();

    // Types":- 1.Unary = single operand
    // 2. Binary = two operand

    // Unary operator overloading:-

    class sample
    {
        int a, b;
        public sample(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public static sample operator -(sample obj)
        {
            obj.a = -obj.a;
            obj.b = -obj.b;
            return obj;
        }

        public void print()
        {
            Console.WriteLine(a + "," + b);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            sample obj = new sample(100, -200);
            obj = -obj;
            obj.print();
        }
    }

    =======================================================================================

        // Binary Operator overloading:-

    class sample
    {
        int a, b;

        public sample()        // default constructor
        {

        }
        public sample(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public static sample operator -(sample obj1, sample obj2)
        {
            sample temp = new sample();
            temp.a = obj1.a - obj2.a;
            temp.b = obj1.b - obj2.b;
            return temp;
        }
        public static sample operator +(sample obj1, sample obj2)
        {
            sample temp = new sample();
            temp.a = obj1.a + obj2.a;
            temp.b = obj1.b + obj2.b;
            return temp;
        }
        public void print()
        {
            Console.WriteLine(a + "," + b);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            sample obj1 = new sample(100,200);
            obj1.print();
            sample obj2 = new sample(10, 20);
            obj2.print();
            sample obj3 = new sample();
            obj3 = obj1 - obj2;
            obj3.print();
            sample obj4 = new sample();
            obj4 = obj1 + obj2;
            obj4.print();
        }
    }
    =======================================================================================================

    // is and as operator:-
    // is: it is an operator which returns boolean value, "to check" runtime type of an object or not.it is used for reference type object

    // is:-

    class sample1
    {

    }
    class sample2
    {

    }

    class Program
    {
        static void Main(string[] args)
        {
            sample1 s1 = new sample1();
            sample2 s2 = new sample2();

            Console.WriteLine(s1 is sample1);
            Console.WriteLine(s2 is sample2);

            Console.WriteLine(s1 is sample2);
            Console.WriteLine(s2 is sample1);

            Console.WriteLine(s1 is object);
            Console.WriteLine(s2 is object);
        }
    }

    =================================================================================================

    // as:-

    class sample1
    {

    }
    class sample2
    {

    }

    class Program
    {
        static void Main(string[] args)
        {
            object[] objarray = new object[7];
            objarray[0] = new sample1();
            objarray[1] = new sample2();
            objarray[2] = "hello";
            objarray[4] = 1234;
            objarray[5] = true;
            objarray[6] = null;

            for(int i =0; i< objarray.Length;i++)
            {
                string result = objarray[i] as string;
                if (result != null)
                    Console.WriteLine(result);
                else
                    Console.WriteLine("not a string" + result);
            }
        }
    }

    ==========================================================================================

    namespace n1
    {
        class sample
        {
            public void print()
            {
                Console.WriteLine("Ajax and jquery");
            }
        }
    }
    namespace n2
    {
        class sample
        {
            public void print()
            {
                Console.WriteLine("C3, .NET, MVC");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            n1.sample obj1 = new n1.sample();
            obj1.print();
            n2.sample obj2 = new n2.sample();
            obj2.print();
        }
    }

    =========================================================================================================================================================================

    class sample
    {
        public void swap(ref int a, ref int b)
        {
            int temp;
            temp = a;
            a = b;
            b = temp;
            Console.WriteLine("a=" + a + ",b=" + b);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            sample obj = new sample();
            int a = 100, b = 200;
            obj.swap(ref a, ref b);   // call by reference
        }
    }
    =========================================================================================================================================================================

    class sample
    {
        public void method1(int a, int b, out int r1, out int r2, out int r3)
        {
            r1 = a + b;
            r2 = a - b;
            r3 = a * b;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            sample obj = new sample();
            int a = 100, b = 200, Result1, Result2, Result3;
            obj.method1(a, b, out Result1, out Result2, out Result3);

            Console.WriteLine("sum=" + Result1);
            Console.WriteLine("Diff=" + Result2);
            Console.WriteLine("Pro=" + Result3);
        }
    }

    =========================================================================================================================================================================

    // params:-

    class sample
    {
        public void method1(params int[] a)
        {
            foreach(int i in a)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("----------------------------");
        }
        public void method2(params object[] a)
        {
            foreach(var i in a)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("------------------------------");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            sample obj = new sample();
            obj.method1(10,20,30);
            obj.method2(40,50,60,70,80,90,100);
            obj.method2("Nikhil","Prasad");
        }
    }
    
    =========================================================================================================================================================================

    // Named Parameters:-

    class sample
    {
        public void studentdetails(int regno, string sname, string smailid, string course)
        {
            Console.WriteLine(regno + "," + sname + "," + smailid + "," + course);
            Console.WriteLine("------------------------------------");
        }

        public void bookdetails(string bname,double price, string auname = "Robert")  // default parameter
        {
            Console.WriteLine(bname + "," + auname + "," + price);
            Console.WriteLine("----------------------");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            sample obj = new sample();
            obj.studentdetails(1, "Nikhil", "nikhil@gmail", ".NET full-stack");
            obj.bookdetails("Wingsoffire", 500, "Nickion");
            obj.bookdetails("Wingsoffire", 500);
        }
    }
    
    =========================================================================================================================================================================

    // Properties:- it provides access to private data members

    class book
    {
        int bid;
        string bname;
        string auname;

        public int _bid
        {
            get { return bid; }
            set { bid = value; }
        }
        public string _bname
        {
            get { return bname; }
            set { bname = value; }
        }

        public string _auname
        {
            get { return auname; }
            set { auname = value; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            book obj = new book();
            obj._bid = 1;
            obj._bname = "SQL";
            obj._auname = "symond";

            Console.WriteLine(obj._bid + "," + obj._bname + "," + obj._auname);
        }
    }

    
    =========================================================================================================================================================================

    // Readonly Property:-

    class book
    {
        int bid;
        string bname;
        string auname;

        public book()
        {
            bid = 1;
            bname = "java";
            auname = "xxxx";
        }
        public int _bid
        {
            get { return bid; }
        }
        public string _bname
        {
            get { return bname; }
        }
        public string _auname
        {
            get { return auname; }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            book obj = new book();
            Console.WriteLine(obj._bid + "," + obj._bname + "," + obj._auname);
        }
    }
    
    =========================================================================================================================================================================

    // Write only property:-

    class book
    {
        int bid;
        string bname;
        string auname;

        public int _bid
        {
            set { bid = value; }
        }
        public string _bname
        {
            set { bname = value; }
        }

        public string _auname
        {
            set { auname = value; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            book obj = new book();
            obj._bid = 1;
            obj._bname = "SQL";
            obj._auname = "symond";
            obj.print();
        }
    }
     
    =========================================================================================================================================================================

    class book
    {
        public int bid { get; set; }
        public string bname { get; set; }
        public double bprice { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            book obj = new book() { bid = 1, bname = "VB.NET", bprice = 4500 };
            Console.WriteLine(obj.bid + "," + obj.bname + "," + obj.bprice);
        }
    } 

    =========================================================================================================================================================================

    // Indexer:- it is used when data-member is an array, it does nt have name
                  

    class demo
    {
        int[] a = new int[4];

        public demo()
        {
            a = new int[] { 10, 20, 30, 40 };
        }
        public int this[int index]
        {
            get { return a[index]; }
            set { a[index] = value; }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            demo obj = new demo();
            obj[0] = 100;   // set
            obj[3] = 400;

            for (int i = 0; i < 4;i++)
            {
                Console.WriteLine(obj[i]);
            }
        }
    }

    =========================================================================================================================================================================

    class demo
    {
        int[,] a = new int[2,2];

        public demo()
        {
            a = new int[,] { { 10, 20 }, { 30, 40 } };
        }
        public int this[int index1,int index2]
        {
            get { return a[index1, index2]; }
            set { a[index1, index2] = value; }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            demo obj = new demo();
            obj[0,0] = 15;   // set
            obj[1,0] = 35;

            for (int i = 0; i < 2; i++)
            {
                for ( int j = 0; j < 2;j++)
                {
                    Console.Write(obj[i,j] + "\t");
                }
                Console.WriteLine("\n");
            }
        }
    }
    
    =========================================================================================================================================================================

    // Method Hiding:-it provides option for reimplementing the method with 'new' keyword.

    class dept
    {
        public void display()
        {
            Console.WriteLine("Total no. od Department:3");
        }
    }
    class compinfo : dept
    {
        public new void display()
        {
            //base.display();       // method hiding
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Dept Name = HR, No of emp = 10");
            Console.WriteLine("Dept Name = accounts, NO. of emp=50");
            Console.WriteLine("Dept Name = sales, NO. of emp = 500");
            
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            compinfo obj = new compinfo();
            obj.display();
        }
    }
    
    =========================================================================================================================================================================

    //Using library:- MyLib

    class Program
    {
        static void Main(string[] args)
        {
            MyLib1.Class1 obj = new Class1();
            obj.method1(10, 20);
            Console.WriteLine("Area of circle:" + obj.method2(10));
            Console.WriteLine("Circumference of circle:" + obj.method3(10));
        }
    }
    
    =========================================================================================================================================================================

    // Internal and Protected internal
    //Internal:variable is visible within the namespace,consoleapp or assembly only.

    public class dept //internal
    {
        internal string dname = "HR_Dept";  //private
    }
    class Program
    {
        static void Main(string[] args)
        {
            dept obj = new dept();
            Console.WriteLine(obj.dname);
        }
    }

     
    =========================================================================================================================================================================

    //Protected internal:-variable is visible within the namespace,consoleapp or assembly
    //and outside the assembly

    public class dept
    {
        protected internal string dname = "HR_Dept";  //protected internal,private
    }
    class Program
    {
        static void Main(string[] args)
        {
            dept obj = new dept();
            Console.WriteLine(obj.dname);
        }
    }

       =========================================================================================================================================================================
  
     // Delegate:-

    delegate void MyDelegate();
    class demo
    {
        public void method1()
        {
            Console.WriteLine("Hello");
        }
        public void method2()
        {
            Console.WriteLine("C# Programming");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            demo obj = new demo();
            MyDelegate del1 = new MyDelegate(obj.method1);
            del1();
            MyDelegate del2 = new MyDelegate(obj.method2);
            del2();
        }
    }

}
    */