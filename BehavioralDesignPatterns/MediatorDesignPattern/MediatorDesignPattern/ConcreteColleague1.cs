using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorDesignPattern
{
    class ConcreteColleague1 : Katilimci
    {
        public ConcreteColleague1(string ad)
        : base(ad)
        {
        }
        public override void MesajAlici(string kimden, string mesaj)
        {
            Console.Write("Kime -> ConcreteColleague1: ");
            base.MesajAlici(kimden, mesaj);
        }
    }
}
