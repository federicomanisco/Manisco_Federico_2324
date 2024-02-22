using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ScacchiC
{
    public class Scacchiera
    {
        private Pedina[,] scacchiera;

        public Scacchiera()
        {
            scacchiera = new Pedina[8, 8];
        }

        public void posizionaPedina(int r, int c, Pedina p)
        {
            controllaCoordinate(r, c);
            scacchiera[r, c] = p;
        }

        public void rimuoviPedina(int r, int c)
        {
            controllaCoordinate(r, c);
            scacchiera[r, c] = null;
        }
        public Pedina getPedina(int r, int c)
        {
            controllaCoordinate(r, c);
            return scacchiera[r, c];
        }

        private void controllaCoordinate(int r, int c)
        {
            if (r < 0 || r > 7)
            {
                throw new ArgumentException("riga non valida");
            }
            if (c < 0 || c > 7)
            {
                throw new ArgumentException("colonna non valida");
            }
        }

        public void visualizza()
        {
            for (int r = 0 ; r < 8; r++) { 
                for (int c = 0 ; c < 8; c++)
                {
                    if (scacchiera[r,c] == null)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(scacchiera[r, c].stampa());
                    }
                    
                }
                Console.WriteLine("\n");
            }
        }
    }
}
