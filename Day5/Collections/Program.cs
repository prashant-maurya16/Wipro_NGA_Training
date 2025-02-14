using System;
using System.Collections;

namespace Collections


{
    class Program
    {
        public static void Main(string[] args)
        {
            Class1 c = new Class1();


            // adding elements using object initializer syntax
            var arraylist = new ArrayList()
            {
                102,"Prashant", "Kumar",true , 34.50


        };

            //converting primitive to object is boxing and object to primitive is unboxing
            var fe = (int)arraylist[0]; //unboxing
            var se = (double)arraylist[4];

            Console.WriteLine($"{fe} , {se}");

            arraylist[0] = "MoreValue";
            arraylist[1] = 1101;

            // arraylist[5] = 1101;

            foreach (var item in arraylist)
            {
                Console.WriteLine(item);

            }

        }
    }

}
}
