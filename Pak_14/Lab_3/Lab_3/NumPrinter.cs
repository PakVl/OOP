using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Lab_3
{
    internal class NumPrinter: INumPrinter
    {
        private int n;
        public int[] massCh;

        public NumPrinter(int n)
        {
            this.n = n;
            massCh = new int[n];
        }

        public int[] GetNumbers()
        {
            Thread.Sleep(10000);

            for (int i = 0; i< n;i++)
            {
                massCh[i] = i;
            }
            return massCh;
        }
    }
}
