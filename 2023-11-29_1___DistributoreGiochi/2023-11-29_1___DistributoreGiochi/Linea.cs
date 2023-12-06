using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace _2023_11_29_1___DistributoreGiochi {
    public class Linea {
        private static List<string> ids;
        private string idLinea;
        private string nomeLinea;
        private string descrizione;
        private float percentSconto;

        public static List<string> Ids {
            get { return ids; }
        }

        public string IdLinea {
            get { return idLinea; }
        }

        public string NomeLinea {
            get { return nomeLinea; }
            set {
                if (string.IsNullOrEmpty(value)) {
                    throw new ArgumentException("Il nome non può essere vuoto.");
                }
                idLinea = value;
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

        public float PercentSconto {
            get { return percentSconto; }
            set {
                if (value < 0) {
                    throw new ArgumentException("La percentuale di sconto non può essere negativa.");
                }
                if (value > 1) {
                    throw new ArgumentException("La percentuale di sconto deve essere indicata come numero compreso tra 0 e 1");
                }
                percentSconto = value;
            }
        }

        private string GeneraId(string nomeLinea) {
            System.Security.Cryptography.SHA1 hash = new System.Security.Cryptography.SHA1CryptoServiceProvider();
            if (string.IsNullOrEmpty(nomeLinea)) return "";

            //Unicode Encode Covering all characterset
            byte[] byteContents = Encoding.Unicode.GetBytes(nomeLinea);
            byte[] hashText = hash.ComputeHash(byteContents);
            uint hashCodeStart = BitConverter.ToUInt32(hashText, 0);
            uint hashCodeMedium = BitConverter.ToUInt32(hashText, 8);
            uint hashCodeEnd = BitConverter.ToUInt32(hashText, 16);
            var hashCode = hashCodeStart ^ hashCodeMedium ^ hashCodeEnd;
            string id = (uint.MaxValue - hashCode).ToString();
            if (!ids.Contains(id)) {
                ids.Add(id);
                return id;
            } else {
                GeneraId(nomeLinea);
            }
            return "";
        }

        public Linea(string nomeLinea, string descrizione, float percentSconto) {
            ids = new List<string>();
            idLinea = GeneraId(nomeLinea);
            NomeLinea = nomeLinea;
            Descrizione = descrizione;
            PercentSconto = percentSconto;
        }

        public Linea(Linea linea) {
            ids = new List<string>();
            idLinea = GeneraId(linea.NomeLinea);
            NomeLinea = linea.NomeLinea;
            Descrizione = linea.Descrizione;
            PercentSconto = linea.PercentSconto;
        }

        public override string ToString() {
            return $"{nomeLinea}/{idLinea}/{descrizione}/{percentSconto * 100}%";
        }
    }
}
