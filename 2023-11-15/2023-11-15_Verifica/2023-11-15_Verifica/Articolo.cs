using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023_11_15_Verifica {
    public class Articolo {
		private string id;

		public string Id {
			get { return id; }
			set {
				if (value.Length == 6) {
					bool valido = true;
					foreach (char c in value) {
						if (char.IsSymbol(c)) {
							valido = false;
						}
					}
					if (valido) {
						id = value;
					} else {
						throw new ArgumentException("L'ID non può contenere caratteri speciali.");
					}
				} else {
					throw new ArgumentException("L'ID deve essere di 6 caratteri alfanumerici.");
				}
			}
		}
		private string descrizione;

		public string Descrizione {
			get { return descrizione; }
			set {
				if (value.Length >= 5 && value.Length <= 45) {
					descrizione = value;
				} else {
					throw new ArgumentOutOfRangeException("La descrizione non può essere più corta di 5 caratteri o più lunga di 45.");
				}
			}
		}

		private string tipo;
		private List<string> articoliAccettati = new List<string> { "elettronico", "decorativo", "ecofriendly", "ironico" };

		public string Tipo {
			get { return tipo; }
			set {
				if (articoliAccettati.Contains(value)) {
					tipo = value; 
				} else {
					throw new ArgumentException("Tipo non accettato.");
				}
			}
		}

		private DateTime dataAcquisto;

		public DateTime DataAcquisto {
			get { return dataAcquisto; }
			set {
				if (value <= DateTime.Now) {
					dataAcquisto = value; 
				} else {
					throw new ArgumentOutOfRangeException("La data può essere al massimo quella di oggi.");
				}
			}
		}

		private float prezzo;

		public float Prezzo {
			get { return prezzo; }
			set {
				if (value >= 0) {
					prezzo = value; 
				} else {
					throw new ArgumentException("Il prezzo non può essere negativo.");
				}
			}
		}

		public Articolo(string id, string descrizione, string tipo, DateTime dataAcquisto, float prezzo) {
			Id = id;
			Descrizione = descrizione;
			Tipo = tipo;
			DataAcquisto = dataAcquisto;
			Prezzo = prezzo;
		}

		public float ScontoApplicabile() {
			if (Tipo == "elettronico" || Tipo == "decorativo" || Prezzo < 15) {
				return 0;
			}
			float sconto = 0.8f + ((float)DateTime.Now.Subtract(DataAcquisto).Days / 1000.0f) * Prezzo;
			if (sconto < Prezzo) {
				return sconto;
			} else {
				return Prezzo;
			}
		}

        public string getDataToString() {
            return new DateOnly(DataAcquisto.Year, DataAcquisto.Month, DataAcquisto.Day).ToString();
        }

        public override string ToString() {
			return $"{Id} {Descrizione}. Articolo {Tipo}. {getDataToString()} {Prezzo}€";
		}

	}
}
