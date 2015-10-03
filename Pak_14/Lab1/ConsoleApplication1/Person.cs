using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Person
    {
        private string Name;
        private string Surname;
        private DateTime DateOfBirth;

        public Person()
        {
            this.Name = "Иван";
            this.Surname = "Иванов";
            this.DateOfBirth = new DateTime(2001, 1, 1);
        }

        public Person(string Name, string Surname, DateTime DateOfBirth)
        {
            this.Name = Name;
            this.Surname = Surname;
            this.DateOfBirth = DateOfBirth;
        }

        public string FieldName
        {
            get { return Name; }
            set { Name = value; }
        }

        public string FieldSurname
        {
            get { return Surname; }
            set { Surname = value; }
        }

        public DateTime FieldDateOfBirth
        {
            get { return DateOfBirth; }
            set { DateOfBirth = value; }
        }

        public int FieldIntDate
        {
            get { return Convert.ToInt32(DateOfBirth); }
            set { DateOfBirth.AddYears(value - DateOfBirth.Year); }
        }

        public override string ToString()
        {
            return Name +" "+ Surname +" "+ DateOfBirth.ToShortDateString();
        }

        public virtual string ToShortString()
        {
            return Name +" "+ Surname;
        }

    }
}
