using System.Collections.Concurrent;

ConcurrentQueue<string> coda = new ConcurrentQueue<string>();
Random random = new Random();
int positivi = 0, negativi = 0, persone = 0;
bool finito1 = false, finito2 = false;
Thread portante = new Thread(Inizia);
portante.Start();


void Inizia() {
    Thread addetto1 = new Thread(Accoda);
    Thread addetto2 = new Thread(Accoda);
    Thread medico1 = new Thread(Test);
    Thread medico2 = new Thread(Test);
    addetto1.Start(finito1);
    addetto1.Name = "1";
    addetto2.Start(finito2);
    addetto2.Name = "2";
    medico1.Start();
    medico2.Start();
    medico1.Join();
    medico2.Join();
    Console.WriteLine($"partecipanti negativi: {negativi} - partecipanti positivi: {positivi}");
}

void Test() {
    while (!finito1 || !finito2 || coda.Count > 0) {
        if (coda.TryDequeue(out string persona)) {
            Thread.Sleep(100);
            string esito;
            if (random.Next(0, 101) < 90) {
                esito = "negativo";
                ++negativi;
            } else {
                esito = "positivo";
                ++positivi;
            }
            Console.WriteLine($"{persona} -> {esito}");
        } else {
            Thread.Sleep(500);
        }
    }
}

void Accoda(object flag) {
    for (int i = 0; i < 250; i++) {
        if (i % 100 == 0) {
            Thread.Sleep(3000);
        }
        else Thread.Sleep(50);

        string persona = $"persona{++persone}";
        coda.Enqueue(persona);
        Console.WriteLine(i);
    }
    if (Thread.CurrentThread.Name == "1") {
        finito1 = true;
    } else {
        finito2 = true;
    }
}