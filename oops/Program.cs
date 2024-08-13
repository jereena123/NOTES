using oops.inheritancedemo;
using oops.inheritancedemo.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace inheritancedemo
{
    public class Program

    {
        static void Main(string[] args)
        {
            ///create an instane 

            /*new Car(); //anonymous object */

            Car objMaruthi = new Car(); // caer obj reference to car itself
            objMaruthi.Name = "Maruthi";
            objMaruthi.Model = "aAlto";
            objMaruthi.Year = 2002;

            objMaruthi.DisplayInfo();

            //create a child object 

            Honda objHonda = new Honda();
            objHonda.Name = "Hero";
            objHonda.Model = "Nexon";
            objHonda.Year = 2010;
            objHonda.DisplayInfo();
            objHonda.DisplayBrand();

            

            Console.ReadKey();

            /* output 
             * Base class from car
 Name : Maruthi Model :aAlto
Base class from car
 Name : Hero Model :Nexon
Derived class from Honda
Brand :
            */



        }
    }
}