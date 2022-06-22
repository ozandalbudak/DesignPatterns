using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPatterns
{
    public class ConcreteProduct2 : Product
    {
        public override void Konus()
        {
            Console.WriteLine("İspanya için üretilen nesne Hola Mundo  diyor..."); 
        }
    }
}
