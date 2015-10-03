using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> Cheloveki = new List<Student>();

            Education SomeEd1 = (Education)1;
            Education SomeEd2 = (Education)2;
            Education SomeEd3 = (Education)3;
            Person Person1 = new Person("Александр", "Григорьев", new DateTime(1990, 10, 15));
            Student studP1 = new Student(Person1, SomeEd1, 32);
            Cheloveki.Add(studP1);
            bool work = true;
            while (work)
            {
                //Вывод меню
                Console.Clear();
                Console.WriteLine("1. Вывести список студентов");
                Console.WriteLine("2. Создать нового студента");
                Console.WriteLine("3. Добавить экзамен студенту");
                Console.WriteLine("4. Просмотр формы обучения студента");
                Console.WriteLine("5. Просмотр экзаменов студента");
                Console.WriteLine("6. Замер времени расчета массивов");
                Console.WriteLine("7. Выход");
                Console.WriteLine();
                Console.Write("Выбирите пункт: ");
                int Menu = Convert.ToInt32(Console.ReadLine());


                switch (Menu)
                {
                    case 1:
                        {
                            // Вывод всех студентов
                            Console.Clear();
                            if (Cheloveki.Count == 0)
                            {
                                Console.WriteLine("Список пуст");
                                Console.ReadKey();
                                break;
                            }
                            else
                            {
                                for (int i = 0; i < Cheloveki.Count; i++)
                                {
                                    Console.WriteLine(i + ": " + Cheloveki[i].ToShortString());
                                }
                                Console.WriteLine();
                                Console.WriteLine("Для перехода в меню нажмите любую клавишу");
                                Console.ReadKey();
                                break;
                            }
                        }
                    case 2:
                        {
                            //Создание нового студента
                            Console.Clear();

                            Console.Write("Введите имя: ");
                            string name = Console.ReadLine();
                            Console.Write("Введите Фамилию: ");
                            string surname = Console.ReadLine();

                            Console.Write("Год рождения: ");
                            int year = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Месяц рождения: ");
                            int month = Convert.ToInt32(Console.ReadLine());
                            Console.Write("День рождения: ");
                            int day = Convert.ToInt32(Console.ReadLine());

                            Console.Clear();

                            Console.WriteLine("Формы обучения: ");
                            Console.WriteLine("1. Specialist");
                            Console.WriteLine("2. Вachelor");
                            Console.WriteLine("3. SecondEducation");

                            Console.Write("Выбирите форму обучения: ");
                            int formEd = Convert.ToInt32(Console.ReadLine());

                            Console.Clear();

                            Console.Write("Введите номер группы: ");
                            int nomGr = Convert.ToInt32(Console.ReadLine());

                            Console.Clear();

                            Cheloveki.Add(new Student(new Person(name, surname, new DateTime(year, month, day)), (Education)formEd, nomGr));

                            Console.WriteLine("Новый студент: " + Cheloveki[Cheloveki.Count - 1].ToString());
                            Console.WriteLine();
                            Console.ReadKey();
                            break;
                        }
                    case 3:
                        {
                            //Добавление экзамена студентам
                            List<Exam> ListEx = new List<Exam>();
                            Console.Clear();
                            for (int i = 0; i < Cheloveki.Count; i++)
                            {
                                Console.WriteLine(i + ": " + Cheloveki[i].ToShortString());
                            }
                            Console.WriteLine();
                            Console.Write("Выбирите студента: ");
                            int nomStud = Convert.ToInt32(Console.ReadLine());

                            Console.Clear();

                            Console.WriteLine(Cheloveki[nomStud].ToString());
                            Console.WriteLine();
                            while (true)
                            {
                                Console.WriteLine();
                                Console.Write("Добавить/выход ?: ");
                                if (Console.ReadLine() == "выход")
                                {
                                    break;
                                }
                                else
                                {
                                    Console.Write("Название предмета:");
                                    string nameIt = Console.ReadLine();
                                    Console.Write("Оценка:");
                                    int mark = Convert.ToInt32(Console.ReadLine());
                                    Console.Write("Год сдачи: ");
                                    int year = Convert.ToInt32(Console.ReadLine());
                                    Console.Write("Месяц сдачи: ");
                                    int month = Convert.ToInt32(Console.ReadLine());
                                    Console.Write("День сдачи: ");
                                    int day = Convert.ToInt32(Console.ReadLine());

                                    ListEx.Add(new Exam(nameIt, mark, new DateTime(year, month, day)));

                                    Cheloveki[nomStud].AddExams();
                                }
                            }
                            Cheloveki[nomStud].AddExams(ListEx.ToArray());
                            Console.WriteLine(Cheloveki[nomStud].ToString());
                            Console.WriteLine();
                            Console.ReadKey();
                            break;
                        }
                    case 4:
                        {
                            //Просмотр формы обучения
                            Console.Clear();
                            for (int i = 0; i < Cheloveki.Count; i++)
                            {
                                Console.WriteLine(i + ": " + Cheloveki[i].ToShortString());
                            }
                            Console.WriteLine();
                            Console.Write("Выбирите студента: ");
                            int nomStud = Convert.ToInt32(Console.ReadLine());

                            Console.Clear();

                            Console.WriteLine(Cheloveki[nomStud].ToString());
                            Console.WriteLine();

                            Console.WriteLine("Specialist: " + Cheloveki[nomStud][SomeEd1]);
                            Console.WriteLine("Вachelor: " + Cheloveki[nomStud][SomeEd2]);
                            Console.WriteLine("SecondEducation: " + Cheloveki[nomStud][SomeEd3]);
                            Console.WriteLine();
                            Console.WriteLine("Для перехода в меню нажмите любую клавишу");
                            Console.ReadKey();
                            break;
                        }
                    case 5:
                        {
                            //Просмотр списка экзаменов
                            Console.Clear();
                            for (int i = 0; i < Cheloveki.Count; i++)
                            {
                                Console.WriteLine(i + ": " + Cheloveki[i].ToShortString());
                            }
                            Console.WriteLine();
                            Console.Write("Выбирите студента: ");
                            int nomStud = Convert.ToInt32(Console.ReadLine());

                            Console.Clear();

                            Console.WriteLine(Cheloveki[nomStud].ToString());
                            Console.WriteLine();

                            for (int i = 0; i < Cheloveki[nomStud].FieldListExam.Length; i++)
                            {
                                Console.WriteLine(string.Format("Название:{0} Оценка:{1} Дата:{2} ", Cheloveki[nomStud].FieldListExam[i].NameItem, Cheloveki[nomStud].FieldListExam[i].Mark, Convert.ToString(Cheloveki[nomStud].FieldListExam[i].DateExam)));
                            }
                            Console.WriteLine();
                            Console.WriteLine("Для перехода в меню нажмите любую клавишу");
                            Console.ReadKey();
                            break;
                        }
                    case 6:
                        {
                            //Скорость отработки разных массивов
                            Console.Clear();
                            Console.Write("Введите размерность: ");
                            int n = Convert.ToInt32(Console.ReadLine());

                            MassTime t = new MassTime(n);

                            Console.WriteLine("Время работы: ");
                            Console.WriteLine("Одномерный массив: " + t.Timefirst());
                            Console.WriteLine("Двумерный массив: " + t.TimeRec());
                            Console.WriteLine("Двумерный ступеньчатый массив: " + t.TimedoSt());
                            Console.WriteLine();
                            Console.WriteLine("Для перехода в меню нажмите любую клавишу");
                            Console.ReadKey();
                            break;
                        }
                    case 7:
                        {
                            work = false;
                            break;
                        }
                }
            }
        }
    }
}


