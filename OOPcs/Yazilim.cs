using Accessibility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPcs
{
    internal class Yazilim
    {
        private string _YazilimAdi; //50 karakter
        private string _Versiyon; //10 karakter
        private string _Ozellikler; //500 
        private double _Fiyati; //>0        
        private string _IsletimSistemi;//1-Windows 2-Linux
        private string _Resim; //50       

        public void SetYazilimAdi(string yazilimAdi)
        {
            if(yazilimAdi.Length>50) _YazilimAdi = yazilimAdi.Substring(50);
            else _YazilimAdi = yazilimAdi;   
        }
        public void SetVersiyon(string version)
        {
            if (version.Length > 10) _Versiyon = version.Substring(10);
            else _Versiyon = version;
           
        }
        public void SetOzellikler(string ozellikler)
        {
            if (ozellikler.Length > 500) _Ozellikler = ozellikler.Substring(500);
            else _Ozellikler = ozellikler;
        }
        public void SetFiyat(double fiyat)
        {
            if (fiyat <= 0) _Fiyati = Math.Abs(fiyat) + 1;
            else _Fiyati = fiyat;
        }
        public void SetIsletimSistemi(int isletim)
        {
            if(isletim == 1) _IsletimSistemi = "Windows";
            else _IsletimSistemi = "Linux";
        }
        public void SetResim(string resim)
        {
            if(resim.Length>50) _Resim = resim.Substring(50);
            else _Resim = resim;
        }
        public override string ToString()
        {
            return _YazilimAdi+"-"+_Versiyon +"-"+ _Ozellikler +"-"+ _Fiyati +"-"+_IsletimSistemi+"-"+_Resim;
        }

    }
}
