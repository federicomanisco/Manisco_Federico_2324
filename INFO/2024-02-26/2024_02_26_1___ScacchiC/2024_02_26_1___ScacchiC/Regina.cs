
namespace ScacchiC
{
    public class Regina : Pedina
    {
        public Regina(Colore colore, int riga, int colonna, Scacchiera scacchiera) : base(colore, riga, colonna, scacchiera)
        {

        }

        public override void mangia(int r, int c)
        {
            throw new NotImplementedException();
        }

        public override void trasforma(Pedina p)
        {
            throw new NotImplementedException();
        }

        public override void muovi(int nuovaRiga, int nuovaColonna)
        {
            base.muovi(nuovaRiga, nuovaColonna);
            
            int diffR = Math.Abs(nuovaRiga-riga);
            int diffC = Math.Abs(nuovaColonna-colonna);
            if (diffR !=0 && diffC != 0 && diffR != diffC) {
                throw new ArgumentException("Mossa non valida");
            }

            //non possono esserci pedine nel mezzo
            if (scacchiera.pedinaNelMezzo(riga, colonna, nuovaRiga, nuovaColonna)){
                    throw new ArgumentException("Pedina nel mezzo");
            };

            //non e piu la prima mossa
            primaMossa = false;

            //muovo
            scacchiera.rimuoviPedina(riga, colonna);
            riga = nuovaRiga;
            colonna = nuovaColonna;
            scacchiera.posizionaPedina(riga, colonna, this);

        }

        public override string stampa()
        {
            return "♛";
        }
    } 
}
