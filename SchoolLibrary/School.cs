using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolLibrary
{
    class School
    {

        string Name { get; set;}
        string Address { get; set; }
        string City { get; set; }
        string State { get; set; }
        string Zip { get; set; }
        string Number { get; set; }
        string _twitterAddress;
        string TwitterAddress
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
    }
}
