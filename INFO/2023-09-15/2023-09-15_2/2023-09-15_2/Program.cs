float Base, altezza;

Console.Write("Inserire la base del rettangolo: ");
Base = float.Parse(Console.ReadLine());
Console.Write("Inserire l'altezza del rettangolo: ");
altezza = float.Parse(Console.ReadLine());

Console.WriteLine("L'area del rettangolo è di " + Base * altezza + ".");
Console.WriteLine("Il perimetro del rettangolo è di " + ((Base * 2) + (altezza * 2)) + ".");