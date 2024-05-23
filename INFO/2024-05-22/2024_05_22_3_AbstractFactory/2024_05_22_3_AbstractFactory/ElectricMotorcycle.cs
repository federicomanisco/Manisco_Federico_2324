using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_05_22_3_AbstractFactory {
    public class ElectricMotorcycle: Motorcycle {
        public ElectricMotorcycle(string name) : base(name) {
        }

        public override void changeTires() {
            statoRuote = 100.0f;
        }

        public override void Drive() {
            statoRuote -= 0.5f;
        }
    }
}
