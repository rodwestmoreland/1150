using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_RepoPattern.Content
{
    public class Movie:StreamingContent
    {
        public double RunTime { get; set; }
        
        public Movie(string title, string desc, MaturityType maturity, GenreType genre, double stars, double runTime)
            :base(title, desc, maturity, stars, genre)
        {
            RunTime = runTime;
        }
    }
}
