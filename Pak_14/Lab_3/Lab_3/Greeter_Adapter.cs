using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    class Greeter_Adapter : IGreeter
    {
        Printer pr = new Printer();

        public void SayHello()
        {
            pr.Print("Hallo!");
        }
    }
}
