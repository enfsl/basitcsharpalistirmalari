using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tekseikiciftseucazaltma
{
    class Program
    {
        static void Main(string[] args)
        {
            /* kullanıcı tarafından girilen sayı tekse girilen sayıyı 2 arttıran çiftse girilen sayıyı 3 azaltan programı yazınız*/
            int a;
            Console.Write("Sayıyı giriniz");
            a = Convert.ToInt32(Console.ReadLine());
            if(a%2==0)
            {
                a = a - 3;
                Console.Write("Girdiğiniz sayı çift ve sayı 3 azaltıldı ve sayı {0} oldu", a);
            }
            else if(a%2==1)
            {
                a = a + 2;
                Console.Write("Girdiğiniz sayı tek ve sayı 2 artırıldı ve sayı {0} oldu", a);
            }
        }
    }
}
