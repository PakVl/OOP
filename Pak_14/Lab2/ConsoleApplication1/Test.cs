using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Test
    {
        public string NameT
        { get; set; }
        public bool StatT
        { get; set; }

        public Test()
        {
            NameT = "Программирование";
            StatT = true;
        }
        public Test(string NameT, bool StatT)
        {
            this.NameT = NameT;
            this.StatT = StatT;
        }
        public override string ToString()
        {
            return string.Format("Название предмета: {0}  Зачтено: {1}", NameT, StatT);
        }
    }
}
