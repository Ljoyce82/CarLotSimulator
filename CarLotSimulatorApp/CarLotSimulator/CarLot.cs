using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    public class CarLot
    {
        public static int numberOfCars;
        public List<Car> BadJimsCarLot {  get; set; } = new List<Car>();
        public void SaleCars()
        {
            foreach (var car in BadJimsCarLot)
            {
                Console.WriteLine($"For sale {car.Year} {car.Make} {car.Model} ");
                
                if(car.Make == "Rayfield")
                {
                    car.MakeEngineNoise("Slient");
                    car.MakeHonkNoise("Beep");

                }
                else if(car.Make == "Quadra Type-66")
                {
                    car.MakeEngineNoise("MillTech Silent");
                    car.MakeHonkNoise("OOHHHHGGGAAA");
                }
            }
        }
    }
}
