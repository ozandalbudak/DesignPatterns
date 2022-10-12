using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDesignPattern
{
    public class HavaDurumuRaporu
    {
        private DateTime sonGuncelleme;
        public DateTime SonGuncelleme
        {
            get
            {
                return sonGuncelleme;
            }
            set
            {
                sonGuncelleme = value;
                GozlemleyicileriUyar();
            }
        }
        public string Durum { get; set; }
        public int Sicaklik { get; set; }
        public int Ruzgar { get; set; }
        public string RuzgarYonu { get; set; }
        private List<IGozlemleyici> gozlemleyiciler;
        public HavaDurumuRaporu()
        {
            gozlemleyiciler = new List<IGozlemleyici>();
        }
        public void GozlemleyiciEkle(IGozlemleyici gozlemleyici)
        {
            gozlemleyiciler.Add(gozlemleyici);
        }
        public void GozlemleyiciSil(IGozlemleyici gozlemleyici)
        {
            gozlemleyiciler.Remove(gozlemleyici);
        }
        private void GozlemleyicileriUyar()
        {
            foreach (IGozlemleyici gozlemleyici in gozlemleyiciler)
            {
                gozlemleyici.Guncelle(this);
            }
        }
    }
}
