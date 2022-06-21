using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPatterns
{
    public abstract class ComputerBuilder
    {
        protected Product computer;
        public Product Computer
        {
            get { return computer; }
        }
        public abstract void UretimHattinaAl();
        public abstract void CihazMontaj();
        public abstract void IsletimSistemiKurulum();
    }
}
