using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace _2023_12_13_1___Cinema {
    public class Poltrona {

        private string posizione;
        private bool occupata;

        public string Posizione {
            get { return posizione; }
            set {
                if (value.Length != 2) throw new ArgumentException("Inserisci una posizione valida.");
                if (!char.IsLetter(value[0]) && !char.IsDigit(value[1])) throw new ArgumentException("Inserisci una posizione valida.");
                posizione = value; 
            }
        }

        public bool Occupata {
            get { return occupata; }
            set { occupata = value; }
        }

        public Poltrona(string posizione, bool occupata) {
            Posizione = posizione;
            Occupata = occupata;
        }
    }
}
