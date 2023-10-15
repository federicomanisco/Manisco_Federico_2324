int voti1, voti2;
float totale;

Console.Write("Inserisci il voti del primo candidato: ");
voti1 = int.Parse(Console.ReadLine());
Console.Write("Inserisci il voti del secondo candidato: ");
voti2 = int.Parse(Console.ReadLine());

totale = voti1 + voti2;
Console.WriteLine($"Il primo candidato ha ottenuto il {(voti1 / totale) * 100}% dei voti. \nIl secondo candidato ha ottenuto il {(voti2 / totale) * 100}% dei voti.");