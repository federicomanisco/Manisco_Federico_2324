using System.Configuration;

namespace _2024_05_22_3_AbstractFactory {
    public partial class Form1: Form {
        List<Car> cars;
        List<Motorcycle> motorcycles;
        ElectricVehicleFactory electricVehiclefactory;
        CombustionVechicleFactory combustionVehiclefactory;
        bool veicoloSelezionato;
        int indiceSelezionato;
        public Form1() {
            InitializeComponent();
            cars = new List<Car>();
            motorcycles = new List<Motorcycle>();
            electricVehiclefactory = new ElectricVehicleFactory();
            combustionVehiclefactory = new CombustionVechicleFactory();
            veicoloSelezionato = false;
        }

        void aggiornaElenco() {
            listBox1.Items.Clear();
            foreach (Car car in cars) {
                listBox1.Items.Add(car);
            }

            foreach (Motorcycle motorcycle in motorcycles) {
                listBox1.Items.Add(motorcycle);
            }
        }

        private void AggiungiVeicolo_Click(object sender, EventArgs e) {
            string name = textBox1.Text;
            if (checkBox1.Checked && checkBox3.Checked) {
                ElectricCar car = (ElectricCar)electricVehiclefactory.createCar(name);
                cars.Add(car);
            } else if (checkBox2.Checked && checkBox3.Checked) {
                ElectricMotorcycle motorcycle = (ElectricMotorcycle)electricVehiclefactory.createMotorcycle(name);
                motorcycles.Add(motorcycle);
            } else if (checkBox1.Checked && checkBox4.Checked) {
                CombustionCar car = (CombustionCar)combustionVehiclefactory.createCar(name);
                cars.Add(car);
            } else if (checkBox2.Checked && checkBox4.Checked) {
                CombustionMotorcycle motorcycle = (CombustionMotorcycle)combustionVehiclefactory.createMotorcycle(name);
                motorcycles.Add(motorcycle);
            } else {
                MessageBox.Show("Inserisci tutti i dati.");
            }
            textBox1.Text = string.Empty;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            aggiornaElenco();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e) {
            if (checkBox2.Checked && checkBox1.Checked) {
                checkBox2.Checked = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e) {
            if (checkBox1.Checked && checkBox2.Checked) {
                checkBox1.Checked = false;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e) {
            if (checkBox4.Checked && checkBox3.Checked) {
                checkBox4.Checked = false;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e) {
            if (checkBox3.Checked && checkBox4.Checked) {
                checkBox3.Checked = false;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) {
            if (listBox1.SelectedIndex != -1) {
                veicoloSelezionato = true;
                indiceSelezionato = listBox1.SelectedIndex;
            } else {
                veicoloSelezionato = false;
                indiceSelezionato = listBox1.SelectedIndex;
            }
        }

        private void timer1_Tick(object sender, EventArgs e) {
            if (veicoloSelezionato) {
                object veicolo = listBox1.SelectedItem;
                if (veicolo is Car) {
                    Car car = (Car)veicolo;
                    car.Drive();
                } else if (veicolo is Motorcycle) {
                    Motorcycle moto = (Motorcycle)veicolo;
                    moto.Drive();
                }
                aggiornaElenco();
                listBox1.SelectedIndex = indiceSelezionato;
            }
        }

        private void RiparaVeicolo_Click(object sender, EventArgs e) {
            if (veicoloSelezionato) {
                object veicolo = listBox1.SelectedItem;
                if (veicolo is Car) {
                    Car car = (Car)veicolo;
                    car.Refuel();
                } else {
                    Motorcycle motorcycle = (Motorcycle)veicolo;
                    motorcycle.changeTires();
                }
                aggiornaElenco();
            }
        }

        private void Form1_Load(object sender, EventArgs e) {
            timer1.Start();
        }
    }
}