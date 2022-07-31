using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hakan.ConsoleApp.TeknolojiApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int seçim;
            int seçim1;
            int seçim2;
            int seçim3;
            int renk;
            int emin1;
            int adet;
            decimal toplam = 0;
            bool devam1 = true;
            int[] Sepet = new int[62];
            Bilgisayar[] DiziBilg = new Bilgisayar[19];
            Tablet[] DiziTab = new Tablet[7];
            Telefon[] DiziTel = new Telefon[36];

            DiziBilg[0] = new Bilgisayar(1, "Asus", "Zenbook", "Intel Core i5", 8, 17.3, 2, true, "GeForce GTX 1650", 4500);
            DiziBilg[1] = new Bilgisayar(2, "Asus", "TUF Gaming", "Intel Core i9", 16, 17.3, 2, true, "GeForce RTX 3070", 7500);
            DiziBilg[2] = new Bilgisayar(3, "Asus", "Vivobook", "Intel Core i7", 8, 15.6, 3, true, "GeForce RTX 3060", 5500);
            DiziBilg[3] = new Bilgisayar(4, "Monster", "Abra", "Intel Core i5", 8, 15.6, 3, true, "GeForce GTX 1650", 3800);
            DiziBilg[4] = new Bilgisayar(5, "Monster", "Tulpar", "Intel Core i7", 16, 17.3, 3, true, "GeForce RTX 3060", 4800);
            DiziBilg[5] = new Bilgisayar(6, "Monster", "Serduk", "Intel Core i9", 16, 17.3, 3, true, "GeForce RTX 3070", 7800);
            DiziBilg[6] = new Bilgisayar(7, "Lenovo", "V14", "Intel Core i5", 8, 15.6, 2, true, "Intel Iris Xe Graphics", 2500);
            DiziBilg[7] = new Bilgisayar(8, "Lenovo", "V15", "Intel Core i7", 8, 14, 2, true, "GeForce RTX 3050", 3500);
            DiziBilg[8] = new Bilgisayar(9, "Lenovo", "V17", "Intel Core i9", 16, 15.6, 3, true, "GeForce RTX 3070", 4500);
            DiziBilg[9] = new Bilgisayar(10, "Casper", "Nirvana", "Intel Core i5", 4, 14, 2, true, "Intel Iris Xe Graphics", 2500);
            DiziBilg[10] = new Bilgisayar(11, "Casper", "Excalibur", "Intel Core i7", 8, 15.6, 2, true, "GeForce RTX 3060", 3500);
            DiziBilg[11] = new Bilgisayar(12, "Lenovo", "Legion", "Intel Core i5", 8, 15.6, 2, false, "Intel Iris Xe Graphics", 3250);
            DiziBilg[12] = new Bilgisayar(13, "Lenovo", "IdeaCentre", "Intel Core i5", 8, 15.6, 2, false, "Intel Iris Xe Graphics", 3750);
            DiziBilg[13] = new Bilgisayar(14, "MSI", "Trident", "Intel Core i7", 8, 15.6, 2, false, "GeForce GTX 1650", 4800);
            DiziBilg[14] = new Bilgisayar(15, "MSI", "MAG", "AMD Ryzen 5", 16, 14, 2, false, "GeForce GTX 1650", 5200);
            DiziBilg[15] = new Bilgisayar(16, "MSI", "Creator", "Intel Core i7", 16, 17.3, 2, false, "GeForce RTX 3070", 5700);
            DiziBilg[16] = new Bilgisayar(17, "MSI", "Creator", "Intel Core i9", 16, 17.3, 2, false, "GeForce RTX 3080", 8700);
            DiziBilg[17] = new Bilgisayar(18, "Casper", "Nirvana", "Intel Core i5", 8, 14, 2, false, "Intel Iris Xe Graphics", 3200);
            DiziBilg[18] = new Bilgisayar(19, "Casper", "Excalibur", "Intel Core i7", 16, 15.3, 2, false, "GeForce GTX 1650", 4300);
            DiziTab[0] = new Tablet(1, "Apple", "iPad Pro 3. Nesil", "iOS 6 3 Ghz", 8, 11, 2, "12 MP", 4200);
            DiziTab[1] = new Tablet(2, "Apple", "iPad Pro 5. Nesil", "iOS 15 2.5 Ghz", 32, 10.9, 2, "12 MP", 5200);
            DiziTab[2] = new Tablet(3, "Apple", "iPad Pro 9. Nesil", "iOS 15 2.4 Ghz", 64, 10.2, 2, "18 MP", 6200);
            DiziTab[3] = new Tablet(4, "Samsung", "Galaxy Tab A7", "Android 2 Ghz", 16, 10.2, 2, "12 MP", 3200);
            DiziTab[4] = new Tablet(5, "Samsung", "Galaxy Tab A8", "Android 2.4 Ghz", 32, 10.3, 2, "12 MP", 3600);
            DiziTab[5] = new Tablet(6, "Samsung", "Galaxy Tab S7", "Android 2 Ghz", 16, 10.9, 2, "18 MP", 4100);
            DiziTab[6] = new Tablet(7, "Samsung", "Galaxy Tab S8", "Android 2.4 Ghz", 32, 11, 2, "18 MP", 4700);
            DiziTel[0] = new Telefon(1, "Apple", "IPhone 11", "iOS 13 32 Gb", 4, 6.1, 2, "12 MP", "Siyah", 3500);
            DiziTel[1] = new Telefon(2, "Apple", "IPhone 11", "iOS 13 32 Gb", 4, 6.1, 2, "12 MP", "Beyaz", 3400);
            DiziTel[2] = new Telefon(3, "Apple", "IPhone 11", "iOS 13 64 Gb", 4, 6.1, 2, "12 MP", "Siyah", 4400);
            DiziTel[3] = new Telefon(4, "Apple", "IPhone 11", "iOS 13 64 Gb", 4, 6.1, 2, "12 MP", "Beyaz", 4300);
            DiziTel[4] = new Telefon(5, "Apple", "IPhone 11", "iOS 13 128 Gb", 4, 6.1, 2, "12 MP", "Siyah", 5300);
            DiziTel[5] = new Telefon(6, "Apple", "IPhone 11", "iOS 13 128 Gb", 4, 6.1, 2, "12 MP", "Beyaz", 5200);
            DiziTel[6] = new Telefon(7, "Apple", "IPhone 12", "iOS 14 32 Gb", 8, 6.2, 2, "12 MP", "Siyah", 4500);
            DiziTel[7] = new Telefon(8, "Apple", "IPhone 12", "iOS 14 32 Gb", 8, 6.2, 2, "12 MP", "Beyaz", 4400);
            DiziTel[8] = new Telefon(9, "Apple", "IPhone 12", "iOS 14 64 Gb", 8, 6.2, 2, "12 MP", "Siyah", 5400);
            DiziTel[9] = new Telefon(10, "Apple", "IPhone 12", "iOS 14 64 Gb", 8, 6.2, 2, "12 MP", "Beyaz", 5300);
            DiziTel[10] = new Telefon(11, "Apple", "IPhone 12", "iOS 14 128 Gb", 8, 6.2, 2, "12 MP", "Siyah", 6300);
            DiziTel[11] = new Telefon(12, "Apple", "IPhone 12", "iOS 14 128 Gb", 16, 6.2, 2, "12 MP", "Beyaz", 6200);
            DiziTel[12] = new Telefon(13, "Apple", "IPhone 13", "iOS 15 32 Gb", 16, 6.3, 2, "12 MP", "Siyah", 5400);
            DiziTel[13] = new Telefon(14, "Apple", "IPhone 13", "iOS 15 32 Gb", 16, 6.3, 2, "12 MP", "Beyaz", 5300);
            DiziTel[14] = new Telefon(15, "Apple", "IPhone 13", "iOS 15 64 Gb", 16, 6.3, 2, "12 MP", "Siyah", 6300);
            DiziTel[15] = new Telefon(16, "Apple", "IPhone 13", "iOS 15 64 Gb", 16, 6.3, 2, "12 MP", "Beyaz", 6200);
            DiziTel[16] = new Telefon(17, "Apple", "IPhone 13", "iOS 15 128 Gb", 16, 6.3, 2, "12 MP", "Siyah", 7200);
            DiziTel[17] = new Telefon(18, "Apple", "IPhone 13", "iOS 15 128 Gb", 16, 6.3, 2, "12 MP", "Beyaz", 7100);
            DiziTel[18] = new Telefon(19, "Samsung", "A12", "Android 32 GB", 8, 6.5, 2, "12 MP", "Siyah", 3500);
            DiziTel[19] = new Telefon(20, "Samsung", "A12", "Android 32 GB", 8, 6.5, 2, "12 MP", "Beyaz", 3500);
            DiziTel[20] = new Telefon(21, "Samsung", "A12", "Android 64 GB", 16, 6.5, 2, "12 MP", "Siyah", 3500);
            DiziTel[21] = new Telefon(22, "Samsung", "A12", "Android 64 GB", 16, 6.5, 2, "12 MP", "Beyaz", 3500);
            DiziTel[22] = new Telefon(23, "Samsung", "A12", "Android 128 GB", 32, 6.5, 2, "12 MP", "Siyah", 3500);
            DiziTel[23] = new Telefon(24, "Samsung", "A12", "Android 128 GB", 32, 6.5, 2, "12 MP", "Beyaz", 3500);
            DiziTel[24] = new Telefon(25, "Samsung", "A32", "Android 32 GB", 8, 6.7, 2, "12 MP", "Siyah", 3500);
            DiziTel[25] = new Telefon(26, "Samsung", "A32", "Android 32 GB", 8, 6.7, 2, "12 MP", "Beyaz", 3500);
            DiziTel[26] = new Telefon(27, "Samsung", "A32", "Android 64 GB", 16, 6.7, 2, "12 MP", "Siyah", 3500);
            DiziTel[27] = new Telefon(28, "Samsung", "A32", "Android 64 GB", 16, 6.7, 2, "12 MP", "Beyaz", 3500);
            DiziTel[28] = new Telefon(29, "Samsung", "A32", "Android 128 GB", 32, 6.7, 2, "12 MP", "Siyah", 3500);
            DiziTel[29] = new Telefon(30, "Samsung", "A32", "Android 128 GB", 32, 6.7, 2, "12 MP", "Beyaz", 3500);
            DiziTel[30] = new Telefon(31, "Samsung", "A52", "Android 32 GB", 8, 6.9, 2, "12 MP", "Siyah", 3500);
            DiziTel[31] = new Telefon(32, "Samsung", "A52", "Android 32 GB", 8, 6.9, 2, "12 MP", "Beyaz", 3500);
            DiziTel[32] = new Telefon(33, "Samsung", "A52", "Android 64 GB", 16, 6.9, 2, "12 MP", "Siyah", 3500);
            DiziTel[33] = new Telefon(34, "Samsung", "A52", "Android 64 GB", 16, 6.9, 2, "12 MP", "Beyaz", 3500);
            DiziTel[34] = new Telefon(35, "Samsung", "A52", "Android 128 GB", 32, 6.9, 2, "12 MP", "Siyah", 3500);
            DiziTel[35] = new Telefon(36, "Samsung", "A52", "Android 128 GB", 32, 6.9, 2, "12 MP", "Beyaz", 3500);

            while (devam1)
            {
                try
                {
                    devam1 = false;
                    Console.WriteLine("Pisipisi platformuna hoşgeldiniz.\n" +
                      "1) Satın almak için ürünlerimizi inceleyin.\n" +
                      "2) Sepetinizde bulunan ürünleri inceleyin.\n" +
                      "3) Satın Almak için sepete gidin.\n" +
                      "4) Sepeti sıfırlayın.\n" +
                      "0) Programdan çıkın.\n" +
                      "----------------------------\n");
                    seçim = Convert.ToInt32(Console.ReadLine());
                    //satın alma inceleme
                    if (seçim == 1)
                    {
                        Console.WriteLine("Satın almak için incelemek istediğiniz cihazı seçiniz:\n" +
                            "1) Bilgisayar\n" +
                            "2) Tablet\n" +
                            "3) Telefon\n" +
                            "----------------------------\n");
                        seçim1 = int.Parse(Console.ReadLine());
                        //bilgisayar satın alma
                        if (seçim1 == 1)
                        {
                            Console.WriteLine("Lütfen hangi modeli aramak istediğinizi rakamla belirtiniz: ");
                            Bilgisayar.BilgMarkaListele();
                            seçim2 = Convert.ToInt32(Console.ReadLine());
                            if (seçim2 == 1)
                            {
                                for (int i = 0; i < DiziBilg.Length; i++)
                                {if (DiziBilg[i].Marka == "Asus")
                                    { Bilgisayar.BilgUrunGöster(DiziBilg[i]); }}
                            }
                            else if (seçim2 == 2)
                            {
                                for (int i = 0; i < DiziBilg.Length; i++)
                                {if (DiziBilg[i].Marka == "Monster")
                                    { Bilgisayar.BilgUrunGöster(DiziBilg[i]); }}
                            }
                            else if (seçim2 == 3)
                            {
                                for (int i = 0; i < DiziBilg.Length; i++)
                                {if (DiziBilg[i].Marka == "MSI")
                                    { Bilgisayar.BilgUrunGöster(DiziBilg[i]); }}
                            }
                            else if (seçim2 == 4)
                            {
                                for (int i = 0; i < DiziBilg.Length; i++)
                                {if (DiziBilg[i].Marka == "Lenovo")
                                    { Bilgisayar.BilgUrunGöster(DiziBilg[i]); }}
                            }
                            else if (seçim2 == 5)
                            {
                                for (int i = 0; i < DiziBilg.Length; i++)
                                {if (DiziBilg[i].Marka == "Casper")
                                    { Bilgisayar.BilgUrunGöster(DiziBilg[i]); }}
                            }
                            else
                            {
                                Console.WriteLine("Yanlış bir marka girdiniz, ana Menüye dönüyorsunuz...");
                            }
                            //bilgisayar sepete ekleme
                            Console.WriteLine("Lütfen Sepete eklemek istediğiniz ürünün başındaki numarayı yazın:");
                            seçim3 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Sepetinize kaç adet eklemek istediğinizi yazın: ");
                            adet = Convert.ToInt32(Console.ReadLine());
                            for (int i = 0; i < DiziBilg.Length; i++)
                            {
                                if (DiziBilg[i].ÖzelNo == seçim3)
                                { Sepet[i] += adet; }
                            }
                            Console.WriteLine("Sepetinize eklenmiştir.");
                            Console.ReadLine();
                            devam1 = true;
                        }
                        //tablet satın alma
                        else if (seçim1 == 2)
                        {
                            Console.WriteLine("Lütfen hangi markayı aramak istediğinizi rakamla belirtiniz: ");
                            Tablet.TabMarkaListele();
                            seçim2 = Convert.ToInt32(Console.ReadLine());
                            if (seçim2 == 1)
                            {
                                for (int i = 0; i < DiziTab.Length; i++)
                                {if (DiziTab[i].Marka == "Apple")
                                    { Tablet.TabUrunGöster(DiziTab[i]); }}
                            }
                            else if (seçim2 == 2)
                            {
                                for (int i = 0; i < DiziTab.Length; i++)
                                {if (DiziTab[i].Marka == "Samsung")
                                    { Tablet.TabUrunGöster(DiziTab[i]); }}
                            }
                            else
                            {
                                Console.WriteLine("Yanlış bir marka girdiniz, ana Menüye dönüyorsunuz...");
                            }
                            //tablet sepete ekleme
                            Console.WriteLine("Lütfen Sepete eklemek istediğiniz ürünün numarasını yazın: ");
                            seçim3 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Sepetinize kaç adet eklemek istediğinizi yazın: ");
                            adet = Convert.ToInt32(Console.ReadLine());
                            for (int i = 0; i < DiziTab.Length; i++)
                            {
                                if (DiziTab[i].ÖzelNo == seçim3)
                                { Sepet[i + DiziBilg.Length] += adet; }
                            }
                            Console.WriteLine("Sepetinize eklenmiştir.");
                            Console.ReadLine();
                            devam1 = true;
                        }
                        //telefon satın alma
                        else if (seçim1 == 3)
                        {
                            Console.WriteLine("Lütfen hangi modeli aramak istediğinizi rakamla belirtiniz: ");
                            Telefon.TelMarkaListele();
                            seçim2 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Lütfen renk seçiminizi belirtiniz: \n" +
                                "1) Siyah\n" +
                                "2) Beyaz\n" +
                                "----------------------------\n");
                            renk = Convert.ToInt32(Console.ReadLine());
                            if (seçim2 == 1 && renk == 1)
                            {
                                for (int i = 0; i < DiziTel.Length; i++)
                                {if (DiziTel[i].Marka == "Apple" && DiziTel[i].Renk == "Siyah")
                                    { Telefon.TelUrunGöster(DiziTel[i]); }}
                            }
                            else if (seçim2 == 2 && renk == 1)
                            {
                                for (int i = 0; i < DiziTel.Length; i++)
                                {if (DiziTel[i].Marka == "Samsung" && DiziTel[i].Renk == "Siyah")
                                    { Telefon.TelUrunGöster(DiziTel[i]); }}
                            }
                            else if (seçim2 == 1 && renk == 2)
                            {
                                for (int i = 0; i < DiziTel.Length; i++)
                                {if (DiziTel[i].Marka == "Apple" && DiziTel[i].Renk == "Beyaz")
                                    { Telefon.TelUrunGöster(DiziTel[i]); }}
                            }
                            else if (seçim2 == 2 && renk == 2)
                            {
                                for (int i = 0; i < DiziTel.Length; i++)
                                {if (DiziTel[i].Marka == "Samsung" && DiziTel[i].Renk == "Beyaz")
                                    { Telefon.TelUrunGöster(DiziTel[i]); }}
                            }
                            else
                            {
                                Console.WriteLine("Yanlış bir marka girdiniz, ana Menüye dönüyorsunuz...");
                            }
                            //telefon sepete ekleme
                            Console.WriteLine("Lütfen Sepete eklemek istediğiniz ürünün numarasını yazın:");
                            seçim3 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Sepetinize kaç adet eklemek istediğinizi yazın: ");
                            adet = Convert.ToInt32(Console.ReadLine());
                            for (int i = 0; i < DiziTel.Length; i++)
                            {
                                if (DiziTel[i].ÖzelNo == seçim3)
                                { Sepet[i + DiziBilg.Length + DiziTab.Length] += adet; }
                            }
                            Console.WriteLine("Sepetinize eklenmiştir.");
                            Console.ReadLine();
                            devam1 = true;
                        }
                        else
                        {
                            Console.WriteLine("Lütfen hangi modeli aramak istediğinizi rakamla belirtiniz: ");
                            devam1 = true;
                        }
                    }
                    //Sepete bakma
                    else if (seçim == 2)
                    {
                        Console.WriteLine("Sepetinizde: ");
                        for (int i = 0; i < Sepet.Length; i++)
                        {
                            if (Sepet[i] != 0)
                            {
                                if (i < DiziBilg.Length)
                                {
                                    Console.WriteLine($"{Sepet[i]} adet aşağıdaki üründen bulunmaktadır: ");
                                    Bilgisayar.BilgUrunGöster(DiziBilg[i]);
                                }
                                else if (i < (DiziBilg.Length + DiziTab.Length))
                                {
                                    Console.WriteLine($"{Sepet[i]} adet aşağıdaki üründen bulunmaktadır: ");
                                    Tablet.TabUrunGöster(DiziTab[i - DiziBilg.Length]);
                                }
                                else if (i < (DiziBilg.Length + DiziTab.Length + DiziTel.Length))
                                {
                                    Console.WriteLine($"{Sepet[i]} adet aşağıdaki üründen bulunmaktadır: ");
                                    Telefon.TelUrunGöster(DiziTel[i - DiziBilg.Length - DiziTab.Length]);
                                }
                            }
                        }
                        devam1 = true;
                    }
                    //Satın Alma
                    else if (seçim == 3)
                    {
                        for (int i = 0; i < DiziBilg.Length; i++)
                        {
                            toplam += Sepet[i] * DiziBilg[i].FiyatHesap();
                        }
                        for (int i = DiziBilg.Length; i < (DiziBilg.Length + DiziTab.Length); i++)
                        {
                            toplam += Sepet[i] * DiziTab[i - DiziBilg.Length].FiyatHesap();
                        }
                        for (int i = (DiziBilg.Length + DiziTab.Length); i < (DiziBilg.Length + DiziTab.Length + DiziTel.Length); i++)
                        {
                            toplam += Sepet[i] * DiziTel[i - DiziBilg.Length - DiziTab.Length].FiyatHesap();
                        }
                        Console.WriteLine($"Ödemeniz gereken toplam ücret {toplam} TL. Kabul ediyor musunuz ? Evet için 1'e basınız. ");
                        emin1 = Convert.ToInt32(Console.ReadLine());
                        if (emin1 == 1)
                        {
                            Console.WriteLine("Alışverişiniz için teşekkürler.");
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("Başa dönüyorsunuz...");
                            devam1 = true;
                        }
                    }
                    //Sepet sıfırlama
                    else if (seçim == 4)
                    {
                        for (int i = 0; i < Sepet.Length; i++)
                        { Sepet[i] = 0; }
                        Console.WriteLine("Sepetinizdeki tüm ürünler silinmiştir.\n");
                        devam1 = true;
                    }
                    //çıkış
                    else if (seçim == 0)
                    {
                        Console.WriteLine("Pisipisi platformunu kullandığınız için teşekkür ederiz.");
                        Console.ReadLine();
                    }
                    //Hatalı giriş
                    else
                    {
                        Console.WriteLine("Yanlış bir numara girdiniz. Lütfen tekrar deneyin: ");
                        Console.ReadLine();
                        devam1 = true;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Beklenmedik bir hata oluştu. Lütfen tekrar deneyin.");
                    devam1 = true;
                }
            }
        }
    }
}
