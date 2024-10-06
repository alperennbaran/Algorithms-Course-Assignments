using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritma1
{
    internal class Course
    {
        public int quota { get; set; }  // Dersin kontenjanı
        public int duration { get; set; }  // Dersin süresi(saat cinsinden)
        public string name { get; set; }  // Dersin ismi
        public bool isPlaced { get; set; }  // Dersin programa yerleştirilip yerleştirilmediğini gösteren değişken

        public Course(int quota, int duration, string name) 
        { this.quota = quota; this.duration = duration; this.name = name; isPlaced = false; }
    }
}
