using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainofResponsibilityDesignPattern
{
    class Mudur : CORHandler
    {
        public override void Istek(OdemeYetkisi odemeYetkisi)
        {
            if (odemeYetkisi.Yetki == true)
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
