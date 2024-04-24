using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_04_24_Verifica {
    public class Risposta {

        private int rispostaData;
        public int RispostaData { get; }
        private int rispostaCorretta;
        public int RispostaCorretta { get; }

        public Risposta(bool rispostaCorretta, bool rispostaData) {
            this.rispostaData = rispostaData ? 0 : 1;
            this.rispostaCorretta = rispostaCorretta ? 0 : 1;
        }

        public override string ToString() {
            return $"rispostaData: {RispostaData} -- rispostaCorretta {RispostaCorretta}";
        }
    }
}
