using System;

namespace girilenikisayininnotortalamasinialan
{
    class Program
    {
        static void Main(string[] args)
        {
			/* Girilen iki sayının not ortalamasını alıp geçip geçmediğini söyleyen program*/
			int not1,not2;
			Console.Write("İlk notu giriniz");
			not1 = Convert.ToInt32(Console.ReadLine());
			Console.Write("İkinci notu giriniz");
			not2 = Convert.ToInt32(Console.ReadLine());
			int ortalama = (not1+not2) / 2;
			if(ortalama >= 50)
			{
				Console.Write("Dersi Geçtiniz");
			}
			else /*else'nin içine birşey yazmaya gerek kalmadı çünkü >= dediğim için diğer ihtimal <= olarak kaldı gerek olmadı */
			{
				Console.Write("Sınavı Geçemediniz !");
			}
        }
    }
}
