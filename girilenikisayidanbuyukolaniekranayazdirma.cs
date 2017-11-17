using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace girilenikisayidanbuyukolaniekranayazdirma
{
    class Program
    {
        static void Main(string[] args)
        {/*kullanıcı tarafından girilen 2 sayıdan büyük olanı ekrana yazdıran programı yazınız.*/
            int a, b, c;
            Console.Write("ilk sayıyı girin");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("İkinci sayıyı girin");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Üçüncü sayıyı girin");
            c = Convert.ToInt32(Console.ReadLine());
            if (a>b && a>c)
            {
                Console.Write("Girdiğiniz ilk sayı daha büyük");
            }
            else if (b>a && b>c)
            {
                Console.Write("Girdiğiniz ikinci sayı daha büyük");
            }
            else if (c>a && c>b)
            {
                Console.Write("Girdiğiniz üçüncü sayı daha büyük");
            }
            else
            {
                Console.Write("Girdiğiniz sayılar eşit");

            }
        }
    }
}
