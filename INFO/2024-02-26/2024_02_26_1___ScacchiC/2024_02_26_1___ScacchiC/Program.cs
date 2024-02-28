// See https://aka.ms/new-console-template for more information
using ScacchiC;

Scacchiera scacchiera  = new Scacchiera();
Pedina pedone = new Pedone(Pedina.Colore.Black, 1, 2, scacchiera);
Pedina torre = new Torre(Pedina.Colore.White, 2, 3, scacchiera);
scacchiera.posizionaPedina(1, 2, pedone);
scacchiera.posizionaPedina(2, 3, torre);
pedone.muovi(2, 3);
scacchiera.visualizza();        
//regina.muovi(4,5);
//scacchiera.visualizza();

