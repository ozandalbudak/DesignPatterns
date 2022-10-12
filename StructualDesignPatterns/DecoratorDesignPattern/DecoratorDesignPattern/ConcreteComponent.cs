using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPattern
{
    class ConcreteComponent : ComponentBase
    {
        public ConcreteComponent(string kaynak, string hedef, string ad)
        {
            base.Ad = ad;
            base.Kaynak = kaynak;
            base.Hedef = hedef;
        }
        public override void Kopyala()
        {
            Console.WriteLine("{0} dosya yöneticisi {1} kaynaktan {2} hedefe kopyalama işlemi yaptı.", Ad, Kaynak, Hedef); 
        }
    }
}
