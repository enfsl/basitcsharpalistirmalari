using System;

namespace ikiteksayigirinceyekadar
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Kullanıcı iki tek sayı girinceye kadar girilen sayıların toplamını bulan program */
            int s=0;
            int izlence=0;
            while(true)
            {
                Console.WriteLine("Bir sayı giriniz");
                int a = Convert.ToInt32(Console.ReadLine());
                s+=a;
                if(a%2==1) izlence++;
                if(izlence==2) break;
            }
            Console.WriteLine("GİRİLEN SAYILARIN TOPLAMI : {0}",s);
        }
    }
}
