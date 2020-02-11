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
        // Constructor 
        public School()
        {
            Name = "Untitled School";
            Number = "555-1234";
        }

        // Constructor with Parameters
        public School(string SchoolName, string SchoolNumber)
        {
            Name = SchoolName;
            Number = SchoolNumber;
        }

        //public float AvgThreeScores(float a, float b, float c)
        //{
        //    var result = (a + b + c) / 3;
        //    return result;
        //}

        // Function bodies expression - a more concise way to write a function (simple logic)
        public float AvgThreeScores(float a, float b, float c) => (a + b + c) / 3;

        public int AvgThreeScores(int a, int b, int c)
        {
            var result = (a + b + c) / 3;
            return result;
        }
    }
}
