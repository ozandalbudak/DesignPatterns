using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kitap.pdf dosyası yazdırılacak");
            Printer printer = new Printer();
            printer.PrintDocument("Kitap.pdf");
            Console.Read();
        }
    }
}
