using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verifica_Manisco_21_02_2024 {
    public class OrchideDiBranciforti : PiantaEndemica {
        private bool apocromatica;


        public bool Apocromatica {
            get { return apocromatica; }
            set {
                apocromatica = value;
            }
        }



        public OrchideDiBranciforti(string codice, StatoConservazione statoConservazione, bool apocromatica, DateTime periodoAnno) : base(codice, statoConservazione) {
            Apocromatica = apocromatica;
            PeriodoAnno = periodoAnno;
        }

        public override void fiorisci() {
            if (PeriodoAnno.Month == 4 || PeriodoAnno.Month == 5) {
                HaFiorito = true;
            }
        }

        public override string ToString() {
            return base.ToString() + $"{(Apocromatica ? "è apocromatica" : "ha i fiori viola")}"; 
        }
    }
}
