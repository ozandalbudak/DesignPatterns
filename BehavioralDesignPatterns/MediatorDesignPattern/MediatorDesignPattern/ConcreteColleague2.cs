using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorDesignPattern
{
    class ConcreteColleague2 : Katilimci
    {
        public ConcreteColleague2(string ad)
        : base(ad)
        {
        }
        public override void MesajAlici(string kimden, string mesaj)
        {
            Console.Write("Kime -> ConcreteColleague2: ");
            base.MesajAlici(kimden, mesaj);
        }
    }
}