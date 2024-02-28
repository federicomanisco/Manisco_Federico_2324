using Microsoft.VisualBasic;
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
        
        public bool pedinaNelMezzo(int r1, int c1, int r2, int c2){
            //cotrollo la validità dalle coppia di coordinate
            controllaCoordinate(r1,c1);
            controllaCoordinate(r2,c2);
            
            //controllo che le due coppie di coordinate non coincidano
            if (r1==r2 && c1==c2){
                throw new ArgumentException("posizione iniziale e finale coincidenti");    
            } 
            
            //se il controllo non è tra coppie di coordinate su stessa riga o stessa colonna allora deve essere perfettamente obliquo
            if (r1!=r2 && c1!=c2 && Math.Abs(r2-r1)!=Math.Abs(c2-c1)){
                  throw new ArgumentException("le posizioni non sono allineate in obliquo"); 
            }
            
            //controllo pedina nel mezzo
            int dirR = (r1==r2 ? 0 : (r2 > r1 ? 1 : -1));
            int dirC = (c1==c2 ? 0 : (c2 > c1 ? 1 : -1));
            int deltaR = Math.Abs(r2-r1);
            int deltaC = Math.Abs(c2-c1);
            int nPassi = Math.Max(deltaR, deltaC);
            for(int passo = 1; passo <= nPassi; passo++){
                int r = r1+(dirR*passo);
                int c = c1+(dirC*passo);
                if (scacchiera[r, c] != null) return true;
            }
            return false;                    
        } 

        public void visualizza()
        {
            Console.OutputEncoding = Encoding.UTF8;
            for (int r = 0 ; r < 8; r++) { 
                for (int c = 0 ; c < 8; c++)
                {
                    //colore di sfondo
                    if ((r+c)%2 == 0)
                    {
                        Console.BackgroundColor = ConsoleColor.Green;
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.DarkGreen;
                    }

                    if (scacchiera[r,c] == null)
                    {
                        Console.Write("  ");
                    }
                    else
                    {
                        Console.Write(scacchiera[r, c].stampa() + " ");
                    }
                    
                }
                Console.WriteLine("");
                Console.BackgroundColor = ConsoleColor.Black;
            }
        }
    }

}
