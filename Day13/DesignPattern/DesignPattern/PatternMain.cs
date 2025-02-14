﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    internal class PatternMain
    {

        public static void Main1(string[] args)
        {
            //  Singleton s = new Singleton();

            Singleton user1 = Singleton.GetInstance();
            user1.Display("Data fetched by user 1");

            Singleton user2 = Singleton.GetInstance();
            user2.Display("Data fetched by user 2");

        }


    }
}
