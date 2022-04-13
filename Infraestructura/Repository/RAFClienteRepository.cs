using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructura.Repository
{
    public class RAFClienteRepository : IClienteModel
    {
        public RandomAccessFile context;
        public const int SIZE = 222;
        public RAFClienteRepository()
        {
            context = new RandomAccessFile("Clientes", SIZE);
        }

        public void Add(Person t)
        {
            try
            {
                context.Create<Person>(t);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Delete(Person t)
        {
            throw new NotImplementedException();
        }

        public Person GetById(int id)
        {
            try
            {
                return context.Get<Person>(id);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Person> Read()
        {
            try
            {
                return context.GetAll<Person>();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
