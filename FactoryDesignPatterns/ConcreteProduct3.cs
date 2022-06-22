using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPatterns
{
    public class ConcreteProduct3 : Product
    {
        public override void Konus()
        {
            Console.WriteLine("Amerika için üretilen nesne Hello World  diyor..."); 
        }
    }
}
