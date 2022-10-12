using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            KrediHesapAlgoritma konut = new Konut();
            konut.Hesapla(500, 10);
            KrediHesapAlgoritma tasit = new Tasit();
            tasit.Hesapla(300, 10);
            Console.ReadKey();
        }
    }
}
