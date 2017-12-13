using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forarasindakisayilartopl
{
    class Program
    {
        static void Main(string[] args)
        {
            /* kullanıcı tarafından girilen 2 sayının arasındaki sayıların toplamını bulan program*/
            int s1 = Convert.ToInt32(Console.ReadLine());
            int s2 = Convert.ToInt32(Console.ReadLine());
            int ts = 0;
            int kucuk = (s1 < s2) ? s1 : s2;
            int buyuk = (s1 > s2) ? s1 : s2;
            for (int i = kucuk; i < buyuk; i++)
                ts = ts + i;
            Console.Write(ts);

        }
    }
}
