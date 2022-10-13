using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern
{
    public  abstract class Connection
    {
        public abstract void Connect();
        protected String connectionString;
        public abstract String ConnectionString { get; set; }

    }
}
