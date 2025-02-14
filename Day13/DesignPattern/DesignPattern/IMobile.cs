using DesignPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    internal interface IMobile
    {

        void GetModelDetails();
    }
}


public class iPhone:IMobile
{
    public void GetModelDetails()
    {
        Console.WriteLine("I phone");
    }
}
public class Android : IMobile
{

    public void GetModelDetails()
    {
        Console.WriteLine("Android phone");
    }
}
