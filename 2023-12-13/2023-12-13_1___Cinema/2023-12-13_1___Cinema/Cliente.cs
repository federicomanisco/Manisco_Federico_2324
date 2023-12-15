using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace _2023_12_13_1___Cinema {
    public class Cliente {

        private string nome, cognome;
        private Poltrona poltrona;
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

        public Poltrona Poltrona {
            get { return poltrona; }
            set {
                if (poltroneOccupate.Contains(value.Posizione)) throw new ArgumentException("La poltrona è occupata.");
                poltrona = value; 
            }
        }

        public Cliente(string nome, string cognome, Poltrona poltrona) {
            Nome = nome;
            Cognome = cognome;
            Poltrona = poltrona;
            poltroneOccupate.Add(poltrona.Posizione);
        }
    }
}
