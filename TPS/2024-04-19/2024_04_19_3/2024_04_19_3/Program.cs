void Stampa() {
	for (int i = 0; i < 100; i++) {
		Random numero = new Random();
		Console.WriteLine($"{Thread.CurrentThread.Name} - {numero.Next(1, 100)}");
		Thread.Sleep(100);
	}
}

Thread t1 = new Thread(Stampa);
t1.Name = "Thread1";
Thread t2 = new Thread(Stampa);
t2.Name = "Thread2";
t1.Start();
t2.Start();

