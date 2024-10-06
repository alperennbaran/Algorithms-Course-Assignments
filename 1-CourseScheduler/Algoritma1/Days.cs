using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritma1
{
    internal class Days
    {
        public int maxDuration { set; get; } // 1 güne yerleştirilmesi gereken max ders saati
        public String name { set; get; }  // Günün ismi

        public Days(String isim)
        {
            this.name = isim; maxDuration = 8;
        }
    }
}
