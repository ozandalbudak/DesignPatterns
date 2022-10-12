using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDesignPattern
{
    class Facade
    {
        private AltSistem1 _altSistem1;
        private AltSistem2 _altSistem2;
        public Facade()
        {
            _altSistem1 = new AltSistem1();
            _altSistem2 = new AltSistem2();

        }
        public void Method1()
        {
            Console.WriteLine("Method1() Çalıştırıldı");
            _altSistem1.Method1();
        }
        public void Method2()
        {
            Console.WriteLine("Method2() Çalıştırıldı");
            _altSistem2.Method2();
        }
    }
}
