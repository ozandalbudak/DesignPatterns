using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPatterns
{
    public class Director
    {
        public void BilgisayarUret(ComputerBuilder computerBuilder)
        {
            computerBuilder.UretimHattinaAl();
            computerBuilder.CihazMontaj();
            computerBuilder.IsletimSistemiKurulum();
        }
    }
}
