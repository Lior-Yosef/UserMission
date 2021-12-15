using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkUser
{
    public class User : IComparable
    {
        string firstName;
        string lastName;
        int born;
        string email;

        public User(string firstName, string lastName, int born, string email)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.born = born;
            this.email = email;
        }
        public User() { }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string LastName
        {
            set { lastName = value; }
            get { return lastName; }
        }
        public int Born
        {
            get { return born; }
            set { born = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        protected virtual void Print()
        {
            Console.WriteLine($"first name:{this.FirstName}| last name:{this.LastName}| the born: {this.Born}| the email: {this.Email} ");
        }

        public int CompareTo(object obj)
        {
            User u = (User)obj;
            if (this.Born > u.Born)
            {
                return -1;
            }
            if (this.Born < u.Born)
            {
                return 1;
            }
            return 0;
        }
    }
}
