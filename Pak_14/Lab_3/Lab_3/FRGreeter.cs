﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    class FRGreeter : IGreeter
    {
        public void SayHello()
        {
            Console.WriteLine("Salut!");
        }
    }
}
