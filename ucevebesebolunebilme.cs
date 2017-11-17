using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ucevebesebolunebilme
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.Write("Bir sayı giriniz");
            a = Convert.ToInt32(Console.ReadLine());
            if(a%3==0 && a%5==0)
            {
                Console.Write("Girdiğiniz sayı 3e ve 5e bölünebiliyor");
            }
            else if(a%3==0 && a%5!=0)
            {
                Console.Write("Girdiğiniz sayı 3e tam bölünebiliyor 5'e bölünemiyor");
            }
            else if(a%5==0 && a%3!=0)
            {
                Console.Write("Girdiğiniz sayı 5e tam bölünebiliyor 3'e bölünemiyor");
            }
            else
            {
                Console.Write("Girdiğiniz sayı 3e ve 5e bölünemiyor");
            }
        }
    }
}
