using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPattern
{
    public class Client
    {
        public void OdenecekMeblayiHesapla(ITutarHesaplayici hesaplayici)
        {
            Console.WriteLine("\nLutfen fiyati giriniz.\n");
            double fiyat = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nLütfen miktari giriniz.\n");
            double miktar = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nTutar = "+hesaplayici.Hesapla(fiyat,miktar));
            Console.WriteLine();
        }
    }
}
