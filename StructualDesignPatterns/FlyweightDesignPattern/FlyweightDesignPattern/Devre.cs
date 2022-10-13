using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightDesignPattern
{
    public class Devre
    {
        private static Devre d = null;
        private static List<DevreElemani> elemanlar;
        private Devre()
        {
            elemanlar = new List<DevreElemani>();
        }
        public static Devre olustur()
        {
            if (d == null)
            {
                d = new Devre();
            }
            return d;
        }
        public static DevreElemani ElemanEkle(Eleman eleman)
        {
            DevreElemani temp = null;
            for (int i = 0; i <= elemanlar.Count-1; i++)
            {
                if(((Eleman)elemanlar[i]).CompareTo(eleman)==1)
                {
                    temp = eleman;
                }
            }
            if(temp is null)
            {
                temp = new Eleman() { 
                Detay=eleman.Detay,
                Konum=eleman.Konum,
                Tur=eleman.Tur};
                elemanlar.Add(temp);
            }
            return temp;
        }
        public int ElemanSayisi
        {
            get
            {
                return elemanlar.Count;
            }
        }
    }
}
