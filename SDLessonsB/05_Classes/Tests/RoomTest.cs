using _05_Classes.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _05_Classes.Tests
{
    [TestClass]
    public class RoomTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Room room = new Room(3,3,6);
            double surface = room.getSurface();
            double volume = room.getVolume();
            
            Room newRoom = new Room();
            double surface2 = room.getSurface(3,3,6);
            double volume2 = room.getVolume(3,3,6);

            Console.WriteLine($"Surface area: {surface} Volume: {volume}");
            Console.WriteLine($"Surface area: {surface2} Volume: {volume2}");
        }
    }
}
