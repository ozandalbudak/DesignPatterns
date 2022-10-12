using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodDesignPattern
{
    class Tasit : KrediHesapAlgoritma
    {
        public override void Yontem1()
        {
            Console.WriteLine("% 35 oran ile");
        }
        public override void Yontem2()
        {
            Console.WriteLine("% 32 oran ile");
        }
    }
}
