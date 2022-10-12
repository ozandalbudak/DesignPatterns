using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPattern
{
    class Printer
    {
        private PrinterState printerState;
        public PrinterState State
        {
            get
            {
                return printerState;
            }
            set
            {
                printerState = value;
                printerState.GetState(this);
            }
        }
        public Printer()
        {
            State = new StatePrinterLoading();
        }
        public void PrintDocument(string documentPath)
        {
            Console.WriteLine("Yazdırılacak döküman geldi");
            State = new StatePrinterBusy();
            Console.WriteLine(documentPath + " yazdırıldı.");
            State = new StatePrinterReady();
        }
    }
}