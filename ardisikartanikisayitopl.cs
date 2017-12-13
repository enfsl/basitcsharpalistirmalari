using System;

namespace ardisikartanikisayitopl
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Kullanıcı tarafından ardışık artan iki sayı girilinceye kadar
            girilen sayıların toplamını bulan program */
            int sayac=1;
            int son=0;
            int tp=0;
            while(true)
            {
                Console.WriteLine("Bir sayı giriniz");
                int gs=Convert.ToInt32(Console.ReadLine());
                tp+=gs;
                if(sayac==1) son=gs;
                else
                {
                    if(gs-son==1) break;
                    else son = gs;
                }
                sayac++;
            }
            Console.WriteLine("TOPLAMI {0}",tp);
        }
    }
}
