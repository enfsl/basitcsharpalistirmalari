using System;

namespace ikisayininenbuyukvenkucukolanibulma
{
    class Program
    {
        static void Main(string[] args)
        {
			int sayi1,sayi2;
			/*Klavyeden girilen 2 sayının en büyük ve en küçük hangisi olduğunu bulan program */
			Console.Write("Birinci Sayıyı Giriniz : ");
			sayi1 = Convert.ToInt32(Console.ReadLine());
			Console.Write("İkinci Sayıyı Giriniz : ");
			sayi2 = Convert.ToInt32(Console.ReadLine());
			if(sayi1>sayi2)
			{
				Console.Write("Girdiğiniz İlk Sayı Daha Büyük ! {0}",sayi1);
			}
			else if(sayi2>sayi1)
			{
				Console.Write("Girdiğiniz İkinci Sayı Daha Büyük ! {0}",sayi2);
			}
			else
			{
				Console.Write("Girdiğiniz Sayılar Birbirine Eşit ! {0} = {1}",sayi1 ,sayi2);
			}
        }
    }
}
