using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern
{
    public abstract class DBFactory
    {
        public abstract Connection CreateConnection();
        public abstract Command CreateCommand();
    }
}
