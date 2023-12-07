using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


   /*prvo se kopira kod (pa desnim klikom misa na Solution) +add + new 
    projeck + u pretrazi ukucam .dll sacekam da se pojavi C# dll 
    + dam mu ime dll fajla pa promenim klasu
    u klasu koju koristim nakon toga probam da li radi ,ako ne radi idem 
    (desnim klikom misa na dll file da ga povezem ) add + reference */

namespace Eksterni_NameSpace1
{
    class A
    {
        public static void Eksaterni1Print()
        {
            Console.WriteLine("Ekstesni 1");
        }
    }
}
class B
{
    public static void Eksaterni2Print()
    {
        Console.WriteLine("Ekstesni 2");
    }
}

