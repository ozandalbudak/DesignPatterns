using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            DBFactory db = FactoryUtil.GetFactory("SQL");
            Connection cnn = db.CreateConnection();
            cnn.Connect();
            Command cmd = db.CreateCommand();
            cmd.Query = "SELECT * FROM TABLO";
            cmd.Execute();

            db = FactoryUtil.GetFactory("Oracle");
            cnn = db.CreateConnection();
            cnn.Connect();

            cmd = db.CreateCommand();
            cmd.Query = "SELECT * FROM TABLO";
            cmd.Execute();

            Console.ReadLine();
        }
    }
}
