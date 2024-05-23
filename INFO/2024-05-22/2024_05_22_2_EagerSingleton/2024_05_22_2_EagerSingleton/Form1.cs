namespace _2024_05_22_2_EagerSingleton {
    public partial class Form1: Form {
        ServerCollectionManager servers = ServerCollectionManager.Instance;
        Random random;
        List<Thread> produttori;
        List<Thread> consumatori;
        delegate void delegato();
        delegate void delegato2(string server);
        bool ThreadAlive;
        int serverCount;
        public Form1() {
            InitializeComponent();
            random = new Random();
            serverCount = 0;
        }

        private void Avvia_Click(object sender, EventArgs e) {
            produttori = new List<Thread>();
            consumatori = new List<Thread>();
            Avvia.Enabled = false;
            Reset.Enabled = false;
            Thread portante = new Thread(Inizia);
            portante.Start();
        }

        private void Inizia() {
            delegato ButtonEnabler = new delegato(Enable);
            int numeroProduttori = (int)numericUpDown1.Value;
            int numeroConsumatori = (int)numericUpDown2.Value;
            for (int i = 0; i < numeroProduttori; i++) {
                Thread produttore = new Thread(Produci);
                produttore.Name = $"produttore{i + 1}";
                produttori.Add(produttore);
            }

            for (int i = 0; i < numeroConsumatori; i++) {
                Thread consumatore = new Thread(Consuma);
                consumatore.Name = $"consumatore{i + 1}";
                consumatori.Add(consumatore);
            }
            ThreadAlive = true;
            foreach (Thread produttore in produttori) {
                produttore.Start();
            }

            foreach (Thread consumatore in consumatori) {
                consumatore.Start();
            }

            foreach (Thread produttore in produttori) {
                produttore.Join();
            }

            foreach (Thread consumatore in consumatori) {

                consumatore.Join();
            }

            Invoke(ButtonEnabler);
        }

        private void Enable() {
            Reset.Enabled = true;
        }

        private void Consuma() {
            delegato2 ServerListManager = new delegato2(UpdateServerList);
            delegato2 LogManager = new delegato2(UpdateLogs);

            while (ThreadAlive || servers.Queue.Count > 0) {
                Thread.Sleep((int)numericUpDown4.Value);
                if (servers.Queue.TryDequeue(out string server)) {
                    Invoke(LogManager, $"{Thread.CurrentThread.Name} -> Now processing: {server}");
                    if (server.Contains("http://www.") || server.Contains("https://www.")) {
                        Invoke(ServerListManager, server);
                        Invoke(LogManager, $"{Thread.CurrentThread.Name} -> Accepted: {server}");
                        servers.Collection.Add(server);
                    } else {
                        Invoke(LogManager, $"{Thread.CurrentThread.Name} -> Rejected: {server}, Invalid server name.");
                    }
                }

                foreach (Thread thread in produttori) {
                    ThreadAlive = false;
                    if (thread.IsAlive) {
                        ThreadAlive = true;
                        break;
                    }
                }
            }
        }

        private void UpdateLogs(string message) {
            Log.Items.Add(message);
            Log.SelectedIndex = Log.Items.Count - 1;
            Log.SelectedIndex = -1;
        }
        private void UpdateServerList(string server) {
            ServerList.Items.Add(server);
            ServerList.SelectedIndex = ServerList.Items.Count - 1;
            ServerList.SelectedIndex = -1;
        }

        private void Produci() {
            delegato2 LogManager = new delegato2(UpdateLogs);
            for (int i = 0; i < (int)numericUpDown5.Value; i++) {
                Thread.Sleep((int)numericUpDown3.Value);
                int scelta = random.Next(1, 4);
                string server;
                if (scelta == 1) {
                    server = $"http://www.server{++serverCount}.{(random.Next(1, 3) == 1 ? "com" : "it")}";
                } else if (scelta == 2) {
                    server = $"https://www.server{++serverCount}.{(random.Next(1, 3) == 1 ? "com" : "it")}";
                } else {
                    server = $"server{++serverCount}.{(random.Next(1, 3) == 1 ? "com" : "it")}";
                }
                Invoke(LogManager, $"{Thread.CurrentThread.Name} -> Request sent for {server}");
                servers.Queue.Enqueue(server);
            }
            Invoke(LogManager, $"{Thread.CurrentThread.Name} -> Sono morto");
        }

        private void Reset_Click(object sender, EventArgs e) {
            servers.Collection.Clear();
            servers.Queue.Clear();
            Log.Items.Clear();
            ServerList.Items.Clear();
            Avvia.Enabled = true;
            serverCount = 0;
        }
    }
}
