using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteMediator sohbetOdasi = new ConcreteMediator();
            Katilimci Can = new ConcreteColleague1("Can");
            Katilimci Canan = new ConcreteColleague1("Canan");
            Katilimci Baris = new ConcreteColleague2("Barış");
            Katilimci Ahmet = new ConcreteColleague2("Ahmet");
            Katilimci Selvi = new ConcreteColleague1("Selvi");
            sohbetOdasi.KayitOl(Can);
            sohbetOdasi.KayitOl(Canan);
            sohbetOdasi.KayitOl(Baris);
            sohbetOdasi.KayitOl(Ahmet);
            sohbetOdasi.KayitOl(Selvi);
            // Chatting participants 
            Selvi.MesajGonder("Can", "Selam Can");
            Canan.MesajGonder("Can", "Selam Can Yemeğe Çıkacakmısın ?");
            Baris.MesajGonder("Ahmet", "İstediğim evraklar hazır mı ?");
            Canan.MesajGonder("Ahmet", "Toplantı saat 3'te ");
            Ahmet.MesajGonder("Barış", "İstediğin evraklar hazır");
            Console.Read();
        }
    }
}
