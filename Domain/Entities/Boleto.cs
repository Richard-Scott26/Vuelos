using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Boleto
    {
        public int id { get; set; }

        public String AereolineaName = "Copa AirLine";
        public Person cliente { get; set; }
        public Saller vendedor { get; set; }
        public Vuelo vuelo { get; set; }


        // 4+27+222+249+94= 588 bytes en total

        public Boleto() { }
    }
}
