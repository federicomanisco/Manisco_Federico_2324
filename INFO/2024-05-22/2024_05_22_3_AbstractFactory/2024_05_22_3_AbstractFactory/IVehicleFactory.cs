namespace _2024_05_22_3_AbstractFactory {
    public interface IVehicleFactory {
        ICar createCar(string name);
        IMotorcycle createMotorcycle(string name);
    }
}
