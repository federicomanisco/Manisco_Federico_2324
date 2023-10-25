using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _2023_10_25_1___FootballManager {
    public class Calciatore {
        private string nome;
        private string cognome;
        private int numeroMaglia;
        private DateOnly dataNascita;
        private int capacitaFisica = 3;

        public Calciatore(string nome, string cognome, int numeroMaglia, DateOnly dataNascita) {
            setNome(nome);
            setCognome(cognome);
            setNumeroMaglia(numeroMaglia);
            setDataNascita(dataNascita);
        }

        public void setNome(string nome) { 
            if (string.IsNullOrWhiteSpace(nome)) {
                throw new ArgumentNullException("Il nome non può essere vuoto.");
            }
            this.nome = nome;
        }

        public void setCognome(string cognome) {
            if (string.IsNullOrWhiteSpace(cognome)) {
                throw new ArgumentNullException("Il cognome non può essere vuoto.");
            }
            this.cognome = cognome;
        }

        public void setNumeroMaglia(int numeroMaglia) {
            if (numeroMaglia < 1 || numeroMaglia > 99) {
                throw new ArgumentException("Il numero di maglia deve essere compreso tra 1 e 99.");
            }
            this.numeroMaglia = numeroMaglia;
        }

        public void setDataNascita(DateOnly dataNascita) {
            DateTime dataTemp = new DateTime(dataNascita.Year, dataNascita.Month, dataNascita.Day);
            TimeSpan diff = DateTime.Now - dataTemp;

            if (diff.Days < 365 * 6) {
                throw new ArgumentException("Il calciatore è troppo giovane. (minimo 6 anni)");
            }

            this.dataNascita = dataNascita;
        }

        public int Eta {
            get {
                DateTime date = new DateTime(dataNascita.Year, dataNascita.Month, dataNascita.Day);
                return (DateTime.Now - date).Days;
            }
        }

        public void allenati(int durata) {
            if (durata > 90) {
                if (capacitaFisica > 2) {
                    capacitaFisica -= 2;
                } else {
                    capacitaFisica = 0;
                }
            }
            if (durata > 45 && durata < 70) {
                if (!(capacitaFisica > 100-3)) {
                    capacitaFisica += 3;
                } else {
                    capacitaFisica = 100;
                }
            }
        }

        public override string ToString() {
            return $"{nome}, {cognome}, {numeroMaglia}, {capacitaFisica}, {dataNascita}";
        }
    }
}
