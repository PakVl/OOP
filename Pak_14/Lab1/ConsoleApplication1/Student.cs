using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Student
    {
        private Person Stud;
        private Education FormEd;
        private int Group;
        private Exam[] ListExam = new Exam[0];

        public Student(Person stud, Education formEd, int group)
        {
            Stud = stud;
            FormEd = formEd;
            Group = group;
        }

        public Student()
        {
            Stud = new Person();
            FormEd = (Education)1;
            Group = 21;
        }

        public Person FieldStudent
        {
            get { return Stud; }
            set { Stud = value; }
        }

        public Education FieldFormEd
        {
            get { return FormEd; }
            set { FormEd = value; }
        }

        public int FieldGroup
        {
            get { return Group; }
            set { Group = value; }
        }

        public Exam[] FieldListExam
        {
            get { return ListExam; }
            set { ListExam = value; }
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
                    for (int i = 0; i < ListExam.Length; i++)
                    {
                        sred = sred + ListExam[i].Mark;
                    }
                    return sred / ListExam.Length;
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

        public void AddExams(params Exam[] NewList)
        {

                for (int i = 0; i < NewList.Length; i++)
                {
                    Array.Resize(ref ListExam, ListExam.Length + 1);
                    ListExam[ListExam.Length - 1] = NewList[i];
                }
           
        }

        public override string ToString()
        {
            if (ListExam == null)
            {
                return Stud.ToShortString() + " " + "Форма обучения: " + Convert.ToString(FormEd) + " " + "Группа: " + Convert.ToString(Group);
            }
            else
            {
                string Exams = "";
                for (int i = 0; i < ListExam.Length; i++)
                {
                    Exams = Exams + string.Format("Название:{0} Оценка:{1} Дата:{2} ", ListExam[i].NameItem, Convert.ToString(ListExam[i].Mark), Convert.ToString(ListExam[i].DateExam));
                }
                return Stud.ToShortString() + " " + "Форма обучения: " + Convert.ToString(FormEd) + " " + "Группа: " + Convert.ToString(Group) + " " + Exams;
            }
        }

        public virtual string ToShortString()
        {
            return Stud.ToShortString() + " " + "Форма обучения: " + Convert.ToString(FormEd) + " " + "Группа: " + Convert.ToString(Group) + " " + "Средний бал: " + Convert.ToString(StudentGet);
        }
    }
}
