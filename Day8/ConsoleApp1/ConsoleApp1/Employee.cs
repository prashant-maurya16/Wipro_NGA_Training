using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Employee

    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Salary { get; set; }
        public int Age { get; set; }

        public Employee(int id, string name, string salary, int age)
        {
            Id = id;
            Name = name;
            Salary = salary;
            Age = age;
        }

        public Employee()
        {
        }

        public void PrintEmployee()
        {
            Console.WriteLine("Method created to print Employee Details :");
        }

        public void PrintEmployee(string name, int age)
        {
            Console.WriteLine("Method created to print Employee Details :");
        }


    }

}
    
    

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Web.Services;

namespace ConsoleApp1
{

    [AddMetaData(" ghjh")]
    internal class Program
    {


        static void Main(string[] args)
        {
            /*Add(23, 34);
            Add(new int[]{4,5,6});*/

            //  Employee employee = new Employee(); // Compile time
            //  employee.PrintEmployee();

            //Reflection : -- to inspect the library at run time and grab all the details from it 
            // at run time

            /* int i = 42;
             Type type =  i.GetType();
             Console.WriteLine(type.FullName);*/

            // Let's say we want to fetch all the properties ,  methods and constructor of a Employee 

            // Assembly assembly = Assembly.Load(Assembly.GetExecutingAssembly().Location);
            // Type[] types = assembly.GetTypes();
            //  
            // foreach (Type type in types)
            // {



            Type type = Type.GetType("ConsoleApp1.Employee");
            if (type != null)
            {

                Console.WriteLine(type.FullName);
                Console.WriteLine(type.Name);
                GetMethods(type);

                Console.WriteLine("************* Properties ******************");

                GetProperties(type);


                Console.WriteLine("************* Constructors ******************");

                GetConstructors(type);

            }
        }



    }

    public static void GetMethods(Type type)
    {
        MethodInfo[] methodInfo = type.GetMethods();
        foreach (MethodInfo mi in methodInfo)
        {
            Console.WriteLine($"Method Name : {mi.Name} Return Type : {mi.ReturnType}");
        }

    }


    public static void GetProperties(Type type)
    {
        PropertyInfo[] propertyInfo = type.GetProperties();
        foreach (PropertyInfo pi in propertyInfo)
        {
            Console.WriteLine($"Method Name : {pi.Name} Return Type : {pi.PropertyType}");
        }

    }


    public static void GetConstructors(Type type)
    {
        ConstructorInfo[] constructorInfo = type.GetConstructors();
        foreach (ConstructorInfo ci in constructorInfo)
        {
            Console.WriteLine($"Method Name : {ci.Name} Return Type : {ci.IsPublic}");
        }

    }





    /* //  [WebMethod]
     [Obsolete("This method will get permanently deleted on 5 th Feb 2025")]
     public static void Add(int a, int b)
     {
         Console.WriteLine("The result is : " + (a + b));

     }

     [AddMetaData("This is a new method created in place of Add method used previously")]
     public static int Add(int[] number)
     {
         int result = 0;
         for (int i = 0; i < number.Length; i++)
         {    result += number[i];
             Console.WriteLine(result);

         }
         Console.WriteLine(result);
         return result;

     }

     public static void Update()
     { }

     public static void Delete()
     { }*/

}


