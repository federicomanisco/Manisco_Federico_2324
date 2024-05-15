using System.Collections.Concurrent;

ConcurrentQueue<string> coda = new ConcurrentQueue<string>();
Random random = new Random();
int totale = 0;
bool finito = false;


Thread start = new Thread(Inizia);
start.Start();

void Inizia() {
    Thread produttore = new Thread(Produci);
    Thread consumatore = new Thread(Consuma);
    produttore.Start();
    consumatore.Start();
}

void Consuma() {
    while (!finito || coda.Count != 0) {
        if (coda.TryDequeue(out string veicolo)) {
            Thread.Sleep(100);
            int prezzo = random.Next(2, 71);
            totale += prezzo;
            Console.WriteLine($"Passato {veicolo} - pedaggio: {prezzo}");
        }
    }
    Console.WriteLine($"Totale pedaggio: {totale}");
}

void Produci() {
    int auto = 0;
    int camion = 0;
    if (coda.Count >= 20) {
        Thread.Sleep(500);
    } else {
        for (int i = 0; i < 150; i++) {
            Thread.Sleep(random.Next(50, 71));
            int n = random.Next(1, 101);
            string veicolo = "";
            if (n < 70) {
                veicolo = $"auto{++auto}";
            } else {
                veicolo = $"camion{++camion}";
            }
            coda.Enqueue(veicolo);
        }
        finito = true;
    }
}