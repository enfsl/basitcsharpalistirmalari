using System;

namespace indirimuygulama
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 1000tlye %5, 1500tlye %7, 2500tlye %9 indirim uygulayan programı yazınız */
            double fiyat;
            Console.Write("Aldığınız Ürünün Fiyatı : ");
            fiyat = Convert.ToDouble(Console.ReadLine());
            if(fiyat>=2500)
            {
            double kazanilanindirim = ((fiyat*9)/100);
            Console.WriteLine("Kazandığınız İndirim : {0}",kazanilanindirim);
            fiyat = fiyat - kazanilanindirim;
            Console.Write("Ödeyeceğiniz Tutar : {0}",fiyat);
            }
            else if((fiyat>=1000) && (fiyat<1500))
            {
            double kazanilanindirim = ((fiyat*5)/100);
            Console.WriteLine("Kazandığınız İndirim : {0}",kazanilanindirim);
            fiyat = fiyat - kazanilanindirim;
            Console.Write("Ödeyeceğiniz Tutar : {0}",fiyat);
            }
            else if((fiyat>=1500) && (fiyat<2500))
            {
            double kazanilanindirim = ((fiyat*7)/100);
            Console.WriteLine("Kazandığınız İndirim : {0}",kazanilanindirim);
            fiyat = fiyat - kazanilanindirim;
            Console.Write("Ödeyeceğiniz Tutar : {0}",fiyat);
            }
            else
            {
            Console.WriteLine("İndirim Kazanamadınız !");
            Console.Write("Ödeyeceğiniz Tutar : {0}",fiyat);
            }
        }
    }
}
