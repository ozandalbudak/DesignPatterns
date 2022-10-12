using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorDesignPattern
{
    class ConcreteMediator : Mediator
    {
        private Dictionary<string, Katilimci> _katilimcilar = new
       Dictionary<string, Katilimci>();
        public override void KayitOl(Katilimci katilimci)
        {
            if (!_katilimcilar.ContainsValue(katilimci))
            {
                _katilimcilar[katilimci.Ad] = katilimci;
            }
            katilimci.concreteMediator = this;
        }
        public override void MesajGonder(string kimden, string kime,
       string mesaj)
        {
            Katilimci katilimci = _katilimcilar[kime];
            if (katilimci != null)
            {
                katilimci.MesajAlici(kimden, mesaj);
            }
        }
    }
}
