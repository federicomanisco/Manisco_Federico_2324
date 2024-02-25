
namespace ScacchiC
{
    public class Alfiere : Pedina
    {
        public Alfiere(Colore colore, int riga, int colonna, Scacchiera scacchiera) : base(colore, riga, colonna, scacchiera)
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
            
            //non posso muovere in verticale o in orizzontale
            if (riga == nuovaRiga || colonna == nuovaColonna) {
                throw new ArgumentException("Non puoi muovere in orizzontale o verticale");
            }
            
            //devo muove in obliquo perfetto
            if (riga!=nuovaRiga && colonna!=nuovaColonna && Math.Abs(nuovaRiga-riga)!=Math.Abs(nuovaColonna-colonna)){
                throw new ArgumentException("Movimento non obliquo");
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
            return "♝";
        }
    }  
}
