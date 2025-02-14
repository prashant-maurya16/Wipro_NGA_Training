using ClassLibrary1;
using System;


namespace ClassLibrary1
{
    public class Class1
    {
        public int Id= 4;  //private accesses specifier
        public void display()
        {
            Console.WriteLine(Id);  //you can access private member within that type(class)
        }

    }

    public class Class2 : Class1
    {
        public void display()
        {
            Console.WriteLine(Id);  //you cannot access private member withn drive  type(class) in same assembly as well
        }
    }


    public class Class3
    {
        public void display()
        {
            Class1 obj = new Class1();
           
            Console.WriteLine(obj.Id);  //you cannot access private member within Undrive type(class) in same assembly as well
        }
    }

}

