using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDesignPattern
{
    public class Gozlemleyici : IGozlemleyici
    {
        public void Guncelle(HavaDurumuRaporu havaDurumuRaporu)
        {
            Console.WriteLine("Yeni hava durumu yayınlandı yayın tarihi / saati " + havaDurumuRaporu.SonGuncelleme.ToString()); 
        }
        public string Kimlik { get; set; }
    }
}
