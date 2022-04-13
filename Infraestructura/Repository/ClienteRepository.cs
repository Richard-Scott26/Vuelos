using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructura.Repository
{
    public class ClienteRepository : Base<Person>, IClienteModel
    {
        public Person GetById(int id)
        {
            return data.Where(x => x.id == id).FirstOrDefault();
        }
    }
}
