using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeDesignPatterns
{
    class Program
    {
        static void Main()
        {
            // Prototype model nesne oluşturuluyor. 
            Printer printer = new Printer(0x0F, "Hp", true, true, 600,
           "A4");
            for (int i = 0; i < 20; i++)
            {
                PrintDocument((Printer)printer.Clone(), i.ToString());
                Console.WriteLine(Convert.ToString(i + 1) + " nolu sayfa basıldı"); 
            }
            Console.WriteLine("Yazdırma tamamlandı...");
            Console.ReadLine();
        }
        static void PrintDocument(Printer printer, string content)
        {
            // Print işlemi yapan metod. 
        }
    }
}
