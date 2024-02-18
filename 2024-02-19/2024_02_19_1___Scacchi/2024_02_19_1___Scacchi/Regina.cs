using ScacchiC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_02_19_1___Scacchi {
    public class Regina : Pedina {
        public Regina(string colore, int riga, int colonna, Scacchiera scacchiera) : base(colore, riga, colonna, scacchiera) {

        }

        public override void mangia(int r, int c) {
            throw new NotImplementedException();
        }

        public override void trasforma(Pedina p) {
            throw new NotImplementedException();
        }

        public override string stampa() {
            return "r";
        }

        public override void muovi(int nuovaRiga, int nuovaColonna) {
            base.muovi(nuovaRiga, nuovaColonna);
            bool mossa_valida = (Math.Abs(nuovaColonna - colonna) == Math.Abs(nuovaRiga - riga) || (nuovaRiga == riga || nuovaColonna == colonna));

            if (!mossa_valida) {
                throw new ArgumentException("Mossa non valida");
            }

            if (nuovaColonna != colonna && nuovaRiga != riga) {
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
            } else {
                if (nuovaColonna != colonna) {
                    if (nuovaColonna > colonna) {
                        for (int i = colonna + 1; i <= nuovaColonna; i++) {
                            if (scacchiera.getPedina(riga, i) != null) {
                                throw new ArgumentException("Pedina nel mezzo");
                            }
                        }
                    }
                    if (nuovaColonna < colonna) {
                        for (int i = colonna - 1; i >= nuovaColonna; i--) {
                            if (scacchiera.getPedina(riga, i) != null) {
                                throw new ArgumentException("Pedina nel mezzo");
                            }
                        }
                    }
                }
                if (nuovaRiga != riga) {
                    if (nuovaRiga > riga) {
                        for (int i = riga + 1; i <= nuovaRiga; i++) {
                            if (scacchiera.getPedina(i, colonna) != null) {
                                throw new ArgumentException("Pedina nel mezzo");
                            }
                        }
                    }
                    if (nuovaRiga < riga) {
                        for (int i = riga - 1; i >= nuovaRiga; i--) {
                            if (scacchiera.getPedina(i, colonna) != null) {
                                throw new ArgumentException("Pedina nel mezzo");
                            }
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
