using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
	internal class Program
	{
		static void Main(string[] args)
		{

			#region Yazdırma Komutları

			//Console.WriteLine("***** Yemek Kategorileri *****");
			//Console.WriteLine();
			//Console.WriteLine("1-Çorbalar");
			//Console.WriteLine("2-Ana Yemekler");
			//Console.WriteLine("3-Soğuk Başlangıçlar");
			//Console.WriteLine("4-Salatalar");
			//Console.WriteLine("5-Tatlılar");
			//Console.WriteLine("6-İçecekler");
			//Console.WriteLine();
			//Console.WriteLine("***** Yemek Kategorileri *****");

			#endregion

			#region String Değişkenler

			//string name;
			//name = "Ümran";
			//Console.Write(name);

			//string customerName;
			//string customerSurname;
			//string customerPhone;
			//string customerEmail, district, city;

			//customerName = "Ebru";
			//customerSurname = "Aydın";
			//customerPhone = "+90 500 400 30 20";
			//customerEmail = "ebru@gmail.com";
			//district = "Maltepe";
			//city = "İstanbul";

			//Console.WriteLine("**** Rezervasyon Kartı ****");
			//Console.WriteLine();
			//Console.WriteLine("-------------------------------------------------");
			//Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
			//Console.WriteLine("İletişim: " + customerPhone);
			//Console.WriteLine("Email Adresi: " + customerEmail);
			//Console.WriteLine("Adres: " + district + "/" + city);
			//Console.WriteLine("-------------------------------------------------");
			//Console.WriteLine();

			//customerName = "Edanur";
			//customerSurname = "Esertaş";
			//customerPhone = "+90 400 300 80 70";
			//customerEmail = "edanur@gmail.com";
			//district = "Sancaktepe";
			//city = "İstanbul";

			//Console.WriteLine("-------------------------------------------------");
			//Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
			//Console.WriteLine("İletişim: " + customerPhone);
			//Console.WriteLine("Email Adresi: " + customerEmail);
			//Console.WriteLine("Adres: " + district + "/" + city);
			//Console.WriteLine("-------------------------------------------------");

			#endregion

			#region Int Değişkenler

			int hamburgerPrice = 350;
			int cokePrice = 50;
			int waterPrice = 15;
			int friesPrice = 65;
			int pizzaPrice = 450;
			int lemonadePrice = 80;

			Console.WriteLine("**** Restoran Menü Fiyatı ****");
			Console.WriteLine();
			Console.WriteLine("-----Hamburger: " + hamburgerPrice + " TL");
			Console.WriteLine("-----Pizza: " + pizzaPrice + " TL");
			Console.WriteLine("-----Kola: " + cokePrice + " TL");
			Console.WriteLine("-----Limonata: " + lemonadePrice + " TL");
			Console.WriteLine("-----Kızartma: " + friesPrice + " TL");
			Console.WriteLine("-----Su: " + waterPrice + " TL");
			Console.WriteLine();
			Console.WriteLine("**** Restoran Menü Fiyatı ****");
			Console.WriteLine();

			int hamburgerCount;
			int cokeCount;
			int waterCount;
			int friesCount;
			int pizzaCount;
			int lemonadeCount;

			int totalHamgurgerPrice;
			int totalCokePrice;
			int totalWaterPrice;
			int totalFriesPrice;
			int totalPizzaPrice;
			int totalLemonadePrice;

			hamburgerCount = 5;
			cokeCount = 3;
			waterCount = 2;
			friesCount = 4;
			pizzaCount = 2;
			lemonadeCount = 2;

			totalHamgurgerPrice = hamburgerCount * hamburgerPrice;
			totalCokePrice = cokeCount * cokePrice;
			totalWaterPrice = waterCount * waterPrice;
			totalLemonadePrice = lemonadeCount * lemonadePrice;
			totalFriesPrice = friesCount * friesPrice;
			totalPizzaPrice = pizzaCount * pizzaPrice;

			Console.WriteLine("-------------------------------------");
			Console.WriteLine("Hamburger Tutarı: " + totalHamgurgerPrice + " TL");
			Console.WriteLine("Pizza Tutarı: " + totalPizzaPrice + " TL");
			Console.WriteLine("Kızartma Tutarı: " + totalFriesPrice + " TL");
			Console.WriteLine("Kola Tutarı: " + totalCokePrice + " TL");
			Console.WriteLine("Limonata Tutarı: " + totalLemonadePrice + " TL");
			Console.WriteLine("Su Tutarı: " + totalWaterPrice + " TL");

			Console.WriteLine();

			int totalPrice = totalCokePrice + totalWaterPrice + totalLemonadePrice + totalHamgurgerPrice + totalPizzaPrice + totalFriesPrice;

			Console.WriteLine("Toplam Ödenecek Tutar: " + totalPrice + " TL");

			#endregion

			Console.Read();

		}
	}
}
