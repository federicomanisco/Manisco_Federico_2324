using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shogi {
    public class Salvataggio {
        public Koma[,] ShogibanState { get; set; }
        public ((int, int), (int, int)) TempiGiocatori { get; set; }
        public bool Turno { get; set; }

        public Salvataggio(Koma[,] shogibanState, bool turno, ((int, int), (int, int)) tempiGiocatori) {
            ShogibanState = shogibanState;
            Turno = turno;
            TempiGiocatori = tempiGiocatori;
        }
    }
}
