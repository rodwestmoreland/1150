using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewtLibs
{
    class Message
    {
        public string StoryTitle { get; set; }
        public string UserName { get; set; }
        
        public Message(string title)
        {
            StoryTitle = title;
        }

        public void SetStoryTitle()
        {
            Console.Clear();
            Console.Title = "NewtLibs - " + StoryTitle;
            Console.WriteLine(StoryTitle);
            Console.WriteLine();

        }
    }
}
