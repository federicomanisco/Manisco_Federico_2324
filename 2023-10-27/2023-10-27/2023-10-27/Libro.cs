using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace _2023_10_27 {
    public class Libro {
        private string titolo;
        private string autore;
        private int numeroPagine;
        private string genere;
        private bool raccolta;


        public string Titolo {
            get { return titolo; }
            set { 
                if (string.IsNullOrEmpty(value)) { 
                    throw new ArgumentNullException("Il titolo non può essere vuoto."); 
                }
                
                if (!(value.Length >= 2)) {
                    throw new ArgumentException("Il titolo non può essere più corto di 2 caratteri.");
                }
                titolo = value; 
            }
        }

        public string Autore { 
            get {
                return autore;
            } 
            set {
                if (string.IsNullOrEmpty(value)) {
                    throw new ArgumentNullException("L'autore non può essere vuoto.");
                }

                autore = value;
            }
        }

        public int NumeroPagine {
            get {
                return numeroPagine;
            } 
            set {
                if (value == 0 || value < 50 || value > 10000) {
                    throw new ArgumentException("Il numero di pagine non è valido.");
                }
                numeroPagine = value;
            }
        }

        public string Genere { 
            get {
                return genere;
            } 
            set {
                if (string.IsNullOrEmpty(value)) {
                    throw new ArgumentNullException("Il genere non può essere vuoto");
                }
                genere = value;
            } 
        }

        public bool Raccolta {
            get {
                return raccolta;
            }

            set {
                raccolta = value;
            }
        }

        public Libro(string titolo, string autore, int numeroPagine,  string genere, bool raccolta) {
            Titolo = titolo;
            Autore = autore;
            NumeroPagine = numeroPagine;
            Genere = genere;
            Raccolta = raccolta;
        }

        private float calcolaCosto(int numeroPagine) {
            float costo = numeroPagine * 0.01f;
            if (numeroPagine > 100 && numeroPagine <= 200) {
                return costo - costo * 0.01f;
            }
            if (numeroPagine > 200 && numeroPagine <= 500) {
                return costo - costo * 0.03f;
            }
            if (numeroPagine > 500) {
                return costo - costo * 0.05f;
            }
            return costo;
        }

        public override string ToString() {
            return $"Titolo: {Titolo}, Autore: {Autore}, Numero Pagine: {NumeroPagine}, Genere: {Genere}, {(Raccolta? "Parte di una raccolta" : "Non parte di una raccolta")}";
        }
    }
}
