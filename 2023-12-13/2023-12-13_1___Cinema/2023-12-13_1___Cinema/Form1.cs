using Microsoft.VisualBasic.Devices;
using System.DirectoryServices.ActiveDirectory;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.Xml;
using System.Text;

namespace _2023_12_13_1___Cinema {
    public partial class Form1: Form {

        Bitmap image;
        List<Cliente> clienti;
        List<string> poltronePrenotate = new List<string>();
        (int, int, string) coordinatePoltrona;

        int xfinal = 0, yfinal = 0, selezionati = 0;
        void selezionamomentaneo(int x, int y) {
            Graphics g = Graphics.FromImage(image);
            g.FillRectangle(Brushes.Yellow, x + 1, y + 1, 29, 29);
            pictureBox1.Image = image;
            selezionati++;
        }

        void deseleziona(int x, int y, string posizione) {
            if (selezionati != 0 && !poltronePrenotate.Contains(posizione)) {
                Graphics g = Graphics.FromImage(image);
                g.FillRectangle(Brushes.Green, x + 1, y + 1, 29, 29);
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
                    for (int c = 0; c < 8; c++) {
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

        void prenota(int x, int y) {
            Graphics g = Graphics.FromImage(image);
            g.FillRectangle(Brushes.Red, x + 1, y + 1, 29, 29);
            pictureBox1.Image = image;
            (int, int, string) poltrona = trovaPoltrona(x, y);
            poltronePrenotate.Add(poltrona.Item3);
        }

        public Form1() {
            InitializeComponent();
            clienti = new List<Cliente>();
            
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

        private void button1_Click(object sender, EventArgs e) {
            Cliente cliente = null;

            try {
                cliente = new Cliente(textBox1.Text, textBox2.Text);
                clienti.Add(cliente);
                prenota(coordinatePoltrona.Item1, coordinatePoltrona.Item2);
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }


        }

        private void pictureBox1_Click(object sender, EventArgs e) {
            deseleziona(coordinatePoltrona.Item1, coordinatePoltrona.Item2, coordinatePoltrona.Item3);
            int mousex, mousey, xfinale, yfinale;

            MouseEventArgs mouse = (MouseEventArgs)e;
            mousex = mouse.Location.X;
            mousey = mouse.Location.Y;

            (int, int, string) risultato = trovaPoltrona(mousex, mousey);
            coordinatePoltrona = (xfinal, yfinal, risultato.Item3);
            xfinale = risultato.Item1;
            yfinale = risultato.Item2;
            string poltrona = risultato.Item3;


            if (poltrona.Length != 2) label1.Text = "Seleziona una poltrona";
            else {
                label1.Text = poltrona;
                selezionamomentaneo(xfinale, yfinale);
            }
        }
    }
}