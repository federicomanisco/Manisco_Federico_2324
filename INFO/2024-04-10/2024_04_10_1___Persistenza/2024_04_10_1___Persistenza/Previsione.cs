using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_04_10_1___Persistenza
{
    public class Previsione
    {
        public string Citta { get; set; }
        public float TempMedia { get; set; }
        public int mmPioggia { get; set; }
        public DateTime Data { get; set; }
        public int[] Temperature { get; set; }
    }
}
