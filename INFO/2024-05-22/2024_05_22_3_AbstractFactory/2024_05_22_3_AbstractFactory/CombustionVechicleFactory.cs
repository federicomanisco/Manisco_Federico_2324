namespace _2024_05_22_3_AbstractFactory {
    public class CombustionVechicleFactory: VehicleFactory {
        public override ICar createCar(string name) {
            return new CombustionCar(name);
        }

        public override IMotorcycle createMotorcycle(string name) {
            return new CombustionMotorcycle(name);
        }
    }
}
