using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightDesignPattern
{
    public class Eleman : DevreElemani, IComparable
    {
        private ElemanTurleri tur;
        private String detay;
        private Konum konum;
        public Eleman()
        { }

        public Eleman(string detay, Konum konum,ElemanTurleri tur)
        {
            this.tur = tur;
            this.detay = detay;
            this.konum = konum;
        }

        public ElemanTurleri Tur { get => tur; set => tur = value; }
        public string Detay { get => detay; set => detay = value; }
        public Konum Konum { get => konum; set => konum = value; }

        public override void Render()
        {
            Console.WriteLine("X:{0}-Y:{1} konumundaki {2} elemanı render edildi", Konum.X, Konum.Y, Detay);
        }
        public int CompareTo(object obj)
        {
            if (obj is Eleman)
            {
                Eleman e = (Eleman)obj;
                if (e.Tur == this.Tur)
                    return 1;
                else
                    return 0;
            }
            else
                return -1;
        }
    }
}
