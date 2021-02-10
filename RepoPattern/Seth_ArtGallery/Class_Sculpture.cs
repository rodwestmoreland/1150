using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seth_ArtGallery
{
    public class Class_Sculpture : IArt
    {
        public string Artist { get;  }
        public string Title { get; }
        public decimal Value { get; set; }
        public DateTime Created { get;  }
        public double Weight { get; set; }

        public Class_Sculpture(string artist, string title, DateTime created, double weight)
        {
            Artist = artist;
            Title = title;
            Created = created;
            Weight = weight;

        }
    }
}
