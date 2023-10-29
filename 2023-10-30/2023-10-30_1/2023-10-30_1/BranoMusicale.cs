using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023_10_30_1 {
    public class BranoMusicale {
		private string titolo;
		private string autore;
		private int durata;
		private string titoloAlbum;
		private bool isGhost;

		public bool IsGhost {
			get { return isGhost; }
			set { isGhost = value; }
		}


		public string TitoloAlbum {
			get { return titoloAlbum; }
			set { 
				if (string.IsNullOrEmpty(value)) {
					throw new ArgumentException("Il titolo non può essere vuoto.");
				}
				if (value.Length <= 1) {
					throw new ArgumentException("Il titolo è troppo corto.");
				}
				titoloAlbum = value; 
			}
		}


		public int Durata {
			get { return durata; }
			set { 
				if (value < 0) {
					throw new ArgumentOutOfRangeException("La durata non può essere negativa.");
				}
				if (value > 10000) {
					throw new ArgumentOutOfRangeException("La durata è troppo grande.");
				}
				durata = value; 
			}
		}


		public string Autore {
			get { return autore; }
			set {
                if (string.IsNullOrEmpty(value)) {
                    throw new ArgumentException("L'autore non può essere vuoto.");
                }
                autore = value; 
			}
		}


		public string Titolo {
			get { return titolo; }
			set {
                if (string.IsNullOrEmpty(value)) {
                    throw new ArgumentException("Il titolo non può essere vuoto.");
                }
                if (value.Length <= 1) {
                    throw new ArgumentException("Il titolo è troppo corto.");
                }
                titolo = value; 
			}
		}

		public BranoMusicale(string titolo, string autore, int durata, string titoloAlbum, bool isGhost) {
			Titolo = titolo;
			Autore = autore;
			TitoloAlbum = titoloAlbum;
			Durata = durata;
			IsGhost = isGhost;
		}

		public BranoMusicale(BranoMusicale branoMusicale) {
			Titolo = branoMusicale.Titolo;
			Autore = branoMusicale.Autore;
			Durata = branoMusicale.Durata;
			TitoloAlbum = branoMusicale.TitoloAlbum;
			IsGhost = branoMusicale.IsGhost;
		}

		public override string ToString() {
			return $"{Titolo} di {Autore}. {Durata} secondi, parte di {TitoloAlbum}. {(IsGhost? "Ghost-track" : "Non ghost-track")}";
		}

	}
}
