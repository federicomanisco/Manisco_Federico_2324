namespace _2023_12_07 {
    public partial class Form1: Form {
        public Form1() {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {
            if (comboBox1.SelectedIndex == -1 || comboBox2.SelectedIndex == -1) {
                MessageBox.Show("Inserire un'unità di misura.");
            } else {
                if (comboBox1.SelectedIndex == 0) {
                    if (comboBox2.SelectedIndex == 0) {
                        numericUpDown2.Value = numericUpDown1.Value;
                    } else if (comboBox2.SelectedIndex == 1) {
                        numericUpDown2.Value = (decimal)ConvertitoreTemperature.CelsiusToFahreneit((float)numericUpDown1.Value);
                    } else {
                        numericUpDown2.Value = (decimal)ConvertitoreTemperature.CelsiusToKelvin((float)numericUpDown1.Value);
                    }
                } else if (comboBox1.SelectedIndex == 1) {
                    if (comboBox2.SelectedIndex == 0) {
                        numericUpDown2.Value = (decimal)ConvertitoreTemperature.FahreneitToCelsius((float)numericUpDown1.Value);
                    } else if (comboBox2.SelectedIndex == 1) {
                        numericUpDown2.Value = numericUpDown1.Value;
                    } else {
                        numericUpDown2.Value = (decimal)ConvertitoreTemperature.FahreneitToKelvin((float)numericUpDown1.Value);
                    }
                } else {
                    if (comboBox2.SelectedIndex == 0) {
                        numericUpDown2.Value = (decimal)ConvertitoreTemperature.KelvinToCelsius((float)numericUpDown1.Value);
                    } else if (comboBox2.SelectedIndex == 1) {
                        numericUpDown2.Value = (decimal)ConvertitoreTemperature.KelvinToFahreneit((float)numericUpDown1.Value);
                    } else {
                        numericUpDown2.Value = numericUpDown1.Value;
                    }
                }
            }
        }
    }
}