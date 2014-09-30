using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonApp
{
    class Person
    {
        public string FirstName { private get; set; }
        public string MiddleName { private get; set; }
        public string LastName { private get; set; }
        public Person(string firstName, string middleName, string lastname):this(firstName,lastname)
        {
            MiddleName = middleName;
        }

        public Person(string firstName,string lastName):this()
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public Person()
        {
            
        }

        //public double add(double a1, double a2)
        //{
        //    return 0;
        //}
        //public double add(double a1, double a2, double b3)
        //{
        //    return 0;
        //}
      



        public string GetFullName()
        {
            return FirstName + " " + MiddleName + " " + LastName;
        }

        public string GetFullReverseName()
        {
            string fullName = GetFullName();
            char[] cArray = fullName.ToCharArray();
            string reverse = String.Empty;
            for (int i = cArray.Length - 1; i > -1; i--)
            {
                reverse += cArray[i];
            }
            return reverse;            
        }
    }
}
