using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern
{
    public class SQLFactory : DBFactory
    {
        public override Command CreateCommand()
        {
            return new SQLCommand();
        }

        public override Connection CreateConnection()
        {
            return new SQLConnection();
        }
    }
}
