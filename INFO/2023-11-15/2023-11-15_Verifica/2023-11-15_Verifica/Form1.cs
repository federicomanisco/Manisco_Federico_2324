using System.Data;
using System.DirectoryServices.ActiveDirectory;

namespace _2023_11_15_Verifica {
    public partial class Form1 : Form {
        List<Articolo> articoli;
        List<string> ids;
        public Form1() {
            InitializeComponent();
            articoli = new List<Articolo>();
            ids = new List<string>();
        }

        private void aggiornaArticoli() {
            label11.Text = listBox1.Items.Count.ToString();
            int scontiApplicabili = 0;
            float sommaPrezzi = 0, maxSconto = float.MinValue;
            string id = "";
            foreach (Articolo articolo in listBox1.Items) {
                if (articolo.ScontoApplicabile() != 0) {
                    scontiApplicabili++;
                }
                sommaPrezzi += articolo.Prezzo;
                float sconto = articolo.ScontoApplicabile();
                if (sconto > maxSconto) {
                    maxSconto = sconto;
                    id = articolo.Id;
                }
            }
            float mediaPrezzi = sommaPrezzi / listBox1.Items.Count;
            label12.Text = scontiApplicabili.ToString();
            label13.Text = mediaPrezzi.ToString() + "€";
            label14.Text = $"{maxSconto}€ {id}";

        }

        private void aggiornaElenco() {
            listBox1.Items.Clear();
            foreach (Articolo articolo in articoli) {
                listBox1.Items.Add(articolo);
                ids.Add(articolo.Id);
            }
            aggiornaArticoli();
        }

        private void ricerca() {
            if (string.IsNullOrEmpty(textBox3.Text)) {
                aggiornaElenco();
                return;
            }
            List<int> indiciTrovati = new List<int>();
            listBox1.Items.Clear();
            int index = 0;
            foreach (Articolo articolo in articoli) {
                if (articolo.Id.ToLower().Contains(textBox3.Text.ToLower()) 
                    || articolo.Descrizione.ToLower().Contains(textBox3.Text.ToLower()) 
                    || articolo.Tipo.ToLower().Contains(textBox3.Text.ToLower()) 
                    || articolo.getDataToString().ToLower().Contains(textBox3.Text.ToLower()) 
                    || articolo.Prezzo.ToString().ToLower().Contains(textBox3.Text.ToLower())) {
                    if (!indiciTrovati.Contains(index)) {
                        listBox1.Items.Add(articolo);
                        indiciTrovati.Add(index);
                    }
                }
                index++;
            }
            aggiornaArticoli();
        }

        private void Inserisci_Click(object sender, EventArgs e) {
            Articolo articolo = null;
            bool successo = true;
            if (comboBox1.SelectedIndex == -1) comboBox1.SelectedIndex = 0;
            if (!ids.Contains(textBox1.Text.ToUpper())) {
                try {
                    articolo = new Articolo(textBox1.Text.ToUpper(), textBox2.Text, comboBox1.SelectedItem.ToString(), dateTimePicker1.Value, (float)numericUpDown1.Value);
                } catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                    successo = false;
                }

                if (successo) {
                    articoli.Add(articolo);
                    aggiornaElenco();
                }
            } else {
                MessageBox.Show("Gli ID devono essere univoci.");
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) {
            if (listBox1.SelectedIndex != -1) {
                textBox1.Text = articoli[listBox1.SelectedIndex].Id;
                textBox2.Text = articoli[listBox1.SelectedIndex].Descrizione;
                comboBox1.SelectedItem = articoli[listBox1.SelectedIndex].Tipo;
                dateTimePicker1.Value = articoli[listBox1.SelectedIndex].DataAcquisto;
                numericUpDown1.Value = (decimal)articoli[listBox1.SelectedIndex].Prezzo;
            } else {
                textBox1.Text = "";
                textBox2.Text = "";
                comboBox1.SelectedIndex = -1;
                dateTimePicker1.Value = DateTime.Now;
                numericUpDown1.Value = (decimal)0.00f;
            }
        }

        private void Modifica_Click(object sender, EventArgs e) {
            if (listBox1.SelectedIndex == -1) {
                MessageBox.Show("Seleziona l'elemento da modificare");
            } else {
                if (!ids.Contains(textBox1.Text)) {
                    MessageBox.Show("Non è possibile modificare l'ID dell'articolo");
                    textBox1.Text = articoli[listBox1.SelectedIndex].Id;
                    textBox1.Enabled = false;
                } else {
                    if (comboBox1.SelectedIndex == -1) comboBox1.SelectedIndex = 0; 
                    articoli[listBox1.SelectedIndex].Descrizione = textBox2.Text;
                    articoli[listBox1.SelectedIndex].Tipo = comboBox1.SelectedItem.ToString();
                    articoli[listBox1.SelectedIndex].DataAcquisto = dateTimePicker1.Value;
                    articoli[listBox1.SelectedIndex].Prezzo = (float)numericUpDown1.Value;
                    aggiornaElenco();
                }
            }
        }

        private void Rimuovi_Click(object sender, EventArgs e) {
            if (listBox1.SelectedIndex == -1) {
                MessageBox.Show("Seleziona l'articolo da rimuovere.");
            } else {
                articoli.RemoveAt(listBox1.SelectedIndex);
                aggiornaElenco();
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            textBox3.Text = "";
            aggiornaElenco();
            Inserisci.Enabled = true;
            Modifica.Enabled = true;
            Rimuovi.Enabled = true;
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            comboBox1.Enabled = true;
            dateTimePicker1.Enabled = true;
            numericUpDown1.Enabled = true;
        }

        private void textBox3_TextChanged(object sender, EventArgs e) {
            Inserisci.Enabled = false;
            Modifica.Enabled = false;
            Rimuovi.Enabled = false;
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            comboBox1.Enabled = false;
            dateTimePicker1.Enabled = false;
            numericUpDown1.Enabled = false;
            ricerca();
        }
    }
}