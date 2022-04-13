using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructura.Repository
{
    public class RAFVendedorRepository : IVendedorModel
    {
        public RandomAccessFile context;
        public const int SIZE = 250;

        public void Add(Saller t)
        {
            try
            {
                context.Create<Saller>(t);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Delete(Saller t)
        {
            throw new NotImplementedException();
        }

        public Saller GetById(int id)
        {
            try
            {
                return context.Get<Saller>(id);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Saller> Read()
        {
            try
            {
                return context.GetAll<Saller>();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
