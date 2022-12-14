using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPcs
{
    internal class MaasHesabi
    {
        public string AdiSoyadi { get; set; }
        public int CalismaGun { get; set; }
        public double GunUcret { get; set; }
        public int Kesinti { get; set; }
        public double GunlukYolUcreti { get; set; }
        public double GunlukYemekUcreti { get; set; }
        public int GelirVergisiOrani { get; set; }

        public double MaasHesapla()
        {
            return (CalismaGun*GunUcret-Kesinti) * (100-GelirVergisiOrani)/100;
        }
    }
}
