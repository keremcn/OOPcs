using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPcs
{
    internal class Yazilimlar
    {
        private Yazilim yaz1 = new Yazilim();
        private Yazilim yaz2 = new Yazilim();



        private ArrayList yazilimlar = new ArrayList(); 
        public void AddSoftware(Yazilim software)
        {
            yazilimlar.Add(software);   
        }

        
        

        public string PrintList()
        {
            string sonuc = "Yazılım Adı\tVersiyon\tÖzellikler\tFiyat\tİşletim Sistemi\tResim\n\r";

            foreach (Yazilim software in yazilimlar)
            {
                sonuc += software.ToString().Replace('-','\t')+"\n\r";           
              
            }
           
            return sonuc;
        }

        public Yazilimlar()
        {            
            yaz1.SetYazilimAdi("Market");
            yaz1.SetVersiyon("2.1.1");
            yaz1.SetOzellikler("Stok Ekleme");
            yaz1.SetFiyat(1.00D);
            yaz1.SetIsletimSistemi(1);
            yaz1.SetResim("Market.jpg");

            yaz2.SetYazilimAdi("Muhasebe");
            yaz2.SetVersiyon("1.1.1");
            yaz2.SetOzellikler("Yevmiye fişi, mizan oluşturma");
            yaz2.SetFiyat(2.00D);
            yaz2.SetIsletimSistemi(2);
            yaz2.SetResim("Muhasebe.jpg");

            AddSoftware(yaz1);
            AddSoftware(yaz2);
        }
        
    }
}
