
using System;
using System.Collections.Generic;
using static System.Net.WebRequestMethods;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Dealership
{
    class Cars
    {
        //1.Ask the user how many cars are in the dealership.
        static void Main(string[] args)
        {
            Console.WriteLine("How many cars do you have in the dealership?: ");
            int cars = Convert.ToInt32(Console.ReadLine());
            //2.For each car, ask for:
            //horsepower / HP(int)
            //price in euros(double)
            //fuel consumption in liters / 100km(double)
            //and fill the corresponding 3 lists.
            List<int> horsepower_list = new List<int>();
            List<double> price_list = new List<double>();
            List<double> liters_list = new List<double>();

            for (int i = 0; i < cars; i++)
            {
                Console.Write($"Write the horsepower for car {i + 1}");
                int horsepower=Convert.ToInt32(Console.ReadLine());
                horsepower_list.Add( horsepower );

                Console.WriteLine($"Write the price for car {i + 1}");
                double price=Convert.ToDouble(Console.ReadLine());
                price_list.Add(price);

                Console.WriteLine($"Write the liters for car {i + 1}");
                double liters=Convert.ToDouble(Console.ReadLine());
                liters_list.Add(liters);
            }
            //3. Print for each car: HP / price / consumption.
            for (int i=0; i< horsepower_list.Count; i++)
            {
                Console.WriteLine($"For car {i + 1} horsepower is: {horsepower_list[i]}, price: {price_list[i]}, liters: {liters_list[i]}");

            }
            //4.Find and print:
            // a) How many cars cost less than 15,000 euros.
            int count_cars_less_15000 = 0;
            for (int i=0; i<price_list.Count; i++)
            {
                if (price_list[i]<15000)
                {
                    count_cars_less_15000++;
                }
            }
            Console.WriteLine($"Less than 1500euros cost {count_cars_less_15000} cars");
            Console.WriteLine("")

            //b) How many cars have HP > 100 AND consumption < 6.0
            int count_horsepower = 0;
            int count_liters_less_6 = 0;
            for (int i=0; i<horsepower_list.Count; i++)
            {
                if (horsepower_list[i]>100 && liters_list[i]<6.0)
                {
                    count_horsepower++;
                    count_liters_less_6++;
                }
            }
            Console.WriteLine($"Cars with HP > 100 are {count_horsepower} AND consumption < 6.0 are {count_liters_less_6} ");
            Console.WriteLine("")

            //The average price of all cars.
            double suma_price = 0;
            for (int i=0; i<price_list.Count; i++)
            {
                suma_price = suma_price + price_list[i];
            }
            double mean_price = suma_price / price_list.Count;
            Console.WriteLine($"The mean price of all cars is {mean_price}");

            //c) The average  consumption ONLY for cars that have HP > 120.
            double suma_liters = 0;
            for (int i=0; i < liters_list.Count; i++)
            {
                if (horsepower_list[i]>120)
                {
                    suma_liters=suma_liters + liters_list[i];
                }
            }
            double mean_liters = suma_liters / liters_list.Count;
            Console.WriteLine($"The average  consumption ONLY for cars that have HP > 120 is {mean_liters}");
            Console.WriteLine("")

            //d)The maximum (max) price. Which car has it (position/index)? 
            //What is the HP and the consumption of this specific car?
            double max_price = price_list[0];
            int pos = 0;
            for (int i=0; i<price_list.Count; i++)
            {
                if (price_list[i]> max_price)
                {
                    max_price= price_list[i];
                    pos = i;
                }
            }
            Console.WriteLine($"The max price is {max_price} with possision {pos + 1} and horsepower possision {liters_list[pos]}");
        }

    }
}
