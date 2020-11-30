using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    class Person
    {
        protected string Name;
        protected string Surname;
        protected DateTime DateOfBirth;
        public Person(string name, string surname)
        {
            Name = name;
            Surname = surname;
            DateOfBirth = new DateTime();
        }
        public Person()
        {
            Name = "-";
            Surname = "-";
            DateOfBirth = new DateTime();
        }
        public Person(string name, string surname, DateTime datetime)
        {
            Name = name;
            Surname = surname;
            DateOfBirth = datetime;
        }
        public string GetName()
        {
            return Name;
        }
        public string GetSurname()
        {
            return Surname;
        }
        public DateTime GetDateOfBirth()
        {
            return DateOfBirth;
        }
        public void SetName(string name)
        {
            Name = name;
        }
        public void SetSurname(string surname)
        {
            Surname = surname;
        }
        public void SetDateOfBirth(DateTime datetime)
        {
              DateOfBirth = datetime;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"{Name} {Surname} born {DateOfBirth.Date.ToShortDateString()}\n");
        }

    }
}
