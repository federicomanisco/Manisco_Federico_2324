namespace _2024_05_22_3_AbstractFactory {
    public class ElectricCar: Car {
        public ElectricCar(string name) : base(name) {
        }

        public override void Drive() {
            carburante -= 0.5f;
        }

        public override void Refuel() {
            carburante = 100.0f;
        }
    }
}
