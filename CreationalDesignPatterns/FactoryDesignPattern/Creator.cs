using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPatterns
{
    class Creator
    {
        public Product FactoryMethod(Ulkeler ulke)
        {
            Product product = null;
            switch (ulke)
            {
                case Ulkeler.Turkiye:
                    product = new ConcreteProduct1();
                    break;
                case Ulkeler.Ispanya:
                    product = new ConcreteProduct2();
                    break;
                case Ulkeler.Amerika:
                    product = new ConcreteProduct3();
                    break;
                default:
                    break;
            }
            return product;
        }
    }
}
