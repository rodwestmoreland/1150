﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_RepoPattern
{
    public class CT_Repo
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

        public List<StreamingContent> GetContents()
        {
            
            return _directory;
        }

        public List<StreamingContent> GetFamilyContent()
        {

            List<StreamingContent> list = new List<StreamingContent>();
            foreach (StreamingContent movie in _directory)
            {
                if (movie.IsFamilyFriendly)
                {

                    return list;

                }
            }
            return list;
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
            foreach (StreamingContent content in _directory)
            {
                if (title.ToLower() == content.Title.ToLower()) { return content; }
            }
            return null;
        }

    }// \class

}
