using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_05_22_3_AbstractFactory {
    public class CombustionCar: Car {
        public CombustionCar(string name) : base(name) {
        }

        public override void Drive() {
            carburante -= 1.0f;
        }

        public override void Refuel() {
            carburante = 100.0f;
        }
    }
}
