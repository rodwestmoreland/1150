using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepoPattern
{
    public enum GenreType { Action = 1, Comedy, SciFi, Western, Drama }
    public class StreamingContent
    {

        public string Title { get; set; }
        public string Desc { get; set; }
        public string MaturityRating { get; set; }
        public double Stars { get; set; }
        public bool IsFamily { get; set; }
        public GenreType Genre { get; set; }

        public StreamingContent() { }
        public StreamingContent(string title, string desc, string mature, double stars, bool family, GenreType genre)
        {
            Title = title;
            Desc = desc;
            MaturityRating = mature;
            Stars = stars;
            IsFamily = IsFamily;
            Genre = genre;
        }
       
    }
}
