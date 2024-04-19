void stampaAst() {
    for (int i = 0; i < 1000; i++) {
        if (i % 2 == 0) {
            Console.WriteLine($"{i}");
        }
    }
}

void stampaCanc() {
    for (int i = 0; i < 1000; i++ ) {
        if (i % 2 != 0)
            Console.WriteLine($"{i}");
    }
}

Thread asterisco = new Thread(stampaAst);
Thread cancelletto = new Thread(stampaCanc);
asterisco.Start();
cancelletto.Start();