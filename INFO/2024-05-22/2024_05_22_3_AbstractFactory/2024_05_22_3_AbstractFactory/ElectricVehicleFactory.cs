namespace _2024_05_22_3_AbstractFactory {
    public class ElectricVehicleFactory : VehicleFactory {
        public override ICar createCar(string name) {
            return new ElectricCar(name);
        }

        public override IMotorcycle createMotorcycle(string name) {
            return new ElectricMotorcycle(name);
        }
    }
}
