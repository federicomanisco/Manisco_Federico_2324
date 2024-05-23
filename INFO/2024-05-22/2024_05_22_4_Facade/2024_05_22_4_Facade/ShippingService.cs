namespace _2024_05_22_4_Facade {
    public class ShippingService {
        public void Travel(Order order) {
            if (order.Item.HasBeenPayed)
                order.updateDaysUntilShipment();
        }
    }
}
