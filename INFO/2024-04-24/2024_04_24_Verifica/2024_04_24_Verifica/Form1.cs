using Newtonsoft.Json;

namespace _2024_04_24_Verifica {
    public partial class Form1 : Form {
        List<Domanda> quesiti;
        List<Domanda> variantiScelte;
        Risposta[] risposteDate;
        List<Salvataggio> salvataggi = new List<Salvataggio>();
        List<Salvataggio> tentativi;
        DateTime dataInizio;
        DateTime dataFine;
        int numeroDomanda = 0;
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            StreamReader sr = new StreamReader("quiz.json");
            string json = sr.ReadToEnd();
            sr.Close();
            try {
                quesiti = JsonConvert.DeserializeObject<List<Domanda>>(json);
            } catch {
                MessageBox.Show("Caricamento domande fallito.");
            }

            StreamReader sr2 = new StreamReader("tentativi.json");
            string json2 = sr2.ReadToEnd();
            sr2.Close();
            if (string.IsNullOrEmpty(json2)) return;
            try {
                salvataggi = JsonConvert.DeserializeObject<List<Salvataggio>>(json2, new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All});
            } catch {
            }
            foreach(Salvataggio salvataggio in salvataggi) {
                listBox1.Items.Add(salvataggio);
            }
        }

        private List<Domanda> FiltraDomandePerGruppo(List<Domanda> domande, int gruppo) {
            List<Domanda> toReturn = new List<Domanda>();
            foreach (Domanda domanda in quesiti) {
                if (domanda.Gruppo == gruppo) {
                    toReturn.Add(domanda);
                }
            }
            return toReturn;
        }

        private List<Domanda> Scegli5Domande(List<Domanda> domandeUtili) {
            Random random = new Random();
            List<Domanda> toReturn = new List<Domanda>();
            int max = int.MinValue;
            for (int i = 0; i < 5; i++) {
                int numero = random.Next(1, domandeUtili[domandeUtili.Count - 1].Numero + 1);
                if (numero > max) {
                    int domandaSorteggiata = numero;
                    foreach (Domanda domanda in domandeUtili) {
                        if (domanda.Numero == domandaSorteggiata) {
                            toReturn.Add(domanda);
                        }
                    }
                }
            }
            return toReturn;
        }

        private List<Domanda> ScegliVarianti(List<Domanda> domandeScelte) {
            int[] numeroMaxVarianti = new int[5];
            int variantiTrovate = 0;
            int numeroDomandaPrecendente = domandeScelte[0].Numero;
            while (variantiTrovate < 5) {
                foreach (Domanda domanda in domandeScelte) {
                    if (domanda.Numero == numeroDomandaPrecendente) {
                        numeroMaxVarianti[variantiTrovate] = domanda.Variante;
                        numeroDomandaPrecendente = domanda.Numero;
                    } else {
                        variantiTrovate++;
                    }
                }
            }

            List<Domanda> toReturn = new List<Domanda>();
            Random random = new Random();
            for (int i = 0; i < 5; i++) {
                int varianteScelta = random.Next(numeroMaxVarianti[i]);
                foreach (Domanda domanda in domandeScelte) {
                    if (domanda.Variante == varianteScelta) {
                        toReturn.Add(domanda);
                    }
                }
            }

            return toReturn;
        }

        private void MostraDomanda(int numero, List<Domanda> domande) {
            label2.Text = $"Domanda numero: {numero + 1}";
            pictureBox1.Image = Image.FromFile($"immagini/{domande[numero].Immagine}");
            textBox1.Text = domande[numero].Quesito;
        }

        private void MostraRispostaData(int numero, Risposta[] risposte) {
            if (risposte[numero] != null) {
                if (risposte[numero].RispostaData == 0) {
                    comboBox1.SelectedIndex = 0;
                } else {
                    comboBox1.SelectedIndex = 1;
                }
            }
        }

        private void Inizia_Click(object sender, EventArgs e) {
            dataInizio = DateTime.Now;
            List<Domanda> quesitiDaScegliere = new List<Domanda>();
            List<Domanda> quesitiScelti = new List<Domanda>();
            variantiScelte = new List<Domanda>();
            risposteDate = new Risposta[5];
            if (numericUpDown1.Value == 0) {
                MessageBox.Show("Scegliere il gruppo di domande.");
                return;
            }

            quesitiDaScegliere = FiltraDomandePerGruppo(quesiti, (int)numericUpDown1.Value);
            quesitiScelti = Scegli5Domande(quesitiDaScegliere);
            variantiScelte = ScegliVarianti(quesitiScelti);
            numeroDomanda = 0;
            MostraDomanda(numeroDomanda, variantiScelte);
            Inizia.Enabled = false;
            Inizia.Visible = false;
            Successiva.Enabled = true;
            Successiva.Visible = true;
            Precedente.Enabled = true;
            Precedente.Visible = true;
            comboBox1.Enabled = true;
            comboBox1.Visible = true;
            SalvaRisposta.Enabled = true;
            SalvaRisposta.Visible = true;
            ControllaRisposte.Enabled = true;
            ControllaRisposte.Visible = true;
        }

        private void Precedente_Click(object sender, EventArgs e) {
            comboBox1.SelectedIndex = -1;
            if (numeroDomanda == 0) {
                numeroDomanda = 4;
            } else {
                numeroDomanda--;
            }
            MostraDomanda(numeroDomanda, variantiScelte);
            MostraRispostaData(numeroDomanda, risposteDate);
        }

        private void Successiva_Click(object sender, EventArgs e) {
            comboBox1.SelectedIndex = -1;
            if (numeroDomanda == 4) {
                numeroDomanda = 0;
            } else {
                numeroDomanda++;
            }
            MostraDomanda(numeroDomanda, variantiScelte);
            MostraRispostaData(numeroDomanda, risposteDate);
        }

        private void SalvaRisposta_Click(object sender, EventArgs e) {
            if (comboBox1.SelectedIndex == -1) {
                MessageBox.Show("Selezionare una risposta.");
                return;
            }

            bool rispostaData;
            if (comboBox1.SelectedIndex == 0) {
                rispostaData = true;
            } else {
                rispostaData = false;
            }

            Risposta risposta = new Risposta(rispostaData, variantiScelte[numeroDomanda].Risposta);
            risposteDate[numeroDomanda] = risposta;
        }

        private void SalvaTentativoSuFile(int risposteGiuste, int risposteSbagliate) {
            StreamWriter sw = new StreamWriter("tentativi.json");
            (int, int)[] domande = new (int, int)[5];
            int counter = 0;
            foreach (Domanda domanda in variantiScelte) {
                domande[counter] = (domanda.Numero, domanda.Variante);
                counter++;
            }
            Salvataggio salvataggio = new Salvataggio(dataInizio, dataFine, variantiScelte[0].Gruppo, domande, (risposteGiuste, risposteSbagliate));
            salvataggi.Add(salvataggio);
            string json = JsonConvert.SerializeObject(salvataggi, Formatting.Indented, new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All });
            sw.Write(json);
            sw.Close();
        }

        private void ControllaRisposte_Click(object sender, EventArgs e) {
            dataFine = DateTime.Now;
            int risposteCorrette = 0;
            int risposteSbagliate = 0;
            int counter = 0;
            string risposteSbagliateText = $"Risposte sbagliate: ";
            foreach(Risposta risposta in risposteDate) {
                if (risposta == null) {
                    MessageBox.Show("Rispondi a tutte le domande.");
                    return;
                }

                if (risposta.RispostaData == risposta.RispostaCorretta) {
                    risposteCorrette++;
                } else {
                    risposteSbagliateText += $"{counter + 1},";
                    risposteSbagliate++;
                }
                counter++;
            }
            MessageBox.Show($"Risposte corrette: {risposteCorrette}/5 {risposteSbagliateText}");

            SalvaTentativoSuFile(risposteCorrette, risposteSbagliate);
            variantiScelte.Clear();
            risposteDate = new Risposta[5];
            Inizia.Enabled = true;
            Inizia.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e) {
            StreamWriter sw = new StreamWriter("tentativi.json");
            sw.Write("");
            sw.Close();
            MessageBox.Show("Eliminati tentativi precedenti.");
        }
    }
}