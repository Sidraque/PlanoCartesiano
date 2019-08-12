using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculaCoordenadasForm {
    class DadosPonto {
        public double Distxyz(Ponto pa, Ponto pb) {

            double retorno = Math.Sqrt(Math.Pow((pb.CoordX - pa.CoordX), 2) + Math.Pow((pb.CoordY - pa.CoordY), 2) + Math.Pow((pb.CoordZ - pa.CoordZ), 2));

            return retorno;

        }
    }
}
