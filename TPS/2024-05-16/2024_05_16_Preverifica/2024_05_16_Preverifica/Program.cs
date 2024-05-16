using System.Collections.Concurrent;
using System.Runtime.CompilerServices;

int persone = 0;
ConcurrentQueue<string> coda = new ConcurrentQueue<string>();
Random r = new Random(); 
int positivi = 0, negativi = 0;
bool scritto = false;
bool finito = false;

Thread portante = new Thread(Inizia);
Console.Write(portante.Name);
portante.Start();


void Inizia() {
    Thread produttore1 = new Thread(Produci);
    Thread produttore2 = new Thread(Produci);
    Thread consumatore1 = new Thread(Consuma);
    Thread consumatore2 = new Thread(Consuma);
    consumatore1.Name = "1";
    consumatore2.Name = "2";
    produttore1.Start();
    produttore2.Start();
    consumatore1.Start(); 
    consumatore2.Start();
}

void Produci() {
    for (int i = 0; i < 250; i++) {
        Thread.Sleep(0);
        string persona = $"persona{++persone}";
        coda.Enqueue(persona);
        if (i == 99) {
            Thread.Sleep(3000);
        }
    }

    

}

void Consuma() {
    int cont = 0;
    while (cont < 250) {
        Thread.Sleep(0);
        if (coda.TryDequeue(out string persona)) {
            cont++;
            int numero = r.Next(1, 101);
            if (numero <= 90) {
                negativi++;
                Console.WriteLine($"{persona} - Negativo -> Idoneo");
            } else {
                positivi++;
                Console.WriteLine($"{persona} - Positivo -> Non idoneo");
            }
        }
    }

    Console.WriteLine($"totale negativi: {negativi} - totale positivi: {positivi}");
}