namespace _2023_11_08_1___Sport {
    public partial class Form1 : Form {
        private List<Squadra> squadre;


        public Form1() {
            InitializeComponent();
            squadre = new List<Squadra>();
        }

        private void aggiornaElencoSquadre() {
            listBox1.Items.Clear();
            foreach (Squadra squadra in squadre) {
                listBox1.Items.Add(squadra);
            }
        }

        private void aggiornaElencoAtleti() {
            listBox2.Items.Clear();
            Squadra s = (Squadra)listBox1.SelectedItem;
            foreach (Atleta a in s.Membri) {
                listBox2.Items.Add(a);
            }
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void label2_Click(object sender, EventArgs e) {

        }

        private void RegistraSquadra_Click(object sender, EventArgs e) {
            try {
                Squadra squadra = new Squadra(textBox1.Text, comboBox1.SelectedItem.ToString(), dateTimePicker1.Value);
                foreach (Squadra s in squadre) {
                    if (s.Nome.ToUpper() == squadra.Nome.ToUpper()) {
                        throw new Exception("Squadra già presente.");
                    }
                    squadre.Add(squadra);
                    aggiornaElencoSquadre();
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void CancellaSquadra_Click(object sender, EventArgs e) {
            if (listBox1.SelectedIndex == -1) {
                MessageBox.Show("Seleziona la squadra da cancellare.");
            } else {
                DialogResult conferma = MessageBox.Show("Procedere con la cancellazione?", "Attenzione", MessageBoxButtons.YesNo);
                if (conferma == DialogResult.Yes) {
                    if (squadre.Remove((Squadra)listBox1.SelectedItem)) {
                        aggiornaElencoSquadre();
                        MessageBox.Show("Squadra cancellata correttamente.");
                    }
                }
            }
        }

        private void tabPage1_Click(object sender, EventArgs e) {

        }

        private void RegistraAtleta_Click(object sender, EventArgs e) {
            if (listBox1.SelectedIndex == -1) {
                MessageBox.Show("Devi scegliere una squadra in cui inserire l'atleta.");
            } else {
                Squadra squadra = (Squadra)listBox1.SelectedItem;
                try {
                    Atleta atleta = new Atleta(textBox2.Text, textBox3.Text, dateTimePicker2.Value, comboBox2.SelectedItem.ToString());
                    squadra.aggiungiMembro(atleta);
                    aggiornaElencoAtleti();
                } catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) {
            if (listBox1.SelectedIndex != -1) {
                aggiornaElencoAtleti();
            }
        }
    }
}