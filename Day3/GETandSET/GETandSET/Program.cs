using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GETandSET
{
    internal class Program
    {

        public int AGE { get; set; }
        public string NAME { get; set; }


        /*  public int A
          {
              get { return a; }
              set { a = value; }
          }
          public string Name
          {
              get { return name; }
              set { name = value; }
          }*/








    }
    public class GetandSet
    {
        static void Main(string[] args)
        {
            Program p = new Program();

            p.AGE = (int)7;
               
            p.NAME = "rahul";
            Console.WriteLine(p.AGE);
            Console.WriteLine(p.NAME);
            Console.ReadLine();


        }
    }
}
