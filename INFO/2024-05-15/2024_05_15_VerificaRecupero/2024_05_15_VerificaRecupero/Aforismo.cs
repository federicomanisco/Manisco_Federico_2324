using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_05_15_VerificaRecupero {
    public class Aforismo : IComparable<Aforismo>, IEquatable<Aforismo> {
        public string Autore { get; set; }
        public int AnnoDiNascita { get; set; }
        public string Aforisma { get; set; }
        public bool Divertente { get; set; }
        public string Nazionalità { get; set; }

        public int CompareTo(Aforismo? other) {
            string cognomeThis, cognomeOther;

            if (other == null) return 1;
            string[] thisAutore = this.Autore.Split(" ");
            if (thisAutore.Count() > 2) {
                cognomeThis = thisAutore[thisAutore.Count() - 2] + " " + thisAutore[thisAutore.Count() - 1];
            } else {
                cognomeThis = thisAutore[thisAutore.Count() - 1];
            }
            string[] otherAutore = other.Autore.Split(" ");
            if (otherAutore.Count() > 2) {
                cognomeOther = otherAutore[otherAutore.Count() - 2] + " " + otherAutore[otherAutore.Count() - 1];
            } else {
                cognomeOther = otherAutore[otherAutore.Count() - 1];
            }
            return string.Compare(cognomeThis, cognomeOther);
        }

        public bool Equals(Aforismo? other) {
            if (other == null) return false;
            return (Autore == other.Autore && AnnoDiNascita == other.AnnoDiNascita && Aforisma == other.Aforisma && Divertente == other.Divertente && Nazionalità == other.Nazionalità);
        }

        public override string ToString() {
            return $"{Autore}: {Aforisma}";
        }
    }
}
