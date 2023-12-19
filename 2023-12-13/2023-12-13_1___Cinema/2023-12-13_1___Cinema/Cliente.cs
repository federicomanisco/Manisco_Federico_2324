using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace _2023_12_13_1___Cinema {
    public class Cliente {

        private string nome, cognome;
        private List<string> poltronePrenotate;
        private static List<string> poltroneOccupate = new List<string>();

        public string Nome {
            get { return nome; }
            set {
                if (value.Length < 3) { throw new ArgumentNullException("Il nome deve contenere almeno 3 lettere."); }
                nome = value;
            }
        }
        
        public string Cognome { 
            get { return cognome; }
            set {
                if (value.Length < 3) { throw new ArgumentNullException("Il cognome deve contenere almeno 3 lettere."); }
                cognome = value; 
            }
        }

        public void prenotaPoltrone(List<string> poltrone) {
            foreach (string poltrona in poltrone) {
                if (poltronePrenotate.Contains(poltrona) || poltroneOccupate.Contains(poltrona)) {
                    throw new Exception("Poltrona già prenotata");
                }
                poltronePrenotate.Add(poltrona);
            }
        }

        public Cliente(string nome, string cognome) {
            Nome = nome;
            Cognome = cognome;
        }
    }
}
