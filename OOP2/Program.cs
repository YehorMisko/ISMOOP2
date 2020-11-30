using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person Danil = new Person("Danil", "NeYchista", new DateTime(2002, 01, 19));
            Danil.ShowInfo();
            //Danil = new Entrant("Danil", "NeYchista", 100, 9);
            Entrant Who = new Entrant("Vlad", "Bondarchyk", new DateTime(2000, 04, 25), 120, 10, "Zh420");
            //Danil.ShowInfo();
            Teacher Whomvst = new Teacher();
            Whomvst.Post = "Headmaster";
            Whomvst.UniversityName = "TERNOPOLSKIY PTU";
            Whomvst.SetDateOfBirth(new DateTime(1976, 12, 15));
            Whomvst.SetName("Jeff");
            Whomvst.SetSurname("Jeffchenko");
            Whomvst.Department = "science";
            Student Vova = new Student("Vova", "Kostushko", new DateTime(1941, 07, 01),130, 10, "ZOSH 1", 2,  "ZHDU", "Physics-Mathematics", "23BD-SOinf");
            Who.ShowInfo();
            Whomvst.ShowInfo();
            Vova.ShowInfo();
            LibraryUser Misha = new LibraryUser("Misha", "Leshkovich", 9943, 20000);
            Misha.SetDateOfBirth(new DateTime(2001, 02, 02));
            Misha.SetDateOfIssue(new DateTime(2012, 01, 23));
            Misha.ShowInfo();
        }
    }
}
