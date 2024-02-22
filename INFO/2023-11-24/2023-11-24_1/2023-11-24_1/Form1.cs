namespace _2023_11_24_1 {
    public partial class Form1: Form {
        private Cassa cassa1, cassa2, cassa3;


        public Form1() {
            InitializeComponent();
            cassa1 = new Cassa();
            cassa2 = new Cassa();
            cassa3 = new Cassa();
        }

        private void aggiornaLabel() {
            if (cassa1.BigliettiRimanenti >= 0) {
                label1.Text = $"{(100 - cassa1.BigliettiRimanenti):D3}/100";
            }
            if (cassa2.BigliettiRimanenti >= 0) {
                label2.Text = $"{(100 - cassa2.BigliettiRimanenti):D3}/100";
            }
            if (cassa3.BigliettiRimanenti >= 0) {
                label3.Text = $"{(100 - cassa3.BigliettiRimanenti):D3}/100";
            }
            if (cassa1.BigliettiVenduti <= 250) {
                label4.Text = $"{cassa1.BigliettiVenduti:D3}/250"; 
            }
        }

        private void c1c1_Click(object sender, EventArgs e) {
            try {
                cassa1.VendiBiglietto();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            aggiornaLabel();
        }

        private void c1c2_Click(object sender, EventArgs e) {
            try {
                cassa2.VendiBiglietto();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            aggiornaLabel();
        }

        private void c1c3_Click(object sender, EventArgs e) {
            try {
                cassa3.VendiBiglietto();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            aggiornaLabel();
        }

        private void c5c1_Click(object sender, EventArgs e) {
            try {
                cassa1.VendiBiglietti(5);
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            aggiornaLabel();
        }

        private void c7c2_Click(object sender, EventArgs e) {
            try {
                cassa2.VendiBiglietti(7);
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            aggiornaLabel();
        }

        private void c3c3_Click(object sender, EventArgs e) {
            try {
                cassa3.VendiBiglietti(3);
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            aggiornaLabel();
        }
    }
}