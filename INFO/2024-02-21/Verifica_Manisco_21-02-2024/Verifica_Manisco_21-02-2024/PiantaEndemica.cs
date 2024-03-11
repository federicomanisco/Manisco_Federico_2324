using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace Verifica_Manisco_21_02_2024 {
    public abstract class PiantaEndemica {
        private static List<string> codici;
        private string codicePianta;
        protected bool haFiorito;
        protected static DateTime periodoAnno;

        public DateTime PeriodoAnno {
            get { return periodoAnno; }
            set {
                periodoAnno = value;
            }
        }

        public enum StatoConservazione {
            Estinto = 0,
            Minacciato = 1,
            BassoRischio = 2,
            NonValutato = 3,
        }

        protected StatoConservazione statoConservazione;
        public StatoConservazione Stato {
            get { return statoConservazione; }
            set {
                statoConservazione = value;
            }
        }

        public string CodicePianta {
            get { return codicePianta; }
            set {
                if (codici.Contains(value)) {
                    throw new ArgumentException("Codice già presente. Inserire un codice univoco per ogni pianta.");
                }
                if (value.Length != 8) {
                    throw new ArgumentException("Il codice deve contenere esattamente 8 caratteri alfanumerici.");
                }
                if (string.IsNullOrEmpty(value)) {
                    throw new ArgumentNullException("Il codice non può essere vuoto.");
                }
                foreach (char c in value) {
                    if (!(char.IsLetter(c) || char.IsDigit(c))) {
                        throw new ArgumentException("Il codice può contenere solo caratteri alfanumerici senza simboli o caratteri speciali.");
                    }
                    codicePianta = value;
                    if (value != "00000000") codici.Add(value);
                }
            }
        }

        public bool HaFiorito {
            get { return haFiorito; }
            set {
                haFiorito = value;
            }
        }


        public PiantaEndemica(string codicePianta, StatoConservazione statoConservazione) {
            codici = new List<String>();
            CodicePianta = codicePianta;
            this.statoConservazione = statoConservazione;
        }

        public PiantaEndemica(string a_caso) {
            CodicePianta = "00000000";
        }

        public abstract void fiorisci();
        public override string ToString() {
            string conservazione = "";
            switch (statoConservazione) {
                case StatoConservazione.Estinto:
                    conservazione = "Estinta";
                    break;
                case StatoConservazione.Minacciato:
                    conservazione = "Minacciata";
                    break;
                case StatoConservazione.BassoRischio:
                    conservazione = "Basso rischio";
                    break;
                case StatoConservazione.NonValutato:
                    conservazione = "Non valutato";
                    break;
                default:
                    break;
            }
            return $"{codicePianta} {conservazione} {(HaFiorito ? "ha fiorito" : "non ha fiorito")} ";
        }
    }
}
