using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _2023_11_29_1___DistributoreGiochi
{
    public class Gioco {
        private static List<string> ids;
        private string idGioco;
        private string nomeGioco;
        private string descrizione;
        private Linea linea;
        private float prezzo;

        public static List<string> Ids {
            get {
                return ids;
            }
        }

        public string IdGioco {
            get { return idGioco; }
        }

        public string NomeGioco {
            get { return nomeGioco; }
            set {
                if (string.IsNullOrEmpty(value)) {
                    throw new ArgumentException("Il nome non può essere vuoto.");
                }
                nomeGioco = value;
            }
        }

        public string Descrizione {
            get { return descrizione; }
            set {
                if (!(value.Length >= 5 && value.Length <= 40)) {
                    throw new ArgumentException("La descrizione può contenere da 5 a 40 caratteri.");
                }
                descrizione = value;
            }
        }

        public Linea Linea {
            get { return linea; }
        }

        public float Prezzo {
            get { return prezzo; }
            set {
                if (value < 0) {
                    throw new ArgumentException("Il prezzo non può essere negativo.");
                }
            }
        }

        private string GeneraID() {
            StringBuilder builder = new StringBuilder();
            Enumerable
               .Range(65, 26)
                .Select(e => ((char)e).ToString())
                .Concat(Enumerable.Range(97, 26).Select(e => ((char)e).ToString()))
                .Concat(Enumerable.Range(0, 10).Select(e => e.ToString()))
                .OrderBy(e => Guid.NewGuid())
                .Take(10)
                .ToList().ForEach(e => builder.Append(e));
            string id = builder.ToString();
            if (!ids.Contains(id)) {
                ids.Add(id);
                return id;
            } else {
                GeneraID();
            }
            return "";
        }

        public Gioco(string nomeGioco, string descrizione, Linea linea, float prezzo) {
            idGioco = GeneraID();
            NomeGioco = nomeGioco;
            Descrizione = descrizione;
            this.linea = new Linea(linea);
            Prezzo = prezzo;
        }

        public Gioco(string nomeGioco, string descrizione, string nomeLinea, string descrizioneLinea, float percentSconto, float prezzo) {
            NomeGioco = nomeGioco;
            Descrizione = descrizione;
            linea = new Linea(nomeLinea, descrizioneLinea, percentSconto);
            Prezzo = prezzo;
        }

        public override string ToString() {
            return $"{NomeGioco}/{idGioco}/{linea}/{Prezzo}€";
        }
    }
}
