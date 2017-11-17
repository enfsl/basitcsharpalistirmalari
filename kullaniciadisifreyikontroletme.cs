using System;

namespace kullaniciadisifreyikontroletme
{
    class Program
    {
        static void Main(string[] args)
        {
			/* kullanıcı adı ve şifrenin doğru olduğunu kontrol eden program*/
			string a,b;
			Console.Write("Kullanıcı Adını Giriniz : ");
			a = Console.ReadLine();
			Console.Write("Kullanıcı Şifresini Giriniz : ");
			b = Console.ReadLine();
			if((a=="emrenefesli") && (b=="1234567890"))
			{
				Console.Write("Kullanıcı Adı ve Şifre Doğru");
			}
			else
			{
				if((a!="emrenefesli") && (b=="1234567890"))
				{
					Console.Write("Kullanıcı adı hatalı ! ");
				}
				else if((b!="1234567890") && (a=="emrenefesli"))
				{
					Console.Write("Şifre yanlış ! ");
				}
				else
				{
					Console.Write("Kullanıcı Adı ve Şifre Yanlış ! ");
				}
			}
        }
    }
}
