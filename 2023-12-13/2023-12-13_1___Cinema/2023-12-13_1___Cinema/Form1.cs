using System.DirectoryServices.ActiveDirectory;
using System.Globalization;
using System.Text;

namespace _2023_12_13_1___Cinema {
    public partial class Form1 : Form {

        Bitmap image;
        List<(string, ((int, int), (int, int)))> coordPoltrone;

        public Form1() {
            InitializeComponent();
            coordPoltrone = new List<(string, ((int, int), (int, int)))>();
        }

        public string Poltrona(Point mp) {
            string colonna = "", fila = "";

            if (mp.X > 60 && mp.X < 90) colonna = "1";
            if (mp.X > 110 && mp.X < 140) colonna = "2";
            if (mp.X > 190 && mp.X < 220) colonna = "3";
            if (mp.X > 270 && mp.X < 300) colonna = "4";
            if (mp.X > 350 && mp.X < 380) colonna = "5";
            if (mp.X > 430 && mp.X < 460) colonna = "6";
            if (mp.X > 510 && mp.X < 540) colonna = "7";
            if (mp.X > 60 && mp.X < 90) colonna = "8";
            if (mp.X > 60 && mp.X < 90) colonna = "9";
            if (mp.X > 60 && mp.X < 90) colonna = "10";

            if (mp.Y > 80 && mp.Y < 110) fila = "A";
            if (mp.Y > 80 && mp.Y < 110) fila = "A";
            if (mp.Y > 80 && mp.Y < 110) fila = "A";
            if (mp.Y > 80 && mp.Y < 110) fila = "A";
            if (mp.Y > 80 && mp.Y < 110) fila = "A";
            if (mp.Y > 80 && mp.Y < 110) fila = "A";
            if (mp.Y > 80 && mp.Y < 110) fila = "A";
            if (mp.Y > 80 && mp.Y < 110) fila = "A";

            return fila + colonna;
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
            int mousex, mousey;

            MouseEventArgs mouse = (MouseEventArgs)e;
            label1.Text = mouse.Location.ToString();
            mousex = mouse.Location.X;
            mousey = mouse.Location.Y;
        }
    }
}