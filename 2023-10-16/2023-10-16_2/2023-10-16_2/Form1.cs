using System.Diagnostics;

namespace _2023_10_16_2 {
    public partial class Form1: Form {
        public Form1() {
            InitializeComponent();
        }

        private int gioca() {
            Random giocata = new Random();
            int mossa = giocata.Next(1, 4);
            switch (mossa) {
                case 1:
                    PC.Load("..\\..\\..\\..\\..\\Carta.PNG");
                    break;
                case 2:
                    PC.Load("..\\..\\..\\..\\..\\Forbici.PNG");
                    break;
                case 3:
                    PC.Load("..\\..\\..\\..\\..\\Sasso.PNG");
                    break;
            }
            return mossa;
        }

        int punti_umano = 0, punti_PC = 0;

        private void calcola_punteggio(int vincitore) {
            switch (vincitore) {
                case 1:
                    string vecchio_testo_umano = label6.Text;
                    label6.Text = (int.Parse(vecchio_testo_umano) + 1).ToString();
                    MessageBox.Show("Ha vinto l'umano");
                    break;
                case 2:
                    string vecchio_testo_pc = label7.Text;
                    label7.Text = (int.Parse(vecchio_testo_pc) + 1).ToString();
                    MessageBox.Show("Ha vinto il PC");
                    break;
                default:
                    MessageBox.Show("Pareggio");
                    break;
            }
        }

        private int vincitore(int mossa_PC, int mossa_umano) {
            switch (mossa_PC) {
                case 1: //0 = pareggio, 1 = umano, 2 = pc
                    if (mossa_umano == 1) {
                        return 0;
                    }
                    else if (mossa_umano == 2) {
                        return 1;
                    }
                    else {
                        return 2;
                    }

                case 2:
                    if (mossa_umano == 1) {
                        return 2;
                    }
                    else if (mossa_umano == 2) {
                        return 0;
                    }
                    else {
                        return 1;
                    }
                case 3:
                    if (mossa_umano == 1) {
                        return 1;
                    }
                    else if (mossa_umano == 2) {
                        return 2;
                    }
                    else {
                        return 0;
                    }
                default:
                    return -1;
            }
        }

        private void Carta_Click(object sender, EventArgs e) {
            Umano.Load("..\\..\\..\\..\\..\\Carta.PNG");
            int vincente = vincitore(gioca(), 1);
            calcola_punteggio(vincente);
        }

        private void Forbici_Click(object sender, EventArgs e) {
            Umano.Load("..\\..\\..\\..\\..\\Forbici.PNG");
            int vincente = vincitore(gioca(), 2);
            calcola_punteggio(vincente);
        }

        private void Sasso_Click(object sender, EventArgs e) {
            Umano.Load("..\\..\\..\\..\\..\\Sasso.PNG");
            int vincente = vincitore(gioca(), 3);
            calcola_punteggio(vincente);
        }
    }
}