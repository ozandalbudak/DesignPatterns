using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectPoolDesignPattern
{
    public class ConnectionContext
    {
        private bool is_Active;
        public bool Is_Active { get => is_Active; set => is_Active = value; }
        public ConnectionContext()
        {
            is_Active = false;
            Console.WriteLine("Connection Context yaratıldı");
        }
        public void Open()
        {
            Console.WriteLine("Connection Açıldı");
        }
        public void Close()
        { Console.WriteLine("Connection Kapandı"); }
        public void Exceute(string query)
        {
            Console.WriteLine(query + " çalıştı");
        }

    }
}
