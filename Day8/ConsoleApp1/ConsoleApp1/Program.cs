
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Services;

namespace ConsoleApp1
{
    

  //Custom defined Attribute
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class)]
    internal class AddMetaDataAttribute : Attribute
    {

        public string Message { get; set; }

        public AddMetaDataAttribute(string msg)
        {

            this.Message = msg;
        }
    }
}


[AddMetaData(" ghjh")]
    internal class Program
    {


        static void Main1(string[] args)
        {
            Add(23, 34);
            Add(new int[] { 4, 5, 6 });

        }

        //  [WebMethod]
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
            {
                result += number[i];
                Console.WriteLine(result);

            }
            Console.WriteLine(result);
            return result;

        }

        public static void Update()
        { }

        public static void Delete()
        { }

    }
}




