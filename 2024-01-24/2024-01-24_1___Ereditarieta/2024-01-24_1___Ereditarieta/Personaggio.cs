using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace _2024_01_24_1___Ereditarieta
{
    public class Personaggio
    {
        protected Random r = new Random();
        protected string nome;
        protected int forza; // 0 - 100
        protected int salute; // 0 - 100
        protected Point posizione;

        public string Nome
        {
            get { return nome; }
            set
            {
                if (value.Length < 1) {
                    throw new ArgumentException("Nome troppo corto.");
                }
                nome = value;
            }
        }

        public int Forza {
            get { return forza; }
            set {
                if (value < 0 || value > 100) {
                    throw new ArgumentException("Valore oltre i limiti.");
                }
            }
        }

        public int Salute {
            get { return salute; }
            set {
                if (value < 0 || value > 100) {
                    throw new Exception("Valore non ammesso.");
                } else {
                    salute = value;
                }
            }
        }

        public void cammina(Point destinazione) {

        }

        public void rigeneraSalute() {

        }
        
        public virtual void attacca(Personaggio p) {
            salute -= 1;
        }

        public Personaggio() {
            forza = 1;
            salute = 100;
            Nome = "P";
        }
    }

    public class Guerriero : Personaggio {
        protected string abilita; // colpo di spada, scudo...
        protected List<string> equipaggiamento = new List<string>();
        private static int i = 1;
        
        public List<string> Equipaggiamento {
            get { return equipaggiamento; }
        }

        public void aggiungiEquipaggiamento(string i) {
            if (equipaggiamento.Contains(i)) {
                return;
            } else {
                equipaggiamento.Add(i);
            }
        }

        public override string ToString() {
            return $"Guerriero: {nome} - f:{forza} - s:{salute} ";
        }

        public override void attacca(Personaggio p) {
            p.Salute -= (equipaggiamento.Count + r.Next(0, forza / 10));
        }

        public Guerriero() {
            Nome = "G"+i;
            forza = 30;
            i++;
        }
    }

    public class Mago : Personaggio {
        protected string elemento; // acqua, fuoco, terra, aria
        protected int potereMagico; // 0 - 10
        protected List<string> magie = new List<string>();
        protected int livelloAttacco; // 1 - 5
        protected int livelloDifesa; // 1 - 5
    }

    public class Zombie : Personaggio {
        protected int danniMorso; // 1 - 20
        protected int numeroOcchi; // 0 - 6
    }
}
