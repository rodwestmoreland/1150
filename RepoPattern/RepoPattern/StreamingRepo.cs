using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepoPattern
{
    public class StreamingRepo
    {
        private readonly List<StreamingContent> _content = new List<StreamingContent>();


        public void AddContent(StreamingContent content)
        {
            _content.Add(content);
        }

        public List<StreamingContent> GetContents()
        {
            return _content;
        }

        public bool UpdateContents(string originalTitle, StreamingContent newContent)
        {
            StreamingContent oldContent = GetContentByTitle(originalTitle);

            if(oldContent != null)
            {

                oldContent.Title =          newContent.Title;
                oldContent.Desc =           newContent.Desc;
                oldContent.Genre =          newContent.Genre;
                oldContent.IsFamily =       newContent.IsFamily;
                oldContent.MaturityRating = newContent.MaturityRating;
                oldContent.Stars =          newContent.Stars;
                return true;
            }
            return false;

        }
        public bool DeleteContent(string title)
        {
            StreamingContent content = GetContentByTitle(title);
            if (content == null)
            {
                return false;
            }
            int oldListCount = _content.Count;
            _content.Remove(content);

            return (oldListCount > _content.Count) ? true : false;
        }



        // Helper method *****
        public StreamingContent GetContentByTitle(string title)
        {
            return _content.SingleOrDefault(x => x.Title == title);
        }
    }
}
