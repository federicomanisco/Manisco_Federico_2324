string scelta;
char sesso;
int maschi = 0, femmine = 0;

do {
    Console.Write("Inserire il nome del gatto: ");
    Console.ReadLine();
    Console.Write("Inserisci il sesso del gatto (M o F): ");
    sesso = char.Parse(Console.ReadLine());
    switch (sesso) {
        case 'M': 
            maschi++;
            break;
        case 'F': 
            femmine++;
            break;
        default: 
            Console.WriteLine("Sesso inserito non valido.");
            break;
    }
    Console.Write("Inserire un altro gatto? ('no' per uscire) ");
    scelta = Console.ReadLine();
} while (scelta != "no" && scelta != "No");

Console.WriteLine($"Il numero di gatti maschi registrato è {maschi}, mentre il numero di femmine è {femmine}");