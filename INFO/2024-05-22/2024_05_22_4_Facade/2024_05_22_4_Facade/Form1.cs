namespace _2024_05_22_4_Facade {
    public partial class Form1: Form {
        OrderFacade orderFacade;
        bool timerStarted;
        public Form1() {
            InitializeComponent();
            orderFacade = new OrderFacade();
            timerStarted = false;
        }

        private void button1_Click(object sender, EventArgs e) {
            orderFacade.addToCart(listBox1.SelectedIndex);
            updateCart();
            listBox1.SelectedIndex = -1;
        }

        void loadCatalog() {
            listBox1.Items.Clear();
            foreach (Product product in orderFacade.getCatalog()) {
                listBox1.Items.Add(product);
            }
        }

        void updateCart() {
            listBox2.Items.Clear();
            foreach (Product product in orderFacade.getCart()) {
                listBox2.Items.Add(product);
            }
        }

        void updateOrderHistory() {
            listBox3.Items.Clear();
            foreach (Order order in orderFacade.getOrders()) {
                listBox3.Items.Add(order);
            }
        }

        private void Form1_Load(object sender, EventArgs e) {
            loadCatalog();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) {
            if (listBox1.SelectedIndex != -1) {
                AggiungiCarrello.Enabled = true;
            } else {
                AggiungiCarrello.Enabled = false;
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e) {
            if (listBox2.SelectedIndex != -1) {
                Ordina.Enabled = true;
            } else {
                Ordina.Enabled = false;
            }
        }

        private void Ordina_Click(object sender, EventArgs e) {
            if (!string.IsNullOrEmpty(textBox1.Text)) {
                Product product = orderFacade.getCart()[listBox2.SelectedIndex];
                orderFacade.getCart().RemoveAt(listBox2.SelectedIndex);
                orderFacade.PlaceOrder(product, textBox1.Text);
                updateOrderHistory();
                updateCart();
                listBox2.SelectedIndex = -1;
            } else {
                MessageBox.Show("Inserisci una destinazione a cui spedire il prodotto");
            }

            if (!timerStarted) {
                timer1.Start();
                timerStarted = true;
            }
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e) {
            if (listBox3.SelectedIndex != -1) {
                listBox3.SelectedIndex = -1;
            }
        }

        private void timer1_Tick(object sender, EventArgs e) {
            foreach (Order order in orderFacade.getOrders()) {
                orderFacade.UpdateStateOfDelivery(order);
            }
            updateOrderHistory();
        }
    }
}