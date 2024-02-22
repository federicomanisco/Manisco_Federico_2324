using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023_11_08_1___Sport {
    public class Squadra {
        private string nome;
        private string disciplina;
        private DateTime dataFondazione;
        private List<Atleta> membri;

        public string Nome {
            get {
                return nome;
            }
            set {
                if (string.IsNullOrEmpty(value)) {
                    throw new ArgumentException("Il nome della squadra non può essere vuoto.");
                }
                nome = value;
            }
        }

        public int NumeroMembri {
            get {
                return membri.Count;
            }
        }

        public DateTime DataFondazione {
            get {
                return dataFondazione;
            }
            set {
                if (value > DateTime.Now) {
                    throw new ArgumentException("La data deve essere precedente a quella di oggi.");
                }
                dataFondazione = value;
            }
        }

        public string Disciplina {
            get { return disciplina; }
            set {
                if (string.IsNullOrEmpty(value)) {
                    throw new ArgumentException("La disciplina della squadra non può essere vuota.");
                }
                disciplina = value;
            }
        }

        public Squadra(string nome, string disciplina, DateTime annoFondazione) {
            Nome = nome;
            Disciplina = disciplina;
            DataFondazione = annoFondazione;
            membri = new List<Atleta>();
        }

        public void aggiungiMembro(Atleta atleta) {
            if (atleta.Disciplina == Disciplina) {
                membri.Add(atleta);
            } else {
                throw new Exception("La disciplina dell'atleta deve coincidere con quella della squadra.");
            }
        }

        public List<Atleta> Membri {
            get { return membri; }
        }

        public override string ToString() {
            return $"{Nome} {DataFondazione.Year} Disciplina: {Disciplina} N° atleti: {NumeroMembri}";
        }
    }
}
