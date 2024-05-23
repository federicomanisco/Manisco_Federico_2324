namespace _2024_05_22_4_Facade {
    public class ProductCatalog {
        private List<Product> products;
        public List<Product> Products { get { return products; } }
        public ProductCatalog() {
            products = new List<Product> {
                new Product("Laptop", 1200.99f),
                new Product("Smartphone", 799.49f),
                new Product("Tablet", 450.00f),
                new Product("Smartwatch", 199.99f),
                new Product("Cuffie", 89.99f),
                new Product("Altoparlante Bluetooth", 59.99f),
                new Product("Hard Disk Esterno", 120.00f),
                new Product("Mouse", 25.50f),
                new Product("Tastiera", 45.00f),
                new Product("Monitor", 300.00f),
                new Product("Stampante", 150.00f),
                new Product("Fotocamera", 599.99f),
                new Product("Router", 75.00f),
                new Product("Chiavetta USB", 15.99f),
                new Product("Webcam", 49.99f),
                new Product("Console di Gioco", 499.99f)
            };
        }

        public Product SelectProduct(int index) {
            return products[index];
        }
    }
}
