using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _05_Classes.Classes.Tests
{
    [TestClass]
    public class VehicleTest
    {
        [TestMethod]
        public void Properties()
        {
            Vehicle firstVehicle = new Vehicle("Volvo","S60",VehicleType.Car);
            firstVehicle.Make = "Volvo";
            firstVehicle.Make = "Pontiac";
            firstVehicle.Model = "firebird";
            firstVehicle.Mileage = 70000;
            firstVehicle.Type = VehicleType.Car;
            firstVehicle.Year = 1977;
            Console.WriteLine(String.Format("{0,1} {1, 15} {2, 25}",firstVehicle.Make,firstVehicle.Model,firstVehicle.Year));
        }
        [TestMethod]
        public void Running()
        {
            Vehicle nextVehicle = new Vehicle("Volvo", "S60", VehicleType.Car);
            nextVehicle.TurnOff();
            nextVehicle.IndicateLeft();
            Console.WriteLine(nextVehicle.IsRunning);

        }
    }
}
