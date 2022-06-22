using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPatterns
{
    public class Product
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public string Anakart { get; set; }
        public string Cpu { get; set; }
        public string Ram { get; set; }
        public string HDD { get; set; }
        public string Kasa { get; set; }
        public string Klavye { get; set; }
        public string Mouse { get; set; }
        public string Monitor { get; set; }
        public string OS { get; set; }
        public override string ToString()
        {
            return Marka + " Marka " + Model + " Model bilgisayar üretildi.";
        }
    }
}
