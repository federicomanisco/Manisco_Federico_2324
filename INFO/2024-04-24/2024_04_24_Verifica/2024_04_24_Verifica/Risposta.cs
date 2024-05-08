using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_04_24_Verifica {
    public class Risposta {

        private int rispostaData;
        public int RispostaData { get { return rispostaData; } }
        private int rispostaCorretta;
        public int RispostaCorretta { get { return rispostaCorretta; } }

        public Risposta(bool rispostaCorretta, bool rispostaData) {
            this.rispostaData = rispostaData == true ? 0 : 1;
            this.rispostaCorretta = rispostaCorretta == true ? 0 : 1;
        }

        public override string ToString() {
            return $"rispostaData: {RispostaData} -- rispostaCorretta {RispostaCorretta}";
        }
    }
}
