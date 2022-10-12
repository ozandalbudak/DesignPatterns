using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodDesignPattern
{
    class Konut : KrediHesapAlgoritma
    {
        public override void Yontem1()
        {
            Console.WriteLine("% 0,5 oran ile");
        }
        public override void Yontem2()
        {
            Console.WriteLine("% 2 oran ile");
        }
    }
}
