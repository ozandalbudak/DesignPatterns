using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainofResponsibilityDesignPattern
{
    class Sef : CORHandler
    {
        public override void Istek(OdemeYetkisi odemeYetkisi)
        {
            if (odemeYetkisi.Yetki == true && odemeYetkisi.Miktar < 5000)
            {
                Console.WriteLine("{0} Ödeme onaylandı.",
               this.GetType().Name);
            }
            else if (successor != null)
            {
                successor.Istek(odemeYetkisi);
            }
        }
    }
}
