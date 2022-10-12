using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
			var alisveris = new Alisveris();
			alisveris.Kullanici = "Engin Demiroğ";
			alisveris.Urun = "Navigasyon Cihazı";
			alisveris.Fiyat = 200;
			alisveris.AlisverisIslemleri = new AlisverisIslemleriOnline();
			alisveris.Ekle();
			alisveris.AlisverisIslemleri = new AlisverisIslemleriVeritabani();
			alisveris.Ekle();

			var indirimliAlisveris = new IndirimliAlisveris();
			indirimliAlisveris.Kullanici = "Engin Demiroğ";
			indirimliAlisveris.Urun = "Navigasyon Cihazı";
			indirimliAlisveris.Fiyat = 200;
			indirimliAlisveris.IndirimOrani = 30;
			indirimliAlisveris.AlisverisIslemleri = new AlisverisIslemleriVeritabani();
			indirimliAlisveris.SatisYap();
			Console.ReadLine();

		}
	}
}
