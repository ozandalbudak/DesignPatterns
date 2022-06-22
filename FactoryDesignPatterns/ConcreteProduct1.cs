using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPatterns
{
    public class ConcreteProduct1: Product
    {
        public override void Konus()
        {
            Console.WriteLine("Türkiye için üretilen nesne Merhaba Dünya  diyor..."); 
 }
    }
}
