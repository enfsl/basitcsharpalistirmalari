using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aylar
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.Write("İstediğiniz ayı sayı olarak giriniz");
            a = Convert.ToInt32(Console.ReadLine());

            if ((a <= 2 && a >= 1) || (a == 12))
            {
                Console.Write("Kış");
            }

            else if (a >= 3 && a <= 5)
            {
                Console.Write("İlk bahar");
            }

            else if (a >= 6 && a <= 8)
            {
                Console.Write("YAZ");
            }

            else if (a >= 9 && a <= 11)
            {
                Console.Write("Son BAHAAR");
            }

            else
            {
                Console.Write("1 ve 12 dahil arasında sayı giriniz");
            }
        }
    }
}
