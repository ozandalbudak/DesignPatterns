using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeDesignPatterns
{
    abstract class PrinterPrototype
    {
        public abstract PrinterPrototype Clone();
    }
}
