using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje1
{
	class Program
	{
		static void Main(string[] args)
		{
            Kutuphane kutuphane = new Kutuphane();

            Kitap kitap1 = new Kitap { Ad = "Kitap 1", Yazar = "Yazar 1", YayınYılı = 2020, KitapID = 1 };
            Kitap kitap2 = new Kitap { Ad = "Kitap 2", Yazar = "Yazar 2", YayınYılı = 2021, KitapID = 2 };

            Uyeler üye1 = new Uyeler { Ad = "Ahmet", Soyad = "Yılmaz", ÜyelikNumarası = 101, OduncKitaplar = new List<Kitap>() };
            üye1 = new Uyeler { Ad = "Ahmet", Soyad = "Yılmaz", ÜyelikNumarası = 101, OduncKitaplar = new List<Kitap>() };

            kutuphane.KitapEkle(kitap1);
            kutuphane.KitapEkle(kitap2);
            kutuphane.UyeEkle(üye1);

            kutuphane.KitapOduncVer(üye1, kitap1);

            Console.WriteLine("Kitaplar:");
            foreach (var kitap in kutuphane.kitaplar)
            {
                kitap.Yazdir();
            }

            Console.WriteLine("\nÜyeler:");
            foreach (var uye in kutuphane.uyeler)
            {
                uye.Yazdir();
            }
        }
	}
}
