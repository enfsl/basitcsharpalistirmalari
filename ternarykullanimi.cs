using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ternarykullanimi
{
    class Program
    {
        static void Main(string[] args)
        {
            /*ternary operatörü kullanımı*/
            Console.WriteLine("Algormitayı seviyormusun ? (E/H)");
            string snc = Console.ReadLine();
            Console.WriteLine((snc=="E")?"Tebrikler":"4 senede bitmez"); /*'?' true, ':' false değeri döndürür*/
            Console.ReadKey();
        }
    }
}
