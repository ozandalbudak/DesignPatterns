using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDesignPattern
{
	class IndirimliAlisveris : Alisveris
	{
		public int IndirimOrani { get; set; }
		public void SatisYap()
		{
			AlisverisIslemleri.SatisYap(Kullanici, Urun, Fiyat * (100 - IndirimOrani) / 100);
		}
	}

}
