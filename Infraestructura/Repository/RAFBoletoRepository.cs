using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructura.Repository
{
    public class RAFBoletoRepository : IBoletoModel
    {
        public RandomAccessFile context;
        public const int SIZE = 600;

        public void Add(Boleto t)
        {
            try
            {
                context.Create<Boleto>(t);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Delete(Boleto t)
        {
            throw new NotImplementedException();
        }

        public Boleto GetById(int id)
        {
            try
            {
                return context.Get<Boleto>(id);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Boleto> Read()
        {
            try
            {
                return context.GetAll<Boleto>();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
