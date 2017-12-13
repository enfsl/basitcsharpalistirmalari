using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forbesveyedibolsayilar
{
    class Program
    {
        static void Main(string[] args)
        {
            /* kullanıcı tarafından girilen 2 sayının arasındaki 5'e ve 7'e bölünen sayıları bulan program*/
            int s1 = Convert.ToInt32(Console.ReadLine());
            int s2 = Convert.ToInt32(Console.ReadLine());
            int kucuk = (s1 < s2) ? s1 : s2;
            int buyuk = (s1 > s2) ? s1 : s2;
            for (int i = kucuk; i <= buyuk; i++)
                if (i % 5 == 0 && i % 7 == 0)
                    Console.WriteLine(i);

        }
    }
}
