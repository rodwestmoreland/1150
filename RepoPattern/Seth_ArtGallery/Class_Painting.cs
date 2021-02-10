using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seth_ArtGallery
{
    public class Class_Painting : IArt
    {
        public string Artist { get; }
        public string Title { get; }
        public decimal Value { get; set; }
        public DateTime Created { get; }
        public double Height { get; set; }
        public double Width { get; set; }


        public Class_Painting(string artist, string title, DateTime created, double height, double width)
        {
            Artist = artist;
            Title = title;
            Created = created;
            Height = height;
            Width = width;

        }
    

    }
}
