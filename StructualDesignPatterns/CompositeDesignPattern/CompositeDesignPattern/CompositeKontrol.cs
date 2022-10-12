using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeDesignPattern
{
    class CompositeKontrol : Kontrol
    {
        //Composite tip içinde tutulacak componentler için generic list
        private List<Kontrol> _kontroller = new List<Kontrol>();
        public CompositeKontrol(string id, string text, KontrolTip tip)
        : base(id, text, tip)
        {
        }
        public override void Ekle(Kontrol uye)
        {
            _kontroller.Add(uye);
        }
        public override void Sil(Kontrol uye)
        {
            _kontroller.Remove(uye);
        }
        public override void Goster(int satirBosluk)
        {
            Console.WriteLine(new String('.', satirBosluk) + "+ " + _id + " " +
           _text);
            foreach (Kontrol kontrol in _kontroller)
            {
                kontrol.Goster(satirBosluk + 1);
            }
        }
    }
}
