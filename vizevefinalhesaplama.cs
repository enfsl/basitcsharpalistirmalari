using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vizevefinalhesaplama
{
    class Program
    {
        static void Main(string[] args)
        {
            int vize, final;
            Console.Write("Vize notunuzu giriniz");
            vize = Convert.ToInt32(Console.ReadLine());
            Console.Write("Final notunuzu giriniz");
            final = Convert.ToInt32(Console.ReadLine());
            double fs = vize * 0.4 + final * 0.6;
            if (fs < 50 || final < 50)
            {
                Console.Write("Bütünleme Notu :");
                int but = Convert.ToInt32(Console.ReadLine());
                double bs = vize * 0.4 + but * 0.6;
                if (bs < 50 || but < 50)
                {
                    Console.WriteLine("kaldınız.");
                }
                else
                {
                    Console.WriteLine("{0} ile geçtiniz", bs);
                }
            }

            else
            {
                Console.WriteLine("{0} ile geçtiniz",fs);
            }

        }
    }
}
