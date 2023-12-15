using System.DirectoryServices.ActiveDirectory;
using System.Globalization;
using System.Security.Cryptography.Xml;
using System.Text;

namespace _2023_12_13_1___Cinema {
    public partial class Form1 : Form {

        Bitmap image;
        List<Cliente> clienti;

        int xfinal = 0, yfinal = 0, selezionati = 0;
        void selezionamomentaneo(int x, int y) {
            Graphics g = Graphics.FromImage(image);
            g.FillRectangle(Brushes.Yellow, x + 1, y + 1, 29, 29);
            pictureBox1.Image = image;
            selezionati++;
        }

        void deseleziona(int x, int y) {
            if (selezionati != 0) {
                Graphics g = Graphics.FromImage(image);
                g.FillRectangle(Brushes.Green, x + 1, y + 1, 29, 29);
                pictureBox1.Image = image;
            } 
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
            
        }

        private void pictureBox1_Click(object sender, EventArgs e) {
            deseleziona(xfinal, yfinal);
            int mousex, mousey, i = 0, xfinale = 0, yfinale = 0;

            MouseEventArgs mouse = (MouseEventArgs)e;
            label1.Text = mouse.Location.ToString();
            string fila = "", colonna = "";
            char lettera = 'A';
            mousex = mouse.Location.X;
            mousey = mouse.Location.Y;

            for (int r = 0; r < 10; r++) {
                i++;
                int x = 60 + (r * 50);
                if (mousex > x && mousex < x + 30) {
                    colonna = i.ToString();
                    xfinale = x;
                    xfinal = x;
                    for (int c = 0; c < 8; c++) {
                        int y = 80 + (c * 50);
                        if (mousey > y && mousey < y + 30) {
                            fila = lettera.ToString();
                            yfinale = y;
                            yfinal = y;
                        }
                        lettera++;
                    }
                }
            }
            if (fila == "" || colonna == "") label1.Text = "Seleziona una poltrona";
            else {
                label1.Text = fila + colonna;
                selezionamomentaneo(xfinale, yfinale);
            }   
        }
    }
}