using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //creating an object
            Mobile redmi=new Redmi();
            redmi.SendSms();
            redmi.MakeCall();
            redmi.DisplayInfo();
            Console.ReadKey();
        }
    }
}
