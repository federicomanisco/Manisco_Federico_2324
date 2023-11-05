using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023_11_06_1 {
    public class Videogioco {

		private string titolo;

		public string Titolo {
			get { return titolo; }
			set {
				if (string.IsNullOrEmpty(value)) {
					throw new ArgumentNullException("Il titolo non può essere vuoto.");
				}
				titolo = value;
			}
		}

		private float prezzo;

		public float Prezzo {
			get { return prezzo; }
			set { 
				if (value < 0) {
					throw new ArgumentOutOfRangeException("Il prezzo non può essere negativo.");
				} 
				prezzo = value;
			}
		}

		private DateOnly dataAcquisto;

		public DateOnly DataAcquisto {
			get { return dataAcquisto; }
			set {
				DateOnly oggi = new DateOnly(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
				int diff = oggi.DayNumber - value.DayNumber;
				if (diff < 0) {
					throw new ArgumentOutOfRangeException("La data di acquisto non può essere successiva alla data di oggi.");
				}
				dataAcquisto = value;
			}
		}

		private List<string> piattaforme = new List<string> { "Computer", "PlayStation", "Xbox", "Nintendo" };

		private string piattaforma;

		public string Piattaforma {
			get { return piattaforma; }
			set {
				if (!piattaforme.Contains(value)) {
					throw new ArgumentException("Piattaforma non valida.");
				}
				piattaforma = value;
			}
		}

		public Videogioco(string titolo, float prezzo, DateOnly dataAcquisto, string piattaforma) {
			Titolo = titolo;
			Prezzo = prezzo;
			DataAcquisto = dataAcquisto;
			Piattaforma = piattaforma;
		}

		public Videogioco(Videogioco videogioco) {
			Titolo = videogioco.Titolo;
			Prezzo = videogioco.Prezzo;
			DataAcquisto = videogioco.DataAcquisto;
			Piattaforma = videogioco.Piattaforma;
		}

        public override string ToString() {
            return $"{Titolo}: {Prezzo}€. Acquistato il {DataAcquisto}. Piattaforma: {Piattaforma}";
        }
    }
}
