using System.DirectoryServices.ActiveDirectory;

namespace Verifica_Manisco_21_02_2024 {
    public partial class Form1 : Form {
        private List<PiantaEndemica> pianteEndemiche;

        public Form1() {
            InitializeComponent();
            pianteEndemiche = new List<PiantaEndemica>();
        }

        private void comboBoxSpecie_SelectedIndexChanged(object sender, EventArgs e) {
            if (comboBoxSpecie.SelectedIndex != -1) {
                if (comboBoxSpecie.SelectedIndex == 0) {
                    comboBoxColoreFrutti.Enabled = true;
                    comboBoxColoreFiori.Enabled = false;
                    comboBoxColoreFiori.SelectedIndex = -1;
                } else if (comboBoxSpecie.SelectedIndex == 1) {
                    comboBoxColoreFiori.Enabled = true;
                    comboBoxColoreFrutti.Enabled = false;
                    comboBoxColoreFrutti.SelectedIndex = -1;
                }
            } else {
                comboBoxColoreFiori.Enabled = false;
                comboBoxColoreFrutti.Enabled = false;
            }
        }

        void aggiornaElenco() {
            listBox1.Items.Clear();
            foreach (PiantaEndemica piantaEndemica in pianteEndemiche) {
                listBox1.Items.Add(piantaEndemica);
            }
        }

        string controllaMese(int mese) {
            switch (mese) {
                case 1:
                    return "Gennaio";
                    break;
                case 2:
                    return "Febbraio";
                    break;
                case 3:
                    return "Marzo";
                    break;
                case 4:
                    return "Aprile";
                    break;
                case 5:
                    return "Maggio";
                    break;
                case 6:
                    return "Giugno";
                    break;
                case 7:
                    return "Luglio";
                    break;
                case 8:
                    return "Agosto";
                    break;
                case 9:
                    return "Settembre";
                    break;
                case 10:
                    return "Ottobre";
                    break;
                case 11:
                    return "Novembre";
                    break;
                case 12:
                    return "Dicembre";
                    break;
                default:
                    return "Invalido";
                    break;
            }
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e) {
            PiantaEndemica piantaEndemica = new PalmaNana("00000000", PiantaEndemica.StatoConservazione.Estinto, PalmaNana.ColoreFrutti.Verde);
            piantaEndemica.PeriodoAnno = monthCalendar1.SelectionEnd;
            labelMese.Text = controllaMese(piantaEndemica.PeriodoAnno.Month);
        }

        private void AggiungiPianta_Click(object sender, EventArgs e) {
            bool successo = true;
            if (comboBoxSpecie.SelectedIndex != -1) {
                if (comboBoxStatoConservazione.SelectedIndex != -1) {
                    PiantaEndemica piantaEndemica = null;
                    PiantaEndemica.StatoConservazione stato = PiantaEndemica.StatoConservazione.NonValutato;
                    switch (comboBoxStatoConservazione.SelectedIndex) {
                        case 0:
                            stato = PiantaEndemica.StatoConservazione.Estinto;
                            break;
                        case 1:
                            stato = PiantaEndemica.StatoConservazione.Minacciato;
                            break;
                        case 2:
                            stato = PiantaEndemica.StatoConservazione.BassoRischio;
                            break;
                        case 3:
                            stato = PiantaEndemica.StatoConservazione.NonValutato;
                            break;
                        default:
                            successo = false;
                            break;
                    }
                    PalmaNana.ColoreFrutti colore = PalmaNana.ColoreFrutti.Verde;
                    switch (comboBoxSpecie.SelectedIndex) {
                        case 0:
                            switch (comboBoxColoreFrutti.SelectedIndex) {
                                case 0:
                                    colore = PalmaNana.ColoreFrutti.Verde;
                                    break;
                                case 1:
                                    colore = PalmaNana.ColoreFrutti.Giallo;
                                    break;
                                case 2:
                                    colore = PalmaNana.ColoreFrutti.Marrone;
                                    break;
                                default:
                                    successo = false;
                                    break;
                            }
                            try {
                                piantaEndemica = new PalmaNana(textBoxCodice.Text, stato, colore);
                            } catch (Exception ex) {
                                successo = false;
                                MessageBox.Show(ex.Message);
                            }
                            break;
                        case 1:
                            bool apocromatica = false;
                            switch (comboBoxColoreFiori.SelectedIndex) {
                                case 0:
                                    apocromatica = true;
                                    break;
                                case 1:
                                    apocromatica = false;
                                    break;
                                default:
                                    successo = false;
                                    break;
                            }
                            DateTime periodoAnno = monthCalendar1.SelectionEnd;
                            try {
                                piantaEndemica = new OrchideDiBranciforti(textBoxCodice.Text, stato, apocromatica, periodoAnno);
                            } catch (Exception ex) {
                                successo = false;
                                MessageBox.Show(ex.Message);
                            }
                            break;
                        default:
                            successo = false;
                            break;
                    }
                    if (successo) {
                        pianteEndemiche.Add(piantaEndemica);
                        aggiornaElenco();
                    }
                } else {
                    MessageBox.Show("Selezionare lo stato di conservazione");
                }
            } else {
                MessageBox.Show("Selezionare la specie della pianta.");
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) {
            if (listBox1.SelectedIndex != -1) {
                PiantaEndemica piantaEndemica = pianteEndemiche[listBox1.SelectedIndex];
                textBoxCodice.Text = piantaEndemica.CodicePianta;
                comboBoxSpecie.SelectedIndex = -1;
                comboBoxStatoConservazione.SelectedIndex = (int)piantaEndemica.Stato;
                comboBoxColoreFrutti.SelectedIndex = -1;
                comboBoxColoreFiori.SelectedIndex = -1;
            }
        }

        private void ControllaFioritura_Click(object sender, EventArgs e) {
            foreach (PiantaEndemica piantaEndemica in pianteEndemiche) {
                piantaEndemica.fiorisci();
            }
            aggiornaElenco();
        }

        private void RimuoviPianta_Click(object sender, EventArgs e) {
            if (listBox1.SelectedIndex == -1) {
                MessageBox.Show("Seleziona la pianta da eliminare.");
            } else {
                pianteEndemiche.RemoveAt(listBox1.SelectedIndex);
                aggiornaElenco();
            }
        }

        private void ModificaPianta_Click(object sender, EventArgs e) {
            if (listBox1.SelectedIndex == -1) {
                MessageBox.Show("Seleziona la pianta da modificare.");
            } else {
                pianteEndemiche.RemoveAt(listBox1.SelectedIndex);
                AggiungiPianta_Click(sender, e);
            }
        }

        private void Form1_Load(object sender, EventArgs e) {
            labelMese.Text = controllaMese(monthCalendar1.SelectionEnd.Month);
        }
    }
}