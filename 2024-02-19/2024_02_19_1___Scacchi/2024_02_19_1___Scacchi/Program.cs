// See https://aka.ms/new-console-template for more information
using _2024_02_19_1___Scacchi;
using ScacchiC;

Scacchiera scacchiera  = new Scacchiera();
Regina regina = new Regina("NERO", 0, 0, scacchiera);
Torre torre = new Torre("NERO", 5, 5, scacchiera);
Re re = new Re("NERO", 2, 2, scacchiera);
scacchiera.posizionaPedina(2, 2, re);
scacchiera.posizionaPedina(0, 0, regina);
scacchiera.posizionaPedina(5, 5, torre);
re.muovi(2, 1);
scacchiera.visualizza();


/*
 * 2,1
 * 4,1
 * 1,2
 * 5,2
 * 1,4
 * 5,4
 * 2,5
 * 4,5
*/
