using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Dealership_App
{
    class UsedCar: Car
    {
        private double mileage;

        public double Mileage
        {
            get
            {
                return mileage;
            }
            set
            {
                mileage = value;
            }             
        }
        public UsedCar(string make, string model, int year, double price, double mileage): base(make, model, year, price)
        {

            Mileage = mileage;
        }
        public override string ToString()
        {
            string result = base.ToString() + $" Used Car {Mileage, -10}";// overrides the cars returning a formatted string
            return result;
        }
    }  
}
