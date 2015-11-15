using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Lab_3
{
    class Proxy_numprint: INumPrinter
    {
        private int Pn;
        private NumPrinter Nump;
        public int[] Proxy_Numbers;
        private List<int> ListNum = new List<int>();

        public Proxy_numprint(int Pn)
        {
            this.Pn = Pn;
            Nump = new NumPrinter(Pn);
            Proxy_Numbers = Nump.GetNumbers();
        }
        public int[] GetNumbers()
        {
            Thread.Sleep(1000);
            for (int i = 0; i < Pn; i++)
            {
                if (Proxy_Numbers[i] % 2 == 0)
                { ListNum.Add(Proxy_Numbers[i]); }
            }
            int[] NewMassNum = new int[ListNum.Count];
            NewMassNum = ListNum.ToArray();
            return NewMassNum;
        }
    }
}
