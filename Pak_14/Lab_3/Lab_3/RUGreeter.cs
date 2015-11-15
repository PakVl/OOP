using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    class RUGreeter: IGreeter
    {
        public void SayHello()
        {
            Console.WriteLine("Привет!");
        }
    }
}
