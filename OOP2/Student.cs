using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    class Student : Entrant
    {
        public int Year { get; set; }
        public string Group { get; set; }
        public string UniversityName { get; set; }
        public string Faculty { get; set; }
        public Student() : base()
        {
            Year = 0;
            Group = "Unassigned";
            UniversityName = "Unassigned";
            Faculty = "Unassigned";
        }
        public Student(string name, string surname, DateTime datetime, int znoscore,
            int schoolscore, string schoolname, int year, string universityname, string faculty, string group) : base(name, surname, datetime, znoscore, schoolscore, schoolname)
        {
            Year = year;
            Group = group;
            UniversityName = universityname;
            Faculty = faculty;
        }
        public Student(string name, string surname, int znoscore,
            int schoolscore, int year, string universityname, string faculty) : base(name, surname, znoscore, schoolscore)
        {
            Year = year;
            Group = Group;
            Faculty = faculty;
        }
        public new void ShowInfo()
        {
            Console.WriteLine($"{Name} {Surname} born {DateOfBirth.Date.ToShortDateString()}.\n" +
                $"Finished {GetSchoolName()} with an overall score of {GetCertificateScore()}.\n" +
                $"Passed the ZNO test with a {GetZNOScore()} score.\n" +
                $"Now stuyding at {UniversityName}, {Year} year, {Faculty} faculty, {Group} group\n");
        }

    }
}
