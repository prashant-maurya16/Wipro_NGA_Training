using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    




        public class Class2
        {
            public Class2()
            {


                Hashtable hashtable = new Hashtable(); //  initial capacity ,  load factor  , hashcode provider and comparer
                hashtable.Add("RollNo", "101");

                hashtable.Add("Name", "Rohan");
            //hashtable.Clear();
            

                //or 

                Console.WriteLine(hashtable["Name"]);

                foreach (object key in hashtable.Keys)
                {
                    Console.WriteLine(hashtable[key]);

                }

                foreach (DictionaryEntry items in hashtable)
                {

                    Console.WriteLine($"{items.Key} , {items.Value}");
                }

                var cities = new Hashtable()
        {
            { "UK" , "London , Manchester"},
            { "USA" , "Chicago, New Yord"},
            { "India" , "Mumbai , Delhi"}

        };



            }


        }



    
}
