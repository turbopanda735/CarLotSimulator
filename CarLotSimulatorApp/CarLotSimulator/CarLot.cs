using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
    class CarLot
    {
        public CarLot() { }
        public CarLot(List<Car> myCarLot)
        {
            MyCarLot = myCarLot;
        }
        public List<Car> MyCarLot { get; set; } = new List<Car>();
        public void LotInventory(List<Car> carLot)
        {
            foreach (Car car in carLot)
                Console.WriteLine($"This driveable ?{car.IsDriveable}? {car.Year} {car.Make} {car.Model} goes {car.EngineNoise} when it starts and {car.HonkNoise} when they're cut off in traffic.");
        }
        public List<Car> NewCar(Car car, List<Car> cars)
        {
            cars.Add(car);
            return cars;
        }
    }
}
