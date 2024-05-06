using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
     public class Car
    {
        public string Make { get; set; }

        public string Model { get; set; }

        public int Year { get; set; }

        public string EngineNoise { get; set; }

        public string HonkNoise { get; set; }

        public bool IsDriveable { get; set; }

        //Random Price = new Random(150000, 300000);


        public void MakeEngineNoise(string engineNoise)
        {
            EngineNoise = engineNoise;
            Console.WriteLine($"The {Year} {Make} {Model} is top line luxery sports car, all leather interior with bullet proof shutters\nnever worry about your drive in Night City again, No one will hear you with this {engineNoise} engine sneak past\nthose bad situations! ");
        }

        public void MakeHonkNoise(string honkNoise)
        {
            HonkNoise = honkNoise;
            Console.WriteLine($"Dont wanna sneak! Let them know your coming with the customizable AI horn make it sound like anything you want.\nDefault noise is {HonkNoise} best part is you can drive it home today {IsDriveable} Price: €$ 150,000 EuroDollers!");
        }

        public Car(int year, string make, string model, bool isDriveable)
        {
            Year = year;
            Make = make;
            Model = model;
            IsDriveable = true;
        }

        public Car()
        {

        }
    }

    
}
