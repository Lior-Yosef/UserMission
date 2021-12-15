using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkUser
{
    public class Student : User
    {
        public string Grade;

        public Student(string firstName, string lastName, int born, string email, string Grade) : base(firstName, lastName, born, email)
        {
            this.Grade = Grade;
        }
        protected override void Print()
        {
            base.Print();
            Console.WriteLine($"{this.FirstName},{this.LastName},{this.Born} {this.Email} {this.Grade}");
        }
    }
}
