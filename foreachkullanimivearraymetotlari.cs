using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace foreachkullanimivearraymetotlari
{
    class Program
    {
        static void Main(string[] args)
        {
            // foreach kullanımı
            // foreach her turda dizinin içindeki terimi değişkenin içine aktarır
            // foreach bloğu içerisinde değişkene birşey atamazsın 
            // mesela i=3; yada i++; gibi olmuyor..
            Console.WriteLine("foreach ile diziden terimleri yazdırma ; ");
            int[] dizi = { 3, 2, 5, 7, 9, 11, 88 };
            foreach (int i in dizi)
                Console.WriteLine(i);
            Console.WriteLine("----------------------------------");

            // copyto kullanımı
            Console.WriteLine("Copyto kullanımı ile bir diziden diğerine terimleri kopyalama");
            int[] d1 = { 3, 2, 5, 7, 9, 11, 88 };
            int[] d2 = new int[10];
            d1.CopyTo(d2, 2); // d1 dizisini d2'e kopyala (, den sonra kaçıncı teriminden itibaren atmak istiyorsak
            foreach (int i in d2) // burda 0 ve 1 terimi es geçip 2 terimden itibaren aktaracak.
                Console.WriteLine(i);
            Console.WriteLine("----------------------------------");

            // Array sınıfından copy metotunu kullanma
            Console.WriteLine("Array sınıfından copy metotu ile bir diziden diğerine terimleri kopyalama");
            int[] d3 = { 3, 2, 5, 7, 9, 11, 88 };
            int[] d4 = new int[10];
            Array.Copy(d3, d4, 3); // d1 dizisini d2'e kopyala sadece ilk 3 elemanını
            //Array.Copy(d3, 0, d4, 4, 2); // d1'in sıfırıncısından başla iki tanesini al d2'nin 4'üncüsünden itibaren yerleştir
            foreach (int i in d4)
                Console.WriteLine(i);
            Console.WriteLine("----------------------------------");

            // Array Reverse ile diziyi ters çevirme
            Console.WriteLine("Array Reverse ile diziyi ters çevirme ");
            int[] dizi1 = { 3, 2, 5, 7, 9, 11, 88 };
            Array.Reverse(dizi1);
            foreach (int i in dizi1)
                Console.WriteLine(i);
            Console.WriteLine("----------------------------------");

            // Array Clear ile dizinin içindeki terimleri silme
            Console.WriteLine("Array clear ile dizinin içindeki terimleri silme ");
            int[] dizi2 = { 3, 2, 5, 7, 9, 11, 88 };
            Array.Clear(dizi2,1,2); // dizi2 dizisinin 1 teriminden başla 2 tanesini temizle
            foreach (int i in dizi2)
                Console.WriteLine(i);
            Console.WriteLine("----------------------------------");

            // Array Sort ile diziyi sıralama
            Console.WriteLine("Array Sort ile diziyi sıralama(küçükten büyüğe felan)");
            int[] dizi3 = { 3, 2, 5, 7, 9, 11, 88 };
            Array.Sort(dizi3);
            foreach (int i in dizi3)
                Console.WriteLine(i);
            Console.WriteLine("----------------------------------");

            // Array BinarySearch ile dizinin içerisinde arama yapma
            Console.WriteLine("Array BinarySearch ile dizinin içerisinde arama yapma");
            int[] dizi4 = { 3, 2, 5, 7, 9, 11, 88 };
            Array.Sort(dizi4); // BinarySearch kullanılmadan önce Sort ile dizi sıralanmalıdır!
            int s = Array.BinarySearch(dizi4, 11); // 11 sayısını hangi terimde olduğunu bulup bunu bir değişkene atar
            Console.WriteLine(s);
            Console.WriteLine("----------------------------------");


        }
    }
}
