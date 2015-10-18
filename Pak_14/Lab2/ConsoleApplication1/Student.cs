using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Student : Person, IdateAndCopy
    {
        //private Person Stud;
        private Education FormEd;
        private int Group;
        private List<Test> ListTest = new List<Test>();
        private List<Exam> ListExam = new List<Exam>();
        public List<object> ListExTest = new List<object>();

        public void List()
        {
            for (int i = 0; i < ListExam.Count; i++)
            {
                ListExTest.Add(ListExam[i]);
            }
            for (int i = 0; i < ListTest.Count; i++)
            {
                ListExTest.Add(ListTest[i]);
            }
        }

        public Student(string name, string surname, DateTime dateofbirth, Education formEd, int group)
        {
            //Stud = stud;
            Name = name;
            Surname = surname;
            DateOfBirth = dateofbirth;
            FormEd = formEd;
            Group = group;
        }

        public Student()
        {
            Name = "Иван";
            Surname = "Иванов";
            DateOfBirth = new DateTime(2001, 1, 1);
            FormEd = (Education)1;
            Group = 21;
        }

        public Person FieldStudent
        {
            get
            {
                Person per;
                return per = new Person(Name, Surname, DateOfBirth);
            }
            set
            {
                Name = value.FieldName;
                Surname = value.FieldSurname;
                DateOfBirth = value.FieldDateOfBirth;
            }
        }

        public Education FieldFormEd
        {
            get { return FormEd; }
            set { FormEd = value; }
        }

        public int FieldGroup
        {
            get { return Group; }
            set
            {
                if (value < 100 || value > 599)
                {
                    throw new IndexOutOfRangeException("Ошибка! Допустимые номера от 100 до 599!");
                }
                else
                {
                    Group = value;
                }
            }
        }

        public List<Exam> FieldListExam
        {
            get { return ListExam; }
            set { ListExam = value; }
        }

        public List<Test> FieldListTest
        {
            get { return ListTest; }
            set { ListTest = value; }
        }
        public double StudentGet
        {
            get
            {
                if (ListExam == null)
                {
                    return 0;
                }
                else
                {
                    double sred = 0;
                    for (int i = 0; i < ListExam.Count; i++)
                    {
                        sred = sred + ListExam[i].Mark;
                    }
                    return sred / ListExam.Count;
                }
            }
        }

        public bool this[Education OutFormEd]
        {
            get
            {
                if (OutFormEd == FormEd)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public void AddExams(Exam[] NewList)
        {

            for (int i = 0; i < NewList.Length; i++)
            {
                ListExam.Add(NewList[i]);
            }

        }

        public override string ToString()
        {
            if (ListExam == null)
            {
                if (ListTest == null)
                {
                    return base.ToShortString() + " " + "Форма обучения: " + Convert.ToString(FormEd) + " " + "Группа: " + Convert.ToString(Group);
                }
                else
                {
                    string Tests = "";
                    for (int i = 0; i < ListTest.Count; i++)
                    {
                        Tests = Tests + string.Format("Название предмета: {0} Зачтено: {1}", ListTest[i].NameT, Convert.ToString(ListTest[i].StatT));
                    }
                    return base.ToShortString() + " " + "Форма обучения: " + Convert.ToString(FormEd) + " " + "Группа: " + Convert.ToString(Group) + "Зачеты: " + Tests;
                }
            }
            else
            {
                string Exams = "";
                for (int i = 0; i < ListExam.Count; i++)
                {
                    Exams = Exams + string.Format("Название:{0} Оценка:{1} Дата:{2} ", ListExam[i].NameItem, Convert.ToString(ListExam[i].Mark), Convert.ToString(ListExam[i].DateExam));
                }

                if (ListTest == null)
                {
                    return base.ToShortString() + " " + "Форма обучения: " + Convert.ToString(FormEd) + " " + "Группа: " + Convert.ToString(Group) + " " + "Экзамены" + Exams;
                }
                else
                {
                    string Tests = "";
                    for (int i = 0; i < ListTest.Count; i++)
                    {
                        Tests = Tests + string.Format("Название предмета: {0} Зачтено: {1}", ListTest[i].NameT, Convert.ToString(ListTest[i].StatT));
                    }
                    return base.ToShortString() + " " + "Форма обучения: " + Convert.ToString(FormEd) + " " + "Группа: " + Convert.ToString(Group) + " " + "Экзамены" + Exams + " " + "Зачеты: " + Tests;
                }
            }
        }

        public virtual string ToShortString()
        {
            return base.ToShortString() + " " + "Форма обучения: " + Convert.ToString(FormEd) + " " + "Группа: " + Convert.ToString(Group) + " " + "Средний бал: " + Convert.ToString(StudentGet);
        }

        public object DeepCopy()
        {
            Student stCopy = new Student(Name,Surname,DateOfBirth,FormEd,Group);
            stCopy.FieldListExam = ListExam;
            stCopy.FieldListTest = ListTest;
            return stCopy;
        }

        public IEnumerable<object> GetStudExTest()
        {
            for (int i = 0;i<ListExTest.Count;i++)
            {
                yield return ListExTest[i];
            }
        }
        public IEnumerable<Exam> GetStudEx()
        {
            for (int i = 0; i < ListExam.Count; i++)
            {
                if (ListExam[i].Mark >= 4)
                {
                    yield return ListExam[i];
                }
            }
        }
    }
}
