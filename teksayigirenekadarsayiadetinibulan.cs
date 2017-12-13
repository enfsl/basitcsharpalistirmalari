using System;

namespace teksayigirenekadarsayiadetinibulan
{
    class Program
    {
        static void Main(string[] args)
        {   /*kullanıcı tek sayı girene kadar sayıların adetini bulan
             program*/
            int sayac=0;
            while(true)
            {
                Console.WriteLine("bir sayı giriniz");
                int gs=Convert.ToInt32(Console.ReadLine());
                sayac++;
                if(gs%2==1) break;
            }
                Console.Write("Girdiğiniz sayı adeti :{0}",sayac);
        }
    }
}
