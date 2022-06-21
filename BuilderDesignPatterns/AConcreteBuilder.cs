using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPatterns
{
    public class AConcreteBuilder : ComputerBuilder
    {
        public AConcreteBuilder()
        {
            computer = new Product();
        }
        public override void UretimHattinaAl()
        {
            computer.Marka = "A";
            computer.Model = "Home 1000";
        }
        public override void CihazMontaj()
        {
            computer.Anakart = "Gigabyte";
            computer.Cpu = "Intel";
            computer.HDD = "Samsung 300GB";
            computer.Kasa = "AOpen";
            computer.Klavye = "OEM";
            computer.Mouse = "OEM";
            computer.Monitor = "Philips";
            computer.Ram = "Kingston 2GB";
        }
        public override void IsletimSistemiKurulum()
        {
            computer.OS = "Windows 7";
        }
    }
}
