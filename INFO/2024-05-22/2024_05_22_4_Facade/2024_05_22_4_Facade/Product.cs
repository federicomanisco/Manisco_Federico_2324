namespace _2024_05_22_4_Facade {
    public class Product {
        private string name;
        private float price;
        private bool hasBeenPayed;
        public string Name { get { return name; } }
        public float Price { get { return price; } }
        public bool HasBeenPayed { get { return hasBeenPayed; } }

        public Product(string name, float price) {
            this.name = name;
            this.price = price;
            hasBeenPayed = false;
        }

        public void buy() {
            if (!hasBeenPayed) { 
                hasBeenPayed = true;
            }
        }

        public override string ToString() {
            return $"{name} - prezzo: {price}€ - {(hasBeenPayed ? "Acquistato" : "Non Acquistato")}";
        }
    }
}
