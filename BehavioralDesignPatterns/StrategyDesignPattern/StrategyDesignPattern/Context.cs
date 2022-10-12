using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPattern
{
    class Context
    {
        private Strategy _strategy;
        public string NameSurname { get; set; }
        public string Address { get; set; }
        public string Telephone { get; set; }
        public Context(Strategy strategy)
        {
            this._strategy = strategy;
        }
        public void Send()
        {
            _strategy.Send(NameSurname, Address, Telephone);
        }
    }
}
