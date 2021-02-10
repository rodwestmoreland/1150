using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seth_ArtGallery
{
    public class Class_Relief : Class_Sculpture
    {
        public double Height { get; set; }
        public double Width { get; set; }

        public Class_Relief(string artist, string title, DateTime created, double weight, double height, double width)
            :base(artist, title, created, weight)
        {
            Height = height;
            Width = width;
        }

    }
}
