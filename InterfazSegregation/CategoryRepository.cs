using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfazSegregation
{
    //No cumple, poner ejemplo con objetos: Persona y 
    //país, ya que Persona tendría todos los métodos, Pais solo leería
    internal class CategoryRepository : IRepository<Category>
    {
        public void Create(Category entiy)
        {
            throw new NotImplementedException();
        }

        public void Delete(int entiy)
        {
            throw new NotImplementedException();
        }

        public Category Retrieve(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Category> RetrieveAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Category entiy)
        {
            throw new NotImplementedException();
        }
    }
}

namespace InterfazSegregation.WithSolid
{
    public interface IReadable<T>
    {
        T Retrieve(int id);
        IEnumerable<T> RetrieveAll();
    }

    public interface IWritable<T>
    {
        void Create(T entiy);
        void Update(T entiy);
    }

    public interface IDeleteable
    {
        void Delete(int id);
    }

    internal class CategoryReadableRepository : IReadable<Category>
    {
        public Category Retrieve(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Category> RetrieveAll()
        {
            throw new NotImplementedException();
        }
    }
}