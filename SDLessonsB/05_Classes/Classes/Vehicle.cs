using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Classes.Classes
{
    public enum VehicleType
    {
        Car, Truck, Van, Motorcycle, Boat
    }
    public class Vehicle
    {
        public string       Make { get; set; }
        public double       Mileage { get; set; } = 0;
        public int          Year { get; set; }
        public string       Model { get; set; }
        public VehicleType  Type { get; set; }
        public bool         IsRunning { get; private set; }
        public Indicator    LeftBlink { get; set; }
        public Indicator    RightBlink { get; set; }

        public Vehicle(string make, string model, VehicleType type){
            Make =  make;
            Model = model;
            Type =  type;
        }

        public void TurnOn()
        {
            IsRunning = true;
            Console.WriteLine("running");
        }
        public void TurnOff()
        {
            IsRunning = false;
            Console.WriteLine("not running");
        }

        public void IndicateRight()
        {
            RightBlink.TurnOn();
            LeftBlink.TurnOff();
        }
        public void IndicateLeft()
        {
            RightBlink.TurnOff();
            LeftBlink.TurnOn();
        }

        public void Hazards()
        {
            RightBlink.TurnOn();
            LeftBlink.TurnOn();
        }

        public void NoIndicator()
        {
            RightBlink.TurnOff();
            LeftBlink.TurnOff();
        }

    } // class

    public class Indicator
    {
        public Indicator()    { }

        public bool IsBlinking { get; private set; } = false;
        
        public void TurnOn()
        {
            IsBlinking = true;
        }
        
        public void TurnOff()
        {
            IsBlinking = false;
        }
    }
} //ns
