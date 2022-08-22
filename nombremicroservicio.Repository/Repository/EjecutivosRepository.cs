using nombremicroservicio.Domain.Interfaces;
using nombremicroservicio.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nombremicroservicio.Repository.Repository
{
    public class EjecutivosRepository : IEjecutivos
    {
        private readonly IGenericRepository<EjecutivoModel> dataAdapter;
        public EjecutivosRepository(IGenericRepository<EjecutivoModel> _data)
        {
            this.dataAdapter = _data;
        }
        public bool Delete(int id)
        {
            dataAdapter.Delete(id);
            dataAdapter.Save();
            return true;
        }

        public EjecutivoModel Get(int id) => dataAdapter.Get(id);

        public IEnumerable<EjecutivoModel> GetAll() => dataAdapter.Get().ToList();

        public EjecutivoModel Post(EjecutivoModel ejecutivo)
        {
            EjecutivoModel _obj = dataAdapter.Add(ejecutivo);
            dataAdapter.Save();
            return _obj;
        }

        public bool Put(int id, EjecutivoModel ejecutivo)
        {
            ejecutivo.Id = id;
            dataAdapter.Update(ejecutivo);
            dataAdapter.Save();
            return true;
        }
    }
}
