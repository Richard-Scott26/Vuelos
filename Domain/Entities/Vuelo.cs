using Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Vuelo
    {
        public String NumeroDeVuelo { get; set; }
        public String Destino { get; set; }
        public Trayectory trayectoria { get; set; }
        public double precio { get; set; }

        // total de bytes 94

        public Vuelo() { }
    }
}
