using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructura.Repository
{
    public class BoletoRepository : Base<Boleto>, IBoletoModel
    {
        public Boleto GetById(int id)
        {
            return data.Where(x => x.id == id).FirstOrDefault();
        }
    }
}
