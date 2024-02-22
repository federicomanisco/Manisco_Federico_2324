float raggio;

Console.Write("Inserisci il raggio del cerchio: ");
raggio = float.Parse(Console.ReadLine());

Console.WriteLine($"La circonferenza del cerchio è di {raggio * 2 * Math.PI}.");
Console.WriteLine($"L'area del cerchio è di {raggio * raggio * Math.PI}.");