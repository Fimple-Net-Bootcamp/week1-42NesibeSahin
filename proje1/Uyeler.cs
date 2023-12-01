using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje1
{
	public class Uyeler
	{
        [Key]
		public int UyeID { get; set; }
		public string Ad { get; set; }
        public string Soyad { get; set; }
        public int ÜyelikNumarası { get; set; }
        public List<Kitap> OduncKitaplar { get; set; }

        public void Yazdir()
        {
            Console.WriteLine($"{Ad} {Soyad} - Üyelik No: {ÜyelikNumarası}");
            Console.WriteLine("Ödünç Aldığı Kitaplar:");
            foreach (var kitap in OduncKitaplar)
            {
                kitap.Yazdir();
            }
        }
    }
}
