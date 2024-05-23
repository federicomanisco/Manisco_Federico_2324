using System.Reflection.Metadata.Ecma335;

namespace _2024_05_22_4_Facade {
    public class OrderFacade {
        private ProductCatalog catalog;
        private PaymentProcessor paymentProcessor;
        private ShippingService shippingService;
        private List<Product> cart;
        private List<Order> orders;

        public OrderFacade() {
            catalog = new ProductCatalog();
            paymentProcessor = new PaymentProcessor();
            shippingService = new ShippingService();
            orders = new List<Order>();
            cart = new List<Product>();
        }

        public void PlaceOrder(Product product, string destination) {
            Order order = paymentProcessor.ProcessProduct(product, destination);
            orders.Add(order);
        }

        public void UpdateStateOfDelivery(Order order) {
            shippingService.Travel(order);
        }

        public List<Product> getCatalog() {
            return catalog.Products;
        }

        public Product getProduct(int index) {
            return catalog.SelectProduct(index);
        }

        public void addToCart(int index) {
            cart.Add(catalog.SelectProduct(index));
        }

        public List<Product> getCart() {
            return cart;
        }

        public List<Order> getOrders() {
            return orders;
        }
    }
}
