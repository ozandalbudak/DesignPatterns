using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern
{
    public class OracleFactory : DBFactory
    {
        public override Command CreateCommand()
        {
            return new OracleCommand();
        }

        public override Connection CreateConnection()
        {
            return new OracleConnection();
        }
    }
}
