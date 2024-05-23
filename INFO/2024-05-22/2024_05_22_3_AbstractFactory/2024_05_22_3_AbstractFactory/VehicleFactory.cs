namespace _2024_05_22_3_AbstractFactory {
    public abstract class VehicleFactory: IVehicleFactory {
        public abstract ICar createCar(string name);
        public abstract IMotorcycle createMotorcycle(string name);
    }
}
