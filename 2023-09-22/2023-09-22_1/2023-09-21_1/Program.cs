int num1, num2, num3;

Console.Write("Inserisci il primo numero: ");
num1 = int.Parse(Console.ReadLine());
Console.Write("Inserisci il secondo numero:");
num2 = int.Parse(Console.ReadLine());
Console.Write("Inserisci il terzo numero:");
num3 = int.Parse(Console.ReadLine());

float somma = num1 + num2 + num3;

float media = somma / 3;

Console.WriteLine($"La media è {media}");