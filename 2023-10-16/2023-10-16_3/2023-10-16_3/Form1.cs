using System.Runtime.CompilerServices;

namespace _2023_10_16_3 {
    public partial class Form1: Form {
        public Form1() {
            InitializeComponent();
        }

        float[] numeri = new float[1000];
        int cont = 0;

        private float massimo(float[] numeri, int cont) {
            float max = float.MinValue;
            for (int i = 0; i < cont; i++) {
                if (numeri[i] > max) {
                    max = numeri[i];
                }
            }
            return max;
        }

        private float minimo(float[] numeri, int cont) {
            float min = float.MaxValue;
            for (int i = 0; i < cont; i++) {
                if (numeri[i] < min) {
                    min = numeri[i];
                }
            }
            return min;
        }

        private void visualizza(float[] numeri, int cont) {
            listBox1.Items.Clear();
            for (int i = 0; i < cont; i++) {
                listBox1.Items.Add(numeri[i]);
            }
        }

        private void Aggiungi_Click(object sender, EventArgs e) {
            float numero;
            if (float.TryParse(textBox1.Text.Replace(".", ","), out numero)) {
                numeri[cont] = numero;
                cont++;
                Minimo.Text = minimo(numeri, cont).ToString();
                Massimo.Text = massimo(numeri, cont).ToString();
                visualizza(numeri, cont);
            }
            else {
                MessageBox.Show("Numero inserito non valido.");
            }
        }

        private void incrementa(float[] numeri, float addendo, int cont) {
            for (int i = 0; i < cont; i++) {
                numeri[i] += addendo;
            }
        }

        private void Esegui_Click(object sender, EventArgs e) {
            float addendo;
            if (float.TryParse(textBox3.Text.Replace(".", ","), out addendo)) {
                incrementa(numeri, addendo, cont);
                Minimo.Text = minimo(numeri, cont).ToString();
                Massimo.Text = massimo(numeri, cont).ToString();
                visualizza(numeri, cont);
            }
        }

        private int cerca(float[] numeri, float ricercato, int cont) {
            int occorrenze = 0;
            for (int i = 0; i < cont; i++) {
                if (numeri[i] == ricercato) {
                    occorrenze++;
                }
            }
            return occorrenze;
        }

        private void textBox2_TextChanged(object sender, EventArgs e) {
            float ricercato;
            if (float.TryParse(textBox2.Text.Replace(".", ","), out ricercato)) {
                Occorrenze.Text = cerca(numeri, ricercato, cont).ToString();
            }
        }
    }
}