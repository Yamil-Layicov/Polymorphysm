using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorhpsymTask1
{
    class vehicle
    {
        internal abstract class Vehicle
        {
            public string Color { get; set; }
            public string Brand { get; set; }

            public double Milliage { get; set; }

            public Vehicle(string brand, string color, double milliage)
            {
                Color = color;
                Brand = brand;
                Milliage = milliage;
            }


            public virtual void ShowInfo()
            {
                Console.Write($"Brand - {Brand}Color - {Color}Millage - {Milliage}");
            }

            public abstract void Drive(double value);
        }
    }
}
