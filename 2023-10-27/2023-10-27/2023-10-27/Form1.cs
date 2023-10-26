namespace _2023_10_27 {
    public partial class Form1: Form {
        public Form1() {
            InitializeComponent();
        }

        List<Libro> libri = new List<Libro>();

        void aggiornaElenco() {
            listBox1.Items.Clear();
            foreach (Libro libro in libri) {
                listBox1.Items.Add(libro);
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            Libro l = null;
            bool successo = true;
            bool raccolta = false;
            if (!(raccoltaFlag.SelectedIndex == -1)) {
                if (raccoltaFlag.SelectedItem == "Sì") {
                    raccolta = true;
                }
                else {
                    raccolta = false;
                }
            }
            try {
                l = new Libro(textBox1.Text, textBox2.Text, (int)numericUpDown1.Value, textBox3.Text, raccolta);
            }
            catch (Exception ex) {
                successo = false;
                MessageBox.Show(ex.Message);
            }

            if (successo) {
                libri.Add(l);
                aggiornaElenco();
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                numericUpDown1.Value = numericUpDown1.Minimum;
                raccoltaFlag.SelectedIndex = 1;
            }
        }

        private void modifica_Click(object sender, EventArgs e) {
            if (listBox1.SelectedIndex == -1) {
                MessageBox.Show("Selezionare il libro da modificare.");
            }
            else {
                try {
                    libri[listBox1.SelectedIndex].Genere = textBox3.Text;
                } catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
                bool raccolta = false;
                if (!(raccoltaFlag.SelectedIndex == -1)) {
                    if (raccoltaFlag.SelectedItem == "Sì") {
                        raccolta = true;
                    }
                    else {
                        raccolta = false;
                    }
                }
                libri[listBox1.SelectedIndex].Raccolta = raccolta;
                aggiornaElenco();
            }
        }

        private void cancella_Click(object sender, EventArgs e) {
            if (listBox1.SelectedIndex == -1) {
                MessageBox.Show("Selezionare il libro da cancellare.");
            }
            else {
                libri.RemoveAt(listBox1.SelectedIndex);
                aggiornaElenco();
            }
        }
    }
}