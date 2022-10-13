using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectPoolDesignPattern
{
    public class Connection
    {
        private string connectionString;
        private PoolManager poolManager;
        private ConnectionContext con;
        public Connection(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public string ConnectionString { get => connectionString; set => connectionString = value; }
        public void Open()
        {
            poolManager = PoolManager.createPool();
            con = poolManager.TakeConnection(this.connectionString);
            if (con != null)
            {
                con.Open();
            }
            else
            {
                Console.WriteLine("havuzda hiç uygun nesne yok");
            }

        }
        public void Close()
        {
            poolManager.ReleaseConnection(con);
            con.Close();
        }
        public void Execute(string query)
        {
            con.Exceute(query);
        }
    }
}
