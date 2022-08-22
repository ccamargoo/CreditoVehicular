using nombremicroservicio.Domain.Interfaces;
using nombremicroservicio.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nombremicroservicio.Repository.Repository
{
    public class VehiculosRepository : IVehiculos
    {
        private readonly IGenericRepository<VehiculoModel> dataAdapter;
        public VehiculosRepository(IGenericRepository<VehiculoModel> _data)
        {
            this.dataAdapter = _data;
        }
        public bool Delete(int id)
        {
            dataAdapter.Delete(id);
            dataAdapter.Save();
            return true;
        }

        public VehiculoModel Get(int id) => dataAdapter.Get(id);

        public IEnumerable<VehiculoModel> GetAll() => dataAdapter.Get().ToList();

        public VehiculoModel Post(VehiculoModel vehiculo)
        {
            VehiculoModel _obj = dataAdapter.Add(vehiculo);
            dataAdapter.Save();
            return _obj;
        }

        public bool Put(int id, VehiculoModel vehiculo)
        {
            vehiculo.Id = id;
            dataAdapter.Update(vehiculo);
            dataAdapter.Save();
            return true;
        }
    }
}
