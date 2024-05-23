using System.Collections.Concurrent;

ConcurrentQueue<string> coda = new ConcurrentQueue<string>();
Random r = new Random();
int persone = 0, positivi = 0, negativi = 0;
Thread produttore1 = new Thread(Produci);
Thread produttore2 = new Thread(Produci);
Thread consumatore1 = new Thread(Consuma);
Thread consumatore2 = new Thread(Consuma);

produttore1.Start();
Thread.Sleep(10);
produttore2.Start();
Thread.Sleep(10);
consumatore1.Start();
Thread.Sleep(10);
consumatore2.Start();
Thread.Sleep(10);
consumatore2.Join();
Console.WriteLine($"totale positivi: {positivi} - totale negativi: {negativi}");


void Consuma() {
    int cont = 0;
    while (true) {
        Thread.Sleep(100);
        if (coda.TryDequeue(out string persona)) {
            cont++;
            string esito = "negativo";
            if (r.Next(1, 101) >= 90) {
                esito = "positivo";
                positivi++;
            } else {
                negativi++;
            }
            Console.WriteLine($"{persona} -> {esito}");
        }

        if (cont == 249) {
            break;
        }
    }
}

void Produci() {
    for (int i = 0; i < 250; i++) {
        Thread.Sleep(50);
        if (i == 99) {
            Thread.Sleep(3000);
        }

        string persona = $"persona{++persone}";
        coda.Enqueue(persona);
    }
}
