using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje1
{
	public class Kitap : YaziliEserler
    {
        [Key]
        public int KitapID { get; set; }

        public override void Yazdir()
        {
            base.Yazdir();
            Console.WriteLine($"Kitap ID: {KitapID}");
        }
        
    }
}
