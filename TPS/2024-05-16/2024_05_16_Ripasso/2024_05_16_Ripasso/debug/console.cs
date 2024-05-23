using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_05_16_Ripasso.debug {
    public static class console {
        public static void WriteLine(string ciao) {
            Random r = new Random();
            for (int i = 1; i < 501;  i++) {
                Console.WriteLine($"persona{i} - {((r.Next(1, 101) >= 90) ? "positivo" : "negativo")}");
            }
        }
    }
}
