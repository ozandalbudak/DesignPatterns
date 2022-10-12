using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorDesignPattern
{
    abstract class Mediator
    {
        public abstract void KayitOl(Katilimci katilimci);
        public abstract void MesajGonder(string kimden, string kime,
       string mesaj);
    }
}
