using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    public class Kitap
    {
        public int KitapNo { get; set; }
        public string KitapAd { get; set; }
        public string KitapYazari { get; set; }
        public int KitapBaskiYil { get; set; }
        public int KitapSayfaSayi { get; set; }
        public string KitapDil { get; set; }
        public string KitapYayinEvi { get; set; }
        public string KitapAciklama { get; set; }
    }
}
