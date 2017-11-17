using System;

namespace buyuksayiyibulmanonmantiksalop
{
    class Program
    {
        static void Main(string[] args)
        {
            int a,b,c;
            Console.Write("ilk sayiyi giriniz");
            a=Convert.ToInt32(Console.ReadLine());
            Console.Write("ikinci sayiyi giriniz");
            b=Convert.ToInt32(Console.ReadLine());
            Console.Write("üçüncü sayiyi giriniz");
            c=Convert.ToInt32(Console.ReadLine());
            if(a>b)
            {
                if(a>c)
                {
                    Console.Write("ilk sayi en büyük");
                }
            }
            if(b>a)
            {
                if(b>c)
                {
                    Console.Write("İkinci sayi daha büyük");
                }
            }
            if(c>a)
            {
                if(c>b)
                {
                    Console.Write("üçüncü sayi daha büyük");
                }
            }
            else
            {
                if(a==b)
                {
                    if(a==c)
                    {
                        if(b==a)
                        {
                            if(b==c)
                            {
                                if(c==a)
                                {
                                    if(c==b)
                                    {
                                        Console.Write("girdiğiniz sayılar eşit");
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
