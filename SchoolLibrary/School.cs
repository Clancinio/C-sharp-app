using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolLibrary
{
    public class School
    {

        public string Name { get; set;}
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Number { get; set; }
        private string _twitterAddress;
        public string TwitterAddress
        {
            // Make sure the twitter address starts with an @ symbol 
            get { return _twitterAddress; }
            set
            {
                if (value.StartsWith("@"))
                {
                    _twitterAddress = value;
                } else
                {
                    throw new Exception("Twitter address must begin with @");
                }

            }
        }

        public School()
        {
            Name = "Untitled School";
            Number = "555-1234";
        }

        public School(string SchoolName, string SchoolNumber)
        {
            Name = SchoolName;
            Number = SchoolNumber;
        }
    }
}
