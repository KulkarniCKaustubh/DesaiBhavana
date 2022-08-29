using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalInfoLib
{
    public class Person
    {
        private string firstname;
        public string FirstName
        {
            get { return firstname; }
            set { firstname = value; }
        }

        private string lastname;
        public string LastName
        {
            get { return lastname; }
            set { lastname = value; }
        }

        private string email;
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        private DateTime birthdate;
        public DateTime BirthDate
        {
            get { return birthdate; }
            set { birthdate = value; }
        }

        public Person(string firstName, string lastName, string email, DateTime birthDate)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            BirthDate = birthDate;
        }

            public bool IsAdult()
            {
                int age = DateTime.Now.Year - birthdate.Year;



                if (age >= 18)
                {
                    return true;
                }
                else
                {
                    return false;
                }



            }
        
        public override string ToString()
        {
            return String.Format($"FirstName {FirstName}, LastName {LastName}, Email {Email}, Birthdate {BirthDate}");
        }
    }
}
