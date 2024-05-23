using System.Runtime.CompilerServices;
using System.Security.Policy;

namespace _2024_05_22_3_AbstractFactory {
    public abstract class Car : ICar {
        private string name;
        protected float carburante;
        public string Name { get { return name; } }
        public float Carburante { get { return carburante; } }
        public abstract void Drive();
        public abstract void Refuel();

        public Car(string name) {
            this.name = name;
            carburante = 100.0f;
        }

        public override string ToString() {
            return $"{name} - carburante: {carburante}%";
        }
    }
}
