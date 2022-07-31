using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hakan.ConsoleApp.RPGShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                oyuncu oyuncu = new oyuncu();
                Console.WriteLine("Oyuncu ismi giriniz:");
                string isim = (Console.ReadLine());
                bool devam = true;
                int seçim1;
                int seçim2;
                int değer;

                while (devam)
                {
                    Console.WriteLine($"{oyuncu.altın} altının var. Ne yapmayı seçiyorsun ? ");
                    Console.WriteLine("\n1) Ormana devam et\n" +
                        "2) Shopa gir.");
                    seçim1 = Convert.ToInt32(Console.ReadLine());
                    if (seçim1 == 1)
                    {
                        Console.WriteLine("Üzülüp ağlamak istiyorum...");
                        devam = false;
                    }
                    else if (seçim1 == 2)
                    {
                        Console.WriteLine($"Shopa hoşgeldin {isim}. Ne yapmak istiyorsun? ");
                        Console.WriteLine("1) Eşya satmak istiyorum.\n" +
                            "2) Eşya Almak istiyorum\n" +
                            "3) Çantama bakmak istiyorum\n" +
                            "4) Geri Dönmek istiyorum");
                        seçim2 = Convert.ToInt32(Console.ReadLine());
                        if (seçim2 == 1)
                        {
                            oyuncu.Fiyat(false);
                            oyuncu.Sepet();
                            Console.WriteLine("Hangi eşyanı satmak istersin ? (geri dönmek için 'çıkış' yazın)");
                            string n = Console.ReadLine();
                            if (n == "çıkış")
                            {
                                continue;
                            }
                            for (int i = 0; i < oyuncu.item.Length; i++)
                            {
                                if (n.ToLower() == oyuncu.item[i])
                                {
                                    Console.WriteLine($"Kaç adet Satmak istersin (Her biri {oyuncu.itemfiyat[i]} altın)");
                                    int m = Convert.ToInt32(Console.ReadLine());
                                    if (m <= oyuncu.adet[i] && m > 0)
                                    {
                                        oyuncu.adet[i] = oyuncu.adet[i] - m;
                                        değer = m * oyuncu.itemfiyat[i];
                                        oyuncu.altın += değer;
                                        Console.WriteLine($"{m} adet {oyuncu.item[i]} sattın, artık {oyuncu.altın} altınınız var.");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Bu adet çantanda yok.");
                                    }
                                }
                                else
                                {
                                    continue;
                                }
                            }
                        }
                        else if (seçim2 == 2)
                        {
                            oyuncu.Fiyat(true);
                            for (int i = 0; i < oyuncu.item.Length; i++)
                            {
                                Console.WriteLine($"{i + 1}) {oyuncu.item[i]} {oyuncu.itemfiyat[i]} altın; ");
                            }
                            Console.WriteLine($"{oyuncu.item.Length + 1}) Shoptan çıkmak");
                            Console.WriteLine("Hangi eşyadan almak istersiniz ?(başındaki rakamla giriniz) ");
                            byte n = Convert.ToByte(Console.ReadLine());
                            if (n == oyuncu.item.Length + 1)
                            {
                                continue;
                            }
                            for (int i = 0; i < oyuncu.item.Length; i++)
                            {
                                if (n - 1 == i)
                                {
                                    Console.WriteLine($"Kaç adet Almak istersiniz (Her biri {oyuncu.itemfiyat[i]} altın)");
                                    int m = Convert.ToInt32(Console.ReadLine());
                                    if (m * oyuncu.itemfiyat[i] <= oyuncu.altın)
                                    {
                                        değer = m * oyuncu.itemfiyat[i];
                                        oyuncu.altın -= değer;
                                        oyuncu.adet[i] = oyuncu.adet[i] + m;
                                        Console.WriteLine($"{m} adet {oyuncu.item[i]} aldınız, artık {oyuncu.altın} altınınız var.");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Bunu alacak kadar altının yok.");
                                    }
                                }
                                else
                                {
                                    continue;
                                }
                            }

                        }
                        else if (seçim2 == 3)
                        {
                            oyuncu.Sepet();
                        }
                        else if (seçim2 == 4)
                        {
                            continue;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Şu an Sadece ormana ve shopa geçebilirsin.");
                    }
                    Console.ReadLine();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Beklenmeyen hatalar oluşuyor.");
            }
        }
    }
}

class oyuncu
{
    public string[] item = { "kilic", "zirh", "yay", "iksir", "et", "sebze" };
    public int[] adet = { 1, 0, 0, 2, 0, 0 };
    public int[] itemfiyat = { 150, 180, 210, 90, 420, 30 };
    public bool[] kırılma = { true, true, true, false, false, false };
    public int[] maxdayanım = { 20, 20, 15 };
    public int[] dayanım = { 10, 20, 15 };
    public int altın = 200;

    /// <summary>
    /// Satma ve Alma fiyatları değişimi methodu.
    /// </summary>
    /// <param name="a"></param>
    public void Fiyat(bool a)
    {
        if (a == false)
        {
            int[] itemfiyat = { 75, 90, 105, 45, 210, 15 };
        }
        else
        {
            int[] itemfiyat = { 150, 180, 210, 90, 420, 30 };
        }
    }
    /// <summary>
    /// Sepeti gösterme metodu.
    /// </summary>
    public void Sepet()
    {
        Console.WriteLine("Şu an çantanızda: ");
        for (int i = 0; i < item.Length; i++)
        {
            if (adet[i] > 0)
            {
                Console.WriteLine($"{adet[i]} adet {item[i]}.");
            }
            else
            {
                continue;
            }
        }
        Console.WriteLine("Bulunmakta.");
        
    }
}

