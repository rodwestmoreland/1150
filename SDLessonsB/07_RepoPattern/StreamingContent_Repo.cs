using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_RepoPattern
{
    public class StreamingContent_Repo
    {
        public int ContentCount 
        { get { return _directory.Count;  } }
        // this is the repo pattern? (store a private list of items)
        private readonly List<StreamingContent> _directory = new List<StreamingContent>();
        // do CRUD

        public bool AddContentToDirectory(StreamingContent content)
        {
            int startCount = _directory.Count;
            _directory.Add(content);
            
            bool WasAdded = (_directory.Count > startCount);
            return WasAdded;
        }

        public bool UpdateContent(string title, StreamingContent newContent)
        {
            StreamingContent oldContent = GetContentByTitle(title);
            if (oldContent != null)
            {
                oldContent.Title = newContent.Title;
                oldContent.Desc = newContent.Desc;
                oldContent.Maturity = newContent.Maturity;
                oldContent.Genre = newContent.Genre;
                oldContent.Stars = newContent.Stars;
                return true;
            }
            return false;
        }


        public bool DeleteContent(string title)
        {
            StreamingContent ToDelete = GetContentByTitle(title);
            return _directory.Remove(ToDelete);
        }

        //public List<StreamingContent> GetContents()
        //{

        //    foreach(StreamingContent title in _directory)
        //    {
        //        return title.Title;
        //    }
        //}
        public string GetContents()
        {
            int i = 0;
            foreach (StreamingContent movie in _directory)
            {
                if (movie.IsFamilyFriendly)
                {
                i++;
                return movie.Title + " -- hello " + i;

                }
            }
            return "done";
        }

        public List<StreamingContent> GetFamily()
        {
            List<StreamingContent> family = new List<StreamingContent>();
            foreach(StreamingContent movie in _directory)
            {
                if (movie.IsFamilyFriendly)
                {
                    family.Add(movie);
                }
                
            }
            return family;
        }


        public StreamingContent GetContentByTitle(string title)
        {
            //return (StreamingContent)_directory.Where(c => c.Title == title);
            foreach (StreamingContent content in _directory)
            {
                if (title == content.Title) { return content; }
            }
            return null;
        }

    }// class
    //method returns list of family content
}
