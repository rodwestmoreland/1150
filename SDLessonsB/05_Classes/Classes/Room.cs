using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Classes.Classes
{
    public class Room
    {
        //props: L,W,H,Surface area,Volume
        //    empty and full constructor
        public int      Length { get; set; }
        public int      Width { get; set; }
        public int      Height { get; set; }
        private double   SurfaceArea { get; set; }
        private double   Volume { get; set; }

        public Room(int len, int width, int height)
        {
            Length = len;
            Width = width;
            Height = height;
        }
        public Room() { }

        public double getSurface()
        {
            SurfaceArea = Length * Width * Height;
            return SurfaceArea;
        }
        public double getSurface(int length, int width, int height)
        {
            SurfaceArea = length * width * height;
            return SurfaceArea;
        }

        public double getVolume()
        {
            Volume = 2 * (Length * Width * Height);
            return Volume;
        }
        public double getVolume(int length, int width, int height)
        {
            Volume = 2 * (length * width * height);
            return Volume;
        }
    }
}
