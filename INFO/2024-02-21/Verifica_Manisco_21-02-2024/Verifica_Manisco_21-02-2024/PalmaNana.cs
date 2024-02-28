using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verifica_Manisco_21_02_2024 {
    public class PalmaNana : PiantaEndemica {
        public enum ColoreFrutti {
            Verde,
            Giallo,
            Marrone,
        }

        private int fioriture;
        private ColoreFrutti coloreFrutti;
        public PalmaNana(string codice, StatoConservazione statoConservazione, ColoreFrutti coloreFrutti) : base(codice, statoConservazione) {
            fioriture = 1;
            this.coloreFrutti = coloreFrutti;
        }

        public override void fiorisci() {
            if (fioriture == 1) {
                HaFiorito = true;
                fioriture--;
            } else {
            }
        }

        public override string ToString() {
            string colore = "";
            switch (coloreFrutti) {
                case ColoreFrutti.Verde:
                    colore = "Frutti Verdi (immaturi)";
                    break;
                case ColoreFrutti.Giallo:
                    colore = "Frutti Gialli (prossimi alla maturità)";
                    break;
                case ColoreFrutti.Marrone:
                    colore = "Frutti Marroni (maturi)";
                    break;
                default:
                    break;
            }
            return base.ToString() + $"{colore} {(fioriture == 1 ? "può ancora fiorire" : "non può più fiorire")}";
        }
    }
}
