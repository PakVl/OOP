using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Person :IdateAndCopy
    {
        protected string Name;
        protected string Surname;
        protected DateTime DateOfBirth;

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

        public object DeepCopy()
        {
            Person perCopy = new Person(Name, Surname, DateOfBirth);
            return perCopy;
        }

        public DateTime Date
        { get; set; }


        public static bool operator ==(Person man1, Person man2)
        {
            if (man1.Name == man2.Name && man1.Surname == man2.Surname && man1.DateOfBirth == man2.DateOfBirth)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(Person man1, Person man2)
        {
            if (man1.Name != man2.Name || man1.Surname != man2.Surname || man1.DateOfBirth != man2.DateOfBirth)
            {
                return true;
            }
            else
            {
                int i = 0;
                return false;
            }
        }


        public override bool Equals(object obj)
        {
            Person manEq = (Person)obj;
            return Name.Equals(manEq.Name) && Surname.Equals(manEq.Surname) && DateOfBirth.Equals(manEq.DateOfBirth);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
