using System;

namespace faktoriyelfor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("bir sayı giriniz");
            int gs = Convert.ToInt32(Console.ReadLine());
            int s=1;
            /*faktöriyel 1'den n'e kadar olan sayıların çarpımına n faktöriyel denir
            5!=1.2.3.4.5=120 */
            for(int i=gs; i>1; i--)
            {
                s=s*i;
                Console.WriteLine(s);
            }
            
        }
    }
}
