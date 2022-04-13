using Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Person
    {
        public int id { get; set; }
        public String Name { get; set; }
        public String LastName { get; set; }
        public int Age { get; set; }
        public Sexo sexo { get; set; }
        public CivilState civilState { get; set; }

        //la suma de bytes de las variables anteriores es de 222 bytes

        public Person() { }

    }
}
