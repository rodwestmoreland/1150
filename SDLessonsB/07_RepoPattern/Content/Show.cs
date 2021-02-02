using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_RepoPattern.Content
{
    public class Show:StreamingContent
    {
        //episodeCount and AvgRunTime to use Episodes prop
        public int SeasonCount { get; set; }

        public int EpisodeCount { 
            get 
            { return Episodes.Count; } 
        }
        public double AvgRunTime { 
            get 
            {
                double totalRun = 0;
                foreach (Episode episode in Episodes)
                {
                    totalRun += episode.RunTime;
                }
                return totalRun / EpisodeCount;
            } 
        }

        public List<Episode> Episodes { get; set; } = new List<Episode>();
        
    }

    public class Episode
    {
        public string Title { get; set; }
        public double RunTime { get; set; }
        public int SeasonNumber { get; set; }
        
    }
}
