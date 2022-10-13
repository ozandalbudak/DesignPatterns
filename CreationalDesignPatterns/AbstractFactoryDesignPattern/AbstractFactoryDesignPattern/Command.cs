using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern
{
    public abstract class Command
    {
        public abstract void Execute();
        protected String query;
        public abstract String Query { get; set; }
    }
}
