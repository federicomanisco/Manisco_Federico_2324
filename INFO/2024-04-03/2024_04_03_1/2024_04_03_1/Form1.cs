namespace _2024_04_03_1
{
    public partial class Form1 : Form
    {
        private List<Prodotto> archivio = new List<Prodotto>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Prodotto p1 = new Prodotto(textBox1.Text, textBox2.Text);
                archivio.Add(p1);
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            aggiorna();
        }

        public void aggiorna()
        {
            listBox1.Items.Clear();
            foreach (Prodotto prodotto in archivio)
            {
                listBox1.Items.Add(prodotto);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1 || listBox1.SelectedItems.Count != 1)
            {
                MessageBox.Show("Selezionare un solo elemento da cancellare");
                return;
            }

            Prodotto p = (Prodotto)listBox1.SelectedItem;
            p.Dispose();
            archivio.Remove(p);

            aggiorna();
        }
    }
}