using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TrafficLightmultithreading
{
    public class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 3; i++)
            {
                Thread javathread = new Thread(Red);
                Thread netthread = new Thread(Green);
                Thread dotthread = new Thread(Yellow);


                javathread.Start();
                javathread.Join();
                netthread.Start();
                netthread.Join();
                dotthread.Start();
                dotthread.Join();
            }
            Console.ReadKey();
        }
        static void Red()
        {
            Console.WriteLine("Stop");
            Thread.Sleep(1000);
        }
        static void Green()
        {
            Console.WriteLine("GO");
            Thread.Sleep(1000);
        }
        static void Yellow()
        {
            Console.WriteLine("wait");
            Thread.Sleep(1000);
        }
        
    }
}
