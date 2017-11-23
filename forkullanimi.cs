using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forkullanimi
{
    class Program
    {
        static void Main(string[] args)
        {
         /*for:
         (için anlamına gelir)
         kullanım şekli: for(ifade1; şart; ifade2)
         veya;
         for(ifade1; şart; ifade2)
         {
         komut1;
         komut2;
         ..
         ..
         komutn;
         }

         ÇALIŞMA MANTIĞI;
         1-)ifade1 çalıştırılır
         2-)şart'a bakılır true değer üretirse;
         2.1-)Blok içi çalıştırılır
         2.2-)ifade2 çalıştırılır
         2.3-)Tekrar ifade2'ye dönülür
         3-)false değer üretmişse blok sonuna gidilir
         örneğin;
         */
         for(int a=1; a<11; a++)
            {
                Console.WriteLine("Yönetim Bilişim Sistemleri");
            }
            Console.ReadKey();
         /* ekrana 10 defa yönetim bilişim sistemleri yazar*/
        }
    }
}
