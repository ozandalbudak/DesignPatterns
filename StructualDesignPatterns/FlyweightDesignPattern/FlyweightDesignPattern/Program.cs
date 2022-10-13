using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Devre multivibrator = Devre.olustur();

            Eleman e1 = new Eleman("R1 100", new Konum(1, 1), ElemanTurleri.Direnc);
            e1.Render();
            Devre.ElemanEkle(e1);

            Eleman e2 = new Eleman("R2 22K", new Konum(1, 2), ElemanTurleri.Direnc);
            e2.Render();
            Devre.ElemanEkle(e2);

            Eleman e3 = new Eleman("R3 100", new Konum(1, 3), ElemanTurleri.Direnc);
            e3.Render();
            Devre.ElemanEkle(e3);

            Eleman e4 = new Eleman("R4 470", new Konum(1, 4), ElemanTurleri.Direnc);
            e4.Render();
            Devre.ElemanEkle(e4);

            Eleman e5 = new Eleman("LED1", new Konum(2, 1), ElemanTurleri.Led);
            e5.Render();
            Devre.ElemanEkle(e5);

            Eleman e6 = new Eleman("LED2", new Konum(2, 4), ElemanTurleri.Led);
            e6.Render();
            Devre.ElemanEkle(e6);

            Eleman e7 = new Eleman("C1 100", new Konum(3, 1), ElemanTurleri.Kodansator);
            e7.Render();
            Devre.ElemanEkle(e7);

            Eleman e8 = new Eleman("R5 47K", new Konum(3, 3), ElemanTurleri.Direnc);
            e8.Render();
            Devre.ElemanEkle(e8);

            Eleman e9 = new Eleman("T1 BC-547", new Konum(4, 1), ElemanTurleri.Transistor);
            e9.Render();
            Devre.ElemanEkle(e9);

            Eleman e10 = new Eleman("T1 BC-547", new Konum(4, 4), ElemanTurleri.Transistor);
            e10.Render();
            Devre.ElemanEkle(e10);
            Console.WriteLine("üretilen Farklı Eleman Sayısı: {0}", multivibrator.ElemanSayisi);

            Console.ReadLine();

        }
    }
}
