namespace _2024_01_24_1___Ereditarieta
{
    public partial class Form1 : Form
    {
        List<Personaggio> personaggi = new List<Personaggio>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        public void aggiornaLista() {
            listBox1.Items.Clear();
            foreach (Personaggio p in personaggi) {
                listBox1.Items.Add(p);
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            Guerriero guerriero = new Guerriero();
            guerriero.Nome = "Conan";
            guerriero.aggiungiEquipaggiamento("spada");
            guerriero.aggiungiEquipaggiamento("cavallo");
            guerriero.aggiungiEquipaggiamento("armatura");

            personaggi.Add(guerriero);
            aggiornaLista();
        }

        private void button2_Click(object sender, EventArgs e) {
            if (listBox1.SelectedItems.Count != 2) {
                MessageBox.Show("Seleziona esattamente 2 personaggi.");
            } else {
                Personaggio p1 = (Personaggio) listBox1.SelectedItems[0];
                Personaggio p2 = (Personaggio) listBox1.SelectedItems[1];
                p1.attacca(p2);
                aggiornaLista();
            }
            
        }
    }
}