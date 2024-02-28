using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace _2023_11_24_1 {
    public class Cassa {
        private static int bigliettiVenduti;
        private int bigliettiRimanenti;
        public int BigliettiRimanenti {
            get { return bigliettiRimanenti; }
        }

        public int BigliettiVenduti {
            get { return bigliettiVenduti; }
        }

        public Cassa() {
            bigliettiRimanenti = 100;
        }

        public void VendiBiglietto() {
            if (BigliettiVenduti < 250) {
                if (BigliettiRimanenti > 0) {
                    bigliettiVenduti++;
                    bigliettiRimanenti--;
                } else {
                    throw new Exception("Questa cassa ha esaurito i biglietti.");
                }
            } else {
                throw new Exception("Tutti i biglietti sono esauriti.");
            }
        }

        public void AnnullaBiglietto() {
            bigliettiRimanenti++;
            bigliettiVenduti--;
        }

        public void VendiBiglietti(int biglietti) {
            if (BigliettiVenduti < 250 -  biglietti) {
                if (BigliettiRimanenti > 0 + biglietti) {
                    bigliettiVenduti += biglietti;
                    bigliettiRimanenti -= biglietti;    
                } else {
                    throw new Exception($"La cassa non ha abbastanza biglietti.");
                }
            } else {
                throw new Exception("Non rimangono abbastanza biglietti.");
            }
        }

        public void AnnullaBiglietti(int biglietti) {
            bigliettiRimanenti += biglietti;
            bigliettiVenduti -= biglietti;
        }

        public int getVenduti() {
            return 100 - bigliettiRimanenti;
        }
    }
}
