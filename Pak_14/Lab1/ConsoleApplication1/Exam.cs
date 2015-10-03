using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Exam
    {
        public string NameItem;
        public int Mark;
        public DateTime DateExam;

        public Exam(string nameItem, int mark, DateTime dateExam)
        {
            NameItem = nameItem;
            Mark = mark;
            DateExam = dateExam;
        }
        public Exam()
        {
            NameItem = "Предмет";
            Mark = 0;
            DateExam = new DateTime();
        }

        public override string ToString()
        {
            return NameItem + Convert.ToString(Mark) + Convert.ToString(DateExam);
        }
    }
}
