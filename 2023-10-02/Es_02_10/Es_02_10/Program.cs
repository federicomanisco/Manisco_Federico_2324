int[] studenti = new int[30];
Random n = new Random();
string scelta;
int massimo = 0, minimo = 1000, modifica, nuova_età, cerca, cont = 0;
float somma = 0, media;

for (int i = 0; i < 30; i++) {
    studenti[i] = n.Next(13, 19);
}

do {
    Console.WriteLine("-------------------------");
    Console.WriteLine("1 - Visualizza studenti");
    Console.WriteLine("2 - Modifica studente");
    Console.WriteLine("3 - Ricerca età");
    Console.WriteLine("0 - Esci");
    Console.WriteLine("-------------------------");
    Console.WriteLine("Scegli cosa fare: ");
    scelta = Console.ReadLine();
    switch (scelta) {
        case "1":
            for (int i = 0; i < studenti.Length; i++) {
                if (studenti[i] > massimo) {
                    massimo = studenti[i];
                }
            }

            for (int i = 0; i < studenti.Length; i++) {
                if (studenti[i] < minimo) {
                    minimo = studenti[i];
                }
            }

            for (int i = 0; i < studenti.Length; i++) {
                somma += studenti[i];
            }
            media = somma / studenti.Length;

            for (int i = 0; i < studenti.Length; i++) {
                Console.WriteLine($"{i + 1} - {studenti[i]}");
            }
            Console.WriteLine($"Massimo: {massimo}");
            Console.WriteLine($"Minimo: {minimo}");
            Console.WriteLine($"Media: {media}");
            break;
        case "2":
            for (int i = 0; i < studenti.Length; i++) {
                Console.WriteLine($"{i + 1} - {studenti[i]}");
            }
            Console.WriteLine("Inserire la posizione dell'età da cambiare: ");
            modifica = int.Parse(Console.ReadLine());
            if (modifica > 0 && modifica <= studenti.Length) {
                Console.WriteLine("Inserisci la nuova età: ");
                nuova_età = int.Parse(Console.ReadLine());
                studenti[modifica - 1] = nuova_età;
            }
            else {
                Console.WriteLine("Valore inserito non valido.");
            }
            break;
        case "3":
            Console.WriteLine("Inserire l'età da ricercare");
            cerca = int.Parse(Console.ReadLine());
            for (int i = 0; i < studenti.Length; i++) {
                if (studenti[i] == cerca) {
                    cont++;
                }

            }
            Console.WriteLine($"Età trovata {cont} volte.");
            break;
        case "0":
            break;
        default:
            Console.WriteLine("Scelta non valida.");
            break;
    }
} while (scelta != "0");