namespace _2024_05_22_4_Facade {
    public class PaymentProcessor {
        public Order ProcessProduct(Product product, string destination) {
            product.buy();
            Order order = new Order(product, destination);
            return order;
        }
    }
}
