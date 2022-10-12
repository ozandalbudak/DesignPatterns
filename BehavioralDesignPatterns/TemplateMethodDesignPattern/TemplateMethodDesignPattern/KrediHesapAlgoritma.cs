using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodDesignPattern
{
    abstract class KrediHesapAlgoritma
    {
        public abstract void Yontem1();
        public abstract void Yontem2();
        public void Hesapla(int tutar, int vade)
        {
            if (tutar < 400)
                Yontem1();
            else
                Yontem2();
            Console.WriteLine("");
        }
    }
}
