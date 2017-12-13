using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forteksayi
{
    class Program
    {
        static void Main(string[] args)
        {
            /* kullanıcı tarafından girilen 2 sayının arasındaki tek sayıları ekrana yazdıran program*/
            int s1 = Convert.ToInt32(Console.ReadLine());
            int s2 = Convert.ToInt32(Console.ReadLine());
            int kucuk = (s1 < s2) ? s1 : s2;
            int buyuk = (s1 > s2) ? s1 : s2;
            for (int islem = kucuk; islem < buyuk; islem++)
                if (islem % 2 == 1)
                    Console.WriteLine(islem);
        }
    }
}
