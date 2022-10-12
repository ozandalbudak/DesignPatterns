using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorDesignPattern
{
    class Katilimci
    {
        private ConcreteMediator _concreteMediator;
        private string _ad;
        public Katilimci(string ad)
        {
            this._ad = ad;
        }
        public string Ad
        {
            get { return _ad; }
        }
        public ConcreteMediator concreteMediator
        {
            set { _concreteMediator = value; }
            get { return _concreteMediator; }
        }
        public void MesajGonder(string kime, string mesaj)
        {
            _concreteMediator.MesajGonder(_ad, kime, mesaj);
        }
        public virtual void MesajAlici(string kimden, string mesaj)
        {
            Console.WriteLine("{0} to {1}: '{2}'", kimden, Ad, mesaj);
        }
    }
}
