using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Birthdays
{
    public class Person
    {
        private string firstName;
        private string lastName;
        private int dayBorn;
        private int monthBorn;
        private int yearBorn;

        //constructor
        public Person(string firstName, string lastName, int dayBorn, int monthBorn, int yearBorn)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.dayBorn = dayBorn;
            this.monthBorn = monthBorn;
            this.yearBorn = yearBorn;
        }
        //end constructor

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public int DayBorn
        {
            get { return dayBorn; }
            set { dayBorn = value; }
        }
        public int MonthBorn
        {
            get { return monthBorn; }
            set { monthBorn = value; }
        }
        public int YearBorn
        {
            get { return yearBorn; }
            set { yearBorn = value; }
        }

        private bool HadThisYearsBirthday()
        {
            DateTime today = DateTime.Today;
            DateTime thisYearsBirthday = new DateTime(today.Year, monthBorn, dayBorn);
            TimeSpan timespan = today.Subtract(thisYearsBirthday);

            int daysToBirthday = timespan.Days;
            if (daysToBirthday < 0)
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        public int GetAgeInYears()
        {
            DateTime now = DateTime.Today;
            int age = now.Year - yearBorn;
            if (!HadThisYearsBirthday())
            {
                age -= 1;
            }
            return age;
        }


        private DateTime GetNextBirthday()
        {
            DateTime nextBirthday;
            if (HadThisYearsBirthday())
            {
                nextBirthday = new
                    DateTime(DateTime.Today.Year + 1, monthBorn, dayBorn);
            }
            else
            {
                nextBirthday = new
                    System.DateTime(DateTime.Today.Year, monthBorn, dayBorn);
                
            }
            return nextBirthday;
        }
        public int HowManyDaysTillBirthday()
        {
            DateTime nextBirthday = GetNextBirthday();
            DateTime today = DateTime.Today;
            TimeSpan timespan = nextBirthday.Subtract(today);
            int daysToBirthday = timespan.Days;
            return daysToBirthday;
        }

        public string DisplayName()
        {
            return firstName + " " +
                lastName + " (" +
                dayBorn + "/" +
                monthBorn + "/" +
                yearBorn + ")";
        }

        public bool IsItMyBirthday()
        {
            DateTime now = DateTime.Now;
            int todaysDay = now.Day;
            int todaysMonth = now.Month;

            if ((dayBorn == todaysDay) && (monthBorn == todaysMonth))
            {
                return true;
            }
            else
            {
                return false;
            }
     

        }

    }
}
