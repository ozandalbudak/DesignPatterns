using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectPoolDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Connection con = new Connection("k1");
            con.Open();
            con.Execute("select1");
            con.Close();
            Console.WriteLine("-------------------------");

            Connection con2 = new Connection("k2");
            con2.Open();
            con2.Execute("select2");
            con2.Close();
            Console.WriteLine("-------------------------");

            Connection con3 = new Connection("k3");
            con3.Open();
            con3.Execute("select3");
            con3.Close();
            Console.WriteLine("-------------------------");
        }
    }
}
