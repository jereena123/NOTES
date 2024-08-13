/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MulticastDelegate
{
    //1-Define a Delegate
    public delegate void RectangleDelegate(double Width, double Height);
    public class Program
    {
        static void Main(string[] args)
        {
            Program obj = new Program();
            //2 Instantiating Delegate
            RectangleDelegate objRectDele = new RectangleDelegate(obj.GetArea);

            //3.Invoke

            objRectDele.Invoke(100.5, 110.8);

            //Multicast
            Console.WriteLine("Perimeter is Processing");
            objRectDele += obj.GetPerimeter;
            objRectDele.Invoke(10.1, 12.5);

            //removing area
            Console.WriteLine("Removing Area");
            objRectDele -= obj.GetArea;
            Console.WriteLine("Delegate is processing...");
            objRectDele.Invoke(5.4, 15.6);

            Console.ReadKey();
        }
        //GETAREA METHOD
        public void GetArea(double Width, double Height)
        {
            Console.WriteLine("AREA {0}", (Width * Height));
        }

        public void GetPerimeter(double Width, double Height)
        {
            Console.WriteLine("PERIMETER : {0}", (Width + Height));
        }

    }
}*/