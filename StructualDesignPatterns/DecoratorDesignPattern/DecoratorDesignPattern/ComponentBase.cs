using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPattern
{
    abstract class ComponentBase
    {
        public string Ad;
        public string Kaynak;
        public string Hedef;
        public abstract void Kopyala();
    }
}
