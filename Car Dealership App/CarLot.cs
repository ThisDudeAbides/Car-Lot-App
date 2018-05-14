using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Dealership_App
{
    class CarLot
    {
        public static List<Car> GetCars()
        {
            List<Car> AllCars = new List<Car>();

            AllCars.Add(new Car("Ford", "Escape", 2018, 23940));
            AllCars.Add(new Car("Ford", "F150", 2017, 27110));
            AllCars.Add(new Car("Ford", "EcoSport", 2018, 19995));
            AllCars.Add(new UsedCar("Kia", "Rio", 2014, 7495,72394));
            AllCars.Add(new UsedCar("Nissan", "Sonic", 2013, 8700,47993));
            AllCars.Add(new UsedCar("Toyota", "Camry", 2010, 8150,126861));

            return AllCars;
        }
        public static void PrintInfo(List<Car> CarList)
        {
            int count = 0;
            foreach (Car C in CarList)
            {
                count++; // increases the index count by 1
                Console.WriteLine($"{count, -5}"+ C.ToString());// - 5 formats string 
            }
        }
        public static void AddCars(List<Car> CarList) // method to add cars to list
        {
            Console.WriteLine("is the car you would like to add a (1)new car or a (2)used car?");
            string UsedNew = Console.ReadLine();

            if (UsedNew == "1")
            {
                Console.WriteLine("what is the make of your car?");
                string InputMake = Console.ReadLine();
                Console.WriteLine("what is the model of your car?");
                string InputModel = Console.ReadLine();
                Console.WriteLine("what is the year of the car?");
                int InputYear = int.Parse(Console.ReadLine());
                Console.WriteLine("what is the price of your car?");
                double InputPrice = double.Parse(Console.ReadLine());

                Car New1 = new Car(InputMake, InputModel, InputYear, InputPrice);
                CarList.Add(New1); // once car is added, the care is stored to car list
            }
            else if (UsedNew == "2")
            {
                Console.WriteLine("what is the make of your car?");
                string InputMake = Console.ReadLine();
                Console.WriteLine("what is the model of your car?");
                string InputModel = Console.ReadLine();
                Console.WriteLine("what is the year of the car?");
                int InputYear = int.Parse(Console.ReadLine());
                Console.WriteLine("what is the price of your car?");
                double InputPrice = double.Parse(Console.ReadLine());
                Console.WriteLine("what is the mileage of your car?");
                double InputMileage = double.Parse(Console.ReadLine());

                UsedCar used1 = new UsedCar(InputMake, InputModel, InputYear, InputPrice, InputMileage);
                CarList.Add(used1);

            }
        }         
        public static void RemoveCars(List<Car> CarList)// method removes car from the list
        {
            bool repeat = true;
            int buyCar = 0;
            while (repeat)
            {
                PrintInfo(CarList);
                Console.WriteLine("would you like to buy a car? (1)buy (2)No I dont want to by a car");
                bool Check = int.TryParse(Console.ReadLine(), out buyCar);
                if ( Check == true )
                {
                    if (buyCar == 1 || buyCar == 2)
                    {
                        repeat = false;
                        
                    }
                    else
                    {
                        Console.WriteLine("error! invalid input. Please pick a number");
                    }
                }
                else
                {
                    Console.WriteLine("error! invalid input. Please pick a number");
                }
            }
                if (buyCar == 1)
                {
                    Console.WriteLine("which car would you like to buy? please pick a number from the list?");
                    int ListNum = int.Parse(Console.ReadLine());

                    CarList.RemoveAt(ListNum - 1);
                }                      
        }
        public static void IndexSearch(List<Car> CarList)//method searches car in list 
        {           
            Console.WriteLine("please enter a number to look up");
            int CarNum = int.Parse(Console.ReadLine());

            Console.WriteLine(CarList[CarNum -1]);
        }
        public static void ReplaceCar(List<Car> CarList)// method to replace car from the list based upon selection in list
        {
            Console.WriteLine("please enter a number for the car you would like to replace");
            int CarReplace = int.Parse(Console.ReadLine());

            Console.WriteLine("what is the make of your car?");
            string InputMake = Console.ReadLine();
            Console.WriteLine("what is the model of your car?");
            string InputModel = Console.ReadLine();
            Console.WriteLine("what is the year of the car?");
            int InputYear = int.Parse(Console.ReadLine());
            Console.WriteLine("what is the price of your car?");
            double InputPrice = double.Parse(Console.ReadLine());

            Car New1 = new Car(InputMake, InputModel, InputYear, InputPrice);
            CarList[CarReplace - 1] = New1;
        }


    }
}
