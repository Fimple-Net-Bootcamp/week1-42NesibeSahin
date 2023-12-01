using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje1
{
	public class YaziliEserler : IYazdirilabilir
    {
        [Key]
		public int KitapID { get; set; }
		public string Ad { get; set; }
        public string Yazar { get; set; }
        public int YayınYılı { get; set; }

        public virtual void Yazdir()
        {
            Console.WriteLine($"{Ad} - {Yazar} - {YayınYılı}");
        }
    }
}
