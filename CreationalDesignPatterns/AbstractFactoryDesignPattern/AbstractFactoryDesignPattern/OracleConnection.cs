using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern
{
    class OracleConnection : Connection
    {
        public override string ConnectionString { get => base.connectionString; set => base.connectionString=value; }

        public override void Connect()
        {
            Console.WriteLine("Oracle'a baglandi");
        }
    }
}
