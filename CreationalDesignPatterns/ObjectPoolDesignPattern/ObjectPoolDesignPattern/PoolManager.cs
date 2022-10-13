using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectPoolDesignPattern
{
    public class PoolManager
    {
        private const int POOL_SIZE = 10;
        protected static PoolManager pm;
        private Dictionary<string, List<ConnectionContext>> pools;

        public PoolManager()
        {
            pools = new Dictionary<string, List<ConnectionContext>>();
        }
        public static PoolManager createPool()
        {
            if(pm==null)
            {
                pm = new PoolManager();
            }
            return pm;
        }
        public ConnectionContext TakeConnection(string key)
        {
            if(pools.ContainsKey(key))
            {
                List<ConnectionContext> objects = (List<ConnectionContext>)pools[key];
                foreach(ConnectionContext cu in objects)
                {
                    if(!cu.Is_Active)
                    {
                        return cu;
                    }
                }
            }
            else
            {
                List<ConnectionContext> yeniHavuz = new List<ConnectionContext>(POOL_SIZE);
                for(int i=0;i<=POOL_SIZE-1;i++)
                {
                    yeniHavuz.Add(new ConnectionContext());
                }
                pools.Add(key, yeniHavuz);
                ConnectionContext cu = yeniHavuz[0];
                cu.Is_Active = true;
                return cu;
            }
            return null;
        }
        public void ReleaseConnection(ConnectionContext connection)
        {
            connection.Is_Active = false;
        }
    }
}
