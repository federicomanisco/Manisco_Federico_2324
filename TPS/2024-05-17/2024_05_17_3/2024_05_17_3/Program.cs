using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.PerformanceData;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _2024_05_17_3 {
    internal class Program {
        static ConcurrentQueue<(char[], int)> quiz;
        static Random r;
        static bool finito;
        static int giusti;
        static int sbagliati;
        static void Main(string[] args) {
            quiz = new ConcurrentQueue<(char[], int)>();
            r = new Random();
            finito = false;
            giusti = 0;
            sbagliati = 0;
            Thread portante = new Thread(Inizia);
            portante.Name = "Portante";
            portante.Start();
        }

        private static void Inizia() {
            Thread produttore = new Thread(Produci);
            Thread consumatore1 = new Thread(Consuma);
            Thread consumatore2 = new Thread(Consuma);
            produttore.Name = "Risposte Candidati";
            consumatore1.Name = "Commissario 1";
            consumatore2.Name = "Commissario 2";
            produttore.Start();
            consumatore1.Start();
            consumatore2.Start();
            consumatore1.Join();
            consumatore2.Join();
            Console.WriteLine($"{Thread.CurrentThread.Name} -> Candidati promossi: {giusti} - Candidati bocciati: {sbagliati}");
            Console.ReadKey();
        }

        private static void Consuma() {
            while (!finito || quiz.Count != 0) {
                Thread.Sleep(r.Next(40, 71));
                if (quiz.TryDequeue(out (char[], int) risposte)) {
                    int vere = 0;
                    foreach(char c in risposte.Item1) {
                        if (c == 't') {
                            vere++;
                        }
                    }
                    if (vere >= 2) {
                        giusti++;
                        Console.WriteLine($"{Thread.CurrentThread.Name} -> candidato{risposte.Item2}: Promosso");
                    } else {
                        sbagliati++;
                        Console.WriteLine($"{Thread.CurrentThread.Name} -> candidato{risposte.Item2}: Bocciato");
                    }
                }
            }   
        }

        private static void Produci() {
            for (int i = 0; i < 60; i++) {
                Thread.Sleep(20);
                char[] risposte = new char[3];
                for (int j = 0; j < 3; j++) {
                    char risposta = (r.Next(0, 101) >= 50) ? 't' : 'f';
                    risposte[j] = risposta;
                }
                (char[], int) candidato = (risposte, i);
                quiz.Enqueue(candidato);
                Console.WriteLine($"{Thread.CurrentThread.Name} -> Consegnato quiz candidato{candidato.Item2}");
            }
            finito = true;
        }
    }
}
