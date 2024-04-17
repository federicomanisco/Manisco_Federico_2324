using Microsoft.VisualBasic.Devices;
using Newtonsoft.Json;
using System.Net;

namespace _2024_04_10_1___Persistenza {
    public partial class Form1 : Form {

        List<Previsione> previsioni = new List<Previsione>();

        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void button1_Click_1(object sender, EventArgs e) {
            try {
                Previsione previsione = new Previsione();
                previsione.Citta = textBox2.Text;
                previsione.TempMedia = (float)numericUpDown1.Value;
                previsione.mmPioggia = (int)numericUpDown2.Value;
                previsione.Data = monthCalendar1.SelectionEnd;
                previsione.Temperature = new int[7];
                for (int i = 0; i < previsione.Temperature.Length; i++) {
                    previsione.Temperature[i] = new Random().Next((int)previsione.TempMedia - 5, (int)previsione.TempMedia + 5);
                }
                previsioni.Add(previsione);
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }

            string json = JsonConvert.SerializeObject(previsioni, Formatting.Indented);
            textBox1.Text = json;
        }

        private void button4_Click(object sender, EventArgs e) {
            StreamReader sr = new StreamReader("archivio.txt");
            string daFile = sr.ReadToEnd();
            textBox3.Text = daFile;
            previsioni = JsonConvert.DeserializeObject<List<Previsione>>(daFile);
        }

        private void button2_Click_1(object sender, EventArgs e) {
            StreamWriter sw = new StreamWriter("archivio.txt");
            sw.Write("");
            sw.Close();
        }

        private void button3_Click(object sender, EventArgs e) {
            string json = JsonConvert.SerializeObject(previsioni, Formatting.Indented);
            StreamWriter sw = new StreamWriter("archivio.txt", false);
            sw.WriteLine(json);
            sw.Close();
        }

        private async void button5_Click_1(object sender, EventArgs e) {
            HttpClient httpClient = new HttpClient();
            string url="https://cat-fact.herokuapp.com/facts/random";
            HttpResponseMessage response = await httpClient.GetAsync(url);
            if (response.IsSuccessStatusCode) {
                string responseString = await response.Content.ReadAsStringAsync();
                CatFacts cf = JsonConvert.DeserializeObject<CatFacts>(responseString);
                textBox4.Text = cf.text;
            }
        }
    }
}