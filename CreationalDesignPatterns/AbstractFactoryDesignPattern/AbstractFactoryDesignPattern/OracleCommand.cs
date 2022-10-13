using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern
{
    class OracleCommand : Command
    {
        public override string Query { get => base.query; set => base.query = value; }

        public override void Execute()
        {
            Console.WriteLine("PL/SQL calisti");
        }
    }
}
