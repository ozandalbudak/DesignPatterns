using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPatterns
{
    public class NewDVDDevice
    {
        private static NewDVDDevice dvdDevice;
        // 1.Yol DvdDevice nesnesine Property üzerinden ulaşmak 
        public static NewDVDDevice Device
        {
            get
            {
                if (dvdDevice == null)
                    dvdDevice = new NewDVDDevice();
                return dvdDevice;
            }
        }
        //2.Yol DvdDevice nesnesine Method üzerinden ula 
        public static NewDVDDevice GetDevice()
        {
            if (dvdDevice == null)
                dvdDevice = new NewDVDDevice();
            return dvdDevice;
        }
    }
}
