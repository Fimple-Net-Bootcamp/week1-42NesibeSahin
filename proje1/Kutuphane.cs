using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje1
{
	public class Kutuphane

	{
		public List<Kitap> kitaplar;
		public List<Uyeler> uyeler;

		public Kutuphane()
		{
			kitaplar = new List<Kitap>();
			uyeler = new List<Uyeler>();
		}

		public void KitapEkle(Kitap kitap)
		{
			kitaplar.Add(kitap);
		}

		public void UyeEkle(Uyeler uye)
		{
			uyeler.Add(uye);
		}

		public void KitapOduncVer(Uyeler uye, Kitap kitap)
		{
			uye.OduncKitaplar.Add(kitap);
			kitaplar.Remove(kitap);
		}

		public void KitapIade(Uyeler uye, Kitap kitap)
		{
			uye.OduncKitaplar.Remove(kitap);
			kitaplar.Add(kitap);
		}
	}
}
