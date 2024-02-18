using ScacchiC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _2024_02_19_1___Scacchi {
    public class Alfiere : Pedina {
        public Alfiere (string colore, int riga, int colonna, Scacchiera scacchiera) : base(colore, riga, colonna, scacchiera) {

        }

        public override void mangia(int r, int c) {
            throw new NotImplementedException();
        }

        public override void trasforma(Pedina p) {
            throw new NotImplementedException();
        }

        public override string stampa() {
            return "a";
        }

        public override void muovi(int nuovaRiga, int nuovaColonna) {
            base.muovi(nuovaRiga, nuovaColonna);
            bool mossa_valida = Math.Abs(nuovaColonna - colonna) == Math.Abs(nuovaRiga - riga);

            if (!mossa_valida) {
                throw new ArgumentException("Mossa non valida");
            }

            if (nuovaColonna > colonna && nuovaRiga > riga) {
                for (int i = colonna + 1; i <= nuovaColonna; i++) {
                    for (int j = riga + 1; j <= nuovaRiga; j++) {
                        if (scacchiera.getPedina(j, i) != null) {
                            throw new ArgumentException("Pedina nel mezzo");
                        }
                    }
                }
            }

            if (nuovaColonna > colonna && nuovaRiga < riga) {
                for (int i = colonna + 1; i <= nuovaColonna; i++) {
                    for (int j = riga - 1; j >= nuovaRiga; j--) {
                        if (scacchiera.getPedina(j, i) != null) {
                            throw new ArgumentException("Pedina nel mezzo");
                        }
                    }
                }
            }

            if (nuovaColonna < colonna && nuovaRiga > riga) {
                for (int i = colonna - 1; i >= nuovaColonna; i--) {
                    for (int j = riga + 1; j <= nuovaRiga; j++) {
                        if (scacchiera.getPedina(j, i) != null) {
                            throw new ArgumentException("Pedina nel mezzo");
                        }
                        Console.WriteLine(j.ToString() + " " + i.ToString());
                    }
                }
            }

            if (nuovaColonna < colonna && nuovaRiga < riga) {
                for (int i = colonna - 1; i >= nuovaColonna; i--) {
                    for (int j = riga - 1; j >= nuovaRiga; j--) {
                        if (scacchiera.getPedina(j, i) != null) {
                            throw new ArgumentException("Pedina nel mezzo");
                        }
                    }
                }
            }

            scacchiera.rimuoviPedina(riga, colonna);
            riga = nuovaRiga;
            colonna = nuovaColonna;
            scacchiera.posizionaPedina(riga, colonna, this);
        }
    }
}
