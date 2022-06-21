using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPatterns
{
    public class DVDDevice
    {
        private static DVDDevice dvdDevice = new DVDDevice();
        // 1.Yol DvdDevice nesnesine Property üzerinden ulaşmak 
        public static DVDDevice Device
        {
            get
            {
                return dvdDevice;
            }
        }
        //2.Yol DvdDevice nesnesine Method üzerinden ulaşmak 
        public static DVDDevice GetDevice()
        {
            return dvdDevice;
        }
    }
}
