using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern
{
    class SQLConnection : Connection
    {
        public override string ConnectionString { get => base.connectionString; set => base.connectionString = value; }

        public override void Connect()
        {
            Console.WriteLine("SQL'e baglandi");
        }
    }
}
