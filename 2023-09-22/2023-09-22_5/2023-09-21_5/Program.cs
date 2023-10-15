string scelta;
int eta, cont = 0, max = 0, min = int.MaxValue;
float somma = 0;
int[] etas = new int[1000];

do {
    Console.Write("Inserisci il nome del cane: ");
    Console.ReadLine();
    Console.Write("Inserisci l'età del cane: ");
    eta = int.Parse(Console.ReadLine());
    etas[cont] = eta;
    cont++;
    Console.Write("Vuoi inserire un altro cane? ('no' per uscire) ");
    scelta = Console.ReadLine();
} while (scelta != "no" && scelta != "No");

for (int i = 0; i < cont; i++) {
    if (etas[i] > max) {
        max = etas[i];
    }
}

for (int i = 0; i < cont; i++) {
    if (etas[i] < min) {
        min = etas[i];
    }
}

for (int i = 0; i < cont; i++) {
    somma += etas[i];
}

Console.WriteLine($"La media delle età dei cani registrati è {somma / cont}. L'età massima registrata è {max} e l'età minima è {min}.");