using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeDesignPatterns
{
     class Printer : PrinterPrototype
    {
        public byte Address { get; set; }
        public string Name { get; set; }
        public bool ColorCartridge { get; set; }
        public bool BlackCartridge { get; set; }
        public int ResolutionDpi { get; set; }
        public string PaperSize { get; set; }
        public Printer(byte address, string name, bool colorCartridge,
        bool blackCartridge, int resolution, string paperSize)
        {
            Address = address;
            Name = name;
            ColorCartridge = colorCartridge;
            BlackCartridge = blackCartridge;
            ResolutionDpi = resolution;
            PaperSize = paperSize;
            System.Threading.Thread.Sleep(1000);
        }
        public override PrinterPrototype Clone()
        {
            // Klonlama işlemi. Gelen nesnenin bir kopyası alınıp sonuç             olarak döndürülüyor. 
 return (PrinterPrototype)this.MemberwiseClone();
        }
    }
}
