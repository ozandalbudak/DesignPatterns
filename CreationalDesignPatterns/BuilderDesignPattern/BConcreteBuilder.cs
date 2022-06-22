using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPatterns
{
    public class BConcreteBuilder : ComputerBuilder
    {
        public BConcreteBuilder()
        {
            computer = new Product();
        }
        public override void UretimHattinaAl()
        {
            computer.Marka = "B";
            computer.Model = "Server 200";
        }
        public override void CihazMontaj()
        {
            computer.Anakart = "Asus";
            computer.Cpu = "Amd";
            computer.HDD = "Maxtor 200GB";
            computer.Kasa = "AOpen";
            computer.Klavye = "OEM";
            computer.Mouse = "OEM";
            computer.Monitor = "Samsung";
            computer.Ram = "Kingston 4GB";
        }
        public override void IsletimSistemiKurulum()
        {
            computer.OS = "Linux";
        }
    }
}
