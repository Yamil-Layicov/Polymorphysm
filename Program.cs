using System;

namespace PolymorhpsymTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("BMW", "Black", 1500, 120, 50, 5);
            Bycle bycle = new Bycle("Yamaha", "Red", 130);

            car.ShowInfo();
            bycle.ShowInfo();

            car.Drive(5);
            bycle.Drive(5);

            car.ShowInfo();
            bycle.ShowInfo();

        }
    }
}
