using System;
using System.Collections.Generic;

namespace CarLotSimulator
{
    class Program
    {
        static void Main()
        {
            //DONE
            var testCarLot = new CarLot();

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car
            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car
            testCarLot.LotInventory();

            var myCar = new Car()
            {
                Year = 2023,
                Make = "Subaru",
                Model = "Forester",
                IsDriveable = true,
            };
            testCarLot.NewCar(myCar);
            testCarLot.LotInventory();

            var dreamCar = new Car();
            dreamCar.Year = 2030;
            dreamCar.Model = "Subaru";
            dreamCar.Model = "Fart Car";
            dreamCar.IsDriveable = true;
            testCarLot.NewCar(dreamCar);

            dreamCar.ChangeHonkNoise("toot toot");
            Console.WriteLine("my car go...");
            dreamCar.MakeHonkNoise();
            testCarLot.LotInventory();

            var thirdCar = new Car(2001, "Toyota", "Corolla", false);
            testCarLot.NewCar(thirdCar);

            thirdCar.ChangeEngineNoise("clunk clunk clunk");
            thirdCar.ChangeHonkNoise("AWOOGA AWOOGA");

            //*************BONUS X 2*************//
            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
            testCarLot.LotInventory();
        }
    }
}
