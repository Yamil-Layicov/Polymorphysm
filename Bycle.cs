using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorhpsymTask1
{
    class Bycle
    {
        internal class Bycle : Vehicle
        {

            public Bycle(string brand, string color, double milliage) : base(brand, color, milliage)
            {

            }
            public override void Drive(double value)
            {
                Milliage += value;
            }

            public override void ShowInfo()
            {
                Console.Write("It is a Bycle Info:");
                base.ShowInfo();
                Console.WriteLine();
            }
        }
    }
}
