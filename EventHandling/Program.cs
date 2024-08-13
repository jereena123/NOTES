using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EventHandling
{
    
   
        //1-defining the delegate
        public delegate string WelcomeDelegate(string userName);
        public class Program
        {
            //2-Declaring an event using Event Handler(delegate)
            //Event handling requires delgate implemntaion to dispatch events
            event WelcomeDelegate welComeEvent;

            public Program()
            {
                //3-attaching method or function to the event
                welComeEvent += new WelcomeDelegate(this.Welcome);
            }


            static void Main(string[] args)
            {
                //4-Invoking-dispatching
                Program objProgram = new Program();
                string result = objProgram.welComeEvent("uyhea");
                Console.WriteLine(result);

                Console.ReadKey();
            }
            //method
            public string Welcome(string userName)
            {

                return "You are logged as :" + userName;
            }
        }
    }

