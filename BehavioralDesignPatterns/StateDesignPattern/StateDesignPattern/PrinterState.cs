using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPattern
{
    abstract class PrinterState
    {
        public abstract void GetState(Printer context);
    }
}
