using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightDesignPattern
{
    public class Konum
    {
         private int x, y;

        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
        public Konum()
        {
            this.x = 0;
            this.y = 0;
        }

        public Konum(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public override string ToString()
        {
            return string.Format("X: {0} - Y: {1}",x,y);
        }
    }
}
