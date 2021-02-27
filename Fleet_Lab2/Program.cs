using System;
using System.Collections.Generic;
using System.Linq;

namespace Fleet_Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Collection of cars
            List<Car> fleet = new List<Car>();

            Car c1 = new Car("VW", "Club UP!", "DL123F5", 999);
            Car c2 = new Car("Toyota", "Avensis", "KJ875IE", 1600);
            Car c3 = new Car("Peugeot", "800", "EP13335", 1200);
            Car c4 = new Car("Skoda", "Octavia", "JI456II", 1800);
            Car c5 = new Car("Mazda", "RX7", "CI456II", 1600);
            Car c6 = new Car("Skoda", "Surpeb", "XI00000", 1800);


            fleet.Add(c1);
            fleet.Add(c2);
            fleet.Add(c3);
            fleet.Add(c4);
            fleet.Add(c5);
            fleet.Add(c6);

            Console.WriteLine("List all cars in ascending reg order (by default it is ascending)!!");
            var output1 = fleet.OrderBy(car => car.Registration)
                               .Select(car=> car);

            //--> for loop to print out the transformed collection
            foreach(Car c in output1)
            {
               Console.WriteLine("\n" + c.ToString());
            }

            Console.WriteLine();
            Console.WriteLine("List all the models for all Skoda (or Mazda or whatever) cars in the fleet:");
            IEnumerable<String> output2 = fleet.Where(car => car.Make == "Skoda")
                               .OrderBy(car => car.Registration)
                               .Select(car => car.Model);

            if (output2.Count() == 0)
            {
                Console.WriteLine("\nRecord not found!");
            }
            else 
            {
                foreach (String c in output2)
                {
                    Console.WriteLine("\n" + c.ToString());
                }
            }

           


            Console.WriteLine();
            Console.WriteLine("List all cars in descending engine size order");

            var output3 = fleet.OrderByDescending(car => car.EngineSize)
                               .Select(car => car);

            foreach (Car c in output3)
            {
                Console.WriteLine("\n" + c.ToString());
            }

            Console.WriteLine();
            Console.WriteLine("List just the make and model for cars whose engine size is 1600cc!");

            var output4 = fleet.Where(car => car.EngineSize == 1600)
                               .Select(car => new { car.Make, car.Model });

            foreach (var c in output4)
            {
                Console.WriteLine("\n" + c.Make + " " + c.Model);
            }


            Console.WriteLine();
            Console.WriteLine("Count the number of cars whose engine size is 1600 cc or less");

            var output5 = fleet.Count(car => car.EngineSize <= 1600);

            Console.WriteLine(output5);


                               
                
         
        }
    }
}
