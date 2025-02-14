using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classObj
{
    internal class PracticingClass
    {

        class Dog
        {

            string breed;
            public void bark()
            {
                Console.WriteLine("Bark.....bark..bark");
            }

            static void main(string[] args)
            {
                Dog D = new Dog();
                D.breed = "Labra";
                Console.WriteLine(D.breed);
                D.bark();
                Console.ReadLine();

            }
        }
    }
}
