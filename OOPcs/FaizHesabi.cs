using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPcs
{
    internal class FaizHesabi
    {
        public int AnaPara { get; set; }
        public int VadeGun { get; set; }
        public int YillikFaiz { get; set; }

        public int FaizHesapla()
        {
            return AnaPara * VadeGun * YillikFaiz / 36000;
        }
    }
}
