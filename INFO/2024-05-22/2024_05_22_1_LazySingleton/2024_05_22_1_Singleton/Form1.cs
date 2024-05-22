namespace _2024_05_22_1_Singleton {
    //https://homeworks.java.en.sdacademy.pro/design_pattern_and_good_practices/exercises/#exercise-1-singleton
    public partial class Form1 : Form {
        ServersCollection servers;
        public Form1() {
            InitializeComponent();
            servers = ServersCollection.Instance;
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void aggiornaElenco() {
            listBox1.Items.Clear();
            textBox1.Text = string.Empty;
            foreach (string serverName in ServersCollection.Collection) {
                listBox1.Items.Add(serverName);
            }
            listBox1.SelectedIndex = -1;
        }

        private void aggiungi(string serverName) {
            if (servers.addServer(serverName)) {
                aggiornaElenco();
            } else {
                MessageBox.Show("Nome del server invalido, deve cominciare con 'http://www.' oppure con 'https://www.'. Nessun duplicato.");
            }
        }

        private void modifica(string serverName, int index) {
            if (servers.removeServerAt(index)) {
                if (servers.addServerAt(serverName, index)) {
                    aggiornaElenco();
                } else {
                    MessageBox.Show("Nome del server invalido, deve cominciare con 'http://www.' oppure con 'https://www.'. Nessun duplicato.");
                }
            } else {
                MessageBox.Show("Errore. Impossibile modificare il nome del server.");
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            string serverName = textBox1.Text;
            aggiungi(serverName);
        }

        private void rimuovi(string serverName) {
            if (servers.removeServer(serverName)) {
                aggiornaElenco();
            } else {
                MessageBox.Show("Errore. Impossibile rimuovere il server");
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) {
            if (listBox1.SelectedIndex == -1) {
                button2.Enabled = false;
                button3.Enabled = false;
            } else {
                button2.Enabled = true;
                button3.Enabled = true;
                textBox1.Text = listBox1.SelectedItem.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e) {
            int index = listBox1.SelectedIndex;
            string serverName = textBox1.Text;
            modifica(serverName, index);
        }

        private void button2_Click(object sender, EventArgs e) {
            string serverName = textBox1.Text;
            rimuovi(serverName);
        }
    }
}
