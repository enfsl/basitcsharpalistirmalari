using System;

namespace asalsayiolupolmadigi
{
    class Program
    {
        static void Main(string[] args)
        {
            /*kullanıcı tarafından girilen bir sayının asal sayı olup olmadığını bulan program */
            Console.WriteLine("BİR SAYI GİRİNİZ");
            int gs= Convert.ToInt32(Console.ReadLine());
            int adet = 0;
            for(int i = 1; i<=gs; i++)
            if(gs%i==0) adet++;
            if(adet<3) Console.WriteLine("asal");
            else Console.WriteLine("değil");
        }
    }
}
