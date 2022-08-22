using Microsoft.EntityFrameworkCore;
using nombremicroservicio.Domain.Interfaces;
using nombremicroservicio.Repository.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nombremicroservicio.Repository.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private ApplicationContext _context;
        private DbSet<T> _dbSet;
        public GenericRepository(ApplicationContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }
        public T Add(T data) => _dbSet.Add(data).Entity;

        public void Delete(int id)
        {
            var data = _dbSet.Find(id);
            if (data != null)
                _dbSet.Remove(data);
        }

        public IEnumerable<T> Filter(Func<T, bool> predicate)
        {
            return _dbSet.AsQueryable().Where(predicate).ToArray();
        }

        public IEnumerable<T> Get() => _dbSet.ToList();

        public T Get(int id) => _dbSet.Find(id);

        public void Save() => _context.SaveChanges();

        public void Update(T data)
        {
            _dbSet.Attach(data);
            _context.Entry(data).State = EntityState.Modified;
        }
    }
}
