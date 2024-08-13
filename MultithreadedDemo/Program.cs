using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultithreadedDemo
{
    public class Program
    {
        static AutoResetEvent javaEvent = new AutoResetEvent(true);
        static AutoResetEvent netEvent = new AutoResetEvent(false);
        static AutoResetEvent pythonEvent = new AutoResetEvent(false);

        static void Main(string[] args)
        {
            for (int i = 0; i < 3; i++)
            {
                //Create threads for each work
                Thread javaThread = new Thread(PrintJava);
                Thread netThread = new Thread(PrintNet);
                Thread pythonThread = new Thread(PrintPython);

                //Start the thread
                javaThread.Start();
                //wait for java thread
                javaThread.Join();
                netThread.Start();
                netThread.Join();
                pythonThread.Start();
                pythonThread.Join();
            }
            Console.WriteLine("All threads completed");
            Console.ReadKey();
        

        }

        //Java-method for print java
        static void PrintJava()
        {
            javaEvent.WaitOne();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Java");
                //Simulate some data
                Thread.Sleep(100);
                netEvent.Set();
            }
        }


        //.Net-method for print .Net
        static void PrintNet()
        {
            for (int i = 0; i < 5; i++)
            {
                netEvent.WaitOne();
                Console.WriteLine(".Net");
                //Simulate some data
                Thread.Sleep(100);
                pythonEvent.Set();


            }

        }

        //Python-method for print Python
        static void PrintPython()
        {
            for (int i = 0; i < 5; i++)
            {
                pythonEvent.WaitOne();
                Console.WriteLine("Python");
                //Simulate some data
                Thread.Sleep(100);
                javaEvent.Set();
            }

        }

    }
}




