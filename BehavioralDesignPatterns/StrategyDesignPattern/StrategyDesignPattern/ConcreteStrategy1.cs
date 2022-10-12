using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPattern
{
    class ConcreteStrategy1 : Strategy
    {
        public override void Send(string NameSurname, string Address,
       string Telephone)
        {
            Console.WriteLine("Normal Hizmet Tarifesi üzerinden gönderildi."); 
        }
    }
}
