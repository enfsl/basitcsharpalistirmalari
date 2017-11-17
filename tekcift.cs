using System;

namespace tekcift
{
    class Program
    {
        static void Main(string[] args)
        {
			int a;
			/*Girilen sayının tekmi çiftmi olduğunu hesaplayan program*/
			Console.Write("Bir sayı giriniz : ");
			a = Convert.ToInt32(Console.ReadLine());
			if(a%2==0)
			{
				Console.Write("Girdiğiniz Sayı Çift");
			}
			else
			{
				Console.Write("Girdiğiniz Sayı Tek");
			}
        }
    }
}
