namespace _2023_11_29_1___DistributoreGiochi
{
    public partial class Form1 : Form
    {
        List<Gioco> giochi;
        List<Linea> linee;
        public Form1()
        {
            InitializeComponent();
            giochi = new List<Gioco>();
            linee = new List<Linea>();
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void aggiornaElencoLinee() {
            listBoxLinee.Items.Clear();
            selezioneLineaCB.Items.Clear();
            foreach (Linea linea in linee) {
                listBoxLinee.Items.Add(linea);
                selezioneLineaCB.Items.Add(linea);
            }
        }

        private void aggiornaElencoGiochi() {
            listBoxGiochi.Items.Clear();
            foreach (Gioco gioco in giochi) {
                listBoxGiochi.Items.Add(gioco);
            }
        }

        private float calcolaPrezzoLinea(Linea linea) {
            float sum = 0;
            foreach (Gioco gioco in giochi) {
                if (gioco.Linea.IdLinea == linea.IdLinea) {
                    sum += gioco.Prezzo;
                }
            }
            return sum;
        }

        private float calcolaScontoTotaleLinea(Linea linea) {
            float sum = 0;
            foreach (Gioco gioco in giochi) {
                if (gioco.Linea.IdLinea == linea.IdLinea) {
                    sum += gioco.Prezzo * (1 - linea.PercentSconto);
                }
            }
            return sum;
        }

        private void aggiungiLinea_Click(object sender, EventArgs e) {
            Linea linea = null;
            bool successo = false;
            try {
                linea = new Linea(nomeLineaTB.Text, descrizioneLineaTB.Text, (float)(scontoLineaNUP.Value / 100));
                successo = true;
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }

            if (successo) {
                bool presente = false;
                foreach (Linea l in linee) {
                    if (l.NomeLinea == linea.NomeLinea) {
                        presente = true;
                        break;
                    }
                }
                if (!presente) {
                    linee.Add(linea);
                    aggiornaElencoLinee();
                }
            }
        }

        private void modificaScontoLinea_Click(object sender, EventArgs e) {
            if (listBoxLinee.SelectedIndex == -1) {
                MessageBox.Show("Selezionare la linea da modificare.");
            } else {
                linee[listBoxLinee.SelectedIndex].PercentSconto = (float)scontoLineaNUP.Value;
            }
        }

        private void listBoxLinee_SelectedIndexChanged(object sender, EventArgs e) {
            if (listBoxLinee.SelectedIndex != -1) {
                Linea linea = linee[listBoxLinee.SelectedIndex];
                nomeLineaTB.Text = linea.NomeLinea;
                descrizioneLineaTB.Text = linea.Descrizione;
                scontoLineaNUP.Value = (decimal)linea.PercentSconto;
                visualizzaPrezzoLineaLB.Text = $"Prezzo totale {linea.NomeLinea}: {calcolaPrezzoLinea(linea):2f}€";
                scontoTotaleLineaLB.Text = $"Sconto totale applicato su tutti i giochi di {linea.NomeLinea}: {calcolaScontoTotaleLinea(linea):2f}€";
            } else {
                visualizzaPrezzoLineaLB.Text = "";
            }
        }

        private void eliminaLinea_Click(object sender, EventArgs e) {
            if (listBoxLinee.SelectedIndex == -1) {
                MessageBox.Show("Selezionare la linea da eliminare.");
            } else {
                DialogResult dialogresult = MessageBox.Show("Eliminare la linea e tutti i giochi che le appartengono?", "ATTENZIONE", MessageBoxButtons.YesNo);
                if (dialogresult == DialogResult.Yes) {
                    Linea linea = linee[listBoxLinee.SelectedIndex];
                    foreach (Gioco gioco in giochi) {
                        if (gioco.Linea.IdLinea == linea.IdLinea) {
                            giochi.Remove(gioco);
                        }
                    }
                    linee.Remove(linea);
                    aggiornaElencoGiochi();
                    aggiornaElencoLinee();
                }
            }
        }

        private void aggiungiGioco_Click(object sender, EventArgs e) {
            Gioco gioco = null;
            bool successo = false;
            try {
                gioco = new Gioco(nomeGiocoTB.Text, descrizioneGiocoTB.Text, new Linea(linee[selezioneLineaCB.SelectedIndex]), (float)prezzoGiocoNUP.Value);
                successo = true;
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }

            if (successo) {
                giochi.Add(gioco);
                aggiornaElencoGiochi();
            }
        }

        private void modificaGioco_Click(object sender, EventArgs e) {
            if (listBoxGiochi.SelectedIndex == -1) {
                MessageBox.Show("Selezionare il gioco da modificare.");
            } else {
                try {
                    giochi[listBoxGiochi.SelectedIndex].NomeGioco = nomeGiocoTB.Text;
                    giochi[listBoxGiochi.SelectedIndex].Descrizione = descrizioneGiocoTB.Text;
                    giochi[listBoxGiochi.SelectedIndex].Prezzo = (float)prezzoGiocoNUP.Value;
                } catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }

                if (linee[selezioneLineaCB.SelectedIndex].IdLinea != giochi[listBoxGiochi.SelectedIndex].Linea.IdLinea) {
                    MessageBox.Show("Non è possibile modificare la linea del gioco");
                } 
            }
        }

        private void eliminaGioco_Click(object sender, EventArgs e) {
            if (listBoxGiochi.SelectedIndex == -1) {
                MessageBox.Show("Selezionare il gioco da eliminare.");
            } else {
                giochi.RemoveAt(listBoxGiochi.SelectedIndex);
                aggiornaElencoGiochi();
            }
        }

        private void eliminaGiochiLinea_Click(object sender, EventArgs e) {
            if (selezioneLineaCB.SelectedIndex == -1) {
                MessageBox.Show("Seleziona la linea di cui eliminare i giochi.");
            } else {
                Linea linea = linee[selezioneLineaCB.SelectedIndex];
                foreach (Gioco gioco in giochi) {
                    if (gioco.Linea.IdLinea == linea.IdLinea) {
                        giochi.Remove(gioco);
                    }
                }
                aggiornaElencoGiochi();
            }
        }

        private void listBoxGiochi_SelectedIndexChanged(object sender, EventArgs e) {
            if (listBoxGiochi.SelectedIndex != -1) {
                Gioco gioco = giochi[listBoxGiochi.SelectedIndex];
                nomeGiocoTB.Text = gioco.NomeGioco;
                descrizioneGiocoTB.Text = gioco.Descrizione;
                selezioneLineaCB.SelectedItem = gioco.Linea;
                prezzoGiocoNUP.Value = (decimal)gioco.Prezzo;
                prezzoScontatoGiocoLB.Text = $"Prezzo scontato {gioco.NomeGioco}: {(gioco.Prezzo * gioco.Linea.PercentSconto):2f}€";
            } else {
                prezzoScontatoGiocoLB.Text = "";
            }
        }
    }
}