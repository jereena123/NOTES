using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops.inheritancedemo.model

{
    
    public class Honda : Car
    {


        private string _brand = string.Empty;

        //default constructor
        public Honda()
        {

        }

        //parameterised 
        public Honda(string brand, string _name)
        {
            this._brand = brand;

        }

        //method 
        public void DisplayBrand()
        {
            Console.WriteLine("Derived class from Honda");
            Console.WriteLine($"Brand : {_brand}");
        }


    }
}


