namespace _2023_10_25_1___FootballManager {
    public partial class Form1: Form {
        public Form1() {
            InitializeComponent();
        }

        List<Calciatore> calciatori = new List<Calciatore>();

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void aggiornaElenco() {
            listBox1.Items.Clear();
            foreach (Calciatore cal in calciatori) {
                listBox1.Items.Add(cal);
            }
            label1.Text = $"{calciatori.Count} giocatori in elenco";
        }

        private void allena_Click(object sender, EventArgs e) {
            if (listBox1.SelectedIndex == -1) {
                MessageBox.Show("Devi scegliere il calciatore che vuoi allenare", "Attenzione!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int tempo = (int)numericUpDown1.Value;

            Calciatore calciatore = (Calciatore)listBox1.SelectedItem;
            calciatore.allenati(tempo);
            aggiornaElenco();
        }



        private void label3_Click(object sender, EventArgs e) {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e) {

        }

        private void inserisci_Click(object sender, EventArgs e) {
            bool successo = true;
            Calciatore calciatore = null;
            try {
                calciatore = new Calciatore(textBox1.Text, textBox2.Text, (int)numericUpDown2.Value, DateOnly.Parse(monthCalendar1.SelectionRange.Start.ToShortDateString()));
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
                successo = false;
            }
            if (successo) {
                calciatori.Add(calciatore);
                aggiornaElenco();
            }
        }

        private void cancella_Click(object sender, EventArgs e) {
            if (!(listBox1.SelectedIndex == -1)) {
                calciatori.RemoveAt(listBox1.SelectedIndex);
                aggiornaElenco();
            }

        }
    }
}