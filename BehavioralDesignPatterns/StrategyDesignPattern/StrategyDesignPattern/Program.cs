using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Context context;
            // Normal hizmet tarifesi üzerinden göndermek üzere yola çıktık.
             context = new Context(new ConcreteStrategy1());
            bool isReceivePhoneCalls = true;
            bool isExistAccount = false;
            if (isReceivePhoneCalls == true) // Çağrı geldi 
            {
                if (isExistAccount == false) // İnternet hesabı yoksa ? 
                    context = new Context(new ConcreteStrategy2()); // APS 
                else
                    context = new Context(new ConcreteStrategy3());// EPOSTA
            }
            //Alıcı bilgilerini dolduruyp yolluyoruz. 
            context.NameSurname = "Cin Ali";
            context.Address = "İstanbul";
            context.Telephone = "212-9999999";
            context.Send();
            Console.ReadLine();
        }
    }
}
