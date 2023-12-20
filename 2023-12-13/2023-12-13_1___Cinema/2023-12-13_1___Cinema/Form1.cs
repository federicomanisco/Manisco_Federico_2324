using Microsoft.VisualBasic.Devices;
using System.DirectoryServices.ActiveDirectory;
using System.Globalization;
using System.Net.Security;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Security.Cryptography.Xml;
using System.Text;

namespace _2023_12_13_1___Cinema {
    public partial class Form1: Form {

        Bitmap image;
        List<Cliente> clienti;
        List<(int, int, string)> poltroneSelezionate;

        int xfinal = 0, yfinal = 0;
        void selezionamomentaneo(int x, int y) {
            Graphics g = Graphics.FromImage(image);
            g.FillRectangle(Brushes.Yellow, x + 1, y + 1, 29, 29);
            pictureBox1.Image = image;
            
        }

        void deseleziona(List<(int, int, string)> poltrone) {
            if (poltrone.Count != 0) {
                foreach ((int, int, string) poltrona in poltrone) {
                    if (!Cliente.poltroneOccupate.Contains(poltrona.Item3)) {
                        (int, int) coordPoltrona = trovaPoltrona(poltrona.Item3);
                        Graphics g = Graphics.FromImage(image);
                        g.FillRectangle(Brushes.Green, coordPoltrona.Item1 + 1, coordPoltrona.Item2 + 1, 29, 29);
                    }
                }
                pictureBox1.Image = image;
            }
        }

        (int, int, string) trovaPoltrona(int xCoord, int yCoord) {
            char lettera = 'A';
            int xfinale = 0, yfinale = 0, i = 0;
            string fila = "", colonna = "";
            for (int r = 0; r < 10; r++) {
                i++;
                int x = 60 + (r * 50);
                if (xCoord > x && xCoord < x + 30) {
                    colonna = i.ToString();
                    xfinale = x;
                    xfinal = x;
                    for (int c = 0; c < 11; c++) {
                        int y = 80 + (c * 50);
                        if (yCoord > y && yCoord < y + 30) {
                            fila = lettera.ToString();
                            yfinale = y;
                            yfinal = y;
                        }
                        lettera++;
                    }
                }
            }
            return (xfinale, yfinale, fila + colonna);
        }

        (int, int) trovaPoltrona(string posizione) {
            char fila = posizione[0];
            string colonna = posizione.Substring(1);
            int nFila = fila - 'A', nColonna, xPoltrona, yPoltrona, i = 0, x = 0, y = 0;
            int.TryParse(colonna.ToString(), out nColonna);
            x = 60 + ((nColonna - 1) * 50);
            y = 80 + (nFila * 50);
            return (x, y);
        }

        void prenota(int x, int y) {
            Graphics g = Graphics.FromImage(image);
            g.FillRectangle(Brushes.Red, x + 1, y + 1, 29, 29);
            pictureBox1.Image = image;
            (int, int, string) poltrona = trovaPoltrona(x, y);
        }

        void aggiornaElenco() {
            listBox1.Items.Clear();
            foreach (Cliente cliente in clienti) {
                listBox1.Items.Add(cliente);
            }
        }

        public Form1() {
            InitializeComponent();
            clienti = new List<Cliente>();
            poltroneSelezionate = new List<(int, int, string)>();
        }

        private void Form1_Load(object sender, EventArgs e) {
            image = new Bitmap(600, 600);
            Graphics g = Graphics.FromImage(image);

            g.Clear(Color.Gray);


            Font f = new Font(FontFamily.GenericSansSerif, 20);
            g.DrawString("Sala Cinema", f, Brushes.White, 10, 10);



            for (int i = 0; i < 10; i++) {
                char c = 'A';
                for (int j = 0; j < 8; j++) {
                    int x = 60 + (i * 50);
                    int y = 80 + (j * 50);
                    if (!(i == 0)) g.DrawString(c.ToString(), f, Brushes.White, 20, 75 + (j * 50));
                    g.FillRectangle(Brushes.Green, x, y, 30, 30);

                    c++;

                }

            }
            pictureBox1.Image = image;

            for (int i = 0; i < 10; i++) {
                g.DrawString((i + 1).ToString(), f, Brushes.White, 50 + (i * 50), 470);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e) {
            
            int mousex, mousey, xfinale, yfinale;

            MouseEventArgs mouse = (MouseEventArgs)e;
            mousex = mouse.Location.X;
            mousey = mouse.Location.Y;

            (int, int, string) risultato = trovaPoltrona(mousex, mousey);
            xfinale = risultato.Item1;
            yfinale = risultato.Item2;
            string poltrona = risultato.Item3;
            


            if (poltrona.Length != 2 && poltrona.Length != 3) {
                label1.Text = "Seleziona una poltrona";
                deseleziona(poltroneSelezionate);
                poltroneSelezionate.Clear();
            } else {
                label1.Text = poltrona;
                selezionamomentaneo(xfinale, yfinale);
                poltroneSelezionate.Add(risultato);
            }
        }

        private void Prenota_Click(object sender, EventArgs e) {
            Cliente cliente;
            List<string> poltroneCliente = new List<string>();
            foreach ((int, int, string) poltrona in poltroneSelezionate) {
                poltroneCliente.Add(poltrona.Item3);
            }
            
            try {
                cliente = new Cliente(textBox1.Text, textBox2.Text, poltroneCliente);
                clienti.Add(cliente);
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            aggiornaElenco();
            foreach (string poltrona in poltroneCliente) {
                Cliente.poltroneOccupate.Add(poltrona);
            }

            foreach (string posizione in Cliente.poltroneOccupate) {
                (int, int) coordinatePoltrona = trovaPoltrona(posizione);
                prenota(coordinatePoltrona.Item1, coordinatePoltrona.Item2);
            }

            poltroneSelezionate.Clear();
        }
    }
}