namespace _2023_10_16_1 {
    public partial class Form1: Form {
        public Form1() {
            InitializeComponent();
        }

        List<string> numeri = new List<string>();
        bool numero_valido = true;

        private void visualizza() {
            ListaNumeri.Items.Clear();
            foreach (string str in numeri) {
                ListaNumeri.Items.Add(str);
            }
        }

        private void Inserisci_Click(object sender, EventArgs e) {
            if (NumeroTel.Text.Length == 10) {
                numero_valido = true;
                for (int i = 0; i < 10; i++) {
                    if (!char.IsNumber(NumeroTel.Text[i])) {
                        numero_valido = false;
                    }
                }
                if (numero_valido) {
                    if (!numeri.Contains(NumeroTel.Text)) {
                        numeri.Add(NumeroTel.Text);
                        visualizza();
                    }
                    else {
                        MessageBox.Show("Numero già presente");
                    }
                }
                else {
                    MessageBox.Show("Numero non valido");
                }
            }
            else {
                MessageBox.Show("Numero non valido");
            }
        }

        private void Cancella_Click(object sender, EventArgs e) {
            if (numeri.Contains(NumeroTel.Text)) {
                numeri.Remove(NumeroTel.Text);
                visualizza();
            }
        }
    }
}