using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPattern
{
    class StatePrinterLoading : PrinterState
    {
        public StatePrinterLoading()
        {
            Console.WriteLine("Printer Loading");
        }
        public override void GetState(Printer context)
        {
            Console.WriteLine("Printer Yüklendi Kullanıma Hazır");
            context.State = new StatePrinterReady();
        }
    }
}
