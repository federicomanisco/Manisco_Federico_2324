int[] numeri = new int[10];
Random numero = new Random();

for (int i = 0; i < numeri.Length / 2; i++) {
    numeri[i] = numero.Next(0, 50);
}

for (int i = 0; i < numeri.Length / 2; i++) {
	for (int j = 0; j < numeri.Length / 2; j++) {
		if (numeri[i] < numeri[j]) {
			int temp = numeri[i];
			numeri[i] = numeri[j];
			numeri[j] = temp;
		}
	}
}

for (int i = numeri.Length / 2; i < numeri.Length; i++) {
    numeri[i] = numero.Next(100, 1000);
}

for (int i = numeri.Length / 2; i < numeri.Length; i++) {
    for (int j = numeri.Length / 2; j < numeri.Length; j++) {
        if (numeri[i] > numeri[j]) {
            int temp = numeri[i];
            numeri[i] = numeri[j];
            numeri[j] = temp;
        }
    }
}

for (int i = 0; i < numeri.Length; i++) {
	Console.WriteLine(numeri[i]);
}