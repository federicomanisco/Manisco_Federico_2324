using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace _2023_11_08_1___Sport {
    public class Atleta {
		private string nome;

		public string Nome {
			get { return nome; }
			set {
				if (string.IsNullOrEmpty(value)) {
					throw new ArgumentNullException("Il nome non può essere vuoto.");
				}
				if (value.Length <= 3) {
					throw new ArgumentException("Il nome deve essere più lungo di 3 caratteri.");
				}
				bool valido = true;
				foreach (char c in value) {
					if (char.IsDigit(c)) {
						valido = false;
					}
				}
				if (valido) {
					nome = value;
				} else {
                    throw new ArgumentException("Il nome non può contenere numeri.");
                }
            }
		}

		private string cognome;

		public string Cognome {
			get { return cognome; }
			set {
				if (string.IsNullOrEmpty(value)) {
					throw new ArgumentNullException("Il cognome non può essere vuoto.");
				}
				if (value.Length <= 3) {
					throw new ArgumentException("Il cognome deve essere più lungo di 3 caratteri.");
				}
				bool valido = true;
				foreach (char c in value) {
					if (char.IsDigit(c)) {
						valido = false;
					}
				}
				if (valido) {
					cognome = value;
				} else {
					throw new ArgumentException("Il cognome non può contenere numeri.");
				}
			}
		}

		private DateTime dataNascita;

		public DateTime DataNascita {
			get { return dataNascita; }
			set {
				if (value > DateTime.Now) {
					throw new ArgumentException("La data deve essere precedente a quella di oggi");
				}
				dataNascita = value; 
			}
		}

		private string disciplina;

		public string Disciplina {
			get { return disciplina; }
			set {
                if (string.IsNullOrEmpty(value)) {
                    throw new ArgumentNullException("La disciplina non può essere vuota.");
                }
                bool valido = true;
                foreach (char c in value) {
                    if (char.IsDigit(c)) {
                        valido = false;
                    }
                }
                if (valido) {
                    disciplina = value;
                } else {
                    throw new ArgumentException("La disciplina non può contenere numeri.");
                }
			}
		}

		public Atleta(string nome, string cognome, DateTime dataNascita, string disciplina) {
			Nome = nome;
			Cognome = cognome;
			DataNascita = dataNascita;
			Disciplina = disciplina;
		}

		public override string ToString() {
			return $"{nome} {cognome} {new DateOnly(DataNascita.Year, DataNascita.Month, DataNascita.Day)}";
		}

	}
}
