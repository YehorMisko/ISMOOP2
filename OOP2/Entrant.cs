using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    class Entrant : Person
    {
        public int ZNOScore { private get; set;}
        public int CertificateScore {private get; set; }
        public string SchoolName { private get; set; }
        public Entrant() :base()
        {
            ZNOScore = 0;
            CertificateScore = 0;
            SchoolName = "ZHMHH";
        }
        public Entrant(string name, string surname,int znoscore, int certificatescore) :base(name, surname)
        {
            ZNOScore = znoscore;
            CertificateScore = certificatescore;
        }
        public Entrant(string name, string surname, DateTime dateofbirth, int znoscore, int certificatescore, string schoolname) :base(name,surname, dateofbirth)
        {
            ZNOScore = znoscore;
            CertificateScore = certificatescore;
            SchoolName = schoolname;
        } 
        public new void ShowInfo()
        {
            Console.WriteLine($"{Name} {Surname} born {DateOfBirth.Date.ToShortDateString()}.\n" +
                $"Finished {SchoolName} school with an overall score of {CertificateScore}.\n" +
                $"Passed the ZNO test with a {ZNOScore} score.\n");
        }
        public string GetSchoolName()
        {
            return SchoolName;
        }
        public int GetCertificateScore()
        {
            return CertificateScore;
        }
        public int GetZNOScore()
        {
            return ZNOScore;
        }
    }
}
