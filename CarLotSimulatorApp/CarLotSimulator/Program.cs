﻿using System;

namespace CarLotSimulator
{
    public class Program
    { 
        static void Main(string[] args)
        {
            var carLot = new CarLot();
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            //*************BONUS*************//

            var carOne = new Car();
            carOne.Make = "Rayfield";
            carOne.Model = "Aerondight S9";
            carOne.Year = 2077;
            carOne.IsDriveable = true;

            carLot.BadJimsCarLot.Add(carOne);

            var carTwo = new Car() { Make = "Rayfield", Model = "Caliburn", Year = 2077, IsDriveable = true };

            carLot.BadJimsCarLot.Add(carTwo);

            var carThree = new Car(2077, "Quadra Type-66", "Javelina", true);

            carLot.BadJimsCarLot.Add(carThree);

            carLot.SaleCars();

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console

        }
    }
}
