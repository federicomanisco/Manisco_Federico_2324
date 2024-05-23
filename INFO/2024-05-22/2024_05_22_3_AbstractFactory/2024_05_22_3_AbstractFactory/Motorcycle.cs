namespace _2024_05_22_3_AbstractFactory {
    public abstract class Motorcycle : IMotorcycle {
        private string name;
        protected float statoRuote;
        public string Name { get { return name; } }
        public float StatoRuote { get { return statoRuote; } }

        public abstract void changeTires();
        public abstract void Drive();

        public Motorcycle(string name) {
            this.name = name;
            statoRuote = 100.0f;
        }

        public override string ToString() {
            return $"{name} - consumazione delle ruote: {statoRuote}%";
        }
    }
}
