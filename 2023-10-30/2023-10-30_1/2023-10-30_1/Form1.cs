namespace _2023_10_30_1 {
    public partial class Form1: Form {
        public Form1() {
            InitializeComponent();
        }

        List<BranoMusicale> braniMusicali = new List<BranoMusicale>();

        private void textBox3_TextChanged(object sender, EventArgs e) {

        }

        public void aggiornaElenco() {
            listBox1.Items.Clear();
            foreach (BranoMusicale branoMusicale in braniMusicali) {
                listBox1.Items.Add(branoMusicale);
            }
            n_tracce.Text = listBox1.Items.Count.ToString();
        }

        private void inserisci_Click(object sender, EventArgs e) {
            bool isGhost;
            if (comboBox1.SelectedIndex != -1 && comboBox1.SelectedValue == "Sì") {
                isGhost = true;
            }
            else {
                isGhost = false;
            }
            BranoMusicale branoMusicale = null;
            bool successo = true;
            try {
                branoMusicale = new BranoMusicale(textBox1.Text, textBox2.Text, (int)numericUpDown1.Value, textBox3.Text, isGhost);
            }
            catch (Exception ex) {
                successo = false;
                MessageBox.Show(ex.Message);
            }
            if (successo) {
                braniMusicali.Add(branoMusicale);
                aggiornaElenco();
            }
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            numericUpDown1.Value = numericUpDown1.Minimum;
            textBox3.Text = string.Empty;
            comboBox1.SelectedIndex = 1;
        }

        private void Rimuovi_Click(object sender, EventArgs e) {
            if (listBox1.SelectedIndex == -1) {
                throw new Exception("Devi selezionare il brano da eliminare.");
            }
            else {
                braniMusicali.RemoveAt(listBox1.SelectedIndex);
                aggiornaElenco();
            }
        }

        private void modifica_Click(object sender, EventArgs e) {
            if (listBox1.SelectedIndex == -1) {
                throw new Exception("Devi selezionare il brano da modificare.");
            }
            else {
                bool isGhost;
                if (comboBox1.SelectedIndex != -1 && comboBox1.SelectedValue == "Sì") {
                    isGhost = true;
                }
                else {
                    isGhost = false;
                }
                bool successo = true;
                try {
                    braniMusicali[listBox1.SelectedIndex].Titolo = textBox1.Text;
                    braniMusicali[listBox1.SelectedIndex].Autore = textBox2.Text;
                    braniMusicali[listBox1.SelectedIndex].Durata = (int)numericUpDown1.Value;
                    braniMusicali[listBox1.SelectedIndex].TitoloAlbum = textBox3.Text;
                    braniMusicali[listBox1.SelectedIndex].IsGhost = isGhost;
                }
                catch (Exception ex) {
                    successo = false;
                    MessageBox.Show(ex.Message);
                }
                if (successo) {
                    aggiornaElenco();
                    textBox1.Text = string.Empty;
                    textBox2.Text = string.Empty;
                    numericUpDown1.Value = numericUpDown1.Minimum;
                    textBox3.Text = string.Empty;
                    comboBox1.SelectedIndex = 1;
                }
            }
        }

        private void copia_Click(object sender, EventArgs e) {
            if (listBox1.SelectedIndex != -1) {
                BranoMusicale branoMusicale = null;
                bool successo = true;
                try {
                    branoMusicale = new BranoMusicale(braniMusicali[listBox1.SelectedIndex]);
                }
                catch (Exception ex) {
                    successo = false;
                    MessageBox.Show(ex.Message);
                }
                if (successo) {
                    braniMusicali.Add(branoMusicale);
                    aggiornaElenco();
                }
            }
            else {
                MessageBox.Show("Selezionare il brano da copiare.");
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) {
            textBox1.Text = braniMusicali[listBox1.SelectedIndex].Titolo;
            textBox2.Text = braniMusicali[listBox1.SelectedIndex].Autore;
            numericUpDown1.Value = braniMusicali[listBox1.SelectedIndex].Durata;
            textBox3.Text = braniMusicali[listBox1.SelectedIndex].TitoloAlbum;
            comboBox1.SelectedIndex = braniMusicali[listBox1.SelectedIndex].IsGhost ? 0 : 1;
        }
    }
}