using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPattern
{
    abstract class Strategy
    {
        public abstract void Send(string NameSurname, string Address,
       string Telephone);
    }
}
