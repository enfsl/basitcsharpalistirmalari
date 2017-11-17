using System;

namespace negatifpozitif
{
    class Program
    {
        static void Main(string[] args)
        {
			/* Girilen sayının negatif mi pozitif mi yoksa sıfıra mı eşit olduğunu bulun*/
			int a;
			Console.WriteLine("Bir Sayı Giriniz");
			a = Convert.ToInt32(Console.ReadLine());
			if(a>0)
			{
				Console.Write("Girdiğiniz Sayı Pozitif");
			}
			else if(a<0)
			{
				Console.Write("Girdiğiniz Sayı Negatif");
			}
			else
			{
				Console.Write("Girdiğiniz Sayı 0'a eşit");
			}
        }
    }
}
