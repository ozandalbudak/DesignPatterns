using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPattern
{
    public class Adaptee
    {
        public double IskontaliTutariHesapla(double fiyat,double adet)
        {
            Console.WriteLine("\nLütfen iskonto miktarını giriniz \n");
            double iskonto = Convert.ToDouble(Console.Read());
            return fiyat * adet * (1 - iskonto);
        }

    }
}
