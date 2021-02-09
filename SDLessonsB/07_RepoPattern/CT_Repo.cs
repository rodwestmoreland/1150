using System.Collections.Generic;
using System.Linq;

namespace _07_RepoPattern
{
    public class CustomerTracker_Repo
    {
        public int ContentCount
        { get { return _directory.Count; } }
        // this is the repo pattern? (store a private list of items)
        private readonly List<CustomerTracker> _directory //= new List<CustomerTracker>();
        // do CRUD

        public bool AddCustomerToDirectory(CustomerTracker content)
        {
            int startCount = _directory.Count;
            _directory.Add(content);

            bool WasAdded = (_directory.Count > startCount);
            return WasAdded;
        }

        public bool UpdateContent(int id, CustomerTracker newContent)
        {
            CustomerTracker oldContent = GetContentById(id);
            if (oldContent != null)
            {
                oldContent.LastName = newContent.LastName;
                oldContent.Age = newContent.Age;
                oldContent.DateEnrolled = newContent.DateEnrolled;

                return true;
            }
            return false;
        }


        public bool DeleteContent(int id)
        {
            CustomerTracker ToDelete = GetContentById(id);
            return _directory.Remove(ToDelete);
        }

        public List<CustomerTracker> GetContents()
        {

            return _directory;
        }

        public CustomerTracker GetContentById(int id)
        {
            return _directory.SingleOrDefault(c => c.Id == id);

            //foreach (CustomerTracker content in _directory)
            //{
            //    if (id == content.Id) { return content; }
            //}
            //return null;
        }

    }// \class

}
