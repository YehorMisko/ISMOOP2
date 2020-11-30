using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2 
{
    class Teacher : Person
    {
        public string Post {get; set;}
        public string Department { get; set; }
        public string UniversityName { get; set; }
        public Teacher() : base()
        {
            Post = "Unassigned";
            Department = "Unassigned";
            UniversityName = "Unassigned";
        }
        public Teacher(string name, string surname, DateTime datetime,
            string universityname, string department, string post) : base(name, surname, datetime)
        {
            Post = post;
            UniversityName = universityname;
            Department = department;
        }
        public Teacher(string name, string surname,
            string universityname, string department) : base(name, surname)
        {
            UniversityName = universityname;
            Department = department;
        }
        public new void ShowInfo()
        {
            Console.WriteLine($"{Name} {Surname} born {DateOfBirth.Date.ToShortDateString()}.\n" +
                $"Is a teacher at {UniversityName}, holding the post of {Post}, of the university's {Department} department\n");
        }
        public string GetUniversityName()
        {
            return UniversityName;
        }
        public string GetPost()
        {
            return Post;
        }
        public string GetDepartment()
        {
            return Department;
        }
    }
}
