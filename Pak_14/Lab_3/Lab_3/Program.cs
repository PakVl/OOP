using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    class Program
    {
        static void Main(string[] args)
        {
            ENGreeter eng = new ENGreeter();
            FRGreeter frg = new FRGreeter();
            RUGreeter rug = new RUGreeter();
            Greeter_Adapter ga = new Greeter_Adapter();

            eng.SayHello();
            frg.SayHello();
            rug.SayHello();
            ga.SayHello();

            Console.ReadKey();

            Console.WriteLine("Класс NumPrint");
            Console.Write("Введите n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            NumPrinter numpr = new NumPrinter(n);
            int[] MassNum = numpr.GetNumbers();
            for (int i = 0;i<MassNum.Length;i++)
            {
                Console.Write(MassNum[i] + "  ");
            }
            Console.ReadKey();

            Console.WriteLine("Класс ProxyNumPrint");
            Console.Write("Введите n: ");
            int Pn = Convert.ToInt32(Console.ReadLine());
            Proxy_numprint Proxynumpr = new Proxy_numprint(Pn);
            int[] ProxyMassNum = Proxynumpr.GetNumbers();
            for (int i = 0; i < MassNum.Length; i++)
            {
                Console.Write(MassNum[i] + "  ");
            }
            Console.ReadKey();
        }
    }
}
