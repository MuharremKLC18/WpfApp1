using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Model
{
    public class Oyuncu
    {

        //public string Ad { get; set; }
        //public string Soyad { get; set; }

        String ad;
        String soyad;

        public string Ad { get => ad; set => ad = value.ToUpper(); }
        public string Soyad { get => soyad; set => soyad = value.ToUpper(); }

    }
}
