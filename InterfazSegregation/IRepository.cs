using System.Collections.Generic;

namespace InterfazSegregation
{
    public interface IRepository<T>
    {
        void Create(T entiy);
        T Retrieve(int id);
        IEnumerable<T> RetrieveAll();
        void Update(T entiy);
        void Delete(int id);
    }
}
