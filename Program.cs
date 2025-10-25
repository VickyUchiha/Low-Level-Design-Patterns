using System;
using System.Drawing;

namespace DPatterns
{
    public class Program
    {
        static void Main(string[] args)
        {
            var parkingLot = new ParkingLot(2, 2, 2, 1);
            var manager = new ParkingManager(parkingLot);

            var bike = new Bike { LicensePlate = "TN01BU9794", Color = "black" };
            var car = new Car { LicensePlate = "TN09AB1234", Color = "Red" };

            manager.ParkVehicle(bike);
            
        }
    }
}
