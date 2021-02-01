using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_InheritenceClasses.People
{
    public class User
    {
        private string _fName;
        private string _lName;
        public string PhoneNum { get; set; }
        public string Email { get; set; }
        public string Id { get; }
        public string Name 
        { 
            get
                { 
                    string fullName = $"{_fName} {_lName}";
                    if (!string.IsNullOrWhiteSpace(fullName))
                    {
                        return fullName;
                    }
                     
                     return "error. name not set";
                }
        }
        public User(string email)
        {
            Email = email;
            Id = setId();
            //create method generate random Id
            //No letter X - no vowels - at least one num
            // 16 uppercase char and nums
        }

        public static string setId()
        {
            string allowedChars = "BCDFGHJKLMNPQRSTVWXYZ0123456789";
            int length = 15;
            var createString = new StringBuilder();
            Random random = new Random();
            string num = Convert.ToString(random.Next(0, 10));
            for (var i = 0; i < length; i++)
            {
                var characters = allowedChars[random.Next(0, allowedChars.Length)];
                
                createString.Append(characters);
            }
            string newId = num + createString.ToString();
            return newId;
        }

        public void setFirstName(string name)
        {
            _fName = name;
        }
        public void setLastName(string name)
        {
            _lName = name;
        }

        

    }
}
