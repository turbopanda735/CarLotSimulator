using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
    class CarLot
    {
        public static int NumberOfCars = 0;
        public List<Car> MyCarLot = new List<Car>();
        public void LotInventory()
        {
            foreach (Car car in MyCarLot)
                Console.WriteLine($"This driveable ?{car.IsDriveable}? {car.Year} {car.Make} {car.Model} goes {car.EngineNoise} when it starts and {car.HonkNoise} when they're cut off in traffic.");
            if (NumberOfCars == 0)
                Console.WriteLine($"There are no cars in this car lot.");
            if (NumberOfCars == 1)
                Console.WriteLine($"There is one car in this car lot.");
            if (NumberOfCars > 1) 
                Console.WriteLine($"There are {NumberOfCars} cars in this car lot.");
        }
        public void NewCar(Car car)
        {
            MyCarLot.Add(car);
            NumberOfCars++;
        }
    }
}
