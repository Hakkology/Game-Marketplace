using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hakan.ConsoleApp.MarketPlace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Gerçek RPG Marketplace yapacağız
            //Marketplace önce tamir mi etmek istiyosun satın mı almak istiyosun?
            //satın almak istiyosan silah mı zırh mı diye soracak, her birinde 8 er seçenek olacak, shop bunlardan Random çıkaracak.
            //ayrıca NPC ile olan reputationınna göre shop sana indirim verecek. Reputation almak için shopa gift vereceksin.
            //Tamir etmek istersen, her durability için 1 gold harcamak kaydıyla tamir yapılacak.**
            //Craft etmek istersen, menü açılacak, craftla silahlara bufflar ekleyeceksin.**
            bool shop = true;
            int karaktergold = 700;
            Console.WriteLine("Toplam 700 altınınız var.");

            while (shop)
                Console.Write("Silah satın almak için '1'e, zırh satın almak için '2'ye, tamir etmek için '3'e, shoptan çıkmak için 0'a basınız.");
                byte i = Convert.ToByte(Console.ReadLine());
                if (i == 1)
                {
                    bool seçim = true;
                    while (seçim)
                    {
                        Eşyalar Oyuncu = new Eşyalar();
                        Console.WriteLine("Hangi silahı almak istersiniz ? Lütfen aşağıdan seçin: ");
                        Console.Write($"Kılıç için '1'i, Yay için '2'yi, Mızrak için '3'ü seçiniz:");
                        byte j = Convert.ToByte(Console.ReadLine());
                        Oyuncu.silahseçim(j,seçim);
                        Oyuncu.Sepetfiyat(i,j,k,)
                    }

                }
                else if (i==2)
                {
                    
                }
                else if (i==3)
                {

                }
                else if (i==0)
                {
                    Console.WriteLine("Yine bekleriz.");
                    shop = false;
                }
                else
                {
                    Console.WriteLine("Hatalı bir komut girdiniz.");
                }
            Console.ReadLine();
        }
    }

    class Eşyalar
    {
        private string [] silahisim = {"Kılıç", "Yay", "Mızrak"};
        private string [] silahmat = {"Demir", "Çelik", "Gümüş"};
        private int[] silahfiyat = { 40, 30, 40 };
        public int [] silahhasar = {8, 6, 9}; 
        public int [] silahdayan = {20,15,20};
        private string[] zırhisim = { "Göğüs", "Ayak", "Kol" };
        private string[] zırhmat = { "Demir", "Çelik", "Gümüş" };
        private int[] zırhfiyat = { 35, 55 };
        public int zırhsav;
        public int zırhdayan;

        public void silahseçim(int j, bool dönüş)
        {
                if (j == 1)
                {
                Console.WriteLine("Lütfen malzemesini seçin: ");
                Console.Write($"Demir ({silahfiyat[j-1]} altın) için '1', Çelik ({silahfiyat[j - 1]*2} altın) için '2', gümüş({silahfiyat[j - 1]*3} altın) için '3'ü, Yeniden silah seçmek için '0'ı seçin: ");
                byte k = Convert.ToByte(Console.ReadLine());
                    if (k == 1)
                    {
                        Console.WriteLine("Satın almak istediğiniz adedi belirleyin:");
                        int l = Convert.ToInt32(Console.ReadLine());
                        Fiyatmat(j, k, l);
                        SepeteEkleme ()
                        
                    }
                    else if (k==2)
                    {
                        Console.WriteLine("Satın almak istediğiniz adedi belirleyin:");
                        int l = Convert.ToInt32(Console.ReadLine());
                        Fiyatmat(j, k, l);
                    }
                    else if (k == 3)
                    {
                        Console.WriteLine("Satın almak istediğiniz adedi belirleyin:");
                        int l = Convert.ToInt32(Console.ReadLine());
                        Fiyatmat(j, k, l);
                    }
                    else if (k == 4)
                    {
                        dönüş = false;
                    }
                }
        }

        public void GeriDönüş (bool a)
        {
            a = false;
        }
        public void Fiyatmat(int a, int b, int c)
        {
            silahfiyat[a - 1] = (int)(silahfiyat[a - 1] * b);
            Console.WriteLine($"{silahmat[b - 1]} malzemesinden {silahisim[a - 1]} fiyatı {silahfiyat[a - 1]*b} altındır.");
            c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{c} adet {silahmat[b - 1]} {silahisim[a - 1]} sepetinize eklenmiştir.");
        }

        public void SepeteEkleme (int a, int b)
        {
            int c = a * b;
            int [] sepet = new int [c];

        }
        public void Sepetfiyat (int a, int b, int c, bool d)
        {
            if (a==1)
            {
                int Ödeme = silahfiyat[b] * c;
            }
            else if (a == 2)
            {
                int Ödeme = zırhfiyat[b] * c;
            }
            else
            {
                int Ödeme = 20;
            }
        }
    }

}
