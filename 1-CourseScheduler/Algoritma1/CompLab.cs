using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritma1
{
    internal class CompLab
    {
        public int capacity { get; set; } // Lab kapasitesi
        public int initialCapacity { get; set; } // Bir güne dersleri yerleştirdikten sonra diğer gün o labları yine kullanabilmemiz için kapasiteyi sıfırlamak adına kullandığımız değişken
        public string name { get; set; } // Lab ismi
        public bool isFull { get; set; } // Labın dolu olup olmadığını gösteren değişken

        public CompLab(int capacity,string name) { this.capacity = capacity; this.name = name; isFull = false; initialCapacity = capacity; }
    }
}
