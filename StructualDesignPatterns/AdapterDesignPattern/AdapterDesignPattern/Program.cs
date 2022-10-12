using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AdapterDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Adapter adapter = new Adapter();
            string tercih = null;
            Client client = new Client();
            try
            {
                while(true)
                {
                    Console.WriteLine("Malzamenin tutarını hesaplamak için 1 e,"+"\niskontonun tutarını hesaplamak için 2 ye,"+"\nuygulamadan çıkmak için 3'e basınız\n");
                    tercih = Console.ReadLine();
                    int secenek = Convert.ToInt32(tercih);
                    Console.WriteLine();
                    if (secenek == 1)
                        client.OdenecekMeblayiHesapla(new malzemeTipineGoreToplamTutariniHesapla());
                    else if (secenek == 2)
                    {
                        client.OdenecekMeblayiHesapla(new Adapter());
                    }
                    else
                        return;
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("hata ile karşılaşıldı. Uygulama Sonlanacaktır");
                Thread.Sleep(1500);
            }
        }
    }
}
