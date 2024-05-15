using Newtonsoft.Json;
using System.Drawing.Text;
using System.Xml.Serialization;

namespace _2024_05_15_VerificaRecupero {
    public partial class Form1 : Form {
        private List<Aforismo> aforismi;
        List<Aforismo> aforismiOrdinati;

        public Form1() {
            InitializeComponent();
            aforismi = new List<Aforismo>();
            aforismiOrdinati = new List<Aforismo>();
        }

        private void Form1_Load(object sender, EventArgs e) {
            caricaArchivio();
            RiempiComboBoxNazionalit‡();
        }

        private void caricaArchivio() {
            StreamReader sr = new StreamReader("aforismi.json");
            string json = sr.ReadToEnd();
            sr.Close();
            aforismi = JsonConvert.DeserializeObject<List<Aforismo>>(json);
        }

        private void RiempiComboBoxNazionalit‡() {
            if (aforismi.Count > 0) {
                List<string> nazionalit‡Trovate = new List<string>();
                foreach (Aforismo aforismo in aforismi) {
                    if (!nazionalit‡Trovate.Contains(aforismo.Nazionalit‡)) {
                        nazionalit‡Trovate.Add(aforismo.Nazionalit‡);
                    }
                }
                nazionalit‡Trovate.Sort();
                foreach(string nazionalit‡ in nazionalit‡Trovate) {
                    comboBox1.Items.Add(nazionalit‡);
                }
                comboBox1.SelectedIndex = 0;
            }
        }

        private void AggiornaListBoxAforismi(List<Aforismo> a) {
            listBox1.Items.Clear();
            foreach (Aforismo aforismo in a) {
                listBox1.Items.Add(aforismo);
            }

            if (checkBox1.Checked) {
                foreach(Aforismo aforismo in a) {
                    if (!aforismo.Divertente) {
                        listBox1.Items.Remove(aforismo);
                    }
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {
            if (comboBox1.SelectedIndex == -1) return;
            aforismiOrdinati.Clear();
            foreach (Aforismo aforismo in aforismi) {
                if (aforismo.Nazionalit‡ == comboBox1.SelectedItem.ToString()) {
                    aforismiOrdinati.Add(aforismo);
                }
            }
            aforismiOrdinati.Sort();
            AggiornaListBoxAforismi(aforismiOrdinati);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e) {
            AggiornaListBoxAforismi(aforismiOrdinati);
        }

        private void SalvaDatiSuFile(List<Aforismo> dati) {
            StreamWriter sw = new StreamWriter("salvataggio.json");
            string json = JsonConvert.SerializeObject(dati, Formatting.Indented);
            sw.Write(dati);
            sw.Close();
            sw = new StreamWriter("salvataggio.txt");
            string testo = "";
            foreach (Aforismo aforismo in dati) {
                testo += aforismo.Aforisma + "\n";
            }
            sw.Write(testo);
            sw.Close();
        }

        private List<Aforismo> TrovaAforismiDuplicati(List<Aforismo> dati) {
            List<Aforismo> duplicati = new List<Aforismo>();
            List<Aforismo> parallela = new List<Aforismo>();
            foreach(Aforismo aforismo in dati) {
                if (!parallela.Contains(aforismo)) {
                    parallela.Add(aforismo);
                } else {
                    duplicati.Add(aforismo);
                }
            }
            return duplicati;
        }

        private void EliminaDuplicati(List<Aforismo> dati, List<Aforismo> duplicati) {
            foreach(Aforismo aforismo in duplicati) {
                dati.Remove(aforismo);
            }
        }

        private void SalvaFrasi_Click(object sender, EventArgs e) {
            List<Aforismo> aforismiAttuali = new List<Aforismo>();
            foreach(Aforismo aforismo in aforismiOrdinati) {
                aforismiAttuali.Add(aforismo);
            }
            List<Aforismo> duplicati = TrovaAforismiDuplicati(aforismiAttuali);
            if (duplicati.Count > 0) {
                DialogResult risposta = MessageBox.Show("Individuati duplicati, eliminarli?", "", MessageBoxButtons.YesNo);
                if (risposta == DialogResult.Yes) {
                    EliminaDuplicati(aforismiAttuali, duplicati);
                }
            }
            SalvaDatiSuFile(aforismiAttuali);
            MessageBox.Show("Aforismi attuali salvati in 'salvataggio.txt'");
        }

        private void TrovaDuplicati_Click(object sender, EventArgs e) {
            List<Aforismo> duplicati = TrovaAforismiDuplicati(aforismiOrdinati);
            
            AggiornaListBoxAforismi(duplicati);
        }

        private void Esci_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e) {
            DoDragDrop(this, DragDropEffects.Move);
        }

        private void Reset_Click(object sender, EventArgs e) {
            comboBox1_SelectedIndexChanged(sender, e);
        }
    }
}