using System.Diagnostics;

namespace OOPcs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            //Ali Kiraz Maas Hesabý
            MaasHesabi akiraz = new MaasHesabi();
            akiraz.AdiSoyadi = "Ali Kiraz";
            akiraz.CalismaGun = 5;
            akiraz.GunlukYolUcreti = 20;
            akiraz.GunlukYemekUcreti = 40;
            akiraz.GunUcret = 150;
            akiraz.Kesinti = 200;
            akiraz.GelirVergisiOrani = 20;

            //Rukiye Naz Maas Hesabý
            MaasHesabi rnaz = new MaasHesabi();
            rnaz.AdiSoyadi = "Rukiye Naz";
            rnaz.CalismaGun = 11;
            rnaz.GunlukYolUcreti = 50;
            rnaz.GunlukYemekUcreti = 75;
            rnaz.GunUcret = 125;
            rnaz.Kesinti = 0;
            rnaz.GelirVergisiOrani = 0;           

            //Ahmet Güneþ Maas Hesabý
            MaasHesabi agunes = new MaasHesabi();
            agunes.AdiSoyadi = "Ahmet Güneþ";
            agunes.CalismaGun = 22;
            agunes.GunlukYolUcreti = 30;
            agunes.GunlukYemekUcreti = 50;
            agunes.GunUcret = 125;
            agunes.Kesinti = 0;
            agunes.GelirVergisiOrani = 15;

            MessageBox.Show(
                akiraz.AdiSoyadi + " : " + akiraz.MaasHesapla() + "\r\n" +
                rnaz.AdiSoyadi + " : " + rnaz.MaasHesapla() + "\r\n" +
                agunes.AdiSoyadi + " : " + agunes.MaasHesapla()
                );
        }

        private void button2_Click(object sender, EventArgs e)
        {
            

            Yazilimlar yazilimlar = new Yazilimlar();

            Debug.WriteLine(yazilimlar.PrintList());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string sonuc = "";

            FaizHesabi faizHesabi1 = new FaizHesabi();
            faizHesabi1.AnaPara = 1000;
            faizHesabi1.VadeGun = 150;
            faizHesabi1.YillikFaiz = 40;
            sonuc += "Faiz: " + faizHesabi1.FaizHesapla() + "\n\r";

            FaizHesabi faizHesabi2 = new FaizHesabi();
            faizHesabi1.AnaPara = 2000;
            faizHesabi1.VadeGun = 160;
            faizHesabi1.YillikFaiz = 30;
            sonuc += "Faiz: " + faizHesabi1.FaizHesapla() + "\n\r";

            FaizHesabi faizHesabi3 = new FaizHesabi();
            faizHesabi1.AnaPara = 3000;
            faizHesabi1.VadeGun = 170;
            faizHesabi1.YillikFaiz = 20;
            sonuc += "Faiz: " + faizHesabi1.FaizHesapla() + "\n\r";
            
            MessageBox.Show(sonuc);
        }
    }
}