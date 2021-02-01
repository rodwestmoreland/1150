using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_RepoPattern
{
    public enum GenreType { Kids, Drama, Suspense, Western, Horror, Comedy, SciFi, World }
    public enum MaturityType { G, PG, PG13, NC17, R}

    public class StreamingContent
    {
       
        public string Title { get; set; }
        public string Desc { get; set; }
        public double Stars { get; set; }
        public MaturityType Maturity { get; set; }
        public bool IsFamilyFriendly {
            get { 
                    switch(Maturity)
                    {
                        case MaturityType.G:
                        case MaturityType.PG:
                        case MaturityType.PG13:
                        
                            return true;

                        default:
                            return false;
                    }
                
                 }
        }
        public GenreType Genre { get; set; }

        public StreamingContent(){}
        public StreamingContent(string title, string desc, MaturityType maturity, double stars, GenreType genre)
        {
            Title =             title;
            Desc =              desc;
            Maturity =          maturity;
            Stars =             stars;
            
            Genre =             genre;

        }
    }
}
