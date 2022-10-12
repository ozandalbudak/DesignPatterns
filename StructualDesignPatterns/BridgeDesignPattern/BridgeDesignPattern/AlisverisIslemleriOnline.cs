using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDesignPattern
{
    public class AlisverisIslemleriOnline : AlisverisIslemleriBase
    {
        public override void SatisYap(string kullanici, string urun, decimal fiyat)
        {
            Console.WriteLine(String.Format("Session objesine ekleme işlemi yapıldı.{0}/{1}/{2}", kullanici, urun, fiyat));
            Console.WriteLine();
        }
    }
}
