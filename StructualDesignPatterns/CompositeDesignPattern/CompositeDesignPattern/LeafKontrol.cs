using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeDesignPattern
{
    class LeafKontrol : Kontrol
    {
        public LeafKontrol(string id, string text, KontrolTip tip)
        : base(id, text, tip)
        {
            //Leaf için kullanılmaz
        }
        public override void Ekle(Kontrol kontrol)
        {
            //Leaf için kullanılmaz
        }
        public override void Sil(Kontrol kontrol)
        {
            //Leaf için kullanılmaz
        }
        public override void Goster(int satirBosluk)
        {
            Console.WriteLine(new String('.', satirBosluk) + " " + _id + " " + _text);
        }
    }
}
