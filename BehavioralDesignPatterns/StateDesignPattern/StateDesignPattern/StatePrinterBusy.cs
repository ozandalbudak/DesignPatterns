using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPattern
{
    class StatePrinterBusy : PrinterState
    {
        public StatePrinterBusy()
        {
            Console.WriteLine("Printer Busy");
        }
        public override void GetState(Printer context)
        {
            Console.WriteLine("Printer Meşgul Yazdırma İşlemi Yapıyor.");
        }
    }
}
