using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDesignPattern
{
	class Alisveris
	{
		public AlisverisIslemleriBase AlisverisIslemleri { get; set; }
		public string Kullanici { get; set; }
		public string Urun { get; set; }
		public decimal Fiyat { get; set; }
		public virtual void Ekle()
		{
			AlisverisIslemleri.SatisYap(Kullanici, Urun, Fiyat);
		}
	}

}
