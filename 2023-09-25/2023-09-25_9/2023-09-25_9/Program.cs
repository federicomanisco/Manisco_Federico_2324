int[] numeri = new int[19];

for (int i = 0; i < numeri.Length; i++) {
    if (i < numeri.Length / 3) numeri[i] = 101;
    else if (i >= numeri.Length / 3 && i < (numeri.Length * 2) / 3) numeri[i] = -1;
    else numeri[i] = 201;
    Console.WriteLine(numeri[i]);   
}
