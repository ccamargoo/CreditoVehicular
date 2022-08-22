using nombremicroservicio.Domain.Interfaces;
using nombremicroservicio.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nombremicroservicio.Repository.Repository
{
    public class AsignacionClientesRepository : IAsignacionClientes
    {
        private readonly IGenericRepository<AsignacionClientesModel> dataAdapter;
        public AsignacionClientesRepository(IGenericRepository<AsignacionClientesModel> _data)
        {
            this.dataAdapter = _data;
        }
        public bool Delete(int id)
        {
            dataAdapter.Delete(id);
            dataAdapter.Save();
            return true;
        }

        public AsignacionClientesModel Get(int id) => dataAdapter.Get(id);

        public IEnumerable<AsignacionClientesModel> GetAll() => dataAdapter.Get().ToList();

        public AsignacionClientesModel Post(AsignacionClientesModel asignacion)
        {
            AsignacionClientesModel _obj = dataAdapter.Add(asignacion);
            dataAdapter.Save();
            return _obj;
        }

        public bool Put(int id, AsignacionClientesModel asignacion)
        {
            asignacion.id = id;
            dataAdapter.Update(asignacion);
            dataAdapter.Save();
            return true;
        }
    }
}
