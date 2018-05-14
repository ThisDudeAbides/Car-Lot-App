using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Dealership_App
{
    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double Price { get; set; }

        public Car(string make, string model, int year, double price) // overloaded constructor
        {
            Make = make;
            Model = model;
            Year = year;
            Price = price;
        }
        public Car()// default constructor
        {
        }
        public override string ToString()
        {
            string result = $"{Make,-10}{Model,-10}{Year,- 10}{Price, -10}";
            return result;
        }
    }
}   
