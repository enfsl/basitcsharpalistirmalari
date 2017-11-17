using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ikinciderecedenbirbilinmeyenli
{
    class Program
    {
        static void Main(string[] args)
        {
            /* katsayıları klavyeden girilen 2'nci dereceden bir bilinmeyenli denklemin köklerini bulan programı yazdırınız*/
            int a, b, c;
            Console.Write("BİRİNCİ SAYIYI GİR");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("İKİNCİ SAYIYI GİR");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("ÜÇÜNCÜ SAYIYI GİR");
            c = Convert.ToInt32(Console.ReadLine());
            int delta = (b * b) - (4 * a * c);
            double kokdelta = Math.Sqrt(delta);
            if(kokdelta<0)
            {
                Console.WriteLine("gerçek kök yoktur");
            }
            else
            {
                double x1 = (-b - kokdelta) / 2 * a;
                double x2 = (-b + kokdelta) / 2 * a;
                Console.WriteLine("denklemin çözüm kümesi : ({0},{1})", x1, x2);
            }
        }
    }
}
