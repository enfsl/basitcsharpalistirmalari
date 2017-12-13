using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fortamkarekok
{
    class Program
    {
        static void Main(string[] args)
        {
            /* kullanıcı tarafından sayının varsa tam karekökünü bulan program*/
            int s = Convert.ToInt32(Console.ReadLine());
            bool durum = false;
            for (int i = 1; i <= s; i++)
                if (i * i == s)
                {
                    Console.WriteLine("Karekökü = {0}", i);
                    durum = true;
                }
            if (durum == false)
                Console.WriteLine("karekökü yok");

        }
    }
}
