using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hakan.ConsoleApp.TeknolojiApp
{
    public class Teknoloji
    {
        public int Adet = 62;
        public bool a;

        public string Marka { get; set; }
        public string Model { get; set; }
        public string İşlemci { get; set; }
        public int Ram { get; set; }
        public double Ekranboyutu { get; set; }
        public int Garantisüresi { get; set; }
        public int ÖzelNo { get; set; }
        public decimal AnaFiyat { get; set; }
        public decimal OTVergi
        {
            get
            {
                if (AnaFiyat < 4500)
                {
                    return 1.8M;
                }
                else
                {
                    return 2.1M;
                }
            }
        }
        public virtual void ÜrünListele()
        {
            return;
        }
        public decimal FiyatHesap()
        {
            return AnaFiyat * 1.18M * OTVergi;
        }
    }

    public class Bilgisayar : Teknoloji
    {

        public Bilgisayar(int özelno, string marka, string model, string işlemci, int ram, double ekranboyutu, int garantisüresi, bool dizmasaüstü, string ekrankartı, decimal anafiyat)
        {
            Marka = marka;
            Model = model;
            İşlemci = işlemci;
            Ram = ram;
            Ekranboyutu = ekranboyutu;
            Garantisüresi = garantisüresi;
            a = dizmasaüstü;
            EkranKartı = ekrankartı;
            AnaFiyat = anafiyat;
            ÖzelNo = özelno;
        }
        public string DizMasaüstü
        { get { return a ? "Dizüstü" : "Masaüstü";}}

        public string EkranKartı { get; set; }
        public static void BilgMarkaListele()
        {
            Console.WriteLine("1) Asus\n" +
                "2) Monster\n" +
                "3) MSI\n" +
                "4) Lenovo\n" +
                "5) Casper\n");
        }
        public static void BilgUrunGöster(Bilgisayar bilgisayar)
        {
            Console.WriteLine($"Ürün No: {bilgisayar.ÖzelNo}\n"
                              + $"{bilgisayar.Marka} {bilgisayar.Model} {bilgisayar.DizMasaüstü} Bilgisayar:\n"
                              + $"{bilgisayar.İşlemci} İşlemci, {bilgisayar.Ram} GB Ram, {bilgisayar.Ekranboyutu} İnç Ekran, {bilgisayar.EkranKartı} Ekran Kartı ile...\n"
                              + $"Ürünümüz {bilgisayar.Garantisüresi} sene garantilidir.\n"
                              + $"Fiyat : {bilgisayar.FiyatHesap()} \n"
                              + "----------------------------\n");
        }
    }
    public class Tablet : Teknoloji
    {
        public Tablet(int özelno, string marka, string model, string işlemci, int ram, double ekranboyutu, int garantisüresi,string kamera, decimal anafiyat)
        {
            Marka = marka;
            Model = model;
            İşlemci = işlemci;
            Ram = ram;
            Ekranboyutu = ekranboyutu;
            Garantisüresi = garantisüresi;
            Kamera = kamera;
            AnaFiyat = anafiyat;
            ÖzelNo = özelno;
        }
        public string Kamera { get; set; }
        public static void TabMarkaListele()
        {
            Console.WriteLine("1) Apple\n"
                              + "2) Samsung\n"
                              + "----------------------------\n");
        }
        public static void TabUrunGöster(Tablet tablet)
        {
            Console.WriteLine($"Ürün No: {tablet.ÖzelNo} \n"
                              + $"{tablet.Marka} {tablet.Model} Tablet:\n"
                              + $"{tablet.İşlemci} İşlemci, {tablet.Ram} GB Ram, {tablet.Ekranboyutu} İnç Ekran, {tablet.Kamera} MP Kamera ile...\n"
                              + $"Ürünümüz {tablet.Garantisüresi} sene garantilidir.\n"
                              + $"Fiyat : {tablet.FiyatHesap()} \n"
                              + "----------------------------\n");
        }

    }
    public class Telefon : Teknoloji
    {
        public Telefon(int özelno, string marka, string model, string işlemci, int ram, double ekranboyutu, int garantisüresi, string kamera, string renk, decimal anafiyat)
        {
            Marka = marka;
            Model = model;
            İşlemci = işlemci;
            Ram = ram;
            Ekranboyutu = ekranboyutu;
            Garantisüresi = garantisüresi;
            Kamera = kamera;
            Renk = renk;
            AnaFiyat = anafiyat;
            ÖzelNo = özelno;
        }
        public string Renk { get; set; }
        public string Kamera { get; set; }
        public static void TelMarkaListele()
        {
            Console.WriteLine("1) Apple\n"
                              + "2) Samsung\n"
                              + "----------------------------\n");
        }
        public static void TelUrunGöster(Telefon telefon)
        {
            Console.WriteLine($"Ürün No: {telefon.ÖzelNo} \n"
                              + $"{telefon.Marka} {telefon.Model} {telefon.Renk} Telefon:\n"
                              + $"{telefon.İşlemci} İşlemci, {telefon.Ram} GB Ram, {telefon.Ekranboyutu} İnç Ekran, {telefon.Kamera} MP Kamera ile...\n"
                              + $"Ürünümüz {telefon.Garantisüresi} sene garantilidir.\n"
                              + $"Fiyat : {telefon.FiyatHesap()} \n"
                              + "----------------------------\n");
        }
    }
}


