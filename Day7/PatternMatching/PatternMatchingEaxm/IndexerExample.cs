using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewFunctionalities
{
    internal class IndexerExample
    {



    }

    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string job { get; set; }


        public Employee(int Id, string Name, string job)
        {

            // resolving the ambiguity between the local and class variable while assigning the values.
            this.Id = Id;
            this.Name = Name;
            this.job = job;


        }

        // Indexer we are creating for a class employee
        /* public Object this[int index]   //using int index
         {
             get
             {
                 if (index == 0)
                     return Id;
                 else if (index == 1)
                     return Name;
                 else if (index == 2)
                     return job;
                 else
                     return null;
             }
             set
             {
                 if (index == 0)
                     Id = Convert.ToInt32(value);
                 else if (index == 1)
                     Name = value.ToString();
                 else if (index == 2)
                     job = value.ToString();


             }

         }
        */

        // creating a string indexer
        public Object this[string N]  //using string 
        {
            get
            {
                if (N.ToUpper() == "NAME")
                    return Name;
                else if (N.ToUpper() == "JOB")
                    return job;
                else
                    return null;
            }
            set
            {

                if (N.ToUpper() == "NAME")
                    Name = value.ToString();
                else if (N.ToUpper() == "JOB")
                    job = value.ToString();


            }

        }




    }

    public class program
    {
        public static void Main(string[] args)
        {
             Employee e = new Employee(25,"prashant","NGA Trainee");
              Console.WriteLine($"value  on index:{e["Name"]}");
            Console.WriteLine($"value  on index:{e["Job"]}");


            /*  e[1] = "maurya jii";
              Console.WriteLine("AFTER changing");
              Console.WriteLine($"value  on indec:{e[1]}");
              Console.ReadKey();*/




            e["Name"] = "Prashant kumar";
            e["job"] = "Student";

            Console.WriteLine("After resetting the value ; ");
            Console.WriteLine(e["Name"]);
            Console.WriteLine(e["job"]);
            Console.ReadKey();



        }
    }
}


