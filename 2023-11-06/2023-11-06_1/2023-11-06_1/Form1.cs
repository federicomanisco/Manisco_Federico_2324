using System.Diagnostics.Eventing.Reader;
using System.Runtime.InteropServices;

namespace _2023_11_06_1 {
    public partial class Form1: Form {

        List<Videogioco> videogiochi;
        bool ricerca = false;

        public Form1() {
            InitializeComponent();
            videogiochi = new List<Videogioco>();
        }

        void aggiornaElenco() {
            listBox1.Items.Clear();
            foreach (Videogioco videogioco in videogiochi) {
                listBox1.Items.Add(videogioco.ToString());
            }

            float max = 0, min = 2000, sum = 0, avg = 0;
            if (listBox1.Items.Count > 0) {
                for (int i = 0; i < videogiochi.Count; i++) {
                    if (videogiochi[i].Prezzo > max) {
                        max = videogiochi[i].Prezzo;
                    }
                    if (videogiochi[i].Prezzo < min) {
                        min = videogiochi[i].Prezzo;
                    }
                    sum += videogiochi[i].Prezzo;
                }
                avg = sum / videogiochi.Count;
            } else {
                min = 0;
            }
            label7.Text = max.ToString();
            label8.Text = min.ToString();
            label9.Text = avg.ToString();
        }

        void Ricerca() {
            listBox1.Items.Clear();
            foreach (Videogioco videogioco in videogiochi) {
                if (videogioco.Piattaforma == comboBox1.SelectedItem.ToString()) {
                    listBox1.Items.Add(videogioco.ToString());
                }
            }

            float max = 0, min = 2000, sum = 0, avg = 0;

            if (listBox1.Items.Count > 0) {
                for (int i = 0; i < videogiochi.Count; i++) {
                    if (videogiochi[i].Piattaforma == comboBox1.SelectedItem.ToString()) {
                        if (videogiochi[i].Prezzo > max) {
                            max = videogiochi[i].Prezzo;
                        }
                        if (videogiochi[i].Prezzo < min) {
                            min = videogiochi[i].Prezzo;
                        }
                        sum += videogiochi[i].Prezzo;
                    }
                    avg = sum / listBox1.Items.Count;

                } 
            } else {
                min = 0;
            }
            label7.Text = max.ToString();
            label8.Text = min.ToString();
            label9.Text = avg.ToString();
        }

        private void Inserisci_Click(object sender, EventArgs e) {
            bool successo = true;
            Videogioco videogioco = null;

            if (comboBox1.SelectedIndex != -1) {
                try {
                    videogioco = new Videogioco(textBox1.Text, (float)numericUpDown1.Value, new DateOnly(monthCalendar1.SelectionStart.Year, monthCalendar1.SelectionStart.Month, monthCalendar1.SelectionStart.Day), comboBox1.SelectedItem.ToString());
                } catch (Exception ex) {
                    successo = false;
                    MessageBox.Show(ex.Message);
                }
            } else {
                MessageBox.Show("Selezionare la piattaforma.");
            }

            if (successo) {
                videogiochi.Add(videogioco);
                aggiornaElenco();
                textBox1.Text = "";
                numericUpDown1.Value = (decimal)0.00;
                monthCalendar1.SelectionStart = DateTime.Now;
                monthCalendar1.SelectionEnd = DateTime.Now;
                comboBox1.SelectedIndex = 0;
            }
        }

        private void Cancella_Click(object sender, EventArgs e) {
            if (listBox1.SelectedIndex != -1) {
                videogiochi.RemoveAt(listBox1.SelectedIndex);
                aggiornaElenco();
            } else {
                MessageBox.Show("Selezionare l'elemento da eliminare.");
            }
        }

        private void Modifica_Click(object sender, EventArgs e) {
            if (listBox1.SelectedIndex != -1) {
                if (comboBox1.SelectedIndex == -1) {
                    MessageBox.Show("Seleziona una piattaforma.");
                } else {
                    try {
                        videogiochi[listBox1.SelectedIndex].Titolo = textBox1.Text;
                        videogiochi[listBox1.SelectedIndex].Prezzo = (float)numericUpDown1.Value;
                        videogiochi[listBox1.SelectedIndex].DataAcquisto = new DateOnly(monthCalendar1.SelectionStart.Year, monthCalendar1.SelectionStart.Month, monthCalendar1.SelectionStart.Day);
                        videogiochi[listBox1.SelectedIndex].Piattaforma = comboBox1.SelectedItem.ToString();
                        aggiornaElenco();
                    } catch (Exception ex) {
                        MessageBox.Show(ex.Message);
                    }
                }
            } else {
                MessageBox.Show("Selezionare l'elemento da modificare.");
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) {
            textBox1.Text = videogiochi[listBox1.SelectedIndex].Titolo;
            numericUpDown1.Value = (decimal)videogiochi[listBox1.SelectedIndex].Prezzo;
            monthCalendar1.SelectionStart = DateTime.Parse(videogiochi[listBox1.SelectedIndex].DataAcquisto.ToString());
            monthCalendar1.SelectionEnd = DateTime.Parse(videogiochi[listBox1.SelectedIndex].DataAcquisto.ToString());
            comboBox1.SelectedItem = videogiochi[listBox1.SelectedIndex].Piattaforma;
        }

        private void Copia_Click(object sender, EventArgs e) {
            if (listBox1.SelectedIndex != -1) {
                videogiochi.Add(new Videogioco(videogiochi[listBox1.SelectedIndex]));
                aggiornaElenco();
                listBox1.SelectedIndex = videogiochi.Count - 1;
            } else {
                MessageBox.Show("Seleziona l'elemento da copiare.");
            }
        }

        private void Cerca_Click(object sender, EventArgs e) {
            Inserisci.Enabled = false;
            Modifica.Enabled = false;
            Cancella.Enabled = false;
            Copia.Enabled = false;
            Svuota.Enabled = false;
            Ricerca();
        }

        private void Reset_Click(object sender, EventArgs e) {
            Inserisci.Enabled = true;
            Modifica.Enabled = true;
            Cancella.Enabled = true;
            Svuota.Enabled = true;
            Copia.Enabled = true;
            aggiornaElenco();
        }

        private void Svuota_Click(object sender, EventArgs e) {
            videogiochi.Clear();
            aggiornaElenco();
        }
    }
}