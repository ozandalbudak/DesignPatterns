using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPattern
{
    abstract class DecoratorBase : ComponentBase
    {
        protected ComponentBase DosyaYonetici;
        public DecoratorBase(ComponentBase dosyaYonetici)
        {
            DosyaYonetici = dosyaYonetici;
        }
        public override void Kopyala()
        {
            if (DosyaYonetici != null)
                DosyaYonetici.Kopyala();
        }
    }
}
