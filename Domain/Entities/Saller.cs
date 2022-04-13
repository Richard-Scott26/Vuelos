using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Saller : Person
    {
        public int id { get; set; }
        public String NumeroCarnet { get; set; }
        public Person persona { get; set; }
        // Total de bytes es de 222 + 27 = 249 bytes

        public Saller() { }
    }
}
