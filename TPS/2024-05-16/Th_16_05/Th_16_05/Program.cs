using System.Collections.Concurrent;
using System.Security.Permissions;
using System.Text.Json.Serialization.Metadata;

internal class Program
{
    static ConcurrentQueue<string> coda = new ConcurrentQueue<string>();
    static int pos, neg;
    
    private static void Main(string[] args)
    {
        Thread p1 = new Thread(Produttore);
        Thread p2 = new Thread(Produttore);
        Thread c1 = new Thread(Consumatore);
        Thread c2 = new Thread(Consumatore);
        p1.Start();
        p2.Start();
        c1.Start();
        c2.Start();

        c1.Join();
        c2.Join();
        Console.WriteLine($"Negativi: {neg}  Positivi: {pos}");

    }

    private static void Produttore()
    {
        for (int i = 1; i < 251; i++)
        {
            string persona = "Persona"+i;
            coda.Enqueue(persona);
            Console.WriteLine(persona);
            if (i == 100) Thread.Sleep(3000);
            else Thread.Sleep(50);
        }
    }
    private static void Consumatore()
    {
        Thread.Sleep(1000);
        Random r = new Random();
        for (int i = 1; i < 251; i++)
        {
            if (coda.TryDequeue(out string persona))
            {
                string esito = "negativo";
                if (r.Next(1, 101) >= 90)
                {
                    esito = "positivo";
                    pos++;
                }
                else neg++;
                Console.WriteLine(persona + " " + esito);
            }
            Thread.Sleep(100);
        }
    }
}