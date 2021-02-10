using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seth_ArtGallery
{
    public class Repo_Gallery
    {
        public int Count { get => _gallery.Count; }

        private readonly List<IArt> _gallery = new List<IArt>();
     

        public void AddArt(IArt artwork)
        {
            _gallery.Add(artwork);
        }

        public List<IArt> GetArt()
        {
            return _gallery;
        }

        public IArt GetByTitle(string title)
        {
            return _gallery.SingleOrDefault(x => x.Title == title);
        }

        public void UpdateByTitle(string oldTitle, IArt newArtwork)
        {
            IArt oldArtwork = GetByTitle(oldTitle);

            // only value is declared with a getter and setter - all others would be read only
            oldArtwork.Value = newArtwork.Value;
           

        }

        public bool DeleteArt(string title)
        {
            int oldListCount = _gallery.Count;
            IArt artwork = _gallery.SingleOrDefault(x => x.Title == title);

            if (artwork == null)
            {  return false;  }

            _gallery.Remove(artwork);
            return (oldListCount > _gallery.Count) ? true : false;
        }
    }
}
