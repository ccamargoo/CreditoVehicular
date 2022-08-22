using System;
using System.Collections.Generic;
using System.Text;

namespace nombremicroservicio.Domain.Interfaces
{
    public interface IGenericRepository<T>
    {
        IEnumerable<T> Get();
        T Get(int id);
        T Add(T data);
        void Delete(int id);
        void Update(T data);
        void Save();
    }
}
