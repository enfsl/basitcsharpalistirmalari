using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tekciftswitch
{
    class Program
    {
        static void Main(string[] args)
        {
            /*switch ile iki sayının tekmi çiftmi olduğunu bulma*/
            int sayi1, sayi2;
            int ks1, ks2;
            Console.Write("İlk sayıyı giriniz");
            sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("İkinci sayıyı giriniz");
            sayi2 = Convert.ToInt32(Console.ReadLine());
            ks1 = sayi1 % 2;
            ks2 = sayi2 % 2;
            switch(ks1)
            {
                case 1:
                    {
                        switch (ks2)
                        {
                            case 1: Console.Write("tek-tek"); break;
                            case 0: Console.Write("tek-çift"); break;
                        }
                        break;
                    }
                case 0:
                    {
                        switch (ks2)
                        {
                            case 1: Console.Write("çift-tek");break;
                            case 0: Console.Write("çift-çift");break;
                        }
                    }
                    break;
            }
            Console.ReadKey();
        }
    }
}
