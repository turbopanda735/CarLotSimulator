using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
    internal class Car
    {
        public Car() { }
        public Car(int year, string make, string model, bool isDriveable)
        {
            Year = year;
            Make = make;
            Model = model;
            IsDriveable = isDriveable;
        }
        //Create a seperate class file called Car
        public string EngineNoise = "vroom vroom";
        public string HonkNoise = "honk honk";
        //EngineNoise and HonkNoise have default values because all cars go vroom vroom and honk honk

        //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable

        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public bool IsDriveable { get; set; }

        //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
        public void MakeEngineNoise()
        {
            Console.WriteLine(EngineNoise);
        }
        public void MakeHonkNoise()
        {
            Console.WriteLine(HonkNoise);
        }
        public void ChangeEngineNoise(string newNoise)
        {
            EngineNoise = newNoise;
        }
        public void ChangeHonkNoise(string newNoise)
        {
            HonkNoise = newNoise;
        }
        //The methods should take one string parameter: the respective noise property

    }
}
