namespace _2024_05_22_4_Facade {
    public class Order {
        private Product item;
        private string destination;
        private int daysUntilShipment;
        private bool hasBeenShipped;
        private Random random;
        public Product Item { get { return item; } }
        public string Destination { get { return destination; } }
        public int DaysUntilShipment { get {  return daysUntilShipment; } }
        public bool HasBeenShipped { get { return hasBeenShipped; } }   

        public Order(Product item, string destination) {
            this.item = item;
            this.destination = destination;
            random = new Random();
            daysUntilShipment = random.Next(1, 8);
            hasBeenShipped = false;
        }

        public void updateDaysUntilShipment() {
            if (!hasBeenShipped) {
                daysUntilShipment -= 1;
            }

            if (daysUntilShipment == 0 && !hasBeenShipped) {
                hasBeenShipped = true;
            }
        }

        public override string ToString() {
            return $"Ordine di {item.Name} - Prezzo: {item.Price}€ - Destinazione: {destination} - {(hasBeenShipped ? "Consegnato" : $"Giorni alla spedizione: {daysUntilShipment}")}";
        }
    }
}
