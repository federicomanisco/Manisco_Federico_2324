using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _2024_05_17_2 {
    internal class Program {
        static ConcurrentQueue<(string, int)> coda;
        static Random r;
        static int velocità;
        static bool finito;
        static int totaleMulte;
        static int totalePunti;
        static int multe;
        static void Main(string[] args) {
            coda = new ConcurrentQueue<(string, int)>();
            r = new Random();
            velocità = 0;
            totaleMulte = 0;
            totalePunti = 0;
            multe = 0;
            Thread portante = new Thread(Inizia);
            portante.Name = "Portante";
            portante.Start();
        }

        private static void Inizia() {
            Thread produttore = new Thread(Produci);
            produttore.Name = "Autovelox";
            Thread consumatore = new Thread(Consuma);
            consumatore.Name = "Multatore";
            produttore.Start();
            consumatore.Start();
            consumatore.Join();
            Console.WriteLine($"{Thread.CurrentThread.Name} -> Numero di multe: {multe} - Totale pagato: {totaleMulte}euro - Totale punti sottratti: {totalePunti}");
            Console.ReadKey();
        }

        private static void Consuma() {
            while (!finito || coda.Count != 0) {
                Thread.Sleep(30);
                if (coda.TryDequeue(out (string, int) veicolo)) {
                    int velocità = veicolo.Item2;
                    int multa = 0;
                    if (velocità - 70 >= 10 && velocità - 70 <= 40) {
                        multa = r.Next(173, 695);
                        multe++;
                        totaleMulte += multa;
                        totalePunti += 3;
                        Console.WriteLine($"{Thread.CurrentThread.Name} -> {veicolo.Item1} = multato: {multa} - tolti 3 punti dalla patente.");
                    } else if (velocità - 70 >= 41 && velocità - 70 <= 60) {
                        multa = r.Next(544, 2175);
                        multe++;
                        totaleMulte += multa;
                        totalePunti += 6;
                        Console.WriteLine($"{Thread.CurrentThread.Name} -> {veicolo.Item1} = multato: {multa} - tolti 6 punti dalla patente.");
                    } else if (velocità - 70 >= 61) {
                        multa = r.Next(2175, 3390);
                        multe++;
                        totaleMulte += multa;
                        totalePunti += 10;
                        Console.WriteLine($"{Thread.CurrentThread.Name} -> {veicolo.Item1} = multato: {multa} - tolti 10 punti dalla patente.");
                    } else {
                        Console.WriteLine($"{Thread.CurrentThread.Name} -> {veicolo.Item1} = regolare");
                    }
                }
            }
        }

        private static void Produci() {
            for (int i = 0; i < 200; i++) {
                if (i % 50 == 0) Thread.Sleep(100);
                else Thread.Sleep(50);
                int velocitàVeicolo = r.Next(40, 151);
                string info = $"veicolo{++velocità} - velocità: {velocitàVeicolo}";
                (string, int) veicolo = (info, velocitàVeicolo);
                coda.Enqueue(veicolo);
            }
            finito = true;
        }
    }
}
