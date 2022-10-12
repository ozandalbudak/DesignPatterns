using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            ConcreteComponent dosyaYonetici = new
           ConcreteComponent(@"c:\a.txt", @"d:\a.txt", "D1");
            dosyaYonetici.Kopyala();
            ConcreteDecorator dekoratorDosyaYonetici = new
           ConcreteDecorator(dosyaYonetici);
            dekoratorDosyaYonetici.Sil();
            dekoratorDosyaYonetici.Ac();
            dekoratorDosyaYonetici.KisaYolOlustur();
            dekoratorDosyaYonetici.Kopyala();
            Console.Read();

        }
    }
}
