using System;
using System.Collections.Concurrent;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _2024_05_17_1 {
    internal class Program {
        static ConcurrentQueue<(string, int)> coda;
        static Random r;
        static int persone;
        static bool finito;
        static int totale, interi, ridotti;
        static void Main(string[] args) {
            coda = new ConcurrentQueue<(string, int)>();
            r = new Random();
            persone = 0;
            finito = false;
            totale = 0;
            interi = 0;
            ridotti = 0;
            Thread portante = new Thread(Inizia);
            portante.Name = "Portante";
            portante.Start();
        }

        private static void Inizia() {
            Thread produttore = new Thread(Produci);
            Thread consumatore1 = new Thread(Consuma);
            Thread consumatore2 = new Thread(Consuma);
            produttore.Name = "Produttore";
            consumatore1.Name = "Cassa1";
            consumatore2.Name = "Cassa2";
            produttore.Start();
            consumatore1.Start();
            consumatore2.Start();
            produttore.Join();
            consumatore1.Join();
            consumatore2.Join();
            Console.WriteLine($"{Thread.CurrentThread.Name} -> Totale: {totale}euro - Interi: {interi} = {interi * 40}euro - Ridotti: {ridotti} = {ridotti * 30}euro");
            Console.ReadKey();
        }

        private static void Consuma() {
            int cont = 0;
            while (!finito || coda.Count != 0) {
                if (cont % 100 == 0) Thread.Sleep(150);
                else Thread.Sleep(r.Next(30, 41));
                if (coda.TryDequeue(out (string, int) persona)) {
                    cont++;
                    int vecchioTotale = totale;
                    if (persona.Item2 >= 14 && persona.Item2 <= 32) {
                        interi++;
                        totale += 40;
                    } else {
                        ridotti++;
                        totale += 30;
                    }
                    Console.WriteLine($"{Thread.CurrentThread.Name} -> Uscita {persona.Item1} -> prezzo: {totale - vecchioTotale}");
                }
            }
        }

        private static void Produci() {
            for (int i = 0; i < 300; i++) {
                Thread.Sleep(50);
                int età = r.Next(2, 71);
                (string, int) persona = ($"persona{++persone} - età: {età}", età);
                coda.Enqueue(persona);
                Console.WriteLine($"{Thread.CurrentThread.Name} -> Entrata {persona.Item1}");
            }
            finito = true;
        }
    }
}
