using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Yol 
            DVDDevice device = DVDDevice.Device;
            //2.Yol 
            DVDDevice device2 = DVDDevice.GetDevice();
            Console.Read();

            //1.Yol 
            NewDVDDevice newdevice = NewDVDDevice.Device;
            //2.Yol 
            NewDVDDevice newdevice2 = NewDVDDevice.GetDevice();
            Console.Read();
        }
    }
}
