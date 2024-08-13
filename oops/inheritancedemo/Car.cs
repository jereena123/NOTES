using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops.inheritancedemo
{
    public class Car
    {
        //fields for data memeber
        private string _name = string.Empty;
        private string _model = string.Empty;
        private int _year = 0;


        //default constructor
        public Car()
        {


        }

        //getters and setters
        public string Name
        {
            get { return _name; }
            set { _name = "jereena"; }
        }
        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }

        public int Year
        {
            get { return _year; }
            set { _year = value; }
        }

        //methods 
        public void DisplayInfo()
        {
            //methods
            Console.WriteLine($"Base class from car ");
            Console.WriteLine($" Name : {Name} Model :{Model}");

        }

    }
}
