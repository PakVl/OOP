using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person Chel1 = new Person();
            Person Chel2 = new Person();

            Console.WriteLine("Персоны: ");
            Console.WriteLine("1) " + Chel1.ToString());
            Console.WriteLine("2) " + Chel2.ToString());
            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("Сравнения : ");
            Console.WriteLine(string.Format("Совпадение: {0}", Chel1.Equals((object)Chel2)));
            Console.WriteLine(string.Format("Хеш код 1 человека: {0} Хеш код 2 человека: {1} ", Chel1.GetHashCode(), Chel2.GetHashCode()));
            Console.WriteLine();
            Console.ReadKey();

            Student Stud1 = new Student();
            Stud1.FieldListExam.Add(new Exam("Алгебра", 5, new DateTime(2001, 10, 10)));
            Stud1.FieldListExam.Add(new Exam("Физика", 4, new DateTime(2001, 10, 11)));
            Stud1.FieldListExam.Add(new Exam("Магия", 3, new DateTime(2001, 10, 09)));
            Stud1.FieldListTest.Add(new Test("Базы данных", true));
            Stud1.FieldListTest.Add(new Test("Философия", false));
            Console.WriteLine("Студент: ");
            Console.WriteLine(Stud1.ToString());
            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("Cвойство типа Person для объекта типа Student: ");
            Console.WriteLine(Convert.ToString(Stud1.FieldDateOfBirth));
            Console.ReadKey();
            Console.WriteLine();
            Student Stud2 = (Student)Stud1.DeepCopy();

            Stud1.FieldName = "Никита";
            Stud1.FieldGroup = 500;
            Console.WriteLine("Исходный: ");
            Console.WriteLine(Stud1.ToShortString());
            Console.WriteLine("Копия: ");
            Console.WriteLine(Stud2.ToShortString());
            Console.ReadKey();
            Console.WriteLine();

            Console.WriteLine("Отлов ошибки: ");
            try
            {
                Stud1.FieldGroup = 10;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            Console.ReadKey();
            Console.WriteLine();
            Stud1.List();

            Console.WriteLine("Итератор Объектов: ");
            foreach (object e in Stud1.GetStudExTest())
            {
                Console.WriteLine(Convert.ToString(e));
            }
            Console.ReadKey();
            Console.WriteLine();

            Console.WriteLine("Итератор условный: ");
            foreach (Exam e in Stud1.GetStudEx())
            {
                Console.WriteLine(Convert.ToString(e));
            }
            Console.ReadKey();
            Console.WriteLine();
        }
    }
}



