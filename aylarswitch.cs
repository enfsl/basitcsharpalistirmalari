using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aylarswitch
{
    class Program
    {
        static void Main(string[] args)
        {   /*switch ile aylar*/
            Console.Write("1 ve 12 dahil bunların arasında bir sayı giriniz");
            int ay = Convert.ToInt32(Console.ReadLine());
            switch(ay)
            {
                case 12: 
                case 1:
                case 2: Console.WriteLine("kış mevsimi"); break;
                case 3: 
                case 4:
                case 5: Console.WriteLine("ilkbahar mevsimi"); break;
                case 6: 
                case 7:
                case 8: Console.WriteLine("yaz mevsimi"); break;
                case 9: 
                case 10:
                case 11: Console.WriteLine("sonbahar mevsimi"); break;
                default:Console.WriteLine("hatalı bir sayı girdiniz");break;
            }
            Console.ReadKey();
        }
    }
}
