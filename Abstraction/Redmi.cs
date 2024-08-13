using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    public class Redmi:Mobile
    {
        public override void MakeCall()
        {
            Console.WriteLine("making a call with redmi");
        }

        public override void SendSms()
        {
            Console.WriteLine("sendsms");
        }

       
    }
}
