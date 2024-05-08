using System.Collections.Concurrent;
using System.Threading;

Thread t1, t2, t3;
ConcurrentQueue<int> coda = null;
Random rnd;
int cont = 0, n = 0;

t1 = new Thread(numCasuale);
t2 = new Thread(numCasuale);
t3 = new Thread(stampa);
coda = new ConcurrentQueue<int>();
t1.Start();
t2.Start();
t3.Start();


void numCasuale() {
    rnd = new Random();
    for (int i = 0; i < 250; i++) {
        coda.Enqueue(rnd.Next(0, 1000));
        Thread.Sleep(40);
    }
}

void stampa() {
    int tot = 0;
    while (cont < 500) {
        if (coda.TryDequeue(out n)) {
            cont++;
            tot += n;
            Console.WriteLine($"{tot / cont}");
        } else {
            Thread.Sleep(80);
        }
    }
}