using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    public abstract class Mobile
    {
        //unimplemented methods
        public abstract void MakeCall();
        public abstract void SendSms();

        //concrete methods
        public void DisplayInfo()
        {
            Console.WriteLine("this is the mobile phone");

           
        }
    }
}
