using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtentionMethod
{
    sealed class vehicle
    {
       
        int Speed = Convert.ToInt32(Console.ReadLine());

        public void speed()
        {
            if (Speed > 90)
            {
                Console.WriteLine("Slow down Your vehicle..!It may couse of accident...!!!!");
            }
            else
            {
                Console.WriteLine("Drive sAFELY");
            }
        }

        public void milage()
        {
            Console.WriteLine("Your car have  35km/h milage ");
        }
    }


    static class Car
    {
       public static void Drive(this vehicle V, int s)
        {
            Console.WriteLine($"Maximum speed of the car is {s}");

        }
    }

    internal class PracticeExtention
    {
        public static void Main4(string[] args)
        {
            vehicle V = new vehicle();

            V.speed();
            V.milage();
            V.Drive(50);
            Console.ReadKey();
            

        }






    }
}
