using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPattern
{
    class StatePrinterReady : PrinterState
    {
        public StatePrinterReady()
        {
            Console.WriteLine("Printer Ready");
        }
        public override void GetState(Printer context)
        {
            Console.WriteLine("Yeni Yazdırma İşlemi İsteği İçin Bekliyor."); 
        }
    }
}
