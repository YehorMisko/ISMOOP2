using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    class LibraryUser : Person
    {
        private int IDNumber;
        private DateTime DateOfIssue;
        private int MonthlyFeeAmount;
        public LibraryUser() : base()
        {
            IDNumber = -1;
            DateOfIssue = new DateTime();
            MonthlyFeeAmount = -1;
        }
        public LibraryUser(string name, string surname, DateTime dateofbirth, int idnumber, DateTime dateofissue, int monthlypay)
             : base(name, surname, dateofbirth)
        {
            IDNumber = idnumber;
            DateOfIssue = dateofissue;
            MonthlyFeeAmount = monthlypay;
        }
        public LibraryUser(string name, string surname, int idnumber, int monthlypay)
            : base(name, surname)
        {
            IDNumber = idnumber;
            MonthlyFeeAmount = monthlypay;
        }
        public new void ShowInfo()
        {
            Console.WriteLine($"{Name} {Surname} born {DateOfBirth.Date.ToShortDateString()}.\n" +
                $"Library ID number - {IDNumber}, date of issue {DateOfIssue.Date.ToShortDateString()}, monthly fee {MonthlyFeeAmount}\n");
        }
        public void SetDateOfIssue(DateTime n)
        {
            DateOfIssue = n;
        }
        public void SetIdNumber(int n)
        {
            IDNumber = n;
        
        }
        public void SetMonthlyFee(int n)
        {
            MonthlyFeeAmount = n;
        }

    }
}
