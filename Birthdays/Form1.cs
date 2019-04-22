using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Birthdays
{
    public partial class FormBirthday : Form
    {
        List<Person> people = new List<Person>();
        int personDisplayed = 0;

        public FormBirthday()
        {
            InitializeComponent();
        }

        private void FormBirthday_Load(object sender, EventArgs e)
        {
            people.Add(new Person("Charles", "Babbage", 26, 12, 1792));
            people.Add(new Person("Bill", "Gates", 28, 10, 1955));
            people.Add(new Person("Steve", "Jobs", 24, 2, 1955));
            people.Add(new Person("Tim", "Berners-Lee", 8, 6, 1955));
            people.Add(new Person("Niklaus", "Wirth", 15, 2, 1934));
            people.Add(new Person("William", "Shockley", 13, 2, 1910));
            people.Add(new Person("Charlotte", "Spencer", 17, 3, 1995));
            people.Add(new Person("Grace", "Hopper", 9, 12, 1906));
            people.Add(new Person("Linus", "Torvalds", 28, 12, 1969));
            people.Add(new Person("Ada", "Lovelace", 10, 12, 1815));
            people.Add(new Person("Richard", "Stallman", 16, 3, 1953));
            
            DisplayCurrentDetails();           
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            personDisplayed -= 1;
            if (personDisplayed == -1)
            {
                personDisplayed = people.Count - 1;
            }
            DisplayCurrentDetails();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            personDisplayed += 1;
            if (personDisplayed == people.Count)
            {
                personDisplayed = 0;
            }
            DisplayCurrentDetails();

        }

        private void DisplayCurrentDetails()
        {
            textBoxPerson.Text = people[personDisplayed].DisplayName();
            textBoxAge.Text = Convert.ToString(people[personDisplayed].GetAgeInYears());
            textBoxDaysToBirthday.Text = Convert.ToString(people[personDisplayed].HowManyDaysTillBirthday());
        }

        private void buttonBirthdaysNear_Click(object sender, EventArgs e)
        {
            int i;
            StringBuilder names = new StringBuilder();
            for (i = 0; i < people.Count; i++)
            {
                if (people[i].HowManyDaysTillBirthday() <= 14)
                {
                    names.Append(people[i].DisplayName() + Environment.NewLine);
                }
            }

            if (names.Length == 0)
            {
                names.Append("No birthdays near");
            }

            MessageBox.Show(names.ToString(), "Birthdays in the next 14 days", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void buttonBirthdayThisMonth_Click(object sender, EventArgs e)
        {
            int i;
            StringBuilder names = new StringBuilder();
            for (i = 0; i < people.Count; i++)
            {
                if (people[i].MonthBorn == 10)
                {
                    names.Append(people[i].DisplayName() + Environment.NewLine);
                }

            }

            if (names.Length == 0)
            {
                names.Append("No birthdays in October");
            }

            MessageBox.Show(names.ToString(), "Birthdays in October", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonBirthdayNovember_Click(object sender, EventArgs e)
        {
            int i;
            StringBuilder names = new StringBuilder();
            for (i = 0; i < people.Count; i++)
            {
                if (people[i].MonthBorn == 11)
                {
                    names.Append(people[i].DisplayName() + Environment.NewLine);
                }

            }

            if (names.Length == 0)
            {
                names.Append("No birthdays in November");
            }

            MessageBox.Show(names.ToString(), "Birthdays in November", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonBirthdayJanuary_Click(object sender, EventArgs e)
        {
            int i;
            StringBuilder names = new StringBuilder();
            for (i = 0; i < people.Count; i++)
            {
                if (people[i].MonthBorn == 1)
                {
                    names.Append(people[i].DisplayName() + Environment.NewLine);
                }

            }

            if (names.Length == 0)
            {
                names.Append("No birthdays in January");
            }

            MessageBox.Show(names.ToString(), "Birthdays in January", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonBirthdayFebruary_Click(object sender, EventArgs e)
        {
            int i;
            StringBuilder names = new StringBuilder();
            for (i = 0; i < people.Count; i++)
            {
                if (people[i].MonthBorn == 2)
                {
                    names.Append(people[i].DisplayName() + Environment.NewLine);
                }

            }

            if (names.Length == 0)
            {
                names.Append("No birthdays in February");
            }

            MessageBox.Show(names.ToString(), "Birthdays in February", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonBirthdayMarch_Click(object sender, EventArgs e)
        {
            int i;
            StringBuilder names = new StringBuilder();
            for (i = 0; i < people.Count; i++)
            {
                if (people[i].MonthBorn == 3)
                {
                    names.Append(people[i].DisplayName() + Environment.NewLine);
                }

            }

            if (names.Length == 0)
            {
                names.Append("No birthdays in March");
            }

            MessageBox.Show(names.ToString(), "Birthdays in March", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonBirthdayApril_Click(object sender, EventArgs e)
        {
            int i;
            StringBuilder names = new StringBuilder();
            for (i = 0; i < people.Count; i++)
            {
                if (people[i].MonthBorn == 4)
                {
                    names.Append(people[i].DisplayName() + Environment.NewLine);
                }

            }

            if (names.Length == 0)
            {
                names.Append("No birthdays in April");
            }

            MessageBox.Show(names.ToString(), "Birthdays in April", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonBirthdayMay_Click(object sender, EventArgs e)
        {
            int i;
            StringBuilder names = new StringBuilder();
            for (i = 0; i < people.Count; i++)
            {
                if (people[i].MonthBorn == 5)
                {
                    names.Append(people[i].DisplayName() + Environment.NewLine);
                }

            }

            if (names.Length == 0)
            {
                names.Append("No birthdays in May");
            }

            MessageBox.Show(names.ToString(), "Birthdays in May", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonBirthdayJune_Click(object sender, EventArgs e)
        {
            int i;
            StringBuilder names = new StringBuilder();
            for (i = 0; i < people.Count; i++)
            {
                if (people[i].MonthBorn == 6)
                {
                    names.Append(people[i].DisplayName() + Environment.NewLine);
                }

            }

            if (names.Length == 0)
            {
                names.Append("No birthdays in June");
            }

            MessageBox.Show(names.ToString(), "Birthdays in June", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonBirthdayJuly_Click(object sender, EventArgs e)
        {
            int i;
            StringBuilder names = new StringBuilder();
            for (i = 0; i < people.Count; i++)
            {
                if (people[i].MonthBorn == 7)
                {
                    names.Append(people[i].DisplayName() + Environment.NewLine);
                }

            }

            if (names.Length == 0)
            {
                names.Append("No birthdays in July");
            }

            MessageBox.Show(names.ToString(), "Birthdays in July", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonBirthdayAugust_Click(object sender, EventArgs e)
        {
            int i;
            StringBuilder names = new StringBuilder();
            for (i = 0; i < people.Count; i++)
            {
                if (people[i].MonthBorn == 8)
                {
                    names.Append(people[i].DisplayName() + Environment.NewLine);
                }

            }

            if (names.Length == 0)
            {
                names.Append("No birthdays in August");
            }

            MessageBox.Show(names.ToString(), "Birthdays in August", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonBirthdaySeptember_Click(object sender, EventArgs e)
        {
            int i;
            StringBuilder names = new StringBuilder();
            for (i = 0; i < people.Count; i++)
            {
                if (people[i].MonthBorn == 9)
                {
                    names.Append(people[i].DisplayName() + Environment.NewLine);
                }

            }

            if (names.Length == 0)
            {
                names.Append("No birthdays in September");
            }

            MessageBox.Show(names.ToString(), "Birthdays in September", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonBirthdayDecember_Click(object sender, EventArgs e)
        {
            int i;
            StringBuilder names = new StringBuilder();
            for (i = 0; i < people.Count; i++)
            {
                if (people[i].MonthBorn == 12)
                {
                    names.Append(people[i].DisplayName() + Environment.NewLine);
                }

            }

            if (names.Length == 0)
            {
                names.Append("No birthdays in December");
            }

            MessageBox.Show(names.ToString(), "Birthdays in December", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        



    }
}
