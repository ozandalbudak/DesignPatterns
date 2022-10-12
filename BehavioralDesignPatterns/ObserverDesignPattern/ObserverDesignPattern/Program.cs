using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            HavaDurumuRaporu rapor = new HavaDurumuRaporu();
            Gozlemleyici g1 = new Gozlemleyici
            {
                Kimlik = "ABC Denizcilik"
            };
            rapor.GozlemleyiciEkle(g1);
            Gozlemleyici g2 = new Gozlemleyici
            {
                Kimlik = "DEF Yat Limanı"
            };
            rapor.GozlemleyiciEkle(g2);
            rapor.Durum = "Parçalı Bulutlu";
            rapor.Ruzgar = 3;
            rapor.RuzgarYonu = "Lodos";
            rapor.Sicaklik = 25;
            Console.WriteLine("Nesne Hava Durumu Yayınlıyor...");
            rapor.SonGuncelleme = DateTime.Now;
            Console.ReadLine();
        }
    }
}
