using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_Ado
{
    //1-defining a delegate
    public delegate void RectangleDelegate(double Width, double Height);
    public class multicast_demo
    {
        //2-Define Event
        event RectangleDelegate rectEvent;
        static void Main(string[] args)
        {
            multicast_demo obj=new multicast_demo();


            //3-subscribing  to the event
            obj.rectEvent += obj.GetArea;
            obj.rectEvent += obj.GetPerimeter;

            //Printing output
            Console.WriteLine("Event is processing");
            obj.rectEvent(10.5, 9.8);
            Console.ReadKey();
        }
        public void GetArea(double Width, double Height)
        {
            Console.WriteLine("AREA {0}", (Width * Height));
        }

        public void GetPerimeter(double Width, double Height)
        {
            Console.WriteLine("PERIMETER : {0}", (Width + Height));
        }
    }
}
