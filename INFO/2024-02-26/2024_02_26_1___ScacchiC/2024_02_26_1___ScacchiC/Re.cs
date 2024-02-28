
namespace ScacchiC
{
    public class Re : Pedina
    {
        public Re(Colore colore, int riga, int colonna, Scacchiera scacchiera) : base(colore, riga, colonna, scacchiera)
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
            
            //non posso muovere oltre una casella (in tutte le direzioni)
            if (Math.Abs(nuovaRiga-riga) > 1 || Math.Abs(nuovaColonna-colonna) > 1) {
                throw new ArgumentException("Mossa non valida");
            }

            //TODO - manca arrocco

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
            return "♚";
        }
    } 
}
