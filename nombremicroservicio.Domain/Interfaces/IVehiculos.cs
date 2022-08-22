using nombremicroservicio.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace nombremicroservicio.Domain.Interfaces
{
    public interface IVehiculos
    {
        VehiculoModel Get(int id);
        IEnumerable<VehiculoModel> GetAll();
        VehiculoModel Post(VehiculoModel cliente);
        bool Put(int id, VehiculoModel cliente);
        bool Delete(int id);
    }
    public interface IVehiculosService : IVehiculos { }
}
