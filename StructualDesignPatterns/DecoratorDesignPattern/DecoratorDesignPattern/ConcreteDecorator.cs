using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPattern
{
    class ConcreteDecorator : DecoratorBase
    {
        public ConcreteDecorator(ComponentBase dosyaYonetici)
        : base(dosyaYonetici)
        {
        }
        public void Ac()
        {
            Console.WriteLine("{0} dosya yoneticisi {1} dosyasını açtı.",
           base.DosyaYonetici.Ad, DosyaYonetici.Kaynak);
        }
        public void Sil()
        {
            Console.WriteLine("{0} dosya yoneticisi {1} dosyasını sildi.", base.DosyaYonetici.Ad, base.DosyaYonetici.Kaynak);
        }
        public void KisaYolOlustur()
        {
            Console.WriteLine("{0} dosya yoneticisi {1} dosyası için {2}  konumunda kısayol oluşturdu.", base.DosyaYonetici.Ad, 
           base.DosyaYonetici.Kaynak, base.DosyaYonetici.Hedef);
        }
        public override void Kopyala()
        {
            base.Kopyala();
        }
    }

}
