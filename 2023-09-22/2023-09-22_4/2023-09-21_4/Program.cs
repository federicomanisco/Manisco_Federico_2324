const double BASILICO = 0.27, PINOLI = 0.115;
float grammi;

Console.Write("Inserisci i grammi di pesto da preparare: ");
grammi = float.Parse(Console.ReadLine());

Console.WriteLine($"Per preparare {grammi}g di pesto ti serviranno: {grammi * BASILICO}g di basilico fresco e {grammi * PINOLI}g di pinoli.");