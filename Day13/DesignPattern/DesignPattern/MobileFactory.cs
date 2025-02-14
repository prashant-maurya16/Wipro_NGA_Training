using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    internal interface MobileFactory
    {
public static IMobile GetMobile(string type)
        {
            if(type.ToLower()=="Android")
            {
                return new Android();
            }
            else if (type.ToLower()=="IPhone")
            {

                return new I Phone();
            }
        }

    }
}
