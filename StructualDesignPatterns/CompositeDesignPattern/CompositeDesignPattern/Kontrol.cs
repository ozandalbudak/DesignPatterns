using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeDesignPattern
{
    abstract class Kontrol
    {
        public string _id;
        public string _text;
        public KontrolTip _tip;
        public Kontrol(string id, string text, KontrolTip tip)
        {
            _id = id;
            _text = text;
            _tip = tip;
        }
        public abstract void Ekle(Kontrol uye);
        public abstract void Sil(Kontrol uye);
        public abstract void Goster(int satirBosluk);
    }
}
