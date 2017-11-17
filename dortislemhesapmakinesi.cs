using System;

namespace dortislemhesapmakinesi
{
    class Program
    {
        static void Main(string[] args)
        {
			/*hesap makinesi yap*/
			string basilan;
			double a,b;
			Console.Write("İlk Sayıyı Giriniz : ");
			a = Convert.ToDouble(Console.ReadLine());
			Console.Write("İkinci Sayıyı Giriniz : ");
			b = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Toplama (t), Çıkartma (c), Çarpma (cr), Bölme (b) ");
			basilan = Console.ReadLine();
			if(basilan=="t")
			{
				double sonuc = a + b;
				Console.WriteLine("Sayıların Toplamı : {0}",sonuc);
			}
			else if(basilan=="c")
			{
				double sonuc = a - b;
				Console.WriteLine("Sayıların Çıkarması : {0}",sonuc);
			}
			else if(basilan=="cr")
			{
				double sonuc = a * b;
				Console.WriteLine("Sayıların Çarpımı : {0}",sonuc);
			}
			else if(basilan=="b")
			{
				double sonuc = a / b;
				Console.WriteLine("Sayıların Bölümü : {0}",sonuc);
			}
			
        }
    }
}
