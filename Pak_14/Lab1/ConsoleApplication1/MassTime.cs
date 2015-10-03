using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApplication1
{
    class MassTime
    {
        Exam[] first;
        Exam[,] doRec;
        Exam[][] doStairs;
        int n = 500;
        public MassTime(int n)
        {
            this.n = n;
        }
        /// <summary>
        /// Время  обработки двумерного массива
        /// </summary>
        /// <returns></returns>
        public int TimeRec()
        {
            doRec = new Exam[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    doRec[i, j] = new Exam("dr", i * j + 10000, new DateTime());
                }
            }

            int sum = 0;
            int start = Environment.TickCount;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    sum = (sum + doRec[i, j].Mark * 3000000) ^ 31203;
                }
            }


            int stop = Environment.TickCount;
            return stop - start;
        }
        /// <summary>
        /// Время обработки одномерного массива
        /// </summary>
        /// <returns></returns>
        public int Timefirst()
        {
            int n2 = n * n;
            first = new Exam[n2];
            for (int i = 0; i < n2; i++)
            {
                first[i] = new Exam("f", i + 10000, new DateTime());
            }

            int sum = 0;
            int start = Environment.TickCount;

            for (int i = 0; i < n2; i++)
            {
                sum = (sum + first[i].Mark * 3000000) ^ 31203;
            }

            
            int stop = Environment.TickCount;
            int b = stop - start;
            return b;
        }
        /// <summary>
        /// Время обработки ступеньчатого массива
        /// </summary>
        /// <returns></returns>
        public int TimedoSt()
        {
            doStairs = new Exam[n][];
            for (int i = 0; i < n; i++)
            {
                doStairs[i] = new Exam[n];
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    doStairs[i][j] = new Exam("ds", i * j + 10000, new DateTime());
                }
            }
            int sum = 0;
            int start = Environment.TickCount;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    sum = (sum + doStairs[i][j].Mark * 3000000) ^ 31203;
                }
            }


            int stop = Environment.TickCount;
            return stop - start;
        }

    }
}
