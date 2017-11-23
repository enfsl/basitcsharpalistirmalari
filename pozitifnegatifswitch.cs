using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pozitifnegatifswitch
{
    class Program
    {
        static void Main(string[] args)
        {
            /* POZİTİF-POZİTİF TOPLA
             * POZİTİF-NEGATİF ÇARP
             * NEGATİF-POZİTİF ÇIKART
             * NEGATİF-NEGATİF BÖL
             */
            int sayi1, sayi2;
            Console.WriteLine("İlk sayıyı giriniz");
            sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("İkinci sayıyı giriniz");
            sayi2 = Convert.ToInt32(Console.ReadLine());
            bool d1 = (sayi1 > 1) ? true : false;
            bool d2 = (sayi2 > 1) ? true : false;
            int topla, carp, bol, cıkart;
            topla = sayi1 + sayi2;
            carp = sayi1 * sayi2;
            cıkart = sayi1 - sayi2;
            bol = sayi1 / sayi2;
            switch (d1)
            {
                case true:
                    {
                        switch (d2)
                        {
                            case true: Console.Write("sonuc = {0} GİRDİĞİNİZ SAYILAR POZİTİF BU YÜZDEN TOPLANDI",topla);break;
                            case false: Console.Write("sonuc = {0} GİRDİĞİNİZ SAYILAR POZİTİF-NEGATİF BU YÜZDEN ÇARPILDI", carp);break;
                        }
                    }
                    break;
                case false:
                    {
                        switch(d2)
                        {
                            case true: Console.Write("sonuc = {0} GİRDİĞİNİZ SAYILAR NEGATİF-POZİTİF BU YÜZDEN ÇIKARILDI", cıkart); break;
                            case false: Console.Write("sonuc = {0} GİRDİĞİNİZ SAYILAR NEGATİF-NEGATİF BU YÜZDEN BÖLÜNDÜ", bol); break;
                        }
                    }
                    break;
            }
            Console.ReadKey();
        }
    }
}
