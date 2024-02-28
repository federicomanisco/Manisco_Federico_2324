float lato;

Console.Write("Inserisci il lato del cubo: ");
lato = float.Parse(Console.ReadLine());

Console.WriteLine($"Il volume del cubo è di {Math.Pow(lato, 3)}");