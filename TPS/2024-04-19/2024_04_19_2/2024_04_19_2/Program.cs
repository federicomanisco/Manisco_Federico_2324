Thread.CurrentThread.Name = "MAIN";
Thread t1 = new Thread(Saluta);
t1.Name = "Thread1";
Thread t2 = new Thread(Saluta);
t2.Name = "Thread2";

t1.Start();
t2.Start();
Console.WriteLine($"{Thread.CurrentThread.Name}: Il mio id è: {Thread.CurrentThread.ManagedThreadId}");

void Saluta() {
    Console.WriteLine(Thread.CurrentThread.Name + ": Sono partito!");
    Console.WriteLine($"{Thread.CurrentThread.Name}: Il mio id è {Thread.CurrentThread.ManagedThreadId}");
    Console.WriteLine(Thread.CurrentThread.Name + ": Riposo per 100ms");
    Thread.Sleep(100);
    Console.WriteLine(Thread.CurrentThread.Name + ": Mi sono svegliato.");
}