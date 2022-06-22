using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Creator creator = new Creator();
            Product product1 = creator.FactoryMethod(Ulkeler.Turkiye);
            Product product2 = creator.FactoryMethod(Ulkeler.Ispanya);
            Product product3 = creator.FactoryMethod(Ulkeler.Amerika);
            product1.Konus();
            product2.Konus();
            product3.Konus();
            Console.ReadKey();
        }
    }
}
