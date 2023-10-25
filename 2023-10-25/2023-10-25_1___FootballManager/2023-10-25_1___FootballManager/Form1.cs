namespace _2023_10_25_1___FootballManager {
    public partial class Form1: Form {
        public Form1() {
            InitializeComponent();
        }

        List<Calciatore> calciatori = new List<Calciatore>();

        private void aggiornaElenco() {
            listBox1.Items.Clear();
            foreach (Calciatore cal in calciatori) {
                listBox1.Items.Add(cal);
            }
            label1.Text = $"{listBox1.Items.Count} giocatori in elenco";
        }


        private void calcolaEta_Click(object sender, EventArgs e) {
            listBox1.Items.Clear();
            foreach (Calciatore calciatore in calciatori) {
                int eta = calciatore.Eta;
                if (comboBox1.SelectedIndex == -1) {
                    MessageBox.Show("Devi scegliere una categoria");
                } else {
                    if (comboBox1.SelectedIndex != 0) {
                        if (eta <= 365 * (int)comboBox1.SelectedItem) {
                            listBox1.Items.Add(calciatore);
                        }
                    } else if (comboBox1.SelectedIndex == 0) {
                        aggiornaElenco();
                    }
                }
            }
            label1.Text = $"{listBox1.Items.Count} giocatori in elenco";
        }

        private void inserisci_Click_1(object sender, EventArgs e) {
            bool successo = true;
            Calciatore calciatore = null;
            try {
                calciatore = new Calciatore(textBox1.Text, textBox2.Text, (int)numericUpDown2.Value, DateOnly.Parse(monthCalendar1.SelectionRange.Start.ToShortDateString()));
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
                successo = false;
            }
            if (successo) {
                calciatori.Add(calciatore);
                aggiornaElenco();
            }
        }

        private void cancella_Click_1(object sender, EventArgs e) {
            if (!(listBox1.SelectedIndex == -1)) {
                calciatori.RemoveAt(listBox1.SelectedIndex);
                aggiornaElenco();
            }
        }

        private void allena_Click_1(object sender, EventArgs e) {
            if (listBox1.SelectedIndex == -1) {
                MessageBox.Show("Devi scegliere il calciatore che vuoi allenare", "Attenzione!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int tempo = (int)numericUpDown1.Value;

            Calciatore calciatore = (Calciatore)listBox1.SelectedItem;
            calciatore.allenati(tempo);
            aggiornaElenco();
        }
    }
}