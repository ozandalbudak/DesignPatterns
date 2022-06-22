using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            ComputerBuilder computerBuilder;
            Director director = new Director();
            computerBuilder = new AConcreteBuilder();
            director.BilgisayarUret(computerBuilder);
            Console.WriteLine(computerBuilder.Computer.ToString());
            computerBuilder = new BConcreteBuilder();
            director.BilgisayarUret(computerBuilder);
            Console.WriteLine(computerBuilder.Computer.ToString());
            Console.Read();
        }
    }
}
