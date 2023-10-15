int[] etas = new int[30];
Random eta = new Random();
string scelta;
int max = int.MinValue, min = int.MaxValue, modificare, sostituire, ricercare, trovati = 0;
const int ETA_MIN = 14, ETA_MAX = 20;
float sum = 0, avg;

for (int i = 0; i < 30; i++) {
    etas[i] = eta.Next(ETA_MIN, ETA_MAX);
}

do {
    Console.WriteLine("-------------------------");
    Console.WriteLine("1 - Modifica età");
    Console.WriteLine("2 - Visualizza tutte le età");
    Console.WriteLine("3 - Ricerca un'età");
    Console.WriteLine("0 - Esci");
    Console.WriteLine("-------------------------");
    Console.WriteLine("Cosa vuoi fare? ");
    scelta = Console.ReadLine();
    switch (scelta) {
        case "1":
            for (int i = 0; i < etas.Length; i++) {
                Console.WriteLine($"{i + 1} - {etas[i]}");
            }
            Console.WriteLine("Inserire la posizione dell'età da cambiare: ");
            if (int.TryParse(Console.ReadLine(), out modificare)) { 
                if (modificare > 0 && modificare <= etas.Length) {
                    Console.WriteLine("Inserisci la nuova età: ");
                    if (int.TryParse(Console.ReadLine(), out sostituire)) {
                        if (sostituire >= ETA_MIN && sostituire <= ETA_MAX) {
                            etas[modificare - 1] = sostituire;
                        } else {
                            Console.WriteLine($"Età inserita non valida. (deve essere compresa tra {ETA_MIN} e {ETA_MAX}.");
                        }
                    } else {
                        Console.WriteLine("Valore inserito non valido.");
                    }
                }
            } else {
                Console.WriteLine("Valore inserito non valido.");
            }
            break;
        case "2":
            for (int i = 0; i < etas.Length; i++) {
                Console.WriteLine($"{i + 1} - {etas[i]}");
                if (etas[i] > max) max = etas[i];
                if (etas[i] < min) min = etas[i];
                sum += etas[i];
            }
            avg = sum / (etas.Length);
            Console.WriteLine($"L'età massima registrata è {max}\nL'età media registrata è {avg}\nL'età minima registrata è {min}");
            break;
        case "3":
            Console.WriteLine("Inserire l'età da ricercare");
            if (int.TryParse(Console.ReadLine(), out ricercare)) {
                if (ricercare >= ETA_MIN && ricercare <= ETA_MAX) {
                    for (int i = 0; i < etas.Length; i++) {
                        if (etas[i] == ricercare) trovati++;
                    }
                    Console.WriteLine($"L'età ricercata ({ricercare}) è presente {trovati} volte nell'elenco.");
                } else {
                    Console.WriteLine($"Età inserita non valida. (deve essere compresa tra {ETA_MIN} e {ETA_MAX}.");
                }
            } else {
                Console.WriteLine("Valore inserito non valido.");
            }
            break;
        case "0":
            break;
        default: 
            Console.WriteLine("Scelta non valida.");
            break;
    }
} while (scelta != "0");