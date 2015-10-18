using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    interface IdateAndCopy
    {
        object DeepCopy();
        DateTime Date{ get; set; }
    }
}
