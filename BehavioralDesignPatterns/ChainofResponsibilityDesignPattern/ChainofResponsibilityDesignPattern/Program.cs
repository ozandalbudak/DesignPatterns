using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainofResponsibilityDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            CORHandler memur = new Memur();
            CORHandler sef = new Sef();
            CORHandler mudur = new Mudur();
            memur.Successor(sef);
            sef.Successor(mudur);
            OdemeYetkisi odeme = new OdemeYetkisi()
            {
                Miktar = 800,
                Yetki
           = true
            };
            memur.Istek(odeme);
            odeme = new OdemeYetkisi() { Miktar = 4000, Yetki = true };
            memur.Istek(odeme);
            odeme = new OdemeYetkisi() { Miktar = 2000, Yetki = true };
            sef.Istek(odeme);
            odeme = new OdemeYetkisi() { Miktar = 6000, Yetki = true };
            sef.Istek(odeme);
            odeme = new OdemeYetkisi() { Miktar = 10000, Yetki = true };
            mudur.Istek(odeme);
            Console.ReadKey();
        }
    }
}
